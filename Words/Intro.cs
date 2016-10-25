using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Speech.Synthesis;
using System.Resources;

namespace Words
{
    public partial class Intro : Form
    {
        private string Word = "DEFAULT";
        private readonly string WIN = "YOU WON!";
        private readonly string LOSE = "YOU LOSE!";
        private string[] LoadWordStore;
        private List<int> AlreadyPlayedWords;
        private int IncorrectGuesses;
        private int Timer;
        private int SeqNo;
        private int TotalScore;
        public int Hiscore = 0;
        private Bitmap[] hangImages;
        private List<Control> ControlList = new List<Control>();
        private List<char> Guesses;
        SoundPlayer ButtonSound;
        SoundPlayer ThemeSound;
        SoundPlayer GameLost;
        SoundPlayer GameWon;

        public Intro()
        {
            InitializeComponent();
            try
            {
                hangImages = new Bitmap[] { Words.Properties.Resources.hanging1, Words.Properties.Resources.hanging2,
                                        Words.Properties.Resources.hanging3, Words.Properties.Resources.hanging4,
                                        Words.Properties.Resources.hanging5, Words.Properties.Resources.hanging6,
                                        Words.Properties.Resources.hanging7};
                ButtonSound = new SoundPlayer(Words.Properties.Resources.button_sound);
                ThemeSound = new SoundPlayer(Words.Properties.Resources.Theme);
                GameLost = new SoundPlayer(Words.Properties.Resources.scream);
                GameWon = new SoundPlayer(Words.Properties.Resources.applause);
                ThemeSound.PlayLooping();
            }
            catch (Exception exception)
            {
                Error.Show();
                Console.WriteLine(exception.Message);
            }
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CatSelect.SelectedItem as string))
            {
                ThemeSound.Stop();
                
                //ThemeSound.PlayLooping();
                HighScore.Visible = true;
                SeqNo = 0;
                TotalScore = 0;
                AlreadyPlayedWords = new List<int>();
                Guesses = new List<char>();
                GenerateButtons();
                LoadWords(CatSelect.SelectedItem as string);
                SetupWordChoice();
                LoadWordGuess();
                HideElements(new Control[] { PlyBtn, MainLbl, LevelLbl, CatSelect });
                Score.Text = "Score: " + TotalScore;
                ShowElements(new Control[] { HangPic, PuzzlePic, Score, TimerLabel, GuessLbl });
                Timer = 0;
                TimeKeeper.Start();
            }
        }

        private void LoadWords(string category)
        {
            try
            {
                string inputStream = Words.Properties.Resources.ResourceManager.GetObject(category.ToLower()) as string;
                LoadWordStore = inputStream.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            }
            catch(Exception exception)
            {
                Error.Show();
                Console.WriteLine(exception.Message);
            }
        }

        private void SetupWordChoice()
        {
            int guessIndex;
            try
            {
                do
                {
                    guessIndex = (new Random()).Next(LoadWordStore.Length);
                } while (AlreadyPlayedWords.Contains(guessIndex));
                AlreadyPlayedWords.Add(guessIndex);
                Word = LoadWordStore[guessIndex].ToUpper();
                PuzzlePic.Image = Words.Properties.Resources.ResourceManager.GetObject(Word.ToLower()) as Image;
                IncorrectGuesses = 0;
                HangPic.Image = hangImages[IncorrectGuesses];
            }
            catch (Exception exception)
            {
                Error.Show();
                Console.WriteLine(exception.Message);
            }
        }

        private void LoadWordGuess()
        {
            GuessLbl.Text = "";
            bool complete = true;
            foreach (char letter in Word)
            {
                if (Guesses.Contains(letter))
                {
                    GuessLbl.Text += letter;
                }
                else
                {
                    GuessLbl.Text += '_';
                    complete = false;
                }
                GuessLbl.Text += ' ';
            }
            if (complete)
            {
                SeqNo++;
                TotalScore += SeqNo <= 4 ? 5 : SeqNo <= 8 ? 10 : 20;
                Score.Text = "Score: " + TotalScore;
                if (TotalScore > Hiscore)
                {
                    Hiscore = TotalScore;
                    HighScore.Text = "High Score : " + Hiscore;
                }
                TextToSpeech();
                TimeKeeper.Stop();
                RemoveControls(ControlList);
                ShowElements(new Control[] { Listen, Continue });
                Continue.Focus();
            }
        }

        private void TextToSpeech()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Speak(Word);
        }

        private void GenerateButtons()
        {
            int top = 350;
            int left = 100;
            int width = 35;
            int height = 35;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                if (alpha == 'N')
                {
                    top = 385;
                    left = 100;
                }
                Button button = new Button();
                button.Name = "button" + alpha;
                button.Text = alpha + "";
                button.Top = top;
                button.Left = left;
                button.Width = width;
                button.Height = height;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.White;
                button.Click += new EventHandler(GuessClick);
                button.KeyDown += new KeyEventHandler(GuessKeyPress);
                ControlList.Add(button);
                this.Controls.Add(button);
                button.Focus();
                left += width;
            }
        }

        private void RemoveControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                this.Controls.Remove(control);
            }
            controls = new List<Control>();
        }

        private void HideElements(Control[] keys)
        {
            foreach (Control key in keys)
            {
                key.Hide();
            }
        }

        private void ShowElements(Control[] keys)
        {
            foreach (Control key in keys)
            {
                key.Show();
            }
        }

        private void GuessClick(object sender, EventArgs e)
        {
            ButtonSound.Play();
            Button button = sender as Button;
            if (!Guesses.Contains(button.Text[0]))
            {
                button.BackColor = Color.Red;
                button.Enabled = false;
                Guesses.Add(button.Text[0]);
                LoadWordGuess();
                if (!Word.Contains(button.Text[0]))
                {
                    IncorrectGuess();
                }
                Timer = 0;
            }
        }

        private void IncorrectGuess()
        {
            try
            {
                IncorrectGuesses++;
                if (IncorrectGuesses > 6)
                {
                    GameLost.Play();
                    GameOver(LOSE);
                }
                else
                {
                    HangPic.Image = hangImages[IncorrectGuesses];
                }
            }
            catch (Exception exception)
            {
                Error.Show();
                Console.WriteLine(exception.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = "Timer: " + (30 - Timer / 10);
            Timer++;
            if (Timer == 300)
            {
                IncorrectGuess();
                Timer = 0;
            }
        }

        private void GuessKeyPress(object sender, KeyEventArgs e)
        {
            ButtonSound.Play();
            try
            {
                if (ControlList.Count > 0 && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                {
                    Button keyPress = Controls.Find("button" + e.KeyCode, true)[0] as Button;
                    GuessClick(keyPress, new EventArgs());
                }
            }
            catch (Exception exception)
            {
                Error.Show();
                Console.WriteLine(exception.Message);
            }
        }

        private void GameOver(string status)
        {
            RemoveControls(ControlList);
            CmpltLbl.Text = status;
            FnlScore.Text = Score.Text;
            HideElements(new Control[] { PuzzlePic, HangPic, TimerLabel, Score, GuessLbl, Listen, Continue });
            ShowElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ThemeSound.PlayLooping();
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            ShowElements(new Control[] { PlyBtn, MainLbl, LevelLbl, CatSelect });
        }

        private void PlyAgnBtn_Click(object sender, EventArgs e)
        {
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            PlyBtn_Click(sender, e);
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            TextToSpeech();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (SeqNo == 10)
            {
                GameOver(WIN);
                GameWon.Play();
            }
            else
            {
                HideElements(new Control[] { Listen, Continue });
                GenerateButtons();
                Guesses = new List<char>();
                SetupWordChoice();
                LoadWordGuess();
                Timer = 0;
                TimeKeeper.Start();
            }
        }
    }
}
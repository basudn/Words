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
        //private string[] LoadImageStore;
        private List<int> AlreadyPlayedWords;
        private int IncorrectGuesses;
        private int Timer;
        private int SeqNo;
        private int TotalScore;
        public int Hiscore=0;
        private Bitmap[] hangImages = new Bitmap[] { Words.Properties.Resources.hanging1, Words.Properties.Resources.hanging2,
                                        Words.Properties.Resources.hanging3, Words.Properties.Resources.hanging4,
                                        Words.Properties.Resources.hanging5, Words.Properties.Resources.hanging6,
                                        Words.Properties.Resources.hanging7};
        private List<Control> ControlList = new List<Control>();
        private List<char> Guesses;
        SoundPlayer button_sound = new SoundPlayer(Words.Properties.Resources.button_sound);
        SoundPlayer ThemeSound = new SoundPlayer(Words.Properties.Resources.Theme);
        SoundPlayer GameLost = new SoundPlayer(Words.Properties.Resources.scream);
        SoundPlayer GameWon = new SoundPlayer(Words.Properties.Resources.applause);

        public Intro()
        {
            InitializeComponent();
            ThemeSound.PlayLooping();
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
                loadwords(CatSelect.SelectedItem as string);
                SetupWordChoice();
                LoadWordGuess();
                HideElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, CatSelect });
                Score.Text = "Score: " + TotalScore;
                ShowElements(new Control[] { HangPic, PuzzlePic, Score, TimerLabel, GuessLbl });
                Timer = 0;
                TimeKeeper.Start();
            }
        }

        private void loadwords(string category)
        {
            string inputStream = Words.Properties.Resources.ResourceManager.GetObject(category.ToLower()) as string;
            string[] readText = inputStream.Split(new char[] { },StringSplitOptions.RemoveEmptyEntries);
            LoadWordStore = new String[readText.Length];
            //LoadImageStore = new String[readText.Length];
            int index = 0;
            foreach (String s in readText)
            {
                LoadWordStore[index] = s;
                //LoadImageStore[index] = line[2];
                index++;
            }
        }

        private void SetupWordChoice()
        {
            int guessIndex;
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
                { Hiscore = TotalScore;
                    HighScore.Text = "High Score : " + Hiscore;
                }
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                // Synchronous
                synthesizer.Speak(Word);
                TimeKeeper.Stop();
                RemoveControls(ControlList);
                ShowElements(new Control[] { Listen, Continue });
            }
        }

        private void GenerateButtons()
        {
            int top = 365;
            int left = 100;
            int width = 35;
            int height = 35;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                if (alpha == 'N')
                {
                    top = 400;
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
            foreach(Control control in controls)
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
            button_sound.Play();
            Button button = sender as Button;
            if (!Guesses.Contains(button.Text[0]))
            {
                button.BackColor = Color.Red;
                button.Enabled = false;
                Guesses.Add(button.Text[0]);
                LoadWordGuess();
                if (!Word.Contains(button.Text[0]))
                {
                    IncorrectGuesses++;
                    if(IncorrectGuesses > 6)
                    {
                        GameLost.Play();
                        GameOver(LOSE);
                    }
                    else
                    {
                        HangPic.Image = hangImages[IncorrectGuesses];
                    }
                }
                Timer = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = "Timer: " + (30 - Timer / 10);
            Timer++;
            if(Timer == 300)
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
                Timer = 0;
            }
        }

        private void GuessKeyPress(object sender, KeyEventArgs e)
        {
            button_sound.Play();
            if (ControlList.Count > 0 && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                Button keyPress = Controls.Find("button" + e.KeyCode, true)[0] as Button;
                GuessClick(keyPress, new EventArgs());
            }
        }

        private void GameOver(string status)
        {
            RemoveControls(ControlList);
            CmpltLbl.Text = status;
            FnlScore.Text = Score.Text;
            HideElements(new Control[] { PuzzlePic, HangPic, TimerLabel, Score, GuessLbl });
            ShowElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            Listen.Visible = false;
            Continue.Visible = false;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ThemeSound.PlayLooping();
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            ShowElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, CatSelect });
        }

        private void PlyAgnBtn_Click(object sender, EventArgs e)
        {
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            PlyBtn_Click(sender, e);
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Speak(Word);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Intro_Load_1(object sender, EventArgs e)
        {

        }
    }
}
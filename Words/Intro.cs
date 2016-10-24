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
        private Bitmap[] hangImages = new Bitmap[] { Words.Properties.Resources.hanging1, Words.Properties.Resources.hanging2,
                                        Words.Properties.Resources.hanging3, Words.Properties.Resources.hanging4,
                                        Words.Properties.Resources.hanging5, Words.Properties.Resources.hanging6,
                                        Words.Properties.Resources.hanging7};
        private List<Control> ControlList = new List<Control>();
        private List<char> Guesses;
        SoundPlayer button_sound = new SoundPlayer(Words.Properties.Resources.button_sound);
        WMPLib.WindowsMediaPlayer intro_sound = new WMPLib.WindowsMediaPlayer();
        


        public Intro()
        {
            InitializeComponent();
            intro_sound.URL = (@"C:\Users\Vijay Jain\Documents\Visual Studio 2015\Projects\Words\Audio\Boyce_Avenue_Demons.mp3");
            intro_sound.controls.play();
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            intro_sound.controls.stop();
            SeqNo = 0;
            TotalScore = 0;
            AlreadyPlayedWords = new List<int>();
            Guesses = new List<char>();
            GenerateButtons();
            loadwords();
            SetupWordChoice();
            LoadWordGuess();
            HideElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, LevelSelect });
            Score.Text = "Score: " + TotalScore;
            ShowElements(new Control[] { HangPic, PuzzlePic, Score, TimerLabel, GuessLbl });
            Timer = 0;
            TimeKeeper.Start();
        }

        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("words.csv");
            LoadWordStore = new String[readText.Length];
            //LoadImageStore = new String[readText.Length];
            int index = 0;
           
            
            foreach (String s in readText)
            {
                string[] line = s.Split(delimiterChars);
                LoadWordStore[index] = line[1];
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
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                // Synchronous
                synthesizer.Speak(Word);
                TimeKeeper.Stop();
                if (SeqNo == 10)
                {
                    GameOver(WIN);
                }
                else
                {
                    RemoveControls(ControlList);
                    GenerateButtons();
                    Guesses = new List<char>();
                    SetupWordChoice();
                    LoadWordGuess();
                    Timer = 0;
                    TimeKeeper.Start();
                }
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
        }

        private void Intro_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            intro_sound.controls.play();
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            ShowElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, LevelSelect });
        }

        private void PlyAgnBtn_Click(object sender, EventArgs e)
        {
            HideElements(new Control[] { CmpltLbl, FnlScore, MainMenuBtn, PlyAgnBtn });
            PlyBtn_Click(sender, e);
        }
    }
}
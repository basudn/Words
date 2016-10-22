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

namespace Words
{
    public partial class Intro : Form
    {
        private string Word = "DEFAULT";
        private readonly string WIN = "YOU WON!";
        private readonly string LOSE = "YOU LOSE!";
        private string[] LoadWordStore;
        private string[] LoadImageStore;
        private List<int> AlreadyPlayedWords;
        private int IncorrectGuesses;
        private int Timer;
        private int SeqNo;
        private int TotalScore;
        private Bitmap[] hangImages = new Bitmap[] { Words.Properties.Resources.Hang1, Words.Properties.Resources.Hang2,
                                        Words.Properties.Resources.Hang3, Words.Properties.Resources.Hang4,
                                        Words.Properties.Resources.Hang5, Words.Properties.Resources.Hang6,
                                        Words.Properties.Resources.Hang7};
        private List<Control> ControlList = new List<Control>();
        private List<char> Guesses;

        public Intro()
        {
            InitializeComponent();
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            IncorrectGuesses = 0;
            SeqNo = 0;
            TotalScore = 0;
            AlreadyPlayedWords = new List<int>();
            Guesses = new List<char>();
            GenerateButtons();
            loadwords();
            SetupWordChoice();
            LoadWordGuess();
            HideElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, LevelSelect });
            TimerLabel.Text = "0:0";
            Score.Text = "Score: " + TotalScore;
            TimeKeeper.Enabled = true;
            ShowElements(new Control[] { HangPic, PuzzlePic, Score, TimerLabel, GuessLbl });
        }

        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("words.csv");
            LoadWordStore = new String[readText.Length];
            LoadImageStore = new String[readText.Length];
            int index = 0;
           
            
            foreach (String s in readText)
            {
                string[] line = s.Split(delimiterChars);
                LoadWordStore[index] = line[1];
                LoadImageStore[index] = line[2];
                index++;
            }
        }

        private void SetupWordChoice()
        {
            int guessIndex = (new Random()).Next(LoadWordStore.Length);
            while (AlreadyPlayedWords.Contains(guessIndex))
            {
                guessIndex = (new Random()).Next(LoadWordStore.Length);
            }
            Word = LoadWordStore[guessIndex].ToUpper();
            PuzzlePic.ImageLocation = LoadImageStore[guessIndex];
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
            Timer = 0;
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
            TimerLabel.Text = Timer / 10 + ":" + Timer % 10;
            Timer++;
            if(Timer == 100)
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
            if (ControlList.Count > 0 && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                Button keyPress = Controls.Find("button" + e.KeyCode, true)[0] as Button;
                GuessClick(keyPress, new EventArgs());
            }
        }

        private void GameOver(string status)
        {
            TimeKeeper.Stop();
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
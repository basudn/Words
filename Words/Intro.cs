using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public partial class Intro : Form
    {
        private string Word = "MANGO";
        private int IncorrectGuesses = 0;
        private int Timer;
        private int SeqNo = 0;
        private int TotalScore = 0;
        private Bitmap[] hangImages = new Bitmap[] { Words.Properties.Resources.Hang1, Words.Properties.Resources.Hang2,
                                        Words.Properties.Resources.Hang3, Words.Properties.Resources.Hang4,
                                        Words.Properties.Resources.Hang5, Words.Properties.Resources.Hang6,
                                        Words.Properties.Resources.Hang7};
        private List<Control> ControlList = new List<Control>();
        private List<char> Guesses = new List<char>();

        public Intro()
        {
            InitializeComponent();
        }

        private void PlyBtn_Click(object sender, EventArgs e)
        {
            IncorrectGuesses = 0;
            GenerateButtons();
            LoadWordGuess();
            GuessLbl.Show();
            HideElements(new Control[] { MainPic, PlyBtn, MainLbl, LevelLbl, LevelSelect });
            ShowElements(new Control[] { HangPic, PuzzlePic });
            TimerLabel.Text = "0:0";
            TimerLabel.Show();
            Score.Text = "Score: " + TotalScore;
            Score.Show();
            TimeKeeper.Enabled = true;
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
                    TimeKeeper.Stop();
                }
                else
                {
                    RemoveControls(ControlList);
                    GenerateButtons();
                    Guesses = new List<char>();
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
                        TimeKeeper.Stop();
                        TimerLabel.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Strikeout);
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
                    TimeKeeper.Stop();
                    TimerLabel.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Strikeout);
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
    }
}
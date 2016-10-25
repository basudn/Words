namespace Words
{
    partial class Intro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.PlyBtn = new System.Windows.Forms.Button();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.CatSelect = new System.Windows.Forms.ComboBox();
            this.MainLbl = new System.Windows.Forms.Label();
            this.TimeKeeper = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.GuessLbl = new System.Windows.Forms.Label();
            this.PuzzlePic = new System.Windows.Forms.PictureBox();
            this.HangPic = new System.Windows.Forms.PictureBox();
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.CmpltLbl = new System.Windows.Forms.Label();
            this.FnlScore = new System.Windows.Forms.Label();
            this.PlyAgnBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Listen = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.HighScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PuzzlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlyBtn
            // 
            this.PlyBtn.AutoSize = true;
            this.PlyBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.PlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlyBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlyBtn.Location = new System.Drawing.Point(401, 377);
            this.PlyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlyBtn.Name = "PlyBtn";
            this.PlyBtn.Size = new System.Drawing.Size(120, 58);
            this.PlyBtn.TabIndex = 0;
            this.PlyBtn.Text = "Play";
            this.PlyBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlyBtn.UseVisualStyleBackColor = false;
            this.PlyBtn.Click += new System.EventHandler(this.PlyBtn_Click);
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.BackColor = System.Drawing.Color.Transparent;
            this.LevelLbl.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelLbl.Location = new System.Drawing.Point(256, 206);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(209, 60);
            this.LevelLbl.TabIndex = 3;
            this.LevelLbl.Text = "Category";
            // 
            // CatSelect
            // 
            this.CatSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CatSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatSelect.FormattingEnabled = true;
            this.CatSelect.Items.AddRange(new object[] {
            "Fruits",
            "Vehicles",
            "Flags",
            "Animals"});
            this.CatSelect.Location = new System.Drawing.Point(483, 220);
            this.CatSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CatSelect.Name = "CatSelect";
            this.CatSelect.Size = new System.Drawing.Size(140, 39);
            this.CatSelect.TabIndex = 5;
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.BackColor = System.Drawing.Color.Transparent;
            this.MainLbl.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainLbl.Location = new System.Drawing.Point(285, 46);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(329, 95);
            this.MainLbl.TabIndex = 7;
            this.MainLbl.Text = "hangman";
            // 
            // TimeKeeper
            // 
            this.TimeKeeper.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerLabel.Location = new System.Drawing.Point(662, 60);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(138, 32);
            this.TimerLabel.TabIndex = 9;
            this.TimerLabel.Text = "Timer";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TimerLabel.Visible = false;
            // 
            // GuessLbl
            // 
            this.GuessLbl.BackColor = System.Drawing.Color.Transparent;
            this.GuessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuessLbl.Location = new System.Drawing.Point(171, 348);
            this.GuessLbl.Name = "GuessLbl";
            this.GuessLbl.Size = new System.Drawing.Size(497, 37);
            this.GuessLbl.TabIndex = 11;
            this.GuessLbl.Text = "Guess";
            this.GuessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuessLbl.Visible = false;
            // 
            // PuzzlePic
            // 
            this.PuzzlePic.BackColor = System.Drawing.Color.Transparent;
            this.PuzzlePic.Location = new System.Drawing.Point(302, 80);
            this.PuzzlePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PuzzlePic.Name = "PuzzlePic";
            this.PuzzlePic.Size = new System.Drawing.Size(256, 240);
            this.PuzzlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PuzzlePic.TabIndex = 10;
            this.PuzzlePic.TabStop = false;
            this.PuzzlePic.Visible = false;
            // 
            // HangPic
            // 
            this.HangPic.Location = new System.Drawing.Point(668, 107);
            this.HangPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HangPic.Name = "HangPic";
            this.HangPic.Size = new System.Drawing.Size(171, 305);
            this.HangPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangPic.TabIndex = 8;
            this.HangPic.TabStop = false;
            this.HangPic.Visible = false;
            // 
            // MainPic
            // 
            this.MainPic.BackColor = System.Drawing.Color.Transparent;
            this.MainPic.Location = new System.Drawing.Point(104, 99);
            this.MainPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPic.Name = "MainPic";
            this.MainPic.Size = new System.Drawing.Size(327, 271);
            this.MainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPic.TabIndex = 6;
            this.MainPic.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Location = new System.Drawing.Point(12, 46);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(111, 31);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score";
            this.Score.Visible = false;
            // 
            // CmpltLbl
            // 
            this.CmpltLbl.BackColor = System.Drawing.Color.Transparent;
            this.CmpltLbl.Font = new System.Drawing.Font("Old English Text MT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmpltLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmpltLbl.Location = new System.Drawing.Point(234, 107);
            this.CmpltLbl.Name = "CmpltLbl";
            this.CmpltLbl.Size = new System.Drawing.Size(429, 58);
            this.CmpltLbl.TabIndex = 13;
            this.CmpltLbl.Text = "Status";
            this.CmpltLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CmpltLbl.Visible = false;
            // 
            // FnlScore
            // 
            this.FnlScore.BackColor = System.Drawing.Color.Transparent;
            this.FnlScore.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnlScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FnlScore.Location = new System.Drawing.Point(310, 190);
            this.FnlScore.Name = "FnlScore";
            this.FnlScore.Size = new System.Drawing.Size(262, 30);
            this.FnlScore.TabIndex = 14;
            this.FnlScore.Text = "Final Score";
            this.FnlScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FnlScore.Visible = false;
            // 
            // PlyAgnBtn
            // 
            this.PlyAgnBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlyAgnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.PlyAgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlyAgnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlyAgnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlyAgnBtn.Location = new System.Drawing.Point(355, 306);
            this.PlyAgnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlyAgnBtn.Name = "PlyAgnBtn";
            this.PlyAgnBtn.Size = new System.Drawing.Size(178, 56);
            this.PlyAgnBtn.TabIndex = 15;
            this.PlyAgnBtn.Text = "Play Again";
            this.PlyAgnBtn.UseVisualStyleBackColor = false;
            this.PlyAgnBtn.Visible = false;
            this.PlyAgnBtn.Click += new System.EventHandler(this.PlyAgnBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuBtn.Location = new System.Drawing.Point(355, 247);
            this.MainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(178, 56);
            this.MainMenuBtn.TabIndex = 16;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = false;
            this.MainMenuBtn.Visible = false;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(510, 443);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Listen
            // 
            this.Listen.BackColor = System.Drawing.Color.Transparent;
            this.Listen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Listen.Location = new System.Drawing.Point(242, 422);
            this.Listen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(178, 56);
            this.Listen.TabIndex = 18;
            this.Listen.Text = "Listen";
            this.Listen.UseVisualStyleBackColor = false;
            this.Listen.Visible = false;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Continue.Location = new System.Drawing.Point(436, 422);
            this.Continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(178, 56);
            this.Continue.TabIndex = 19;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HighScore.Location = new System.Drawing.Point(12, 9);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(226, 31);
            this.HighScore.TabIndex = 20;
            this.HighScore.Text = "High Score: 0";
            this.HighScore.Visible = false;
            this.HighScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(163, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "© 2016 Debayan Basu, Vijay Jain, Sushant Karnik";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Words.Properties.Resources.Ship;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.LevelLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Listen);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.PlyAgnBtn);
            this.Controls.Add(this.CmpltLbl);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.GuessLbl);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.HangPic);
            this.Controls.Add(this.MainLbl);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.CatSelect);
            this.Controls.Add(this.PlyBtn);
            this.Controls.Add(this.FnlScore);
            this.Controls.Add(this.PuzzlePic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(962, 609);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(962, 609);
            this.Name = "Intro";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Intro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PuzzlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlyBtn;
        private System.Windows.Forms.Label LevelLbl;
        private System.Windows.Forms.ComboBox CatSelect;
        private System.Windows.Forms.PictureBox MainPic;
        private System.Windows.Forms.Label MainLbl;
        private System.Windows.Forms.PictureBox HangPic;
        private System.Windows.Forms.Timer TimeKeeper;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.PictureBox PuzzlePic;
        private System.Windows.Forms.Label GuessLbl;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label CmpltLbl;
        private System.Windows.Forms.Label FnlScore;
        private System.Windows.Forms.Button PlyAgnBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Label label1;
    }
}


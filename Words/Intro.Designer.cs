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
            this.LevelSelect = new System.Windows.Forms.ComboBox();
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
            this.PlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlyBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlyBtn.Location = new System.Drawing.Point(680, 410);
            this.PlyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlyBtn.Name = "PlyBtn";
            this.PlyBtn.Size = new System.Drawing.Size(120, 56);
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
            this.LevelLbl.Location = new System.Drawing.Point(537, 193);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(209, 60);
            this.LevelLbl.TabIndex = 3;
            this.LevelLbl.Text = "Category";
            // 
            // LevelSelect
            // 
            this.LevelSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelSelect.FormattingEnabled = true;
            this.LevelSelect.Location = new System.Drawing.Point(772, 202);
            this.LevelSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LevelSelect.Name = "LevelSelect";
            this.LevelSelect.Size = new System.Drawing.Size(134, 54);
            this.LevelSelect.TabIndex = 5;
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.BackColor = System.Drawing.Color.Transparent;
            this.MainLbl.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainLbl.Location = new System.Drawing.Point(577, 60);
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
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GuessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessLbl.Location = new System.Drawing.Point(175, 348);
            this.GuessLbl.Name = "GuessLbl";
            this.GuessLbl.Size = new System.Drawing.Size(501, 37);
            this.GuessLbl.TabIndex = 11;
            this.GuessLbl.Text = "Guess";
            this.GuessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuessLbl.Visible = false;
            // 
            // PuzzlePic
            // 
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
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(54, 60);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 31);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score";
            this.Score.Visible = false;
            // 
            // CmpltLbl
            // 
            this.CmpltLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmpltLbl.Location = new System.Drawing.Point(244, 116);
            this.CmpltLbl.Name = "CmpltLbl";
            this.CmpltLbl.Size = new System.Drawing.Size(371, 58);
            this.CmpltLbl.TabIndex = 13;
            this.CmpltLbl.Text = "Status";
            this.CmpltLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CmpltLbl.Visible = false;
            // 
            // FnlScore
            // 
            this.FnlScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnlScore.Location = new System.Drawing.Point(296, 193);
            this.FnlScore.Name = "FnlScore";
            this.FnlScore.Size = new System.Drawing.Size(262, 30);
            this.FnlScore.TabIndex = 14;
            this.FnlScore.Text = "Final Score";
            this.FnlScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FnlScore.Visible = false;
            // 
            // PlyAgnBtn
            // 
            this.PlyAgnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlyAgnBtn.Location = new System.Drawing.Point(335, 289);
            this.PlyAgnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlyAgnBtn.Name = "PlyAgnBtn";
            this.PlyAgnBtn.Size = new System.Drawing.Size(178, 40);
            this.PlyAgnBtn.TabIndex = 15;
            this.PlyAgnBtn.Text = "Play Again";
            this.PlyAgnBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlyAgnBtn.UseVisualStyleBackColor = true;
            this.PlyAgnBtn.Visible = false;
            this.PlyAgnBtn.Click += new System.EventHandler(this.PlyAgnBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(335, 244);
            this.MainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(178, 40);
            this.MainMenuBtn.TabIndex = 16;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainMenuBtn.UseVisualStyleBackColor = true;
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
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Words.Properties.Resources.Ship;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 555);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.PlyAgnBtn);
            this.Controls.Add(this.FnlScore);
            this.Controls.Add(this.CmpltLbl);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.GuessLbl);
            this.Controls.Add(this.PuzzlePic);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.HangPic);
            this.Controls.Add(this.MainLbl);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.LevelSelect);
            this.Controls.Add(this.LevelLbl);
            this.Controls.Add(this.PlyBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.Text = "Hangman";
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
        private System.Windows.Forms.ComboBox LevelSelect;
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
    }
}


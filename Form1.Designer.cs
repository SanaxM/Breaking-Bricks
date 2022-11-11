namespace Breakout
{
    partial class Form1
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
            this.tmrTitleAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrColourChange = new System.Windows.Forms.Timer(this.components);
            this.tmrPaddle = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.tmrLevel1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExplainRules = new System.Windows.Forms.Label();
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.lblPaddleSelect = new System.Windows.Forms.Label();
            this.lblLevelSelect = new System.Windows.Forms.Label();
            this.lblPaddleSelectTitle = new System.Windows.Forms.Label();
            this.lblLevelTitle = new System.Windows.Forms.Label();
            this.tmrLevel2 = new System.Windows.Forms.Timer(this.components);
            this.picPreview2 = new System.Windows.Forms.PictureBox();
            this.picPreview1 = new System.Windows.Forms.PictureBox();
            this.picPaddle2 = new System.Windows.Forms.PictureBox();
            this.picPurplePaddle = new System.Windows.Forms.PictureBox();
            this.picBluePaddle = new System.Windows.Forms.PictureBox();
            this.picGreyPaddle = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurplePaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTitleAnimation
            // 
            this.tmrTitleAnimation.Enabled = true;
            this.tmrTitleAnimation.Interval = 300;
            this.tmrTitleAnimation.Tick += new System.EventHandler(this.tmrTitleAnimation_Tick);
            // 
            // tmrColourChange
            // 
            this.tmrColourChange.Enabled = true;
            this.tmrColourChange.Interval = 700;
            this.tmrColourChange.Tick += new System.EventHandler(this.tmrColourChange_Tick);
            // 
            // tmrPaddle
            // 
            this.tmrPaddle.Interval = 10;
            this.tmrPaddle.Tick += new System.EventHandler(this.tmrPaddle_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Green;
            this.lblStart.Location = new System.Drawing.Point(328, 301);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(397, 36);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "PRESS  ENTER   TO   START";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.Green;
            this.lblRules.Location = new System.Drawing.Point(297, 453);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(467, 36);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = "PRESS  SPACE  FOR  THE  RULES";
            // 
            // tmrLevel1
            // 
            this.tmrLevel1.Interval = 10;
            this.tmrLevel1.Tick += new System.EventHandler(this.tmrLevel1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(274, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 86);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "BREAKOUT";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(99, 30);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            this.lblScore.Visible = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(160, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(233, 30);
            this.lblLives.TabIndex = 11;
            this.lblLives.Text = "|         Lives Left: 3";
            this.lblLives.Visible = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(434, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(155, 30);
            this.lblLevel.TabIndex = 12;
            this.lblLevel.Text = "|         Level:";
            this.lblLevel.Visible = false;
            // 
            // lblExplainRules
            // 
            this.lblExplainRules.AutoSize = true;
            this.lblExplainRules.Font = new System.Drawing.Font("Broadway", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplainRules.ForeColor = System.Drawing.Color.Yellow;
            this.lblExplainRules.Location = new System.Drawing.Point(60, 81);
            this.lblExplainRules.Name = "lblExplainRules";
            this.lblExplainRules.Size = new System.Drawing.Size(88, 27);
            this.lblExplainRules.TabIndex = 13;
            this.lblExplainRules.Text = "Rules";
            this.lblExplainRules.Visible = false;
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRulesTitle.Location = new System.Drawing.Point(402, 373);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.Size = new System.Drawing.Size(225, 36);
            this.lblRulesTitle.TabIndex = 14;
            this.lblRulesTitle.Text = "HOW TO PLAY";
            this.lblRulesTitle.Visible = false;
            // 
            // lblPaddleSelect
            // 
            this.lblPaddleSelect.AutoSize = true;
            this.lblPaddleSelect.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaddleSelect.ForeColor = System.Drawing.Color.Green;
            this.lblPaddleSelect.Location = new System.Drawing.Point(319, 399);
            this.lblPaddleSelect.Name = "lblPaddleSelect";
            this.lblPaddleSelect.Size = new System.Drawing.Size(433, 36);
            this.lblPaddleSelect.TabIndex = 15;
            this.lblPaddleSelect.Text = "PRESS 2  TO  SELECT  PADDLE";
            this.lblPaddleSelect.Visible = false;
            // 
            // lblLevelSelect
            // 
            this.lblLevelSelect.AutoSize = true;
            this.lblLevelSelect.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelSelect.ForeColor = System.Drawing.Color.Green;
            this.lblLevelSelect.Location = new System.Drawing.Point(328, 349);
            this.lblLevelSelect.Name = "lblLevelSelect";
            this.lblLevelSelect.Size = new System.Drawing.Size(411, 36);
            this.lblLevelSelect.TabIndex = 16;
            this.lblLevelSelect.Text = "PRESS  3  TO  SELECT  LEVEL";
            this.lblLevelSelect.Visible = false;
            // 
            // lblPaddleSelectTitle
            // 
            this.lblPaddleSelectTitle.AutoSize = true;
            this.lblPaddleSelectTitle.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaddleSelectTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaddleSelectTitle.Location = new System.Drawing.Point(328, 59);
            this.lblPaddleSelectTitle.Name = "lblPaddleSelectTitle";
            this.lblPaddleSelectTitle.Size = new System.Drawing.Size(351, 36);
            this.lblPaddleSelectTitle.TabIndex = 20;
            this.lblPaddleSelectTitle.Text = "CHOOSE YOUR PADDLE";
            this.lblPaddleSelectTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPaddleSelectTitle.Visible = false;
            // 
            // lblLevelTitle
            // 
            this.lblLevelTitle.AutoSize = true;
            this.lblLevelTitle.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelTitle.ForeColor = System.Drawing.Color.White;
            this.lblLevelTitle.Location = new System.Drawing.Point(328, 167);
            this.lblLevelTitle.Name = "lblLevelTitle";
            this.lblLevelTitle.Size = new System.Drawing.Size(321, 36);
            this.lblLevelTitle.TabIndex = 21;
            this.lblLevelTitle.Text = "CHOOSE YOUR LEVEL";
            this.lblLevelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLevelTitle.Visible = false;
            // 
            // tmrLevel2
            // 
            this.tmrLevel2.Interval = 10;
            this.tmrLevel2.Tick += new System.EventHandler(this.tmrLevel2_Tick);
            // 
            // picPreview2
            // 
            this.picPreview2.Location = new System.Drawing.Point(841, 333);
            this.picPreview2.Name = "picPreview2";
            this.picPreview2.Size = new System.Drawing.Size(117, 63);
            this.picPreview2.TabIndex = 24;
            this.picPreview2.TabStop = false;
            // 
            // picPreview1
            // 
            this.picPreview1.Location = new System.Drawing.Point(841, 264);
            this.picPreview1.Name = "picPreview1";
            this.picPreview1.Size = new System.Drawing.Size(117, 63);
            this.picPreview1.TabIndex = 23;
            this.picPreview1.TabStop = false;
            this.picPreview1.Visible = false;
            // 
            // picPaddle2
            // 
            this.picPaddle2.BackColor = System.Drawing.Color.Black;
            this.picPaddle2.Image = global::Breakout.Properties.Resources.Level2Paddle2;
            this.picPaddle2.Location = new System.Drawing.Point(0, 379);
            this.picPaddle2.Name = "picPaddle2";
            this.picPaddle2.Size = new System.Drawing.Size(122, 30);
            this.picPaddle2.TabIndex = 22;
            this.picPaddle2.TabStop = false;
            this.picPaddle2.Visible = false;
            // 
            // picPurplePaddle
            // 
            this.picPurplePaddle.BackColor = System.Drawing.Color.White;
            this.picPurplePaddle.Enabled = false;
            this.picPurplePaddle.Image = global::Breakout.Properties.Resources.PurplePaddle;
            this.picPurplePaddle.InitialImage = global::Breakout.Properties.Resources.GreyPaddle;
            this.picPurplePaddle.Location = new System.Drawing.Point(146, 488);
            this.picPurplePaddle.Name = "picPurplePaddle";
            this.picPurplePaddle.Size = new System.Drawing.Size(122, 37);
            this.picPurplePaddle.TabIndex = 19;
            this.picPurplePaddle.TabStop = false;
            this.picPurplePaddle.Visible = false;
            // 
            // picBluePaddle
            // 
            this.picBluePaddle.BackColor = System.Drawing.Color.White;
            this.picBluePaddle.Enabled = false;
            this.picBluePaddle.Image = global::Breakout.Properties.Resources.BluePaddle;
            this.picBluePaddle.InitialImage = global::Breakout.Properties.Resources.GreyPaddle;
            this.picBluePaddle.Location = new System.Drawing.Point(146, 330);
            this.picBluePaddle.Name = "picBluePaddle";
            this.picBluePaddle.Size = new System.Drawing.Size(122, 37);
            this.picBluePaddle.TabIndex = 18;
            this.picBluePaddle.TabStop = false;
            this.picBluePaddle.Visible = false;
            // 
            // picGreyPaddle
            // 
            this.picGreyPaddle.BackColor = System.Drawing.Color.White;
            this.picGreyPaddle.Enabled = false;
            this.picGreyPaddle.Image = global::Breakout.Properties.Resources.GreyPaddle;
            this.picGreyPaddle.InitialImage = global::Breakout.Properties.Resources.GreyPaddle;
            this.picGreyPaddle.Location = new System.Drawing.Point(146, 170);
            this.picGreyPaddle.Name = "picGreyPaddle";
            this.picGreyPaddle.Size = new System.Drawing.Size(122, 37);
            this.picGreyPaddle.TabIndex = 17;
            this.picGreyPaddle.TabStop = false;
            this.picGreyPaddle.Visible = false;
            // 
            // picMute
            // 
            this.picMute.BackColor = System.Drawing.Color.Black;
            this.picMute.Image = global::Breakout.Properties.Resources.Volume;
            this.picMute.Location = new System.Drawing.Point(12, 586);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(63, 63);
            this.picMute.TabIndex = 7;
            this.picMute.TabStop = false;
            this.picMute.Click += new System.EventHandler(this.picMute_Click);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = global::Breakout.Properties.Resources.GreyBall;
            this.picBall.Location = new System.Drawing.Point(507, 586);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 4;
            this.picBall.TabStop = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.White;
            this.picPaddle.Enabled = false;
            this.picPaddle.Image = global::Breakout.Properties.Resources.GreyPaddle;
            this.picPaddle.InitialImage = global::Breakout.Properties.Resources.GreyPaddle;
            this.picPaddle.Location = new System.Drawing.Point(453, 612);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(122, 37);
            this.picPaddle.TabIndex = 3;
            this.picPaddle.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Broadway", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(728, 557);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(206, 31);
            this.lblGameOver.TabIndex = 25;
            this.lblGameOver.Text = "GAME OVER!";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 661);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLevelTitle);
            this.Controls.Add(this.lblPaddleSelectTitle);
            this.Controls.Add(this.picPurplePaddle);
            this.Controls.Add(this.picBluePaddle);
            this.Controls.Add(this.picGreyPaddle);
            this.Controls.Add(this.lblLevelSelect);
            this.Controls.Add(this.lblPaddleSelect);
            this.Controls.Add(this.lblRulesTitle);
            this.Controls.Add(this.lblExplainRules);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.picPreview1);
            this.Controls.Add(this.picPreview2);
            this.Controls.Add(this.picPaddle2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurplePaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrTitleAnimation;
        private System.Windows.Forms.Timer tmrColourChange;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Timer tmrPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.Timer tmrLevel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExplainRules;
        private System.Windows.Forms.Label lblRulesTitle;
        private System.Windows.Forms.Label lblPaddleSelect;
        private System.Windows.Forms.Label lblLevelSelect;
        private System.Windows.Forms.PictureBox picGreyPaddle;
        private System.Windows.Forms.PictureBox picBluePaddle;
        private System.Windows.Forms.PictureBox picPurplePaddle;
        private System.Windows.Forms.Label lblPaddleSelectTitle;
        private System.Windows.Forms.Label lblLevelTitle;
        private System.Windows.Forms.Timer tmrLevel2;
        private System.Windows.Forms.PictureBox picPaddle2;
        private System.Windows.Forms.PictureBox picPreview1;
        private System.Windows.Forms.PictureBox picPreview2;
        private System.Windows.Forms.Label lblGameOver;
    }
}


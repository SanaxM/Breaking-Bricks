using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Breakout
{
    public enum PaddleState
    {
        None,
        Left,
        Right
    }
    public partial class Form1 : Form
    {
        //global variables (grouped by object/screen)
        Form Instructions = new Form();
        
        //start menu
        PictureBox[,] StartGrid = new PictureBox[14, 7];
        PictureBox[,] GridOneStart = new PictureBox[14, 7];
        StartMenu ClearMenu = new StartMenu();
        StartMenu aBrickGrid = new StartMenu();
        bool PicAudio = true;

        //paddle
        PaddleState mPaddle = PaddleState.None;

        //music
        Music AudioPlayer = new Music();

        //Level 1
        Level1 PlayingGrid;
        PictureBox[,] Level1Grid = new PictureBox[14, 7];
        int[,] BricksHit = new int[14, 7];
        int NumLives = 3, ScoreKeeper1;
        Ball Ball;

        //Level 2
        Level2 PlayGrid;
        PictureBox[,] Level2Grid = new PictureBox[14, 7];
        int[,] LvlTwoBricksHit = new int[14, 7];
        int NumLivesTwo = 5, ScoreKeeper2;
        Ball LvlTwoBall;

        //paddle select
        PaddleSelect PaddleScreen;

        //Rules
        Instructions Rules;

        //Level select
        LevelSelect LevelSelectScreen;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //control all user interaction here
            if (e.KeyCode == Keys.Return && lblTitle.Visible == true)
            {
                //paddle select screen

                //disable the timer for the colour change of the starting grid
                tmrColourChange.Enabled = false;

                //make all the bricks no longer visible
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        GridOneStart[i, j].Visible = false;
                    }
                }
                picMute.Image = Properties.Resources.Volume;
                PaddleSelect PaddleScreen = new PaddleSelect(picPaddle, picGreyPaddle, picBluePaddle, picPurplePaddle, picBall, lblStart, lblRules, lblLevelSelect, lblPaddleSelect, StartGrid, lblTitle, AudioPlayer, lblPaddleSelectTitle);
            }
            else if (e.KeyCode == Keys.Space && lblTitle.Visible == true)
            {
                //create instructions form
                Rules = new Instructions(Instructions, lblExplainRules, lblRulesTitle, AudioPlayer);
                Instructions.ShowDialog();
            }
            else if (e.KeyCode == Keys.A)
            {
                if (lblPaddleSelectTitle.Visible == true)
                {
                    //to select the grey paddle
                    PaddleSelect PaddleSelected = new PaddleSelect(picPaddle);
                    picPaddle.Image = PaddleSelected.GreyPaddle();
                    picPaddle.Visible = true;
                }
                else if (lblLevelTitle.Visible == true)
                {
                    //level 1
                    
                    //give a few seconds to prepare
                    Task.Delay(300000);

                    picPreview1.Visible = false;
                    picPreview2.Visible = false;

                    //start the paddle timer and reset music icon
                    tmrPaddle.Enabled = true;
                    picMute.Image = Properties.Resources.Volume;

                    //clear start menu controls
                    ClearMenu.ClearMenu(tmrTitleAnimation, tmrColourChange, lblTitle, lblRules, lblStart);
                    lblLevelSelect.Visible = false;
                    lblLevelTitle.Visible = false;

                    //draw on the playing grid- use this grid from now on for level one
                    PlayingGrid = new Level1(GridOneStart, picBall, lblScore, lblLevel, lblLives, tmrLevel1, AudioPlayer);
                    Level1Grid = PlayingGrid.ReturnGrid();
                    for (int i = 0; i < 14; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            //add each brick to the form
                            this.Controls.Add(Level1Grid[i, j]);
                        }
                    }
                    //draw on the ball and initalize it
                    Ball = new Ball(picBall);
                    Ball.Level1InitialSpeed();
                    Ball.Initialize();
                    Ball.BallAngle();
                }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (lblPaddleSelectTitle.Visible == true)
                {
                    //select the blue paddle
                    PaddleSelect PaddleSelected = new PaddleSelect(picPaddle);
                    picPaddle.Image = PaddleSelected.BluePaddle();
                    picPaddle.Visible = true;
                }
                else if (picPreview1.Visible == true)
                {
                    //level 2

                    //give a few seconds to prepare
                    Task.Delay(300000);

                    //disable prior controls
                    picPreview1.Visible = false;
                    picPreview2.Visible = false;

                    //enable paddles to move and reset volume icon
                    tmrPaddle.Enabled = true;
                    picPaddle2.Visible = true;
                    picMute.Image = Properties.Resources.Volume;

                    //create the screen
                    PlayGrid = new Level2(lblRules, lblLevelSelect, lblLevelTitle, lblScore, lblLives, lblLevel, GridOneStart, picBall, tmrColourChange);
                    tmrLevel2.Enabled = true;
                    Level2Grid = PlayGrid.ReturnGrid();
                    for (int i = 0; i < 14; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            //add each brick to the form
                            this.Controls.Add(Level2Grid[i, j]);
                        }
                    }

                    //put new music 
                    AudioPlayer.LevelTwoMusic();

                    //draw on the ball and initalize it
                    LvlTwoBall = new Ball(picBall);
                    LvlTwoBall.Level1InitialSpeed();
                    LvlTwoBall.Initialize();
                }
            }
            else if (e.KeyCode == Keys.C && lblPaddleSelectTitle.Visible == true)
            {
                //select the purple paddle
                PaddleSelect PaddleSelected = new PaddleSelect(picPaddle);
                picPaddle.Image = PaddleSelected.PurplePaddle();
                picPaddle.Visible = true;
            }
            else if (e.KeyCode == Keys.D1 )
            {
                if (picGreyPaddle.Visible == true && picPaddle.Visible == true)
                {
                    //level select
                    //construct the screen
                    LevelSelectScreen = new LevelSelect(picGreyPaddle, picBluePaddle, picPurplePaddle, lblRules, lblLevelSelect, lblPaddleSelect, lblPaddleSelectTitle, lblLevelTitle, picPreview1, picPreview2);
                    picMute.Image = Properties.Resources.Volume;
                }
                else if (lblGameOver.Visible == true && picPaddle2.Visible == false) 
                {
                    //going from level 1 to level 2

                    //disable prior screen's controls
                    tmrPaddle.Enabled = false;
                    tmrLevel1.Enabled = false;
                    lblGameOver.Visible = false;
                    picBall.Visible = false;

                    //draw on the ball and initalize it
                    LvlTwoBall = new Ball(picBall);
                    LvlTwoBall.Level1InitialSpeed();
                    LvlTwoBall.Initialize();

                    //give a few seconds to prepare-- jumping right into the game would be difficult 
                    Task.Delay(300000);

                    //enable user paddle and paddle 2 to move and reset music icon
                    tmrPaddle.Enabled = true;
                    picPaddle2.Visible = true;
                    picMute.Image = Properties.Resources.Volume;

                    //create the screen
                    PlayGrid = new Level2(GridOneStart, lblScore, lblLives, lblLevel, picBall, picPaddle2);
                    tmrLevel2.Enabled = true;
                    Level2Grid = PlayGrid.ReturnGrid();
                    for (int i = 0; i < 14; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            //add each brick to the form
                            this.Controls.Add(Level2Grid[i, j]);
                        }
                    }

                    //put new music 
                    AudioPlayer.LevelTwoMusic();
                }
            }
            else if (e.KeyCode == Keys.D2) //go from level 2 to main menu
            {
                //go to main menu
                if (lblGameOver.Visible == true)
                {
                    //close the current form
                    //when the user wants to go to back to the main menu, relaunch the application from the beginning
                    //I searched how to restart an application and found the following code:
                    Application.Restart();
                }
            }
            else if (e.KeyCode == Keys.Right)
                mPaddle = PaddleState.Right;

            else if (e.KeyCode == Keys.Left)
                mPaddle = PaddleState.Left;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)    
                mPaddle = PaddleState.None;
        }

        private void tmrPaddle_Tick(object sender, EventArgs e)
        {
            //allow the user to move the paddle
            if (mPaddle == PaddleState.Left && picPaddle.Left >= 0)
            {
                    picPaddle.Left -= 5;
            }
            else if (mPaddle == PaddleState.Right && picPaddle.Right <= ClientSize.Width)
            {
                    picPaddle.Left += 5;
            }

            //keep the second paddle moving- it moves from left-right and then resets at the max width of the form
            if (picPaddle2.Left <= 948)
            {
                picPaddle2.Left += 5;
            }
            else
            {
                picPaddle2.Left = 0;
            }
            

        }
        public void StartingGrid()
        {
            //create the starting grid by calling the StartMenu class
            //add the grid to the form controls
            StartMenu aBrickGrid = new StartMenu();
            GridOneStart = aBrickGrid.Return();
            for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        //add each brick to the form
                        this.Controls.Add(GridOneStart[i, j]);
                    }
                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //play main menu music
            AudioPlayer.MainMenu();
            StartingGrid();
        }
        private void tmrTitleAnimation_Tick(object sender, EventArgs e)
        {
            //Animate the Title
            //I searched up different ways to animate the labels, and I found that by changing the colour every time the timer
            //goes off, the label becomes animated
            if (lblRules.BackColor != Color.Yellow)
            {
                lblRules.BackColor = Color.Yellow;
                lblPaddleSelect.BackColor = Color.Yellow;
                lblStart.BackColor = Color.Aqua;
                lblLevelSelect.BackColor = Color.Aqua;

                lblRulesTitle.BackColor = Color.Aqua; //rules form title
            }
            else
            {
                lblRules.BackColor = Color.Aqua;
                lblPaddleSelect.BackColor = Color.Aqua;
                lblStart.BackColor = Color.Yellow;
                lblLevelSelect.BackColor = Color.Yellow;

                lblRulesTitle.BackColor = Color.LimeGreen; //rules form title
            }
        }

        private void tmrColourChange_Tick(object sender, EventArgs e)
        {
            //change the colours of the starting grid every time the timer goes off (700 ms intervals)
            GridOneStart = aBrickGrid.ColourChange(GridOneStart);
            for (int i = 0; i < GridOneStart.GetLength(0); i++)
            {
                for (int j = 0; j < GridOneStart.GetLength(1); j++)
                {
                    GridOneStart[i, j].Visible = true;
                }
            }
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            //if the audio icon is pressed and it shows a volume icon, set the picture to mute and stop 
            //the music
            if (PicAudio == true)
            {
                AudioPlayer.StopMusic();
                picMute.Image = Properties.Resources.Mute;
                PicAudio = false;
            }
            //if the audio icon is pressed and it shows a mute icon, restart the music based on the screen the user is on
            //to distinguish between screens, I checked to see if a control unique to the screen is visible
            else if (PicAudio == false)
            {
                if (lblTitle.Visible == true)
                    AudioPlayer.MainMenu();
                else if (picPaddle2.Visible == false && lblLives.Visible == true)
                    AudioPlayer.GameMusic();
                else if (picPaddle2.Visible == true)
                    AudioPlayer.LevelTwoMusic();
                else if (lblPaddleSelectTitle.Visible == true || lblLevelSelect.Visible == true)
                    AudioPlayer.LoadingMusic();
                picMute.Image = Properties.Resources.Volume;
                PicAudio = true;
            }
        }

        private void tmrLevel1_Tick(object sender, EventArgs e)
        {
            if (NumLives <= 3 && NumLives > 0)
            {
                //check if the paddle intersects with the ball
                if (picPaddle.Bounds.IntersectsWith(picBall.Bounds) && picBall.Bottom <= (ClientSize.Height - picPaddle.Height))
                {
                    //enact the paddle-ball collision method
                    Ball.BallPaddleCollisionLvl1();
                }

                //check if the ball intersects with any of the walls (excluding the bottom)
                if (picBall.Top <= 0) //top
                    Ball.BallHittingTop();

                else if (picBall.Left <= 0 || picBall.Right >= ClientSize.Width) //either side
                    Ball.BallHittingSides();

                else if (picBall.Top >= ClientSize.Height) //bottom 
                {
                    Ball.Initialize();
                    NumLives--;
                    lblLives.Text = "|         Lives Left: " + NumLives;
                    lblLives.ForeColor = Color.Yellow;
                }

                //check if ball intersects with the grid
                for (int i = 0; i < Level1Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < Level1Grid.GetLength(1); j++)
                    {
                        if (picBall.Bounds.IntersectsWith(Level1Grid[i, j].Bounds) && BricksHit[i, j] != -1)
                        {
                            BricksHit = PlayingGrid.BricksHit(i, j);
                            //try picball.location.x and picball.location.y
                            PlayingGrid.BallGridCollision(picBall.Left, picBall.Top);
                            Ball.BallGridCollision(picBall.Left, picBall.Top);
                            RemoveBrick(i, j);
                            ScoreKeeper1 = PlayingGrid.Lvl1Score();
                            break;
                        }
                    }
                }

                Ball.BallPosition();
            }
            //end the game
            if (NumLives == 0 || ScoreKeeper1 == 98)
            {
                picBall.Visible = false;
                mPaddle = PaddleState.None;

                if (NumLives == 0 && ScoreKeeper1 < 98)
                {
                    lblGameOver.Text = "Game over!" + "\n" + "Your score was " + ScoreKeeper1 + "\n" +
                                       "Press 1 to move on to Level 2" + "\n" + "Press 2 to go back to the main menu";
                }
                else if (ScoreKeeper1 == 98)
                {
                    lblGameOver.Text = "YOU WON!" + "\n" + "Press 1 to try your hand at Level 2"
                                        + "\n" + "Press 2 to go back to the main menu";
                }
                lblGameOver.Location = new System.Drawing.Point(250, 300);
                lblGameOver.ForeColor = Color.Aqua;
                lblGameOver.Visible = true;
            }
        }
        public void RemoveBrick(int Row, int Column)
        {
            //remove a brick from the level 1 grid from the form to remove it completely
            this.Controls.Remove(Level1Grid[Row, Column]);
        }
        public void RemoveBrick2(int Row, int Column)
        {
            //remove a brick from the level 2 grid from the form to remove it completely
            this.Controls.Remove(Level2Grid[Row, Column]);
        }

        private void tmrLevel2_Tick(object sender, EventArgs e)
        {
            if (NumLivesTwo <= 5 && NumLivesTwo > 0)
            {
                //check if the paddle intersects with the ball
                if (picPaddle.Bounds.IntersectsWith(picBall.Bounds) && picBall.Bottom <= (ClientSize.Height - picPaddle.Height))
                {
                    //enact the paddle-ball collision method
                    LvlTwoBall.BallPaddleCollisionLvl2();
                }
                //check if the ball hits the second paddle
                else if (picBall.Bounds.IntersectsWith(picPaddle2.Bounds))
                {
                    LvlTwoBall.BallPaddle2CollisionLvl2();
                    NumLivesTwo--;
                    lblLives.Text = "|         Lives Left: " + NumLivesTwo;
                    lblLives.ForeColor = Color.Yellow;
                }


                //check if the ball intersects with any of the walls (excluding the bottom)
                if (picBall.Top <= 0) //top
                    LvlTwoBall.BallHittingTop();

                else if (picBall.Left <= 0 || picBall.Right >= ClientSize.Width) //either side
                    LvlTwoBall.BallHittingSides();

                else if (picBall.Top >= ClientSize.Height) //bottom 
                {
                    LvlTwoBall.Initialize();
                    NumLivesTwo--;
                    lblLives.Text = "|         Lives Left: " + NumLivesTwo;
                    lblLives.ForeColor = Color.Yellow;
                }

                //check if ball intersects with the grid
                for (int i = 0; i < Level2Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < Level2Grid.GetLength(1); j++)
                    {
                        if (picBall.Bounds.IntersectsWith(Level2Grid[i, j].Bounds) && LvlTwoBricksHit[i, j] != -1 && Level2Grid[i, j].BackColor != Color.Black)
                        {
                            LvlTwoBricksHit = PlayGrid.BricksHitTwo(i, j);
                            PlayGrid.BallGridCollision(picBall.Left, picBall.Top);
                            LvlTwoBall.BallGridCollisionLvl2(picBall.Left, picBall.Top);
                            RemoveBrick2(i, j);
                            ScoreKeeper2 = PlayGrid.Lvl2Score();
                            break;
                        }
                    }
                }

                //update the position of the ball
                LvlTwoBall.BallPosition();
            }

            //end the game
            if (NumLivesTwo == 0 || ScoreKeeper2 == 80)
            {
                picBall.Visible = false;
                tmrPaddle.Enabled = false;
                mPaddle = PaddleState.None;
                picPaddle2.Visible = false;3

                if (NumLivesTwo == 0 && ScoreKeeper2 < 80)
                    lblGameOver.Text = "Game over!" + "\n" + "Your score was " + ScoreKeeper2 + "\n" + "Press 2 to go back to the main menu" + "\n" + "Thanks for playing!";
                else if (ScoreKeeper2 == 80)
                    lblGameOver.Text = "YOU WON!" + "\n" + "Press 2 to go to back to the main menu" + "\n" + "Thanks for playing!";

                lblGameOver.Location = new System.Drawing.Point(250, 300);
                lblGameOver.ForeColor = Color.Aqua;
                lblGameOver.Visible = true;
            }

        }
    
    }
}

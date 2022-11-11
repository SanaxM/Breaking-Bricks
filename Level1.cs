using System.Windows.Forms;

namespace Breakout
{
    class Level1
    {
        //member variables
        private PictureBox[,] mGrid = new PictureBox[14, 7];
        //private PictureBox mBall;
        private Ball mBall;

        Label mLblScore;

        private int[,] mHitBricks = new int[14, 7];
        private int mHitRow, mHitCol, mAngle, mScore;

        //constructor
        public Level1(PictureBox[,] Grid, PictureBox Ball, Label Score, Label Level, Label Lives, System.Windows.Forms.Timer Game, Music Audio)
        {
            //construct the form- it will have the grid, and the labels up top (score, level, lives), music in the background
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    mGrid[i, j] = Grid[i, j];
                    mGrid[i, j].Location = new System.Drawing.Point((i * 75) + 4, (j * 35) + 40);
                    mGrid[i, j].Visible = true;
                }
            }

            mLblScore = Score;
            mLblScore.Visible = true;
            Level.Text = "|         Level: 1";
            Level.Visible = true;
            Lives.Visible = true;
            Game.Enabled = true;
            Ball.Visible = true;
            Audio.GameMusic();
            
            //create a Ball object here using the picBall
            mBall = new Ball(Ball);
        }
        //methods
        public int Lvl1Score()
        {
            //increase the score everytime a brick is hit
            mScore++;
            mLblScore.Text = "Score: " + mScore;

            return mScore;
        }
        public PictureBox[,] ReturnGrid()
        {
            return mGrid;
        }
        public void BallGridCollision(int X, int Y)
        {
            //goal: once the ball hits a brick delete that element of the array 
            
            //find the element number hit
            mHitRow = X / (75 + 4);
            mHitCol = Y / (35 + 4);

            //loop through the grid and set the visible property of the hit tile to false
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    if (i == mHitRow && j == mHitCol)
                    {
                        //disable user interaction as well as being able to see the brick
                        mGrid[i, j].Enabled = false;
                        mGrid[i, j].Visible = false;
                        
                    }
                }
            }
        }
        public int[,] BricksHit(int Row, int Column)
        {
            //keep track of which tiles are hit
            for (int i = 0; i < mHitBricks.GetLength(0); i++)
            {
                for (int j = 0; j < mHitBricks.GetLength(1); j++)
                {
                    if (i == Row && j == Column)
                        mHitBricks[i, j] = -1;
                }
            }

            return mHitBricks;
        }   
        public void EndLevel()
        {
            //at the end of level one, the user should have the opportunity to go onto level 2 or to close the form 

        }
    }
}

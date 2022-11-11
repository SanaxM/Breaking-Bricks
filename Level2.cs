using System.Windows.Forms;
using System.Drawing;

namespace Breakout
{
    class Level2
    {
        //member variables
        private PictureBox[,] mGrid = new PictureBox[14, 7];
        private Ball mBall;
        private Label mLblScore, mLblLives, mLblLevel;
        private int[,] mHitBricks = new int[14, 7];
        private int mHitRow, mHitCol, mScore;
        private PictureBox mPicBall;
        //constructors
        //to be pressed from level select
        public Level2(Label Level1, Label Level2, Label Title, Label Score, Label Lives, Label Level, PictureBox[,] Grid, PictureBox Ball, Timer ColorChange)
        {
            //disable old controls
            Level1.Visible = false;
            Level2.Visible = false;
            Title.Visible = false;
            ColorChange.Enabled = false;

            mLblScore = Score;
            mLblScore.Visible = true;
            Lives.Visible = true;
            Lives.Text = "|         Lives: 5";
            mLblLives = Lives;
            Level.Visible = true;
            Level.Text = "|         Level: 2";
            mLblLevel = Level;
            Ball.Visible = true;
            mPicBall = Ball;

            //make form

            //create new grid
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    mGrid[i, j] = Grid[i, j];
                    mGrid[i, j].Location = new Point((i * 75) + 4, (j * 35) + 40);
                }
            }
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    if (i == 0 && j >= 1 && j <= 5)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 1 && j >= 2 && j <= 4)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 2 && j == 3)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 13 && j >= 1 && j <= 5)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 12 && j >= 2 && j <= 4)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 11 && j == 3)
                        mGrid[i, j].BackColor = Color.Black;

                    mGrid[i, j].Visible = true;
                }
            }

            mBall = new Ball(Ball);
        }

        //to be pressed after level 1
        public Level2(PictureBox[,] Grid, Label Score, Label Lives, Label Level, PictureBox Ball, PictureBox Paddle2)
        {
            mLblScore = Score;
            mLblScore.Visible = true;
            Lives.Visible = true;
            Lives.Text = "|         Lives: 5";
            Level.Visible = true;
            Level.Text = "|         Level: 2";
            Ball.Visible = true;
            Paddle2.Visible = true;

            //create new grid
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    mGrid[i, j] = Grid[i, j];
                    mGrid[i, j].Location = new Point((i * 75) + 4, (j * 35) + 40);
                }
            }
            for (int i = 0; i < mGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mGrid.GetLength(1); j++)
                {
                    if (i == 0 && j >= 1 && j <= 5)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 1 && j >= 2 && j <= 4)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 2 && j == 3)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 13 && j >= 1 && j <= 5)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 12 && j >= 2 && j <= 4)
                        mGrid[i, j].BackColor = Color.Black;
                    else if (i == 11 && j == 3)
                        mGrid[i, j].BackColor = Color.Black;

                    mGrid[i, j].Visible = true;
                }
            }
        }

        //methods
        public PictureBox[,] ReturnGrid()
        {
            return mGrid;
        }
        public int Lvl2Score()
        {
            mScore++;
            mLblScore.Text = "Score: " + mScore;

            return mScore;
        }
        public void BallGridCollision(int X, int Y)
        {
            //goal: once the ball hits a grid, delete that element of the array and reverse
            //the x direction

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
        public int[,] BricksHitTwo(int Row, int Column)
        {
            //if a brick is hit, set that row/col of int array to -1
            //add this as part of a check when checking for collision
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

    }
}

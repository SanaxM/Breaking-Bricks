using System;
using System.Windows.Forms;
using System.Drawing;

namespace Breakout
{
    class StartMenu
    {
        //member variables
        private PictureBox[,] mBricks;
        private Color[] mTileColours = new Color[98];

        //constructors
        public StartMenu()
        {
            mBricks = new PictureBox[14, 7];

            //create array of colours to fill grid with
            for (int i = 0; i < mTileColours.Length; i++)
            {
                if (i < 20)
                    mTileColours[i] = Color.Red;

                else if (i < 40 && i > 19)
                    mTileColours[i] = Color.Blue;

                else if (i > 39 && i < 50)
                    mTileColours[i] = Color.LimeGreen;

                else if (i > 49 && i < 60)
                    mTileColours[i] = Color.DarkViolet;

                else if (i > 59 && i < 70)
                    mTileColours[i] = Color.DarkOrange;

                else if (i > 69 && i < 80)
                    mTileColours[i] = Color.HotPink;

                else if (i > 79 && i < 95)
                    mTileColours[i] = Color.Yellow;

                else if (i > 94)
                    mTileColours[i] = Color.Silver;
            }

            //shuffle the order of the colours
            Random Random = new Random();
            int RandomValue;
            Color Temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < mTileColours.Length; j++)
                {
                    RandomValue = Random.Next(i, mTileColours.Length);
                    Temp = mTileColours[i];
                    mTileColours[i] = mTileColours[RandomValue];
                    mTileColours[RandomValue] = Temp;
                }
            }

            int Counter = 0;
            for (int i = 0; i < mBricks.GetLength(0); i++)
            {
                for (int j = 0; j < mBricks.GetLength(1); j++, Counter++)
                {
                    mBricks[i, j] = new PictureBox();
                    mBricks[i, j].BackColor = mTileColours[Counter];
                    mBricks[i, j].Width = 70;
                    mBricks[i, j].Height = 30;
                    mBricks[i, j].Location = new System.Drawing.Point(i * 75 + 4, j * 35 + 4);
                    mBricks[i, j].SendToBack();
                }
            }

        }
        //methods
        public PictureBox[,] Return()
        {
            //return the grid
            return mBricks;
        }
        public PictureBox[,] ColourChange(PictureBox[,] Grid)
        {
            mBricks = Grid;
            //shuffle the order of the colours
            Random Random = new Random();
            int RandomValue;
            Color Temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < mTileColours.Length; j++)
                {
                    RandomValue = Random.Next(i, mTileColours.Length);
                    Temp = mTileColours[i];
                    mTileColours[i] = mTileColours[RandomValue];
                    mTileColours[RandomValue] = Temp;
                }
            }

            //put in the new colours for the grid
            int Counter = 0;
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 7; j++, Counter++)
                {
                    mBricks[i, j].BackColor = mTileColours[Counter];
                }
            }

            return mBricks;
        }
        public void ClearMenu(Timer tmrTitle, Timer tmrTitleColour, Label Title, Label Rules, Label Start)
        {
            //stop all main menu animations
            tmrTitleColour.Enabled = false;
            tmrTitle.Enabled = false;
            Title.Visible = false;
            Rules.Visible = false;
            Start.Visible = false;
        }

    }
}

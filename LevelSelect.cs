using System.Windows.Forms;
using System.Drawing;

namespace Breakout
{
    class LevelSelect
    {
        //member variables 
        private Label mLevel1, mLevel2, mTitle;
        private PictureBox mPreview1, mPreview2;
        private int mCountdown = 3;
        //constructor
        public LevelSelect(PictureBox GreyPaddle, PictureBox BluePaddle, PictureBox PurplePaddle, Label lblGrey, Label lblBlue, Label lblPurple, Label PaddleTitle, Label ScreenTitle, PictureBox Lvl1, PictureBox Lvl2)

        {
            //set all of the paddle select screen to not be visible anymore
            GreyPaddle.Visible = false;
            BluePaddle.Visible = false;
            PurplePaddle.Visible = false;

            lblGrey.Visible = false;
            lblBlue.Visible = false;
            lblPurple.Visible = false;

            PaddleTitle.Visible = false;

            //create new labels for the levels (re-use old labels in order to have to create less in memory)
            mLevel1 = lblGrey;
            mLevel2 = lblBlue;
            mTitle = ScreenTitle;

            //create the pictureboxes
            mPreview1 = Lvl1;
            mPreview2 = Lvl2;

            //make the labels and the pictures to go with them
            mLevel1.Text = "PRESS 'A' TO PLAY LEVEL 1";
            mLevel1.Location = new Point(80, 200);
            mLevel1.Visible = true;

            mPreview1.Height = 300;
            mPreview1.Width = 400;
            mPreview1.Image = Properties.Resources.Level1FullSize;
            mPreview1.Location = new Point(80, 260);
            mPreview1.Visible = true;

            mLevel2.Text = "PRESS 'B' TO PLAY LEVEL 2";
            mLevel2.Location = new Point(580, 540);
            mLevel2.Visible = true;

            mPreview2.Height = 300;
            mPreview2.Width = 400;
            mPreview2.Image = Properties.Resources.Level2FullSize;
            mPreview2.Location = new Point(580, 200);
            mPreview2.Visible = true;

            mTitle.Location = new Point(328, 59);
            mTitle.Visible = true;
        }
        public void Countdown()
        { 
            //black screen
            mLevel2.Visible = false;
            mTitle.Visible = false;

            //count down to the start of the game
            mLevel1.Location = new Point(1070 / 2, 700 / 2);
            mCountdown--;
            mLevel1.Text = mCountdown.ToString();
            mLevel1.Visible = true;
        }
    }
}

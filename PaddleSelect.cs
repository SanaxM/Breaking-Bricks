using System.Windows.Forms;
using System.Drawing;

namespace Breakout
{
    class PaddleSelect
    {
        //member variables
        private PictureBox mPaddle, mGreyPaddle, mBluePaddle, mPurplePaddle;
        private Label mPressGrey, mPressBlue, mPressPurple;
        private Music mAudioPlayer = new Music();

        //constructor
        public PaddleSelect(PictureBox Paddle)
        {
            mPaddle = Paddle;
        }
        public PaddleSelect(PictureBox DefaultPaddle, PictureBox GreyP, PictureBox BlueP, PictureBox PurpleP, PictureBox Ball, Label Enter, Label One, Label Two, Label Three, PictureBox[,] Grid, Label Title, Music AudioPlayer, Label ScreenTitle)
        {
            //make everything on previous start screen no longer visible
            Ball.Visible = false;
            Enter.Visible = false;
            One.Visible = false;
            Two.Visible = false;
            Three.Visible = false;
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                   // Grid[i, j].Visible = false;
                }
            }
            Title.Visible = false;

            //set the paddle to be what the user wants
            mPaddle = new PictureBox();
            mPaddle = DefaultPaddle;
            mPaddle.Visible = false;

            //set background music 
            mAudioPlayer = AudioPlayer;
            mAudioPlayer.LoadingMusic();

            //construct the screen

            //make title visible
            ScreenTitle.Text = "CHOOSE YOUR PADDLE" + "\n" + "PRESS 1 TO CONTINUE";
            ScreenTitle.Visible = true;

            //set each paddle into a variable and make it visible to user
            //create the label underneath each one
            mGreyPaddle = GreyP;
            mPressGrey = One;
            mPressGrey.Text = "PRESS 'A' TO SELECT THE GREY PADDLE";
            mPressGrey.Location = new System.Drawing.Point(350, 170);
            mPressGrey.Visible = true; 

            mBluePaddle = BlueP;
            mPressBlue = Two;
            mPressBlue.Text = "PRESS 'B' TO SELECT THE BLUE PADDLE";
            mPressBlue.Location = new System.Drawing.Point(350, 330);
            mPressBlue.Visible = true;

            mPurplePaddle = PurpleP;
            mPressPurple = Three;
            mPressPurple.Text = "PRESS 'C' TO SELECT THE PURPLE PADDLE";
            mPressPurple.Location = new System.Drawing.Point(350, 488);
            mPressPurple.Visible = true;

            mGreyPaddle.Visible = true;
            mBluePaddle.Visible = true;
            mPurplePaddle.Visible = true;
        }

        //properties 
        public PictureBox PaddleImage
        {
            get { return mPaddle; }
            set { mPaddle = value; }
        }

        //methods 
        public Image BluePaddle()
        {
            mPaddle.Image = Properties.Resources.BluePaddle;
            return mPaddle.Image;
        }
        public Image PurplePaddle()
        {
            mPaddle.Image = Properties.Resources.PurplePaddle;
            return mPaddle.Image;
        }
        public Image GreyPaddle()
        {
            mPaddle.Image = Properties.Resources.GreyPaddle;
            return mPaddle.Image;
        }
    }
}

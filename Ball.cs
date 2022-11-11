using System;
using System.Windows;
using System.Windows.Forms;

namespace Breakout
{
    class Ball
    {
        //global variables 
        private PictureBox mBall;
        private int mAngle;

        private Vector Velocity, Position;
        private double Speed, TempVY, TempVX;
        //constructor
        public Ball(PictureBox Ball)
        {
            mBall = Ball;
        }
        //methods
        public double BallAngle()
        {
            //generate an angle between 45 and 90 degrees for the ball to go at whenever it spawns
            Random RandomAngle = new Random();
            mAngle = 0;
            while (mAngle % 2 == 0)
                mAngle = RandomAngle.Next(46, 89);

            //convert angle and return it 
            double BallAngle = mAngle * 45 * Math.PI / 180;
            return BallAngle;
        }
        public void Initialize()
        {
            //LEVEL 1
            Random StartPos = new Random();
            Position = new Vector(StartPos.Next(300, 500), StartPos.Next(400, 450));
            double Angle = BallAngle();
            //have to set the velocity - x and y components
            Velocity = new Vector((Speed * Math.Cos(Angle)), (Speed * Math.Sin(Angle)) * -1);
        }
        public void Level1InitialSpeed()
        {
            Speed = 4.25;
        }
        public void BallPosition()
        {
            //change the position of the ball as the timer goes off (keeps it moving)
            Position = Position + Velocity;
            mBall.Left = (int)Position.X;
            mBall.Top = (int)Position.Y;
        }
        public Vector BallHittingTop()
        {
            Velocity.Y *= -1;

            return Velocity;
        }
        public Vector BallHittingSides()
        {
            Velocity.X *= -1;

            return Velocity;
        }
        public PictureBox BallPaddleCollisionLvl1()
        {
            //goal: once the two collide, reverse the direction of the ball
            //maximum speed = 14
            if (Speed < 14)
            {
                //increase the speed of the ball each time it is hit
                //make the ball go in the opposite direction y direction(net velocity is going
                //to be opposite)
                Velocity.Y *= -1.05;
                TempVY = Velocity.Y;

                //Speed will be equal to the resultant of the changed (x and y) velocities
                Speed = Velocity.Length;
            }
            else
            {
                Velocity.Y *= -1;
                TempVY = Velocity.Y;
            }

            return mBall;
        }

        public PictureBox BallPaddleCollisionLvl2()
        {
            //goal: once the two collide, reverse the direction of the ball
            //maximum speed = 14
            if (Speed < 14)
            {
                //increase the speed of the ball each time it is hit
                //make the ball go in the opposite direction y direction(net velocity is going
                //to be opposite)
                Velocity.Y *= -1.1;

                Velocity.X *= 1.1;
                TempVX = Velocity.X;

                //Speed will be equal to the resultant of the changed (x and y) velocities
                Speed = Velocity.Length;
            }
            else
            {
                Velocity.Y *= -1;
                TempVY = Velocity.Y;

                Speed = Velocity.Length;
            }

            return mBall;
        }
        public void BallPaddle2CollisionLvl2()
        {
            //if the ball collides with this paddle, the person loses a life
            //respawn the ball
            Initialize();
        }
        public Vector BallGridCollision(int X, int Y)
        {
            //change the speed and velocity of the ball upon collision
            //reverse the direction of the ball and use pythagorean theorem to set new speed
            if (Speed < 14)
            {
                // Velocity.X *= 1;
                if (Math.Sqrt(Velocity.Y) != Math.Pow(Velocity.Y, 2))
                    Velocity.Y *= -1.05;
                else
                    Velocity.Y *= 1.05;
            }

            Velocity.X *= -1;

            //set a new angle for the ball to bounce off at
            BallAngle();

            //create the new velocity for the ball
            Velocity = new Vector((Speed * Math.Cos(mAngle)), (Speed * Math.Sin(mAngle)));
            Speed = Velocity.Length;

            return Velocity;
        }
        public Vector BallGridCollisionLvl2(int X, int Y)
        {
            //change the speed and velocity of the ball upon collision

            //reverse the direction of the ball and use pythagorean theorem to set new speed
            if (Speed < 14)
            {
                Velocity.X *= 1;
                Velocity.Y *= 1.1;
            }
            //make sure the y component is negative no matter what
            if (Math.Sqrt(TempVY) == Math.Pow(TempVY, 2))
            {
                Velocity.Y *= -1;
            }

            Velocity.X *= -1;

            //set a new angle for the ball to bounce off at
            BallAngle();

            //create the new velocity for the ball
            Velocity = new Vector((Speed * Math.Cos(mAngle)), (Speed * Math.Sin(mAngle)));
            Speed = Velocity.Length;

            return Velocity;
        }


    }
}

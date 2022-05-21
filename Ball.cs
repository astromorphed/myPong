using System;
using System.Drawing;
using System.Windows.Forms;

namespace myPong
{
    public class Ball
    {
        Random rand = new Random();
        private PictureBox ball;
        Player leftSide, rightSide;
        int xSpeed, ySpeed;

        public Ball(PictureBox ball, Player leftSide, Player rightSide)
        {
            this.ball = ball;
            this.leftSide = leftSide;
            this.rightSide = rightSide;
            xSpeed = 1;
            ySpeed = 3;
            ResetBall(1);

        }

        internal void ObjectMove()
        {
            var bot = Boundaries.bottomOfWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed, 
                Math.Max(Boundaries.topOfWorld,
                    Math.Min(bot, ball.Location.Y + ySpeed)));

            if(ball.Location.Y >= bot || ball.Location.Y <= Boundaries.topOfWorld)
            {
                ySpeed *= -1;
            }

            if(ball.Location.X <= Boundaries.leftEnd)
            {
                Score(rightSide);
            }
            else if(ball.Location.X >= Boundaries.rightEnd - ball.Width) {
                Score(leftSide);
            }

            if (leftSide.paddle.Bounds.IntersectsWith(ball.Bounds)
                || rightSide.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                xSpeed *= -1;
                ySpeed = rand.Next(-8, 8);
                
            }
        }

        private void Score(Player scored)
        {
            scored.score++;
            ResetBall(2);            
        }

        public void ResetBall(int arg)
        {
            switch (arg)
            {
                case 1: //random direction
                    ball.Location = new Point(Boundaries.centreX, Boundaries.centreY);
                    do
                    {
                        xSpeed = rand.Next(-8, 8);
                        ySpeed = rand.Next(-8, 8);
                    } while (xSpeed + Math.Abs(ySpeed) <= 5 || ySpeed > xSpeed);
                    break;
                case 2: //opposite dir
                    ball.Location = new Point(Boundaries.centreX, Boundaries.centreY);
                    xSpeed *= -1;
                    do
                    {
                        ySpeed = rand.Next(-8, 8);
                    } while (Math.Abs(ySpeed) <= 5);

                    break;
                case 0: //stop
                    ball.Location = new Point(Boundaries.centreX, Boundaries.centreY);
                    xSpeed = 0;
                    ySpeed = 0;
                    break;
            }
        }       


    }
}

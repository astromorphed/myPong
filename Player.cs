using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPong
{
    public class Player {

        const int movSpeed = 1;

        public bool isUpPressed, isDownPressed;
        
        public PictureBox paddle;
        Label scoreLabel;
        bool? wasGoingUp;
        int nOfTicks;


        int _score;
        
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }

        public Player(PictureBox paddle, Label scoreLabel)
        {
            this.paddle = paddle;
            this.scoreLabel = scoreLabel;
        }

        internal void ObjectMove()
        {
            bool? goingUp = null;
            if (isUpPressed)
                goingUp = true;

            if (isDownPressed)
            {
                if (goingUp.HasValue)
                    goingUp = null;
                else
                    goingUp = false;
            }

            //checks if P has changed direction
            if (wasGoingUp.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingUp = null;
                    nOfTicks = 0;
                }
                else if (wasGoingUp.Value == goingUp.Value)
                    nOfTicks++;
                else
                {
                    wasGoingUp = goingUp;
                    nOfTicks = 1;
                }

            }
            else if (goingUp.HasValue)
            {
                wasGoingUp = goingUp;
                nOfTicks = 1;
            }

            DoMove(goingUp);
        }

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = (int)Math.Round(movSpeed * ((float)(nOfTicks / 3)));
                if (goingUp.Value)
                {
                    speed *= -1;
                }

                paddle.Location = new Point(paddle.Location.X, Math.Max(
                    Boundaries.topOfWorld, Math.Min(
                        Boundaries.bottomOfWorld - paddle.Size.Height, paddle.Location.Y + speed)));
            }
        }
    }
}

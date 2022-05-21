using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPong
{
    public partial class Form1 : Form
    {
        
        Player P1, P2;
        Ball aBall;
                
        public Form1()
        {
            InitializeComponent();

            P1 = new Player(paddleR, score1);
            P2 = new Player(paddleL, score2);
            aBall = new Ball(ball, P1, P2);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            P1.ObjectMove();
            P2.ObjectMove();
            aBall.ObjectMove();

            if (P1.score == 3)
            {
                victory.Text = "Player 1 wins!";
                WinCondition();
            }
            else if(P2.score == 3)
            {
                victory.Text = "Player 2 wins!";
                WinCondition();
            }


            //ref var is pointer
        }

        public void WinCondition()
        {
            aBall.ResetBall(0);
            gameover.Visible = true;
            victory.Visible = true;
            label3.Visible = true;       
            label2.Visible = true;       
        }


        private void checkKey(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                //P1
                case Keys.NumPad8:
                case Keys.Up:
                    P1.isUpPressed = isDown;
                    break;
                case Keys.NumPad2:
                case Keys.Down:
                    P1.isDownPressed = isDown;
                    break;
                //P2
                case Keys.W:
                    P2.isUpPressed = isDown;
                    break;
                case Keys.S:
                    P2.isDownPressed = isDown;
                    break;
                case Keys.R:
                    aBall.ResetBall(1);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             checkKey(e, true);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            gameover.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            victory.Visible = false;
            P1.score = 0;
            P2.score = 0;
            aBall.ResetBall(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           checkKey(e, false);
        }
                                     
    }
}

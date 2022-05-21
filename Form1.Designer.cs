namespace myPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreboard = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.victory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paddleR = new System.Windows.Forms.PictureBox();
            this.paddleL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreboard
            // 
            this.scoreboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreboard.AutoSize = true;
            this.scoreboard.BackColor = System.Drawing.SystemColors.ControlText;
            this.scoreboard.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreboard.Location = new System.Drawing.Point(669, 11);
            this.scoreboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(101, 41);
            this.scoreboard.TabIndex = 3;
            this.scoreboard.Text = "Score";
            // 
            // score1
            // 
            this.score1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.SystemColors.ControlText;
            this.score1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score1.Location = new System.Drawing.Point(657, 54);
            this.score1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(36, 41);
            this.score1.TabIndex = 4;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.SystemColors.ControlText;
            this.score2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score2.Location = new System.Drawing.Point(747, 54);
            this.score2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(36, 41);
            this.score2.TabIndex = 5;
            this.score2.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(705, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "|";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gameover.Location = new System.Drawing.Point(480, 260);
            this.gameover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(470, 111);
            this.gameover.TabIndex = 8;
            this.gameover.Text = "Game over!";
            this.gameover.Visible = false;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.BackColor = System.Drawing.SystemColors.WindowText;
            this.player1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.player1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.player1.Location = new System.Drawing.Point(475, 54);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(164, 41);
            this.player1.TabIndex = 9;
            this.player1.Text = "Player 1 :";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.BackColor = System.Drawing.SystemColors.WindowText;
            this.player2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.player2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.player2.Location = new System.Drawing.Point(795, 54);
            this.player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(164, 41);
            this.player2.TabIndex = 10;
            this.player2.Text = ": Player 2";
            // 
            // victory
            // 
            this.victory.AutoSize = true;
            this.victory.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.victory.Location = new System.Drawing.Point(561, 370);
            this.victory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(339, 65);
            this.victory.TabIndex = 11;
            this.victory.Text = "Player x wins!";
            this.victory.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(643, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "Play again";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(691, 555);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quit";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ball
            // 
            this.ball.Image = global::myPong.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(261, 319);
            this.ball.Margin = new System.Windows.Forms.Padding(0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(21, 20);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // paddleR
            // 
            this.paddleR.Image = global::myPong.Properties.Resources.paddleR_png;
            this.paddleR.Location = new System.Drawing.Point(1393, 260);
            this.paddleR.Margin = new System.Windows.Forms.Padding(4);
            this.paddleR.Name = "paddleR";
            this.paddleR.Size = new System.Drawing.Size(10, 141);
            this.paddleR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paddleR.TabIndex = 1;
            this.paddleR.TabStop = false;
            // 
            // paddleL
            // 
            this.paddleL.Image = global::myPong.Properties.Resources.paddleL_png;
            this.paddleL.Location = new System.Drawing.Point(12, 260);
            this.paddleL.Margin = new System.Windows.Forms.Padding(0);
            this.paddleL.Name = "paddleL";
            this.paddleL.Size = new System.Drawing.Size(10, 141);
            this.paddleL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paddleL.TabIndex = 0;
            this.paddleL.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1423, 702);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddleR);
            this.Controls.Add(this.paddleL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddleL;
        private System.Windows.Forms.PictureBox paddleR;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scoreboard;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label score1;
        public System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label victory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


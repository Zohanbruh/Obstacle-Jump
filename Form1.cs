namespace Obstacle_Jump
{
    public partial class Form1 : Form
    {
        //global variables
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameOver = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            lblHighScore.Text = "High Score: " + highScore;
            player.Top += gravity;

            //when player land on platform
            if(player.Top > 324)
            {
                gravity = 0;
                player.Top = 324;
                player.Image = Properties.Resources.run_down0;
            }
            else if(player.Top < 49)
            {
                gravity = 0;
                player.Top = 49;
                player.Image = Properties.Resources.run_up0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if(x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if(x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameTimer.Stop();
                        lblScore.Text += "  Game Over! Pres Enter to Restart";
                        gameOver = true;

                        //set high score

                        if(score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }

            //increase speed of player and obstacle after score 10
            if(score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if (player.Top == 324)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (player.Top == 49)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                }
            }

            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            lblScore.Parent = pictureBox1;
            lblHighScore.Parent = pictureBox2;
            lblHighScore.Top = 0;
            player.Location = new Point(180, 149);
            player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }
            gameTimer.Start();
        }
    }
}

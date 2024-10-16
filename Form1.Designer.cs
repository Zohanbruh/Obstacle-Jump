namespace Obstacle_Jump
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblScore = new Label();
            lblHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox2.Location = new Point(-2, 390);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(804, 62);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_up0;
            player.Location = new Point(203, 49);
            player.Name = "player";
            player.Size = new Size(59, 74);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.box;
            pictureBox3.Location = new Point(364, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.box;
            pictureBox4.Location = new Point(599, 324);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(121, 38);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.BackColor = Color.Transparent;
            lblHighScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHighScore.ForeColor = Color.White;
            lblHighScore.Location = new Point(12, 403);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(192, 38);
            lblHighScore.TabIndex = 6;
            lblHighScore.Text = "High Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Obstacle Jump";
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblScore;
        private Label lblHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

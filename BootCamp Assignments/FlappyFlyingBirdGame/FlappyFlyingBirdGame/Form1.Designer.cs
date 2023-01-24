using System.Windows.Forms;

namespace FlappyFlyingBirdGame
{
    partial class flappyFlyingBird
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
            this.lightHouseTop = new System.Windows.Forms.PictureBox();
            this.lightHouseBottom = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.sea = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOvermsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lightHouseTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightHouseBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // lightHouseTop
            // 
            this.lightHouseTop.Image = global::FlappyFlyingBirdGame.Properties.Resources.lightHouseTop;
            this.lightHouseTop.Location = new System.Drawing.Point(307, -29);
            this.lightHouseTop.Name = "lightHouseTop";
            this.lightHouseTop.Size = new System.Drawing.Size(64, 192);
            this.lightHouseTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightHouseTop.TabIndex = 0;
            this.lightHouseTop.TabStop = false;
            // 
            // lightHouseBottom
            // 
            this.lightHouseBottom.Image = global::FlappyFlyingBirdGame.Properties.Resources.lightHouseBottom;
            this.lightHouseBottom.Location = new System.Drawing.Point(242, 309);
            this.lightHouseBottom.Name = "lightHouseBottom";
            this.lightHouseBottom.Size = new System.Drawing.Size(66, 194);
            this.lightHouseBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightHouseBottom.TabIndex = 1;
            this.lightHouseBottom.TabStop = false;
            // 
            // ship
            // 
            this.ship.BackColor = System.Drawing.Color.Navy;
            this.ship.Image = global::FlappyFlyingBirdGame.Properties.Resources.ship;
            this.ship.Location = new System.Drawing.Point(182, 493);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(240, 56);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            // 
            // sea
            // 
            this.sea.BackColor = System.Drawing.Color.Navy;
            this.sea.Location = new System.Drawing.Point(-33, 490);
            this.sea.Name = "sea";
            this.sea.Size = new System.Drawing.Size(605, 77);
            this.sea.TabIndex = 3;
            this.sea.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyFlyingBirdGame.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(12, 106);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(92, 57);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 4;
            this.bird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(-1, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(66, 18);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameOvermsg
            // 
            this.gameOvermsg.AutoSize = true;
            this.gameOvermsg.BackColor = System.Drawing.Color.Transparent;
            this.gameOvermsg.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOvermsg.ForeColor = System.Drawing.Color.Navy;
            this.gameOvermsg.Location = new System.Drawing.Point(62, 220);
            this.gameOvermsg.Name = "gameOvermsg";
            this.gameOvermsg.Size = new System.Drawing.Size(322, 41);
            this.gameOvermsg.TabIndex = 6;
            this.gameOvermsg.Text = "Press Enter to Play";
            // 
            // flappyFlyingBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.gameOvermsg);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.sea);
            this.Controls.Add(this.lightHouseBottom);
            this.Controls.Add(this.lightHouseTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "flappyFlyingBird";
            this.Text = "            ";
            this.Load += new System.EventHandler(this.flappyFlyingBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressSpace);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.lightHouseTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightHouseBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lightHouseTop;
        private System.Windows.Forms.PictureBox lightHouseBottom;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox sea;
        private System.Windows.Forms.PictureBox bird;
        private Label scoreText;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
        private Label gameOvermsg;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyFlyingBirdGame
{
    public partial class flappyFlyingBird : Form
    {
        int houseSpeed = 5;
        int shipSpeed = 7;
        int gravity = 5;
        int points = 0;
        int pointshigh = 0;
        
        public flappyFlyingBird()
        {
            InitializeComponent();
        }

        private void flappyFlyingBird_Load(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            lightHouseBottom.Left -= houseSpeed;
            lightHouseTop.Left -= houseSpeed;
            ship.Left -= shipSpeed;
            scoreText.Text = "Score: " + points;

            if (lightHouseBottom.Left < -150)
            {
                lightHouseBottom.Left = 430;
                points++;
            }
            if (lightHouseTop.Left < -60)
            {
                lightHouseTop.Left = 650;
                points++;
            }
            if (ship.Left < -300)
            {
                ship.Left = 600;
            }
            if (points > pointshigh + 10)
            {
                pointshigh = points;
                houseSpeed += 2;
                shipSpeed += 3;
            }
            if (bird.Bounds.IntersectsWith(lightHouseBottom.Bounds) ||
                bird.Bounds.IntersectsWith(lightHouseTop.Bounds) ||
                bird.Bounds.IntersectsWith(sea.Bounds) ||
                bird.Top < -18)
            {
                endGame();
            }
        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            gameOvermsg.Text = "Game Over!\nScore: " + points+"\nPress Enter to Restart";
           
            bird.Top = 5;
            lightHouseBottom.Left = +700;
            lightHouseTop.Left = +700;
            ship.Left = +100;
        }

        private void pressSpace(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                houseSpeed = 5;
                shipSpeed = 7;
                gravity = 5;
                points = 0;
                pointshigh = 0;
                gameTimer.Start();
                gameOvermsg.Text = "";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        int score = 0;
        PictureBox[] alien = new PictureBox[10];
        bool fireballisfired = false;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {//set values to alien array
            alien[0] = alien1;
            alien[1] = alien2;
            alien[2] = alien3;
            alien[3] = alien4;
            alien[4] = alien5;
            alien[5] = alien6;
            alien[6] = alien7;
            alien[7] = alien8;
            alien[8] = alien9;
            alien[9] = alien10;

    
            //start the animation
            Spaceshiptimer.Start();
            starstimer.Start();
            
        }

        private void DarkHoresPic_Click(object sender, EventArgs e)
        {

        }

        private void Dragontimer_Tick(object sender, EventArgs e)
        {
            spaceship.Left -= 0;
            
            for (int index = 0; index < 10; index++)
            {
                //set the spaceship to respawn on left edge of the screen after coliding with aliens
                if (spaceship.Bounds.IntersectsWith(alien[index].Bounds) && alien[index].Visible)
                {
                    spaceship.Left = 50;
         
                }
            }

            //set the ship to fire the purple fireball 
            // set the fireball to destroy and respawn the aliens after they have been destroyed
            //add to the counter
            for (int index = 0; index < 10; index++)
            {
                if (purplefireballpicture.Bounds.IntersectsWith(alien[index].Bounds) && alien[index].Visible)
                {
                    alien[index].Hide();
                    purplefireballpicture.Hide();
                    purplefireballpicturetimer.Stop();
                    score += 1;
                    alien[index].Left = this.ClientSize.Width;
                    alien[index].Show();
                    lblscore.Text = Convert.ToString(score);
                }
            }
        }

        private void Dragonpicture_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//set the key controls
            switch (e.KeyCode)
            {
                case Keys.Right:
                    spaceship.Left += 10;
                    break;
                case Keys.Left:
                    spaceship.Left -= 10;
                    break;
                case Keys.Up:
                    spaceship.Top -= 10;
                    break;
                case Keys.Down:
                    spaceship.Top += 10;
                    break;
                case Keys.Space:
                    if (!fireballisfired)
                    {
                        purplefireballpicturetimer.Start();
                        //sends the fireball to the back of the image
                        purplefireballpicture.SendToBack();
                        //makes the fireball vissible when the spacebar is pressed
                        purplefireballpicture.Visible = true;
                        //reoccurring fireball that follows the draggon
                        purplefireballpicture.Left = spaceship.Left + 10;
                        purplefireballpicture.Top = spaceship.Top +10;
                    }
                    break;
            }
        }

        private void purplefireballpicturetimer_Tick(object sender, EventArgs e)
        {
            // set the speed of the purple fireball shot out of the spaceship.
            purplefireballpicture.Left += 15;


        }

        private void purplefireballpicture_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void starstimer_Tick(object sender, EventArgs e)
        {
            //set the speed of the of the aliens 
            //set the aliens to scrole back around when after they have gone off screen.
            for (int index = 0; index < 10; index++)
            {
               
                alien[index].Left -= 5;
               if (alien[index].Left + alien[index].Width < -120)
                { alien[index].Left = this.ClientSize.Width; }

            }
        }
    }
}

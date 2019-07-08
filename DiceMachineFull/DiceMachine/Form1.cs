using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace DiceMachine
{
    public partial class Form1 : Form
    {
        /*
         * SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");  
            simpleSound.Play();  
         */
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.start;           
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"roll.wav");
            simpleSound.Play();
            for (int i = 0; i < 30; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                Thread.Sleep(100);
                Roll(randomNumber);
            }
            
                pictureBox1.Hide();
                Thread.Sleep(150);
                pictureBox1.Show();
            
        }
        private void Roll(int x)
        {
            switch (x)
            {
                case 1: pictureBox1.Image = Properties.Resources.dice1; break;
                case 2: pictureBox1.Image = Properties.Resources.dice2; break;
                case 3: pictureBox1.Image = Properties.Resources.dice3; break;
                case 4: pictureBox1.Image = Properties.Resources.dice4; break;
                case 5: pictureBox1.Image = Properties.Resources.dice5; break;
                case 6: pictureBox1.Image = Properties.Resources.dice6; break;
                default:
                    break;
            }
            pictureBox1.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        
        bool arriba;
        bool abajo;
        bool izquierda;
        bool derecha;
        int v = 5;
        int vg = 8;
        int pink = 1;
        int pinkx = 1;
        int pinky = 1;

        int red = 1;
        int redx = 1;
        int redy = 1;
        
        int score = 0;
        public Form2()
        {
            InitializeComponent();
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;

            if (izquierda)
            {
                pacman.Left -= v;
            }
            if (derecha)
            {
                pacman.Left += v;
            }
            if (abajo)
            {
                pacman.Top += v;

            }
            if (arriba)
            {
                pacman.Top -= v;
            }

            red1.Left += red;
            pink1.Left += pink;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox &&  x.Tag == "ghost")
                {
                    
                if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        
                        timer1.Stop();
                        MessageBox.Show("game over" +  "\nscore:" + score);
                        break;
                    }
                }
                if (x is PictureBox && x.Tag == "uva")
                {
                    
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x); 
                        score += 15; 
                    }
                }
                if (x is PictureBox && x.Tag == "cherry")
                {
                    
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x); 
                        score += 10;
                    }
                }
            }
            

        }


        private void Down(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                izquierda = true;
                pacman.Image = Properties.Resources.pacman_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;

                pacman.Image = Properties.Resources.pacman_right; 
            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = true;
                pacman.Image = Properties.Resources.pacman_up;
            }
            if (e.KeyCode == Keys.Down)
            {
                abajo = true;
                pacman.Image = Properties.Resources.pacman_down;
            }
        }



        private void Up(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {
                    izquierda = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    derecha = false;
                }
                if (e.KeyCode == Keys.Up)
                {
                    arriba = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    abajo = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
           
            Stream stream = new FileStream("../../Serial.txt", FileMode.Open, FileAccess.Write);
            bin.Serialize(stream, score);
            stream.Close();
            
            Application.Exit();

        }
    }
}

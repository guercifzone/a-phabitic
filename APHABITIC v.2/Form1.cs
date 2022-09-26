using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APHABITIC_v._2
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_d;
            player.Stream = Properties.Resources.num_d;
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_l;
            player.Stream = Properties.Resources.num_l;
            player.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_q;
            player.Stream = Properties.Resources.num_q;
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_a;
            player.Stream = Properties.Resources.num_a;
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_b;
            player.Stream = Properties.Resources.num_b;
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_c;
            player.Stream = Properties.Resources.num_c;
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_e;
            player.Stream = Properties.Resources.num_e;
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_f;
            player.Stream = Properties.Resources.num_f;
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_g;
            player.Stream = Properties.Resources.num_g;
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_h;
            player.Stream = Properties.Resources.num_h;
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_i;
            player.Stream = Properties.Resources.num_i;
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_j;
            player.Stream = Properties.Resources.num_j;
            player.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_k;
            player.Stream = Properties.Resources.num_k;
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_m;
            player.Stream = Properties.Resources.num_m;
            player.Play();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_n;
            player.Stream = Properties.Resources.num_n;
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_o;
            player.Stream = Properties.Resources.num_o;
            player.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_p;
            player.Stream = Properties.Resources.num_p;
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_r;
            player.Stream = Properties.Resources.num_r;
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_s;
            player.Stream = Properties.Resources.num_s;
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_t;
            player.Stream = Properties.Resources.num_t;
            player.Play();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_u;
            player.Stream = Properties.Resources.num_u;
            player.Play();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_v;
            player.Stream = Properties.Resources.num_v;
            player.Play();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_w;
            player.Stream = Properties.Resources.num_w;
            player.Play();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_x;
            player.Stream = Properties.Resources.num_x;
            player.Play();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_y;
            player.Stream = Properties.Resources.num_y;
            player.Play();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.letter_z;
            player.Stream = Properties.Resources.num_z;
            player.Play();
        }
    }
}

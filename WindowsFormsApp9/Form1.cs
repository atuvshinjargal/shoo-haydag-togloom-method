using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int shoo() //void utga butsaahgui
        {
            Random rnd = new Random();
            //1,2,3,4,5,6 gesen toonuudiig gargana.
            int score = rnd.Next(1, 7); //sanamsargui too gargah
            label1.Text = score.ToString();
            return score;
        }
        private bool newGame(int score)
        {
            label2.Text = score.ToString();
            label3.Text = score.ToString();
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int score = this.shoo();
            int s = Convert.ToInt32(label2.Text) - score;
            label2.Text = s.ToString();
            if (s < 1)
            {
                MessageBox.Show("1-r toglogch yallaa.");
                if (this.newGame(40))
                {
                    MessageBox.Show("Togloom dahin ehellee.");
                }
            }
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = this.shoo();
            int s = Convert.ToInt32(label3.Text) - score;
            label3.Text = s.ToString();
            if (s < 1)
            {
                MessageBox.Show("2-r toglogch yallaa.");
                if (this.newGame(40))
                {
                    MessageBox.Show("Togloom dahin ehellee.");
                }
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}

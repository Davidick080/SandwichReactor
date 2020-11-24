using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SandwichReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RedBox_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewTitle.Text = "Activating reactor 1";
            this.BackColor = Color.LemonChiffon; 
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            OutPutLabel.Text = "reacto goh oom";
            OutPutLabel.BackColor = Color.Orange;
            RedBox.BackColor = Color.Yellow;
            RedBox2.BackColor = Color.Yellow;
            Refresh();
            Thread.Sleep(1000);
            RedBox.BackColor = Color.White;
            RedBox2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            RedBox.BackColor = Color.Yellow;
            RedBox2.BackColor = Color.Yellow;
           
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NewTitle.Text = "Activating reactor 2";
            this.BackColor = Color.LemonChiffon;
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            OutPutLabel.Text = "reacto go boom";
            OutPutLabel.BackColor = Color.Orange;
            NewTitle.Text = "Activating reactor 2";
            RedBox.BackColor = Color.Yellow;
            RedBox2.BackColor = Color.Yellow;
            Refresh();
            Thread.Sleep(1000);
            RedBox.BackColor = Color.White;
            RedBox2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            RedBox.BackColor = Color.Yellow;
            RedBox2.BackColor = Color.Yellow;
          
            
        }
    }
}

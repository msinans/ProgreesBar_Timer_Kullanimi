using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgreesBar_Timer_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value % 30 == 10)
            {
                label1.BackColor = Color.Red;
            }
            else { label1.BackColor = Color.White; }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.Text = ("Malzemeler Eklendi!");
                timer2.Start();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 20;
            if (progressBar2.Value % 30 == 10)
            {
                label2.BackColor = Color.Red;
            }
            else { label2.BackColor = Color.White; }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label2.Text = ("Karştırma İşlemi Tamamlandı!");
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 25;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            else
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label3.Text = ("Mayalandı!");
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 5;
            if (progressBar4.Value % 10 == 0)
            {
                label4.BackColor = Color.Red;
            }
            else
            {
                label4.BackColor = Color.White;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                label4.Text = ("Pişti");
                MessageBox.Show("Pastanız Hazır!");
            }
        }
    }
}

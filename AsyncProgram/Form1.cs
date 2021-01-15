using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblToplaSonuc.Text=Topla(int.Parse(txt3.Text), int.Parse(txt4.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCarpSonuc.Text = Carp(int.Parse(txt1.Text), int.Parse(txt2.Text)).ToString();
        }

        private int Carp(int v1, int v2)
        {
            return v1*v2;
        }

        private int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Topla_Click(object sender, EventArgs e)
        {

            int a = int.Parse(TSayi1.Text);
            int b = int.Parse(TSayi2.Text);
            Toplam.Text=await ToplamaAsync(a, b)+"";
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(CSayi1.Text);
            int b = int.Parse(CSayi2.Text);
            CarpmaYap.Text = await CarpimAsync(a, b) + "";
        }

        private Task<int> CarpimAsync(int a, int b)
        {
            return Task.Run(() =>
            {
                return a * b;
            });

        }
        private Task<int> ToplamaAsync(int a, int b)
        {
           
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
                return a + b;

            });

        }
    }
}

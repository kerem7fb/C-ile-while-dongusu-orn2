using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int i, toplam, sayı, sayı1, sayıüretim, sayıüretim2;
            sayıüretim = Convert.ToInt32(textBox2.Text);
            sayıüretim2 = Convert.ToInt32(textBox3.Text);
            sayı = Convert.ToInt32(textBox1.Text);
            i = 0;
            toplam = 0;
            while (i <= sayı)
            {
                sayı1 = rast.Next(sayıüretim, sayıüretim2);
                listBox1.Items.Add(sayı1);
                listBox2.Items.Add(i);
                toplam = toplam + sayı1;
                listBox3.Items.Add(toplam);
                i = i + 1;

            }
            MessageBox.Show("Sayıların toplam " + i + " kez çalıştı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

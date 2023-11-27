using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciftleri_bi_tarafa_tekleri_bitarafa_alan_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                listBox1.Items.Add(rnd.Next(i));
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                    listBox2.Items.Add(i);
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}

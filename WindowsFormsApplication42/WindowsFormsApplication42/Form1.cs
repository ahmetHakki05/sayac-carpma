using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 < 10)
            {
                sayi1++;
            }
            {
                textBox1.Text = sayi1.ToString();
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 > 0)
            {
                sayi1--;
            }
            {
                textBox1.Text = sayi1.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

             
            int sayi;
            sayi=Convert.ToInt32(textBox1.Text);
           
           for (int i = 0; i < 10; i++)
			{
                listBox1.Items.Add(i.ToString() + "x" + sayi + "=" + sayi * i);
             }
              
    }
   }
}

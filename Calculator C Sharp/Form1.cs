using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int minus = n1 - n2;

                label3.Text = minus.ToString();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int sum = n1 + n2;
                label3.Text = sum.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else if(textBox2.Text == "0")
            {
                MessageBox.Show("Can't Divide By Zero...");
            }
            else
            {
                float n1 = Int32.Parse(textBox1.Text);
                float n2 = Int32.Parse(textBox2.Text);
                float div = n1 / n2;
                label3.Text = div.ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int mul = n1 * n2;
                label3.Text = mul.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else if (textBox2.Text == "0")
            {
                MessageBox.Show("Can't Divide By Zero...");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int rem = n1 % n2;
                label3.Text = rem.ToString();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Both Numbers!");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int power = 1;
                for (int i = 0; i < n2; i++)
                {
                    power = power * n1;
                }
                label3.Text = power.ToString();
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

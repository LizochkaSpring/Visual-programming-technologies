using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба1
{
    public partial class Form1 : Form
    {
        Int32 a, b, c, d;
        string arr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = arr;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);
                if ((a == 0) & (c > 0) & (b != 0))
                {
                    label4.Text = label4.Text + " " + b.ToString() + "x + " + c.ToString();
                }
                if ((a == 0) & (b == 0))
                {
                    label4.Text = label4.Text + " " + c.ToString();
                }
                if ((a == 0) & (c < 0) & (b != 0))
                {
                    label4.Text = label4.Text + " " + b.ToString() + "x " + c.ToString();
                }
                if ((a == 0) & (c == 0) & (b != 0))
                {
                    label4.Text = label4.Text + " " + b.ToString() + "x ";
                }


                if ((a == 1) & (b > 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "x^2 + " + b.ToString() + "x + " + c.ToString();
                }
                if ((a == 1) & (b > 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "x^2 + " + b.ToString() + "x " + c.ToString();
                }
                if ((a == 1) & (b > 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "x^2 + " + b.ToString() + "x ";
                }

                if ((a == 1) & (b < 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "x^2 " + b.ToString() + "x + " + c.ToString();
                }
                if ((a == 1) & (b < 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "x^2 " + b.ToString() + "x " + c.ToString();
                }
                if ((a == 1) & (b < 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "x^2 " + b.ToString() + "x  ";
                }
                if ((a == 1) & (b == 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "x^2 + " + c.ToString();
                }
                if ((a == 1) & (b == 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "x^2  " + c.ToString();
                }
                if ((a == 1) & (b == 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "x^2  ";
                }


                if ((a == -1) & (b > 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 + " + b.ToString() + "x + " + c.ToString();
                }
                if ((a == -1) & (b > 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 + " + b.ToString() + "x " + c.ToString();
                }
                if ((a == -1) & (b > 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 + " + b.ToString() + "x ";
                }
                if ((a == -1) & (b < 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 " + b.ToString() + "x + " + c.ToString();
                }
                if ((a == -1) & (b < 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 " + b.ToString() + "x " + c.ToString();
                }
                if ((a == -1) & (b < 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 " + b.ToString() + "x ";
                }
                if ((a == -1) & (b == 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + "-x^2 + " + c.ToString();
                }
                if ((a == -1) & (b == 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + "-x^2  " + c.ToString();
                }
                if ((a == -1) & (b == 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + "-x^2  ";
                }


                if ((a != 0) & (a != 1) & (a != -1) & (b > 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 + " + b.ToString() + "x + " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b > 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 + " + b.ToString() + "x " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b > 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 + " + b.ToString() + "x ";
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b < 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 " + b.ToString() + "x + " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b < 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 " + b.ToString() + "x " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b < 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 " + b.ToString() + "x ";
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b == 0) & (c > 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 + " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b == 0) & (c < 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 " + c.ToString();
                }
                if ((a != 0) & (a != 1) & (a != -1) & (b == 0) & (c == 0))
                {
                    label4.Text = label4.Text + " " + a.ToString() + "x^2 ";
                }
                

            }
            catch
            {
                label4.Text = label4.Text + " Некорректные данные" ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
           
            form.textBox1.Text = this.textBox1.Text;
            form.textBox2.Text = this.textBox2.Text;
            form.textBox3.Text = this.textBox3.Text;
            form.ShowDialog();
        }

        public Form1()
        {
            InitializeComponent();
            a = b = c = d = 0;
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();
            arr = label4.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

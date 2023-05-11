using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace lab_1_calculator
{
    public partial class Form1 : Form
    {
        //Определения данных
        Double a, b, c, d;
        string arr;
        public Form1()
        {
            InitializeComponent();
            a = b = c = d = 0;
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            arr = label3.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a + b;
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a - b;
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a * b;
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Pow(a, b);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Pow(b, a);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Pow(a, 2);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Pow(b, 2);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Sin(a);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Sin(b);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Cos(b);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Cos(a);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Sin(a) / Math.Cos(a);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Sin(b) / Math.Cos(b);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Cos(a) / Math.Sin(a);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Math.Cos(b) / Math.Sin(b);
                label3.Text = label3.Text + " " + c.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                int factorial = 1;
                if (a > 19)
                {
                    label3.Text = label3.Text + " Данные переполнены";
                }
                else
                {
                    for (int i = 2; i <= a; i++)
                    {
                        factorial = factorial * i;
                    }
                    c = factorial;
                    label3.Text = label3.Text + " " + c.ToString();
                }

            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                if (b > 19)
                {
                    label3.Text = label3.Text + " Данные переполнены";
                }
                else
                {
                    int factorial = 1;
                    for (int i = 2; i <= b; i++)
                    {
                        factorial = factorial * i;
                    }
                    c = factorial;
                    label3.Text = label3.Text + " " + c.ToString();
                }
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = arr;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a / b;
                d = a % b;
                label3.Text = label3.Text + " " + c.ToString() + " ост: " + d.ToString();
            }
            catch
            {
                label3.Text = "Некорректные исходные данные";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

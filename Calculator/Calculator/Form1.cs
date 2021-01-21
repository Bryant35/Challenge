using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            textBoxTampilan.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string hasil = "";
       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasil = hasil + 1;
            textBoxTampilan.Text = hasil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasil = hasil + 2;
            textBoxTampilan.Text = hasil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hasil = hasil + 3;
            textBoxTampilan.Text = hasil;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasil = hasil + 4;
            textBoxTampilan.Text = hasil;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hasil = hasil + 5;
            textBoxTampilan.Text = hasil;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasil = hasil + 6;
            textBoxTampilan.Text = hasil;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hasil = hasil + 7;
            textBoxTampilan.Text = hasil;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hasil = hasil + 8;
            textBoxTampilan.Text = hasil;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hasil = hasil + 9;
            textBoxTampilan.Text = hasil;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            hasil = hasil + 0;
            textBoxTampilan.Text = hasil;
        }

        double[] nilai = new double[100];
        int count = 0;
        char operasi = '0';
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
            }
            else
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
                if (operasi == '+')
                {
                    nilai[count] = nilai[count - 1] + nilai[count];
                }
                else if (operasi == '-')
                {
                    nilai[count] = nilai[count - 1] - nilai[count];
                }
                else if (operasi == '*')
                {
                    nilai[count] = nilai[count - 1] * nilai[count];
                }
                else if (operasi == '/')
                {
                    nilai[count] = nilai[count - 1] / nilai[count];
                }
                textBoxTampilan.Text = Convert.ToString(nilai[count]);
            }
            operasi = '+';
            count++;
            hasil = "";
        }
        double equal = 0;
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
            textBoxTampilan.Clear();
            for(int i = 0; i <= count; i++)
            {
                if(i == 0)
                {
                    equal = nilai[i];
                }
                else if(operasi == '+')
                {
                    equal = nilai[i - 1] + nilai[i];
                }
                else if(operasi == '-')
                {
                    equal = nilai[i - 1] - nilai[i];
                }
                else if(operasi == '*')
                {
                    equal = nilai[i - 1] * nilai[i];
                }
                else if(operasi == '/')
                {
                    equal = nilai[i - 1] / nilai[i];
                }
            }
            textBoxTampilan.Text = Convert.ToString(equal);
            count++;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
            }
            else
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
                if (operasi == '+')
                {
                    nilai[count] = nilai[count - 1] + nilai[count];
                }
                else if (operasi == '-')
                {
                    nilai[count] = nilai[count - 1] - nilai[count];
                }
                else if (operasi == '*')
                {
                    nilai[count] = nilai[count - 1] * nilai[count];
                }
                else if (operasi == '/')
                {
                    nilai[count] = nilai[count - 1] / nilai[count];
                }
                textBoxTampilan.Text = Convert.ToString(nilai[count]);
            }
            operasi = '-';
            count++;
            hasil = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
            }
            else
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
                if (operasi == '+')
                {
                    nilai[count] = nilai[count - 1] + nilai[count];
                }
                else if (operasi == '-')
                {
                    nilai[count] = nilai[count - 1] - nilai[count];
                }
                else if (operasi == '*')
                {
                    nilai[count] = nilai[count - 1] * nilai[count];
                }
                else if (operasi == '/')
                {
                    nilai[count] = nilai[count - 1] / nilai[count];
                }
                textBoxTampilan.Text = Convert.ToString(nilai[count]);
            }
            operasi = '*';
            count++;
            hasil = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
            }
            else
            {
                nilai[count] = Convert.ToDouble(textBoxTampilan.Text);
                if (operasi == '+')
                {
                    nilai[count] = nilai[count - 1] + nilai[count];
                }
                else if (operasi == '-')
                {
                    nilai[count] = nilai[count - 1] - nilai[count];
                }
                else if (operasi == '*')
                {
                    nilai[count] = nilai[count - 1] * nilai[count];
                }
                else if (operasi == '/')
                {
                    nilai[count] = nilai[count - 1] / nilai[count];
                }
                textBoxTampilan.Text = Convert.ToString(nilai[count]);
            }
            operasi = '/';
            count++;
            hasil = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            string kechar = hasil;
            char[] del = kechar.ToCharArray();
            string simpan = "";
            for(int i = 0; i <= del.Length - 1; i++)
            {
                if(i == del.Length - 1)
                {

                }
                else
                {
                    simpan = simpan + del[i];
                }
            }
            hasil = simpan;
            textBoxTampilan.Text = hasil;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string hasil = "0";
            textBoxTampilan.Text = (hasil);
            hasil = "";
            double[] nilai = new double[100];
            char operasi = '0';
            double equal = 0;
            int count = 0;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Form_Z03_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double h = Convert.ToDouble(textBoxH.Text);

                if (a < b)
                {
                    if (h > 0)
                    {
                        while (a <= b)
                        {
                            f(a);
                            a = a + h;
                        }
                    }
                    else
                    {
                        textBoxError.Text = "H должно быть больше 0!";
                    }
                }
                else
                {
                    textBoxError.Text = "A должно быть меньше B";
                }
            }
            catch (Exception)
            {
                textBoxError.Text = "Некорректный ввод данных!";
            }
        }
        private void f(double x)
        {
            double y;
            if (x < 1)
                textBoxResult.Text = textBoxResult.Text + "x = " + Math.Round(x, 3) + " y = " + Math.Round(y = ((x * x) - 1) * ((x * x) - 1), 3) + "\r\n";
            else if (x > 1)
                textBoxResult.Text = textBoxResult.Text + "x = " + Math.Round(x, 3) + " y = " + Math.Round(y = 1 / (1 + (x * x)), 3) + "\r\n";
            else if (x == 1)
                textBoxResult.Text = textBoxResult.Text + "x = " + Math.Round(x, 3) + " y = " + Math.Round(y = 0, 3) + "\r\n";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
    }
}

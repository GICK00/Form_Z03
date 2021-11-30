using System;
using System.Windows.Forms;

namespace Form_Z03_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxResult1.Text = "";

            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double h = Convert.ToDouble(textBoxH.Text);

                if (a < b)
                {
                    if (h > 0)
                    {
                        double x = a;
                        while (x <= b)
                        {
                            f(x);
                            x = x + h;
                        }

                        x = a;
                        double y;
                        while (x <= b)
                        {
                            f(x, out y);
                            textBoxResult1.Text = textBoxResult1.Text + "x = " + Math.Round(x, 3) + " y = " + Math.Round(y, 3) + "\r\n";
                            x = x + h;
                        }
                    }
                    else
                    {
                        textBoxResult.Text = "H должно быть больше 0!";
                    }
                }
                else
                {
                    textBoxResult.Text = "A должно быть меньше B";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
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
        static void f(double x, out double y)
        {
            y = 1;
            if (x < 1)
                y = ((x * x) - 1) * ((x * x) - 1);
            else if (x > 1)
                y = 1 / (1 + (x * x));
            else if (x == 1)
                y = 0;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxResult1.Text = "";
        }
    }
}

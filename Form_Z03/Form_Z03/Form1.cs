using System;
using System.Windows.Forms;

namespace Form_Z03
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
                int n = Convert.ToInt32(textBoxN.Text);

                if (f(n) != 0)
                    textBoxResult.Text = "Число " + n + " четное, произведена операция деление на 2. Ответ: " + f(n);
                else
                    textBoxResult.Text = "Число " + n + " не четное, произведена операция замена на 0. Ответ: " + f(n);
            }
            catch (Exception)
            {
                textBoxResult.Text = "Неккоректный ввод данных!";
            }
        }

        private void buttonExample_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            Example(n);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxExample.Text = "";
        }
        private static int f(int x)
        {
            if (x % 2 == 0)
                return x / 2;
            else
                return 0;
        }

        private void Example(int n)
        {
            if (n < 999)
            {
                for (int i = 0; i < n + 1; i++) // Бесполезная демонстрация
                {
                    switch (i.ToString().Length)
                    {
                        case 1:
                            textBoxExample.Text = textBoxExample.Text + "i = " + i + ",     f(i) = " + f(i) + "\r\n";
                            break;
                        case 2:
                            textBoxExample.Text = textBoxExample.Text + "i = " + i + ",   f(i) = " + f(i) + "\r\n";
                            break;
                        case 3:
                            textBoxExample.Text = textBoxExample.Text + "i = " + i + ", f(i) = " + f(i) + "\r\n";
                            break;
                    }
                }
            } 
            else
            {
                textBoxResult.Text = "Приложение не может обработать число больше 999, не прописанное форматирование в коносле.";
            }
        }
    }
}

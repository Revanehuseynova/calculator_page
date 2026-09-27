using System;
using System.Windows.Forms;

namespace calculator_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Result düyməsi (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Zəhmət olmasa düzgün ədədlər daxil edin!");
                return;
            }

            double result = 0;
            string command = comboBox1.Text;

            if (command == "+")
            {
                result = number1 + number2;
            }
            else if (command == "-")
            {
                result = number1 - number2;
            }
            else if (command == "*")
            {
                result = number1 * number2;
            }
            else if (command == "/")
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("Sıfıra bölmək olmaz!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa əməliyyat seçin (+, -, *, /)");
                return;
            }

            label4.Text = result.ToString();
        }

        // Clear düyməsi (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            label4.Text = "0";
        }
    }
}
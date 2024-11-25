using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = double.Parse(firstNumberTextBox.Text);
                double secondNumber = double.Parse(secondNumberTextBox.Text);
                string action = actionComboBox.SelectedItem.ToString();
                double result = 0;
                switch (action)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else
                        {
                            MessageBox.Show("Деление на ноль невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Выберите действие из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                resultTextBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
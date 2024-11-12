using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class CalculatorForm : Form
    {
        private string currentExpression = ""; // Выражение для отображения
        private double currentResult = 0; // Текущее значение результата
        private string lastOperation = ""; // Последняя операция
        private bool newOperation = true; // Флаг для нового числа после операции
        public CalculatorForm()
        {
            InitializeComponent();
            button19.SendToBack();
            lblExpression.BackColor = Color.White;
            lblResult.BackColor = Color.White;

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            lblExpression.Text = ""; // Начальное значение для выражения
            lblResult.Text = "0"; // Начальное значение для результата
            lblResult.Font = new Font(lblResult.Font.FontFamily, 24, FontStyle.Bold); // Устанавливаем жирный шрифт для результата
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (newOperation)
            {
                lblResult.Text = "";
                newOperation = false;
            }
            lblResult.Text += button.Text;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Contains(","))
            {
                if (newOperation)
                {
                    lblResult.Text = "0";
                    newOperation = false;
                }
                lblResult.Text += ",";
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(lblResult.Text, out double number))
            {
                if (lastOperation != "")
                {
                    Calculate(number);
                }
                else
                {
                    currentResult = number;
                }
            }

            lastOperation = button.Text;
            currentExpression = $"{currentResult} {lastOperation}"; // Обновляем выражение
            lblExpression.Text = currentExpression;
            newOperation = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResult.Text, out double number))
            {
                Calculate(number);
            }
            lastOperation = "";
            lblExpression.Text = currentExpression + " ="; // Добавляем "=" к выражению
            newOperation = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentExpression = "";
            currentResult = 0;
            lastOperation = "";
            lblExpression.Text = "";
            lblResult.Text = "0";
        }

        private void Calculate(double number)
        {
            switch (lastOperation)
            {
                case "+":
                    currentResult += number;
                    break;
                case "-":
                    currentResult -= number;
                    break;
                case "*":
                    currentResult *= number;
                    break;
                case "/":
                    if (number != 0)
                        currentResult /= number;
                    else
                        MessageBox.Show("Деление на ноль запрещено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            lblResult.Text = currentResult.ToString("G", CultureInfo.CurrentCulture);
            currentExpression += $" {number}";
            lblExpression.Text = currentExpression;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResult.Text, out double number))
            {
                Calculate(number);
            }
            lastOperation = "";
            lblExpression.Text = currentExpression + " ="; // Добавляем "=" к выражению
            newOperation = true;
        }
        private void CalculatorForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
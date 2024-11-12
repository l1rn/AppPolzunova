using System;
using System.Windows.Forms;
namespace Calculator1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            // Добавляем опции в ComboBox
            comboBox1.Items.Add("Calculator");
            comboBox1.Items.Add("Gameplay");
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            // Открытие формы в зависимости от выбора пользователя
            Form selectedForm = null;

            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Calculator":
                    selectedForm = new CalculatorForm();
                    break;
                case "Gameplay":
                    selectedForm = new Game();
                    break;
                default:
                    MessageBox.Show("Пожалуйста, выберите подпрограмму.");
                    return;
            }

            // Отображение выбранной формы
            selectedForm?.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
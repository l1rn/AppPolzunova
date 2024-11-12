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
            // ��������� ����� � ComboBox
            comboBox1.Items.Add("Calculator");
            comboBox1.Items.Add("Gameplay");
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            // �������� ����� � ����������� �� ������ ������������
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
                    MessageBox.Show("����������, �������� ������������.");
                    return;
            }

            // ����������� ��������� �����
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
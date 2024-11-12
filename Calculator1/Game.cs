using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator1
{
    public partial class Game : Form
    {
        private int attempts;
        private int randomNumber;
        private int ReadNumber;
        private int countAttempts;
        Random random = new Random();

        private void Enter_Click(object sender, EventArgs e)
        {
            ReadNumber = 0;
            try
            {
                ReadNumber = Convert.ToInt32(boxForGuess.Text);
            }
            catch { }
            if (!int.TryParse(boxForGuess.Text, out ReadNumber))
            {
                // Если введено не число, показываем сообщение об ошибке и выходим из метода
                lblLose.Visible = true;
                lblLose.Text = "Введите число!";
                return;
            }
            if (attempts == 1)
            {
                lblLose.Visible = true;
                lblLose.Text = "Вы проиграли!";
                boxForGuess.Visible = false;
                Enter.Visible = false;
                Answer.Visible = true;
                AllAttempts.Text = "Осталось попыток: 0";
                Answer.Text = $"Правильный ответ: {randomNumber}";
                Start.Visible = true;

            }
            else
            {
                if(randomNumber == ReadNumber)
                {
                    lblLose.Visible = true;
                    lblLose.Text = "Вы выиграли!";

                    Answer.Visible = true;
                    Answer.Text = $"Правильный ответ: {randomNumber}";
                    Start.Visible = true;
                    boxForGuess.Visible = false;
                    Enter.Visible = false;
                    AllAttempts.Visible = false;
                    SuccessAttempts.Visible = true;
                    SuccessAttempts.Text = $"Вы угадали за {countAttempts} попыток";
                }
                else
                {
                    if(randomNumber > ReadNumber)
                    {
                        lblLose.Visible = true;
                        lblLose.Text = $"Число больше {ReadNumber}!";
                        attempts--;
                        countAttempts++;
                        AllAttempts.Text = $"Осталось попыток: {attempts}";

                    }
                    else if(randomNumber < ReadNumber)
                    {
                        lblLose.Visible = true;
                        lblLose.Text = $"Число меньше {ReadNumber}!";
                        attempts--;
                        countAttempts++;
                        AllAttempts.Text = $"Осталось попыток: {attempts}";
                    }
                }
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void boxForGuess_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void AllAttempts_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hardlvl(object sender, EventArgs e)
        {
            Easylvl.Visible = false;
            Mediumlvl.Visible = false;
            Hardlvl.Visible = false;
            lbl_Easy.Visible = false;
            lbl_Medium.Visible = false;
            lbl_Hard.Visible = false;
            AllAttempts.Visible = true;
            lblLose.Visible = false;
            Enter.Visible = true;
            boxForGuess.Visible = true;
            attempts = 5;
            Answer.Visible = false;
            ReadNumber = 0;
            randomNumber = random.Next(0, 101);
            boxForGuess.Text = "";
            AllAttempts.Text = $"Осталось попыток: {attempts}";
        }

        private void btn_Mediumlvl(object sender, EventArgs e)
        {
            Easylvl.Visible = false;
            Mediumlvl.Visible = false;
            Hardlvl.Visible = false;
            lbl_Easy.Visible = false;
            lbl_Medium.Visible = false;
            lbl_Hard.Visible = false;
            AllAttempts.Visible = true;
            lblLose.Visible = false;
            Enter.Visible = true;
            boxForGuess.Visible = true;
            attempts = 10;
            Answer.Visible = false;
            ReadNumber = 0;
            randomNumber = random.Next(0, 101);
            
            boxForGuess.Text = "";
            AllAttempts.Text = $"Осталось попыток: {attempts}";
        }

        private void btn_Start(object sender, EventArgs e)
        {
            countAttempts = 0;
            SuccessAttempts.Text = "";
            Easylvl.Visible = true;
            Mediumlvl.Visible = true;
            Hardlvl.Visible = true;
            lbl_Easy.Visible = true;
            lbl_Medium.Visible = true;
            lbl_Hard.Visible = true;
            Start.Visible = false;
            Answer.Visible = false;
            AllAttempts.Visible = false;
            lblLose.Visible = false;
        }

        private void btn_Easylvl(object sender, EventArgs e)
        {
            Easylvl.Visible = false;
            Mediumlvl.Visible = false;
            Hardlvl.Visible = false;
            lbl_Easy.Visible = false;
            lbl_Medium.Visible = false;
            lbl_Hard.Visible = false;
            AllAttempts.Visible = true;
            lblLose.Visible = false;
            Enter.Visible = true;
            boxForGuess.Visible = true;
            attempts = 15;
            Answer.Visible = false;
            ReadNumber = 0;
            randomNumber = random.Next(0, 101);
            boxForGuess.Text = "";
            AllAttempts.Text = $"Осталось попыток: {attempts}";
        }

        private void lbl_levels(object sender, EventArgs e)
        {
            
        }

        public Game()
        {
            InitializeComponent();
            this.KeyPreview = true; // Включаем просмотр нажатий клавиш для формы
            this.KeyDown += new KeyEventHandler(Game_KeyDown);
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Отключаем звуковой сигнал Enter
                Enter.PerformClick(); // Замените myButton на имя вашей кнопки
            }
        }
    }
}

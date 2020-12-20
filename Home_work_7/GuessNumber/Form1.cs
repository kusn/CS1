// Кудряшов Сегей

// Используя Windows Forms, разработать игру «Угадай число».
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
// Для ввода данных от человека используется элемент TextBox.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        Guess guess;
        int number;
        int check;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            guess = new Guess();
            guess.Start();
            number = guess.GetNumber();
            MessageBox.Show("Угадайте число от 0 до 100");
        }

        private void txtBxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                check = guess.Check(Convert.ToInt32(txtBxAnswer.Text));
                if (check == 0)
                {
                    MessageBox.Show($"Вы угадали за {guess.GetSteps()} шагов!");
                }
                else if (check == 1)
                {
                    MessageBox.Show("Загаданное число меньше");
                }
                else if (check == -1)
                {
                    MessageBox.Show("Загаданное число больше");
                }
                else
                {
                    MessageBox.Show("Нужно ввести число от 0 до 100");
                }
            }
        }
    }
}

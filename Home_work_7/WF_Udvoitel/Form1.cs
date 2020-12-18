// Кудряшов Сергей

// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение,
// какое число должен получить игрок. Игрок должен получить это число за
// минимальное количество ходов.
// в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
// Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        int target;
        int value;
        Doubler doubler;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            value++;
            doubler.SetValue(value);
            lblNumber.Text = "Текущее значение: " + value.ToString();
            doubler.SetSteps();
            lblStep.Text = doubler.GetSteps().ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            value = value * 2;
            doubler.SetValue(value);
            lblNumber.Text = "Текущее значение: " + value.ToString();
            doubler.SetSteps();
            lblStep.Text = doubler.GetSteps().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            value = doubler.GetValue();
            lblNumber.Text = "Текущее значение: " + value.ToString();
            lblStep.Text = doubler.GetSteps().ToString();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler();
            doubler.Start();

            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;

            target = doubler.GetTarget();
            MessageBox.Show(target.ToString());
            lblTarget.Text = target.ToString();
            lblStep.Text = doubler.GetSteps().ToString();

            if (value == target)
                MessageBox.Show($"Вы смогли получить необходимое число за {doubler.GetSteps()} шагов");
        }
    }
}

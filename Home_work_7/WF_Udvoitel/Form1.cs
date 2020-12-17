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
            lblValue.Text = "Текущее значение: " + value.ToString();

        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            value = value * 2;
            doubler.SetValue(value);
            lblValue.Text = "Текущее значение: " + value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            value = doubler.GetValue();
            lblValue.Text = "Текущее значение: " + value.ToString();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.Start();
            doubler = new Doubler();
            target = doubler.GetTarget();
            MessageBox.Show(target.ToString());
            lblTarget.Text = target.ToString();
            //statusStrip1.Text = "Цель: " + target.ToString() + "Текущее значение: " + doubler.GetValue().ToString();
            
        }
    }
}

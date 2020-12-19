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

        void Update()
        {
            lblNumber.Text = doubler.GetValue().ToString();
            lblStep.Text = doubler.GetSteps().ToString();
            lblTarget.Text = doubler.GetTarget().ToString();
        }

        void Status()
        {
            if(doubler.GetSteps() == doubler.NeededSteps() && doubler.GetValue() == doubler.GetTarget())
                MessageBox.Show("У Вас получилось!");
            else if (doubler.GetSteps() > doubler.NeededSteps() || doubler.GetValue() > doubler.GetTarget())
                MessageBox.Show($"У Вас не получилось. Попробуйте ещё раз. Необходимое кол-во шагов {doubler.NeededSteps()}");
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doubler.Increment();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Double();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();            
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            doubler.Undo();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler();
            doubler.Update += new Action(Update);
            doubler.Status += new Action(Status);
            doubler.Start();

            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;

            target = doubler.GetTarget();
            //doubler.SetValue(1);            
            Update();
            MessageBox.Show("Необходимо получить: " + target.ToString());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
            };
        }
    }
}

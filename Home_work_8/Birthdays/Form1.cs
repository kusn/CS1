using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthdays
{
    public partial class Form1 : Form
    {

        DateStore database;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CreatePrompt = true;
            sfd.DefaultExt = "xml";
            sfd.AddExtension = true;
            sfd.Filter = "Файлы (*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new DateStore(sfd.FileName);
                database.Add("Дата создания", monthCalendar1.TodayDate);
                database.Save();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new DateStore(ofd.FileName);
                database.Load();                
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(database != null)
            {
                string file;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.CreatePrompt = true;
                dialog.DefaultExt = "xml";
                dialog.AddExtension = true;
                dialog.Filter = "Файлы (*.xml)|*.xml";
                dialog.ShowDialog();
                file = dialog.FileName;
                database.SaveAs(file);
            }
            else MessageBox.Show("База данных не создана");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), monthCalendar1.SelectionRange.Start);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (database == null) return;
            database.Remove(database.Search(monthCalendar1.SelectionRange.Start));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.Add(textBox1.Text, monthCalendar1.SelectionRange.Start);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int i = database.Search(monthCalendar1.SelectionRange.Start);
            if (i == 0)
            {
                textBox1.Text = "";
                MessageBox.Show("На данную дату ничего не назначено.");
            }
            else
            {
                textBox1.Text = database[i].text;
            }
        }
    }
}

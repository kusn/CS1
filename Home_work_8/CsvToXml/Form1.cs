using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvToXml
{
    public partial class Form1 : Form
    {
        ConverCsvToXml convert;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;
            ofd.Filter = "Файлы (*.csv)|*.csv";            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string in_file = ofd.FileName;
                string out_file = ofd.FileName + ".xml";
                convert = new ConverCsvToXml();
                convert.ConvertToXml(in_file, out_file);
                MessageBox.Show("Готово");
            }
        }
    }
}

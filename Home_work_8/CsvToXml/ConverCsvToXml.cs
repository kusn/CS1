using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace CsvToXml
{
    class ConverCsvToXml
    {
        string filename;
        List<Student> list;
        public Exception ex;

        public string FileName
        {
            set { this.filename = value; }
        }

        public void ConvertToXml(string in_filename, string out_filename)
        {
            list = new List<Student>();

            StreamReader sr = new StreamReader(in_filename, Encoding.GetEncoding(1251));
            
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch(Exception e)
                {
                    this.ex = e;
                }
            }
            sr.Close();

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(out_filename, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
    }
}

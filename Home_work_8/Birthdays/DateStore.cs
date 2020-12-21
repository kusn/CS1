using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Birthdays
{
    class DateStore
    {
        string fileName;
        List<Birthday> list;
        
        public string FileName
        {
            set { fileName = value; }
        }

        public DateStore(string filename)
        {
            this.fileName = fileName;
            list = new List<Birthday>();
        }

        public void Add(string text, DateTime date)
        {
            list.Add(new Birthday(text, date));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index > 0)
                list.RemoveAt(index);
        }

        public Birthday this[int index]
        {
            get { return list[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Birthday>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void SaveAs(string fname)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Birthday>));
            Stream fStream = new FileStream(fname, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlformat = new XmlSerializer(typeof(List<Birthday>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Birthday>)xmlformat.Deserialize(fStream);
            fStream.Close();
        }

        public int Search(DateTime date)
        {
            int i = 0;
            int n = 0;
            foreach(var v in list)
            {
                if(v.date == date)
                {
                    n = i;
                }
                i++;
            }
            return i;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}

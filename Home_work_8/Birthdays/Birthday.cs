using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays
{
    [Serializable]
    public class Birthday
    {
        public string text;             // Текст
        public DateTime date;           // Дата дня рождения

        public Birthday()
        { }

        public Birthday(string text, DateTime date)
        {
            this.text = text;
            this.date = date;
        }
    }
}

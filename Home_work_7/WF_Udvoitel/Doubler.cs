using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    struct Operations
    {
        int step;
        int value;        
    }
    class Doubler
    {
        int steps;                  // Счетчик числа шагов
        int value;                  // Текущее значение

        Operations op = new Operations();
        int target;

        new Random rnd = new Random();

        public Doubler()
        {
            this.steps = 0;
            this.value = 0;
            this.target = 0;
        }
        
        // Получить текущее кол-во шагов
        public int GetSteps()
        {
            return steps;
        }

        // Прибавить шаг
        public void SetSteps()
        {
            steps++;
        }

        // Получить текущее значение
        public int GetValue()
        {
            return value;
        }

        // Установить текущее значение
        public void SetValue(int value)
        {
            this.value = value;
        }

        // Получить текущее значение цели
        public int GetTarget()
        {
            return target;
        }

        // Метод увеличения на единицу
        public void Increment()
        {
            this.value++;
            this.steps++;
        }

        // Метод удвоения
        public void Double()
        {
            this.value *= 2;
            this.steps++;
        }

        // Сброс текущего значения
        public void Reset()
        {
            SetValue(1);
            steps = 0;
        }

        // Старт игры
        public void Start()
        {
            Random rnd = new Random();
            steps = 0;
            value = 1;
            target = rnd.Next(5, 100);
        }
    }
}

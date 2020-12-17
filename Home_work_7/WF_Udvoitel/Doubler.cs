using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    class Doubler
    {
        int commands = 0;               // Счетчик количества отданных команд удвоителю
        int steps = 0;                  // Счетчик числа шагов
        int value = 0;                  // Текущее значение
        int target;

        // Получить текущее кол-во отданных команд
        public int GetCommandsCount()
        {
            return commands;
        }

        // Прибавить +1 к кол-ву команд
        public void SetCommands()
        {
            commands++;
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

        public int GetTarget()
        {
            return target;
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
            commands = 0;
            value = 1;
            target = rnd.Next(5, 100);
        }
    }
}

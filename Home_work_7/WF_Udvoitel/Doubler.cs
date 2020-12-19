using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    struct Iteration
    {
        public int step { get; set; }
        public int value { get; set; }
    }
    class Doubler
    {
        Iteration itt = new Iteration();
        Stack<Iteration> stack = new Stack<Iteration>();

        // События
        public event System.Action Update;
        public event System.Action Status;

        public int Finish { get; private set; }

        int target;

        Random rnd = new Random();

        public Doubler()
        {
            itt.step = 0;
            itt.value = 1;            
        }
        
        public int NeededSteps()
        {
            int n = target;
            int i = 0;
            while (n != 1)
            {
                n = n % 2 == 0 ? n / 2 : n - 1;
                i++;
            }
            return i;
        }

        // Получить текущее кол-во шагов
        public int GetSteps()
        {            
            return itt.step;
        }
        
        // Получить текущее значение
        public int GetValue()
        {
            return itt.value;
        }

        // Установить текущее значение
        public void SetValue(int value)
        {
            itt.step = value;
        }

        // Получить текущее значение цели
        public int GetTarget()
        {
            return target;
        }

        // Метод увеличения на единицу
        public void Increment()
        {
            stack.Push(itt);
            itt.value++;
            itt.step++;
            if (Update != null) Update.Invoke();
            if ((Status != null) && (itt.value >= target || itt.step >= Finish)) Status.Invoke();
        }

        // Метод удвоения
        public void Double()
        {
            stack.Push(itt);
            itt.value *= 2;
            itt.step++;
            if (Update != null) Update.Invoke();
            if ((Status != null) && (itt.value >= target || itt.step >= Finish)) Status.Invoke();
        }

        // Сброс текущего значения
        public void Reset()
        {
            itt.value = 1;
            itt.step = 0;
            stack.Clear();
            if (Update != null) Update.Invoke();
        }

        public void Undo()
        {
            if (stack.Count != 0) itt = stack.Pop();
            Update?.Invoke();
        }

        // Старт игры
        public void Start()
        {
            int needstep;
            target = rnd.Next(10, 101);
            if (Update != null) Update.Invoke();
            Finish = NeededSteps();
        }
    }
}

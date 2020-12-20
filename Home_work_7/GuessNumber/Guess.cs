using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Guess
    {
        int guess_number;
        int steps;

        public int GetNumber()
        {
            return guess_number = new Random().Next(0, 101);
        }

        public int Check(int n)
        {
            steps++;
            if (n <= 100 && n > 0)
            {
                if (n == guess_number)
                    return 0;
                else if (n > guess_number)
                    return 1;
                else
                    return -1;
            }
            else return 2;
        }

        public int GetSteps()
        {
            return steps;
        }

        public void Start()
        {
            GetNumber();
        }
    }
}

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

        public int GetNumber()
        {
            return guess_number = new Random().Next(0, 1000);
        }

        public bool Check(int n)
        {
            if (n)
        }
    }
}

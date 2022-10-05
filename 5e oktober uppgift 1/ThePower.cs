using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5e_oktober_uppgift_1
{
    internal class ThePower
    {
        private int number;

        public ThePower(int number)
        {
            this.number = number;  
        }

        public static double GetPower(int number)
        {
            double numSquared = Math.Pow(number, 2); 
            return numSquared;
        }
    }
}

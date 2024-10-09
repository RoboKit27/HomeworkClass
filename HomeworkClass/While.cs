using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass
{
    public static class While
    {
        public static int EuclideanAlgorithm(int number1, int number2)
        {
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 -= number2;
                }
                else
                {
                    number2 -= number1;
                }
            }
            return number1;
        }
        public static int GetOddNumbers(int number)
        {
            int count = 0;
            while (number != 0)
            {
                int crnt = number % 10;

                if (crnt % 2 != 0)
                {
                    count++;
                }

                number = number / 10;

            }

            return count;
        }
        public static int ReverseNumber(int number)
        {
            int result = 0;

            while (number != 0)
            {
                int crnt = number % 10;
                number = number / 10;

                result = result * 10 + crnt;

            }

            return result;
        }
    }
}

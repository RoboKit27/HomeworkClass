using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass
{
    public static class For
    {
        public static double GetPower(double number, double power)
        {
            double result = 1;

            if (power >= 0)
            {
                for (int i = 0; i < power; i++)
                {
                    result *= number;
                }
            }
            else
            {
                for (int i = 0; i < -power; i++)
                {
                    result /= number;
                }
            }

            return result;
        }
        public static void GetMultiplesNumbers(int number)
        {
            int end = 1000;

            for (int i = number; i < end; i += number)
            {
                Console.WriteLine(i);
            }
        }
        public static int GetNumbersSquare(int number)
        {
            int result = 0;

            for (int i = 2; i < number; i++)
            {
                if (i * i < number)
                {
                    result++;
                }
            }

            return result;
        }
        public static int GetNOD(int number)
        {
            int result = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = i;
                }
            }

            return result;
        }
        public static int GetNumbersSumFromRange(int start, int end)
        {
            int result = 0;

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (int i = start; i > end; i--)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }

            return result;
        }
    }
}

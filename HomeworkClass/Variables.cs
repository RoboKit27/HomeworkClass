using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass
{
    public static class Variables
    {
        public static double CalculateSalary(double pathLength)
        {
            int fixPrice = 150;
            int kmPrice = 70;
            double salary = fixPrice;

            salary += kmPrice * pathLength;

            return salary;
        }
        public static double CalculateBonus(double salesAmount, double salesPlan)
        {
            double bonusProcent = 10;
            double workerBonus = 0;

            if (salesAmount > salesPlan)
            {
                workerBonus = (salesAmount - salesPlan) * (bonusProcent / 100d);
            }

            return workerBonus;
        }
        public static double CalculateProfit(double depositPrice)
        {
            double depositTime = 18;
            double depositProcent = 10;
            double userProfit = 0;

            userProfit = depositPrice * (depositProcent / 100d) * (depositTime / 12d);

            return userProfit;
        }
    }
}

namespace HomeworkClass.Test
{
    public class VariablesTests
    {
        [TestCase(8, 710)]
        public void CalculateSalaryTest(double pathLength, double excepted)
        {
            double actual = Variables.CalculateSalary(pathLength);

            Assert.AreEqual(excepted, actual);
        }
        
        
        
        [TestCase(16700, 12000, 470)]
        public void CalculateBonusTest(double salesAmount, double salesPlan, double excepted)
        {
            double actual = Variables.CalculateBonus(salesAmount, salesPlan);

            Assert.AreEqual(excepted, actual);
        }
        
        [TestCase(6100, 915)]
        public void CalculateProfitTest(double depositPrice, double excepted)
        {
            double actual = Variables.CalculateProfit(depositPrice);

            Assert.AreEqual(excepted, actual);
        }

    }
}
namespace HomeworkClass.Test
{
    public class ForTest
    {
        [TestCase(7, 5, 16807)]
        public void GetPowerTest(double number, double power, double expected)
        {
            double actual = For.GetPower(number, power);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(200, "200 400 600 800 ")]
        public void GetMultiplesNumbersTest(int number, string expected)
        {
            string actual = For.GetMultiplesNumbers(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 8)]
        public void GetNumbersSquareTest(int number, int expected)
        {
            int actual = For.GetNumbersSquare(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(128, 64)]
        public void GetNODTest(int number, int expected)
        {
            int actual = For.GetNOD(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 59, 252)]
        public void GetNumbersSumFromRangeTest(int start, int end, int expected)
        {
            int actual = For.GetNumbersSumFromRange(start, end);
            Assert.AreEqual(expected, actual);
        }
    }
}

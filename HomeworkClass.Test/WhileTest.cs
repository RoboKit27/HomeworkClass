namespace HomeworkClass.Test
{
    public class WhileTest
    {
        [TestCase(112, 182, 14)]
        public void EuclideanAlgorithmTest(int number1, int number2, int expected)
        {
            int actual = While.EuclideanAlgorithm(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(14372, 3)]
        public void GetOddNumbersTest(int number, int expected)
        {
            int actual = While.GetOddNumbers(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(846, 648)]
        public void ReverseNumberTest(int number, int expected)
        {
            int actual = While.ReverseNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}

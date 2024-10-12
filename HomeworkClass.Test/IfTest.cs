namespace HomeworkClass.Test
{
    public class IfTest
    {
        [TestCase("Бульба", 399.99, 14, true, 4199.895)]
        [TestCase("Бульба", 399.99, 3, false, 1199.97)]
        [TestCase("Бульба", 399.99, 7, false, 2519.937)]
        [TestCase("Бульба", 399.99, 1, true, 339.9915)]
        public void CalculateItemsPriceTest(string itemName, decimal itemPrice, int itemCount, bool isJoinPromotion, decimal expected)
        {
            decimal actual = If.CalculateItemsPrice(itemName, itemPrice, itemCount, isJoinPromotion);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, "small")]
        [TestCase(4, "medium")]
        [TestCase(6, "big")]
        [TestCase(9, "not")]
        public void GetTableTest(int humanCount, string expected)
        {
            string actual = If.GetTable(humanCount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Джон", 65, 4, 5200, true)]
        [TestCase("Джон", 38, 1, 1700, false)]
        [TestCase("Джон", 65, 3, 850, true)]
        [TestCase("Джон", 14, 6, 7300, true)]
        [TestCase("Джон", 45, 6, 2500, false)]
        [TestCase("Джон", 45, 2, 6300, false)]
        public void CalculateUserBonusTest(string clientName, int clientAge, int packageCount, decimal clientAmount, bool expected)
        {
            bool actual = If.CalculateUserBonus(clientName, clientAge, packageCount, clientAmount);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 10, 15, 4, 6, true)]
        [TestCase(60, 50, 45, 4, 6, false)]
        [TestCase(120, 10, 15, 4, 6, false)]
        [TestCase(30, 10, 15, 12, 6, false)]
        [TestCase(30, 10, 15, 4, 25, false)]
        public void GetDeliveryTypeTest(double length, double width, double height, double weight, double deliveryDistance, bool expected)
        {
            bool actual = If.GetDeliveryType(length, width, height, weight, deliveryDistance);
            Assert.AreEqual(expected, actual);
        }
    }
}

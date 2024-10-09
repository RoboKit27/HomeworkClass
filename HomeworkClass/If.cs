using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass
{
    public static class If
    {
        public static decimal CalculateItemsPrice(string itemName, decimal itemPrice, int itemCount, bool isJoinPromotion)
        {
            decimal result = 0m;
            decimal countDiscount = 0.1m;
            decimal promotionDiscount = 0.15m;
            decimal allPrice = itemPrice * itemCount;

            result = allPrice;
            if (itemCount >= 5)
            {
                result -= allPrice * countDiscount;
            }
            if (isJoinPromotion)
            {
                result -= allPrice * promotionDiscount;
            }

            return result;
        }
        public static string GetTable(int humanCount)
        {
            int smallTable = 2;
            int mediumTable = 4;
            int largeTable = 8;

            if (humanCount <= largeTable)
            {
                if (humanCount <= smallTable)
                {
                    return "Вам подойдёт маленький столик:)";
                }
                else if (humanCount <= mediumTable)
                {
                    return "Вам подойдёт средний столик:)";
                }
                else
                {
                    return "Вам подойдёт большой столик:)";
                }
            }
            else
            {
                return "К сожалению, но у нас нет столика для такого количества человек:(";
            }
        }
        public static string CalculateUserBonus(string clientName, int clientAge, int packageCount, decimal clientAmount)
        {
            if (clientAge > 60 || (clientAmount >= 5000 && packageCount >= 4))
            {
                return "Клиенту нужно предоставить скидку";
            }
            else
            {
                return "Клиенту не надо предоставлять скидку";
            }
        }
        public static string GetDeliveryType(double length, double width, double height, double weight, double deliveryDistance)
        {
            if ((length + width + height <= 150) && (length <= 100 && width <= 100 && height <= 100) && (weight <= 10) && (deliveryDistance >= 3 && deliveryDistance <= 10))
            {
                return "Отправление является малогабаритным";
            }
            else
            {
                return "Отправление не является малогабаритным";
            }
        }
    }
}

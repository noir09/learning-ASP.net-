using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using store;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DiscountTest()
        {
            //arrange
            int price = 100;
            double summ;
            double exepected = 80;

            //act
            Discount c = new Discount();
            summ=c.GetDiscountPrice(price);
            //assert
            Assert.AreEqual(exepected, summ);
        }
        [TestMethod]
        public void UserTest()
        {
            //arrange
            int price = 80;
            int balance = 300;
            int spend = 800;
            int exepected_1 = 220;
            int exepected_2 = 880;
            //act
            User Nikita = new User
            {
                Spend = spend,
                Balance = balance
            };
            Nikita.ReduceBalance(price);
            spend = Nikita.Spend;
            balance = Nikita.Balance;
            //assert
            Assert.AreEqual(exepected_1, balance);
            Assert.AreEqual(exepected_2, spend);
        }
        [TestMethod]
        public void UniqueDiscountTest()
        {
            //arrange
            int price = 100;
            double summ;
            double exepected = 70;
            int spend = 1100;

            //act
            User Nikita = new User
            { 
                Spend = spend
            };
            Discount c = new Discount();
            summ = c.UniqueGetDiscountPrice(price, Nikita);
            //assert
            Assert.AreEqual(exepected, summ);
        }
        [TestMethod]
        public void ColaTest()
        {
            //arrange
            int days = 450;
            string exepected = "продукт просрочен";
            string result;

            //act
            Cola cola = new Cola();
            result= cola.Check(days);
            //assert
            Assert.AreEqual(exepected, result);
        }
    }
}

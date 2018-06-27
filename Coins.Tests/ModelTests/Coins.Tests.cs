using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace Coins.Tests
{
    [TestClass]
    public class CoinTest
    {
        //[TestMethod]
        //public string UserInput_CreateVariable_String()
        //{
        //    User testCoin = new User();
        //    CollectionAssert.AreEqual(new string{ "60" }, testCoin.UserInput("60"));
        //}

        [TestMethod]
        public void Quarters_CreateInteger_int()
        {
            User testCoin = new User();
            Assert.AreEqual(24, testCoin.Quarters(99));
        }
        [TestMethod]
        public void Dimes_CreateInteger_int()
        {
            User testCoin = new User();
            Assert.AreEqual(4, testCoin.Dimes(24));
        }

        [TestMethod]
        public void Nickels_CreateInteger_int()
        {
            User testCoin = new User();
            Assert.AreEqual(4, testCoin.Nickels(4));
        }

        [TestMethod]
        public void Pennies_CreateInteger_int()
        {
            User testCoin = new User();
            Assert.AreEqual(0, testCoin.Pennies(4));
        }

    }
}
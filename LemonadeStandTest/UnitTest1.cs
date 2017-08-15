using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.IO;
namespace LemonadeStandTest
{
    [TestClass]
    public class LemonadeStandUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player player = new Player();
            Store store = new Store(player);
            double expectedResult = 1.25;
            string input = "5";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            store.buyLemons();

            Assert.AreEqual(expectedResult, player.totalCostLemons);
        }

        [TestMethod]
        public void TestMethod2()
        {

            UserInterface userInterFace = new UserInterface();
            string expectedResult = "no";
            string input = "no";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            userInterFace.goShopping();

            Assert.AreEqual(expectedResult, input);
        }



        [TestMethod]

        public void TestMethod3()
        {
            Player player = new Player();
            Store store = new Store(player);
            double expectedResult = 2.50;
            string input = "5";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            store.buySugar();

            Assert.AreEqual(expectedResult, player.totalCostSugar);
        }

        [TestMethod]

        public void TestMethod4()
        {
            Player player = new Player();
            Store store = new Store(player);
            double expectedResult = .50;
            string input = "5";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            store.buyIceCubes();

            Assert.AreEqual(expectedResult, player.totalCostIce);
        }

        [TestMethod]

        public void TestMethod5()
        {
            Player player = new Player();
            Store store = new Store(player);
            double expectedResult = .50;
            string input = "5";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            store.buyCups();

            Assert.AreEqual(expectedResult, player.totalCostCups);
        }
    }
}

    


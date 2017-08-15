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

        [TestMethod]

        public void TestMethod6()
        {
            Random random = new Random();
            Weather weather = new Weather();
            weather.getTemp();
            int expectedResult = random.Next(50, 100);

            Assert.AreEqual(expectedResult, weather.temp);
        }

        [TestMethod]

        public void TestMethod7()
        {
            Lemons lemons = new Lemons();
            double expectedResult = .25;

            Assert.AreEqual(expectedResult, lemons.price);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Sugar sugar = new Sugar();
            double expectedResult = .50;

            Assert.AreEqual(expectedResult, sugar.price);
        }

        [TestMethod]
        public void TestMethod9()
        {
            IceCubes ice = new IceCubes();
            double expectedResult = .10;

            Assert.AreEqual(expectedResult, ice.price);
        }

        [TestMethod]

        public void TestMethod10()
        {
            Cups cups = new Cups();
            double expectedResult = .10;

            Assert.AreEqual(expectedResult, cups.price);
        }
    }
}









    

    


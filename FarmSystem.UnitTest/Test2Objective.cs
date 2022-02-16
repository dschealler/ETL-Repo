using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FarmSystem.Test1;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test2Objective
    {
        [TestMethod]
        public void CowNoise()
        {
            string expected = "Cow says Moo!";

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            string actual = cow.MakeNoise();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HenNoise()
        {
            string expected = "Hen says CLUCKAAAAAWWWWK!";

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            string actual = hen.MakeNoise();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HorseNoise()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Horse says Neigh!";

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            string actual = horse.MakeNoise();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SheepNoise()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Sheep says baa!";

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            string actual = sheep.MakeNoise();

            Assert.AreEqual<string>(expected, actual);
        }
    }
}

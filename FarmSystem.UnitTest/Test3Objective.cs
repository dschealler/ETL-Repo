using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FarmSystem.Test1;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test3Objective
    {
        [TestMethod]
        public void IsCowMilkable()
        {
            bool expected = true;

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            bool actual = cow.IsMilkable();

            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void MilkCow()
        {
            string expected = "Cow was milked!";

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            string actual = cow.Milk();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HenNoise()
        {
            bool expected = false;

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            bool actual = hen.IsMilkable();

            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void MilkHen()
        {
            string expected = "Hen cannot be milked.";

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            string actual = hen.Milk();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HorseNoise()
        {
            bool expected = false;

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            bool actual = horse.IsMilkable();

            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void MilkHorse()
        {
            string expected = "Horse cannot be milked.";

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            string actual = horse.Milk();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SheepNoise()
        {
            bool expected = false;

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            bool actual = sheep.IsMilkable();

            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void MilkSheep()
        {
            string expected = "Sheep cannot be milked.";

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            string actual = sheep.Milk();

            Assert.AreEqual<string>(expected, actual);
        }
    }
}

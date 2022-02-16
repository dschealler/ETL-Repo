using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FarmSystem.Test1;
using FarmSystem.Test2;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test3Objective
    {
        [TestMethod]
        public void CanMilkCow()
        {
            string expected = "Cow was milked!";

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;

            var milkableAnimal = cow as IMilkableAnimal;
            Assert.IsNotNull(milkableAnimal);

            string actual = milkableAnimal.ProduceMilkLine();

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void CannotMilkHen()
        {
            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;

            var milkableAnimal = hen as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }

        [TestMethod]
        public void CannotMilkHorse()
        {
            var horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;

            var milkableAnimal = horse as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }

        [TestMethod]
        public void CannotMilkSheep()
        {
            var sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;

            var milkableAnimal = sheep as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }
    }
}

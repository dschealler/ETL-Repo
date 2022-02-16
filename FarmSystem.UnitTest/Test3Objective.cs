using FarmSystem.Test1;
using FarmSystem.Test2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test3Objective
    {
        [TestMethod]
        public void CanMilkCow()
        {
            string expected = "Cow was milked!";

            var animal = new Cow();
            var milkableAnimal = animal as IMilkableAnimal;
            Assert.IsNotNull(milkableAnimal);

            string actual = milkableAnimal.ProduceMilkLine();
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void CannotMilkHen()
        {
            var animal = new Hen();
            var milkableAnimal = animal as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }

        [TestMethod]
        public void CannotMilkHorse()
        {
            var animal = new Horse();
            var milkableAnimal = animal as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }

        [TestMethod]
        public void CannotMilkSheep()
        {
            var animal = new Sheep();
            var milkableAnimal = animal as IMilkableAnimal;
            Assert.IsNull(milkableAnimal);
        }
    }
}

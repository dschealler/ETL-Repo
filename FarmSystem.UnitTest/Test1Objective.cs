using FarmSystem.Test1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test1Objective
    {
        [TestMethod]
        public void EnterCow()
        {
            string expected = "Cow has entered the farm";

            var animal = new Cow();

            var farm = new EmydexFarmSystem();
            string actual = farm.EnterLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterHen()
        {
            string expected = "Hen has entered the farm";

            var animal = new Hen();

            var farm = new EmydexFarmSystem();
            string actual = farm.EnterLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterHorse()
        {
            string expected = "Horse has entered the farm";

            var animal = new Horse();

            var farm = new EmydexFarmSystem();
            string actual = farm.EnterLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterSheep()
        {
            string expected = "Sheep has entered the farm";

            var animal = new Sheep();

            var farm = new EmydexFarmSystem();
            string actual = farm.EnterLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }
    }
}

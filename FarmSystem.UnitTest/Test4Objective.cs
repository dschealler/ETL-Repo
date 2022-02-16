using FarmSystem.Test1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test4Objective
    {
        [TestMethod]
        public void CowLeaves()
        {
            string expected = "Cow has left the farm";

            var animal = new Cow();

            var farm = new EmydexFarmSystem();
            string actual = farm.LeaveLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HenLeaves()
        {
            string expected = "Hen has left the farm";

            var animal = new Hen();

            var farm = new EmydexFarmSystem();
            string actual = farm.LeaveLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HorseLeaves()
        {
            string expected = "Horse has left the farm";

            var animal = new Horse();

            var farm = new EmydexFarmSystem();
            string actual = farm.LeaveLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SheepLeaves()
        {
            string expected = "Sheep has left the farm";

            var animal = new Sheep();

            var farm = new EmydexFarmSystem();
            string actual = farm.LeaveLine(animal);

            Assert.AreEqual<string>(expected, actual);
        }
    }
}

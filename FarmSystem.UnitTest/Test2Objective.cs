using FarmSystem.Test1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test2Objective
    {
        [TestMethod]
        public void CowNoise()
        {
            string expected = "Cow says Moo!";

            var animal = new Cow();
            string actual = animal.TalkLine();
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HenNoise()
        {
            string expected = "Hen says CLUCKAAAAAWWWWK!";

            var animal = new Hen();
            string actual = animal.TalkLine();
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void HorseNoise()
        {
            string expected = "Horse says Neigh!";

            var animal = new Horse();
            string actual = animal.TalkLine();
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SheepNoise()
        {
            string expected = "Sheep says baa!";

            var animal = new Sheep();
            string actual = animal.TalkLine();
            Assert.AreEqual<string>(expected, actual);
        }
    }
}

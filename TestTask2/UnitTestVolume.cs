using Task2;

namespace TestTask2
{
    [TestClass]
    public class UnitTestVolume
    {
        [TestMethod]
        public void TestVolume10()
        {
            TSphere sphere = new(10);

            double expected = (4 * Math.PI * 10 * 10 * 10) / 3.0;
            double actual = sphere.GetVolume();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestVolumeNegative10()
        {
            TSphere sphere = new(-10);

            double expected = (4 * Math.PI * 10 * 10 * 10) / 3.0;
            double actual = sphere.GetVolume();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestVolume5dot5()
        {
            TSphere sphere = new(5.5);

            double expected = (4 * Math.PI * 5.5 * 5.5 * 5.5) / 3.0;
            double actual = sphere.GetVolume();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestVolumeByDefault()
        {
            TSphere sphere = new(0);

            double expected = (4 * Math.PI * 1) / 3.0;
            double actual = sphere.GetVolume();

            Assert.AreEqual(expected, actual);
        }
    }
}

using Task2;

namespace TestTask2
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestCircleSquare1()
        {
            TCircle circle = new();

            double expected = Math.PI * 1;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCircleSquareDefault()
        {
            TCircle circle = new(0);

            double expected = Math.PI * 1;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestCircleSquare5()
        {
            TCircle circle = new(5);

            double expected = Math.PI * 5 * 5;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCircleSquareNegative5()
        {
            TCircle circle = new(-5);

            double expected = Math.PI * 5 * 5;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSphereSquare10()
        {
            TSphere sphere = new(10);

            double expected = 4*Math.PI *10*10;
            double actual = sphere.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSphereSquareNegative10()
        {
            TSphere sphere = new(-10);

            double expected = 4 * Math.PI * 10 * 10;
            double actual = sphere.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSphereSquareDefault()
        {
            TSphere sphere = new(0);

            double expected = 4 * Math.PI * 1;
            double actual = sphere.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
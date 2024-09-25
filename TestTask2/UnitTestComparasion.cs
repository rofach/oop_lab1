using Task2;

namespace TestTask2
{
    [TestClass]
    public class UnitTestComparasion
    {
        [TestMethod]
        public void TestCircleComparasionSmaller()
        {
            TCircle circle1 = new(-1);
            TCircle circle2 = new(1);

            int expected = 0;
            int actual = circle1.CompareTo(circle2);

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void TestCircleComparasionBigger()
        {
            TCircle circle1 = new(2);
            TCircle circle2 = new(1);

            int expected = 1;
            int actual = circle1.CompareTo(circle2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCircleComparasionEqual()
        {
            TCircle circle1 = new();
            TCircle circle2 = new();

            int expected = 0;
            int actual = circle1.CompareTo(circle2);

            Assert.AreEqual(expected, actual);
        }

        public void TestSphereComparasionSmaller()
        {
            TCircle sphere1 = new(1);
            TCircle sphere2 = new(2);

            int expected = -1;
            int actual = sphere1.CompareTo(sphere2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSphereComparasionBigger()
        {
            TCircle sphere1 = new(2);
            TCircle sphere2 = new(1);

            int expected = 1;
            int actual = sphere1.CompareTo(sphere2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSphereComparasionEqual()
        {
            TCircle sphere1 = new();
            TCircle sphere2 = new();

            int expected = 0;
            int actual = sphere1.CompareTo(sphere2);

            Assert.AreEqual(expected, actual);
        }


    }
}
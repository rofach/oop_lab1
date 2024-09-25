

namespace Task1
{
    [TestClass]
    public class UnitTestQuadraticEquation
    {
        [TestMethod]
        public void TestNull()
        {
            QuadraticEquation qe = new(1, 1, 1);
            double? expected = null;
            double? actual = qe[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOneSolution()
        {
            QuadraticEquation qe = new(1, -2, 1);
            double expected = 1;
            double? actual = qe[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFirstSolution()
        {
            QuadraticEquation qe = new(1, -2, -8);
            double expected = -2;
            double? actual = qe[0];
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSecondSolution()
        {
            QuadraticEquation qe = new(1, -2, -8);
            double expected = 4;
            double? actual = qe[1];
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestNegativeCoeffA_FirstSolution()
        {
            QuadraticEquation qe = new(-1, 2, 0);
            double expected = 2;
            double? actual = qe[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNegativeCoeffA_SecondSolution()
        {
            QuadraticEquation qe = new(-1, 2, 0);
            double expected = 0;
            double? actual = qe[1];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "a cant`t equal 0")]

        public void TestExeption()
        {
            QuadraticEquation qe = new(0, 0, 0);
        }
    }
}
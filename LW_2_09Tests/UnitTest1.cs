using Microsoft.VisualStudio.TestTools.UnitTesting;
using LW_2_09;
using System.Linq;

namespace LW_2_09Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor()
        {
            Uravnenie t = new(-5, 7, 1);

            Assert.AreEqual(t, new Uravnenie(-5, 7, 1));
        }

        // non static
        [TestMethod]
        public void AllCoefficientTwoSolution()
        {
            Uravnenie t = new(4, 10, 4);
            double[] expected = { -0.5, -2 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void AllCoefficientOneSolution()
        {
            Uravnenie t = new(4, 8, 4);
            double[] expected = { -1 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void AllCoefficientZeroSolution()
        {
            Uravnenie t = new(4, 1, 4);
            double[] expected = null;

            Assert.AreEqual(t.Solution(), expected);
        }

        [TestMethod]
        public void CoefficientABSolution()
        {
            Uravnenie t = new(4, 8, 0);
            double[] expected = { 0, -2 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void CoefficientACSolution()
        {
            Uravnenie t = new(4, 0, -4);
            double[] expected = { 1, -1 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void CoefficientBCSolution()
        {
            Uravnenie t = new(0, 4, 4);
            double[] expected = { -1 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void CoefficientASolution()
        {
            Uravnenie t = new(16, 0, 0);
            double[] expected = { 4, -4 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void CoefficientBSolution()
        {
            Uravnenie t = new(0, 5, 0);
            double[] expected = { 0 };

            Assert.IsTrue(AreArraysEqual(t.Solution(), expected));
        }

        [TestMethod]
        public void CoefficientCSolution()
        {
            Uravnenie t = new(0, 0, -9);
            double[] expected = null;

            Assert.AreEqual(t.Solution(), expected);
        }

        // static
        [TestMethod]
        public void StaticAllCoefficientTwoSolution()
        {
            double[] expected = { -0.5, -2 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(4, 10, 4), expected));
        }

        [TestMethod]
        public void StaticAllCoefficientOneSolution()
        {
            double[] expected = { -1 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(4, 8, 4), expected));
        }

        [TestMethod]
        public void StaticAllCoefficientZeroSolution()
        {
            double[] expected = null;

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(4, 1, 4), expected));
        }

        [TestMethod]
        public void StaticCoefficientABSolution()
        {
            double[] expected = { 0, -2 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(4, 8, 0), expected));
        }

        [TestMethod]
        public void StaticCoefficientACSolution()
        {
            double[] expected = { 1, -1 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(4, 0, -4), expected));
        }

        [TestMethod]
        public void StaticCoefficientBCSolution()
        {
            double[] expected = { -1 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(0, 4, 4), expected));
        }

        [TestMethod]
        public void StaticCoefficientASolution()
        {
            double[] expected = { 4, -4 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(16, 0, 0), expected));
        }

        [TestMethod]
        public void StaticCoefficientBSolution()
        {
            double[] expected = { 0 };

            Assert.IsTrue(AreArraysEqual(Uravnenie.Solution(0, 5, 0), expected));
        }

        [TestMethod]
        public void StaticCoefficientCSolution()
        {
            double[] expected = null;

            Assert.AreEqual(Uravnenie.Solution(0, 0, -9), expected);
        }

        private bool AreArraysEqual(double[] ar1, double[] ar2)
        {
            if (ar1 == ar2) return true;

            if (ar1 != null && ar2 != null && ar1.Length == ar2.Length)
            {
                bool f = true;
                for (int i = 0; i < ar1.Length && f; i++)
                {
                    f = ar1[i] == ar2[i];
                }
                return f;
            }
            else
            {
                return false;
            }
        }
    }
}

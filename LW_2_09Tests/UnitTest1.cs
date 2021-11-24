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
            Uravnenie t = new(-5, -7, -1);

            Assert.IsTrue(AreUravneniasEqual(t, new Uravnenie(-5, -7, -1)));
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
        public void TestGetCounter()
        {
            Uravnenie t = new(-5, -7, -1);

            Assert.IsTrue(Uravnenie.GetCounter() == Uravnenie.GetCounter());
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

        //
        [TestMethod]
        public void TestOutput()
        {
            Uravnenie t = new(-5, 7, 1);

            Assert.AreEqual("-5x^2+7x+1=0", t.ToString());
        }

        // inc dec
        [TestMethod]
        public void Increment()
        {
            Uravnenie t = new(-5, 7, 1);
            Uravnenie expected = new(-4, 8, 2);
            t++;

            Assert.IsTrue(AreUravneniasEqual(expected, t));
        }

        [TestMethod]
        public void Decrement()
        {
            Uravnenie t = new(-5, 7, 1);
            Uravnenie expected = new(-6, 6, 0);
            t--;

            Assert.IsTrue(AreUravneniasEqual(expected, t));
        }

        private bool AreUravneniasEqual(Uravnenie t1, Uravnenie t2)
        {
            return t1.ToString() == t2.ToString();
        }

        // == !=
        [TestMethod]
        public void Equal1()
        {
            Uravnenie t1 = new(-5, 7, 1);
            Uravnenie t2 = new(-5, 7, 1);

            Assert.IsTrue(t1 == t2);
        }

        [TestMethod]
        public void NotEqual1()
        {
            Uravnenie t1 = new(-5, 7, 1);
            Uravnenie t2 = new(-5, 8, 1);

            Assert.IsFalse(t1 == t2);
        }

        [TestMethod]
        public void Equal2()
        {
            Uravnenie t1 = new(-5, 7, 1);
            Uravnenie t2 = new(-5, 8, 1);

            Assert.IsTrue(t1 != t2);
        }

        [TestMethod]
        public void NotEqual2()
        {
            Uravnenie t1 = new(-5, 7, 1);
            Uravnenie t2 = new(-5, 7, 1);

            Assert.IsFalse(t1 != t2);
        }

        // type to other type
        [TestMethod]
        public void ToDouble()
        {
            Uravnenie t = new(4, 0, -4);
            double expected = 1;

            Assert.AreEqual(expected, (double)t);
        }

        [TestMethod]
        public void ToDouble2()
        {
            Uravnenie t = new(4, 1, 4);
            double expected = 0;

            Assert.AreEqual(expected, (double)t);
        }

        [TestMethod]
        public void ToBool()
        {
            Uravnenie t = new(4, 0, -4);
            bool t2 = t;
            bool expected = true;

            Assert.AreEqual(expected, t2);
        }

        // === uravnenie array ===
        [TestMethod]
        public void TestArrayConstructorWithInt()
        {
            UravnenieArray t = new(5);

            Assert.AreEqual(5, t.GetSize());
        }

        [TestMethod]
        public void TestArrayConstructorEmpty()
        {
            UravnenieArray t = new();

            Assert.AreEqual(0, t.GetSize());
        }

        [TestMethod]
        public void TestArrayConstructorWithArray()
        {
            double[][] data= { new double[]{ 5, 1, 1 }, new double[]{ 4, 8, 4 } };
            UravnenieArray t = new(data);

            Assert.AreEqual(2, t.GetSize());
        }

        [TestMethod]
        public void TestGetIndexator()
        {
            double[][] data = { new double[] { 5, 1, 1 }, new double[] { 4, 1, 4 } };
            UravnenieArray t = new(data);

            Uravnenie expected = new(5, 1, 1);

            Assert.IsTrue(AreUravneniasEqual(expected, t[0]));
        }

        [TestMethod]
        public void TestGetEmptyIndexator()
        {
            UravnenieArray t = new();


            Assert.AreEqual(null, t[9]);
        }

        [TestMethod]
        public void TestSetIndexator()
        {
            UravnenieArray t = new(10);
            Uravnenie t2 = new(5, 1, 1);

            t[6] = t2;

            Assert.IsTrue(AreUravneniasEqual(t2, t[6]));
        }

        [TestMethod]
        public void TestGetSize()
        {
            UravnenieArray t = new(5);

            int expected = 5;

            Assert.AreEqual(expected, t.GetSize());
        }

        [TestMethod]
        public void TestArrayPrint()
        {
            double[][] sets = { new double[] { 1, 5, 6 }, new double[] { 7, 2, 9 } };
            UravnenieArray t = new(sets);

            Assert.AreEqual(t.ToString(), "1x^2+5x+6=0\n7x^2+2x+9=0\n");
        }

        [TestMethod]
        public void TestEmptyArrayPrint()
        {
            UravnenieArray t = new();

            Assert.AreEqual(t.ToString(), "Массив пуст");
        }
    }
}

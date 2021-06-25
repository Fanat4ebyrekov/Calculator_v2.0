using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Calculator_v2._0.Others.Calcul;

namespace TestCalcul
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plus22and11res33()
        {
            double num1 = 22;
            double num2 = 11;
            double ex = 33;

            double res = Plus(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void PlusM22and11res33()
        {
            double num1 = -22;
            double num2 = 11;
            double ex = -11;

            double res = Plus(num1, num2);

            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void PlusM22andM11resM33()
        {
            double num1 = -22;
            double num2 = -11;
            double ex = -33;

            double res = Plus(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Minus22and11res11()
        {
            double num1 = 22;
            double num2 = 11;
            double ex = 11;

            double res = Minus(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Minus22andM11res33()
        {
            double num1 = 22;
            double num2 = -11;
            double ex = 33;

            double res = Minus(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void MinusM22andM11resM11()
        {
            double num1 = -22;
            double num2 = -11;
            double ex = -11;

            double res = Minus(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Mult22and11res11()
        {
            double num1 = 22;
            double num2 = 11;
            double ex = 242;

            double res = Multiply(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void MultM22and11res11()
        {
            double num1 = -22;
            double num2 = 11;
            double ex = -242;

            double res = Multiply(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Mult22andM11res11()
        {
            double num1 = 22;
            double num2 = -11;
            double ex = -242;

            double res = Multiply(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Mult22and0res0()
        {
            double num1 = 22;
            double num2 = 0;
            double ex = 0;

            double res = Multiply(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void MultM22and0res0()
        {
            double num1 = -22;
            double num2 = 0;
            double ex = 0;

            double res = Multiply(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Divide22and11res2()
        {
            string num1 = "22";
            string num2 = "11";
            string ex = "2";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void DivideM22and11resM2()
        {
            string num1 = "-22";
            string num2 = "11";
            string ex = "-2";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Divide22andM11resM2()
        {
            string num1 = "22";
            string num2 = "-11";
            string ex = "-2";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Divide0and11res0()
        {
            string num1 = "0";
            string num2 = "11";
            string ex = "0";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Divide22and0resError()
        {
            string num1 = "22";
            string num2 = "0";
            string ex = "Ошибка";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Divide0and0resError()
        {
            string num1 = "0";
            string num2 = "0";
            string ex = "Ошибка";

            string res = Divide(num1, num2);

            Assert.AreEqual(ex, res);
        }


        [TestMethod]
        public void Pow2and5res32()
        {
            double num1 = 2;
            double num2 = 5;
            double ex = 32;

            double res = Pow(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Pow2andM2res025()
        {
            double num1 = 2;
            double num2 = -2;
            string ex = "0,25";

            string res = Convert.ToString(Pow(num1, num2));

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Pow2and1res2()
        {
            double num1 = 2;
            double num2 = 1;
            double ex = 2;

            double res = Pow(num1, num2);

            Assert.AreEqual(ex, res);
        }

        [TestMethod]
        public void Pow2and0res1()
        {
            double num1 = 2;
            double num2 = 0;
            double ex = 1;

            double res = Pow(num1, num2);

            Assert.AreEqual(ex, res);
        }


    }
}

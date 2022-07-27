using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Calculator;

namespace UnitTestProject_Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3563, 45, 160335)]
        [DataRow(-7895, -948, 7484460)]
        [DataRow(0, 0, 0)]
        [DataRow(395, 123456, 48765120)]
        [DataRow(45739, 4934, 225676226)]
        [DataRow(-583, 3295, -1920985)]
        public void exceedNumericTypeRange_MethodUnitTest(int a, int b, int result) 
        {
            Assert.IsTrue(a <= 2147483647);
            Assert.IsTrue(a >= -2147483648);

            Assert.IsTrue(b <= 2147483647);
            Assert.IsTrue(b >= -2147483648);

            Assert.IsTrue(result <= 2147483647);
            Assert.IsTrue(result >= -2147483648);
        }

        [TestMethod]
        [DataRow(-14651, 431553)]
        [DataRow(-3, -3)]
        [DataRow(47375, 947170)]
        [DataRow(9876542, 1234567)]
        [DataRow(0, 0)]
        [DataRow(395, 123456)]
        public void checkNumbersType_MethodUnitTest(int a, int b)
        {
            Assert.AreEqual((int)a, a);
            Assert.AreEqual((int)b, b);
        }

        [TestMethod]
        [DataRow("/", 475, 5)]
        [DataRow("/", 12, 6)]
        [DataRow("/", 707004, 123)]
        [DataRow("/", 325856, 9584)]
        public void dividerNotZero_MethodUnitTest(string op, int a, int b)
        {
            int unexpectedDividerValue = 0;
            Assert.AreNotEqual(unexpectedDividerValue, b);
        }

        [TestMethod]
        [DataRow(0, 0 , 0)]
        [DataRow(48730, 4511114, 4559844)]
        [DataRow(1, 1, 2)]
        [DataRow(1, 2147483646, 2147483647)]
        [DataRow(11, 3857284, 3857295)]
        [DataRow(-458375, -41, -458416)]
        [DataRow(-14, 47274, 47260)]
        public void addition_MethodUnitTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Program.add(a, b));
        }

        [TestMethod]
        [DataRow(57365, 584737, -527372)]
        [DataRow(41, 9, 32)]
        [DataRow(0, 0, 0)]
        [DataRow(0, 666483, -666483)]
        [DataRow(14514837, 7, 14514830)]
        [DataRow(3857, -74125, 77982)]
        public void substraction_MethodUnitTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Program.sub(a, b));
        }

        [TestMethod]
        [DataRow(3563, 45, 160335)]
        [DataRow(-7895, -948, 7484460)]
        [DataRow(0, 0, 0)]
        [DataRow(395, 123456, 48765120)]
        [DataRow(45739, 4934, 225676226)]
        [DataRow(-583, 3295, -1920985)]
        public void multiplication_MethodUnitTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Program.multiplication(a, b));
        }

        [TestMethod]
        [DataRow(0, 6, 0)]
        [DataRow(5, 15, 0.33)]
        [DataRow(-45, -9, 5)]
        [DataRow(85437512, 2, 42718756)]
        [DataRow(2454660, 5245, 468)]
        [DataRow(148225, 385, 385)]
        [DataRow(5847, 56, 104.41)]
        public void division_MethodUnitTest(int a, int b, double result)
        {
            Assert.AreEqual(result, Math.Round(Program.division(a, b), 2, MidpointRounding.AwayFromZero));
        }
    }
}

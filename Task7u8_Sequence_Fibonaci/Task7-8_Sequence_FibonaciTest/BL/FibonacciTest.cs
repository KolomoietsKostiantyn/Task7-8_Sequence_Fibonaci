using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7u8_Sequence_Fibonaci.BL;

namespace Task7_8_Sequence_FibonaciTest.BL
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void GetEnumerator_ValidData_OK()
        {
            uint start = 5;
            uint end = 50;
            uint[] expected = { 5u, 8u, 13u, 21u, 34u};

            Fibonacci fibonacci = new Fibonacci(start, end);

            int i = 0;
            foreach (uint item in fibonacci)
            {
                Assert.AreEqual(item, expected[i]);
                i++;
            }
        }
    }
}

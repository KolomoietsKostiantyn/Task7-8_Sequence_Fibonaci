using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7u8_Sequence_Fibonaci.BL;

namespace Task7_8_Sequence_FibonaciTest.BL
{
    [TestClass]
    public class SequenceTest
    {
        [TestMethod]
        public void GetEnumerator_ValidData_OK()
        {
            uint num = 15;

            uint[] expected = { 1u, 2u, 3u};

            Sequence fibonacci = new Sequence(num);

            int i = 0;
            foreach (uint item in fibonacci)
            {
                Assert.AreEqual(item, expected[i]);
                i++;
            }
        }
    }
}

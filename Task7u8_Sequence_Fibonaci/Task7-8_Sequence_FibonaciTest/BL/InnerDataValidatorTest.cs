using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7u8_Sequence_Fibonaci.BL;

namespace Task7_8_Sequence_FibonaciTest.BL
{
    [TestClass]
    public class InnerDataValidatorTest
    {
        [TestMethod]
        public void ValidateInputArray_NullReserense_Falfe()
        {
            string[] array = null;

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);
            bool result = parser.ValidateInputArray(array);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateInputArray_TooLongArray_False()
        {
            string[] array = new string[] { "q", "s", "33", " 55", "44" };

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ValidateInputArray(array);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateInputArray_OneArrayElementIsNull_False()
        {
            string[] array = new string[] { "q", null };

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ValidateInputArray(array);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateInputArray_OneArrayElementIsWhiteSpace_False()
        {
            string[] array = new string[] { "q", " " };

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ValidateInputArray(array);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateInputArray_OneArrayElementIsEmpty_False()
        {
            string[] array = new string[] { "q", string.Empty };

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ValidateInputArray(array);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateInputArray_ValidData_True()
        {
            string[] array = new string[] { "q", "s" };

            uint minlenth = 1;
            uint maxlenth = 2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ValidateInputArray(array);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(new string[] {" "})]
        [DataRow(new string[] { "" })]
        [DataRow(new string[] { null })]
        public void ConvertArrayToParamsOneParam_IncorectArray_False(string[] inner)
        {
            uint minlenth = 1;
            uint maxlenth = 2;
            uint num;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ConvertArrayToParams(inner, out num);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(new string[] { "5" }, 5u)]
        [DataRow(new string[] { "0" }, 0u)]
        public void ConvertArrayToParamsOneParam_ValidData_True(string[] inner, uint expected)
        {
            uint minlenth = 1;
            uint maxlenth = 2;
            uint num;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ConvertArrayToParams(inner, out num);

            Assert.IsTrue(result);

            Assert.AreEqual(num, expected);
        }

        [TestMethod]
        [DataRow(new string[] { " ", "12" })]
        [DataRow(new string[] { "", "12" })]
        [DataRow(new string[] { null, "12" })]
        public void ConvertArrayToParamsTwoParam_IncorectArray_False(string[] inner)
        {
            uint minlenth = 1;
            uint maxlenth = 2;
            uint num1;
            uint num2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ConvertArrayToParams(inner, out num1, out num2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(new string[] { "5", "12" }, 5u, 12u)]
        [DataRow(new string[] { "0", "0" }, 0u, 0u)]
        public void ConvertArrayToParamsTwoParam_ValidData_True(string[] inner, uint expected1, uint expected2)
        {
            uint minlenth = 1;
            uint maxlenth = 2;
            uint num1;
            uint num2;
            InnerDataValidator parser = new InnerDataValidator(minlenth, maxlenth);

            bool result = parser.ConvertArrayToParams(inner, out num1, out num2);

            Assert.IsTrue(result);

            Assert.AreEqual(num1, expected1);
            Assert.AreEqual(num2, expected2);
        }
    }
}

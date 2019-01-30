using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Task7u8_Sequence_Fibonaci.BL;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7_8_Sequence_FibonaciTest.BL
{
    [TestClass]
    public class AlgoritmSelectorTest
    {
        [TestMethod]
        public void Select_IncorectInnerArray_Null()
        {
            uint minLenth = 1;
            uint maxLenth = 2;
            string[] array = null;
            Mock<IInnerDataValidator> validator = new Mock<IInnerDataValidator>();

            validator.Setup(x => x.ValidateInputArray(It.Is<string[]>(val => val == null))).Returns(false);
            AlgoritmSelector algoritmSelector = new AlgoritmSelector(validator.Object, minLenth, maxLenth);

            IAlgorithm result = algoritmSelector.Select(array);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Select_ValidArrayLenthOne_SequenceScript()
        {
            uint minLenth = 1;
            uint maxLenth = 2;
            uint num = 1;
            string[] array = {"3"};
            AlgorithmName expected = AlgorithmName.Sequence;
            Mock<IInnerDataValidator> validator = new Mock<IInnerDataValidator>();

            validator.Setup(x => x.ValidateInputArray(It.IsAny<string[]>())).Returns(true);
            validator.Setup(x => x.ConvertArrayToParams(It.IsAny<string[]>(), out num)).Returns(true);
            AlgoritmSelector algoritmSelector = new AlgoritmSelector(validator.Object, minLenth, maxLenth);

            IAlgorithm result = algoritmSelector.Select(array);

            Assert.AreEqual(result.Name, expected);
        }

        [TestMethod]
        public void Select_ValidArrayLenthTwo_FibonacciScript()
        {
            uint minLenth = 1;
            uint maxLenth = 2;
            uint num1 = 1;
            uint num2 = 1;
            string[] array = { "3" };
            AlgorithmName expected = AlgorithmName.Fibonacci;
            Mock<IInnerDataValidator> validator = new Mock<IInnerDataValidator>();

            validator.Setup(x => x.ValidateInputArray(It.IsAny<string[]>())).Returns(true);
            validator.Setup(x => x.ConvertArrayToParams(It.IsAny<string[]>(), out num1, out num2)).Returns(true);
            AlgoritmSelector algoritmSelector = new AlgoritmSelector(validator.Object, minLenth, maxLenth);

            IAlgorithm result = algoritmSelector.Select(array);

            Assert.AreEqual(result.Name, expected);
        }

    }
}

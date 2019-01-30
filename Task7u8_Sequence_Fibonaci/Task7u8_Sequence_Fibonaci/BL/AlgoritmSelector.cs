using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.BL
{
    public class AlgoritmSelector : IAlgoritmSelector
    {
        uint _minLenth;
        uint _maxLenth;
        IInnerDataValidator _validator;

        public AlgoritmSelector(IInnerDataValidator validator, uint minLenth, uint maxLenth)
        {
            _minLenth = minLenth;
            _maxLenth = maxLenth;
            _validator = validator;
        }

        public IAlgorithm Select(string[] array)
        {
            if (!_validator.ValidateInputArray(array))
            {
                return null;
            }

            if (array.Length == _minLenth)
            {
                uint numS;
                if (_validator.ConvertArrayToParams(array,out numS))
                {
                    return new Sequence(numS);
                }
            }
            uint num1;
            uint num2;
            if (_validator.ConvertArrayToParams(array, out num1, out num2))
            {
                return new Fibonacci(Math.Min(num1, num2), Math.Max(num1, num2));
            }

            return null;
        }
    }
}

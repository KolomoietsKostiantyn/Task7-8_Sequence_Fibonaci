using System;
using System.Collections.Generic;
using System.Text;

namespace Task7u8_Sequence_Fibonaci.BL
{
    public class InnerDataValidator: IInnerDataValidator
    {
        private uint _minLenth;
        private uint _maxLenth;

        public InnerDataValidator(uint minLenth, uint maxLenth)
        {
            _minLenth = minLenth;
            _maxLenth = maxLenth;
        }

        public bool ValidateInputArray(string[] arr)
        {
            bool result = true;
            if (arr == null)
            {
                return false;
            }

            if (arr.Length < _minLenth || arr.Length > _maxLenth)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(arr[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public bool ConvertArrayToParams(string[] arr, out uint num1)
        {
            num1 = 0;
            if (!ValidateInputArray(arr))
            {
                return false;
            }

            bool result = true;
            if (!uint.TryParse(arr[0], out num1))
            {
                result = false;
            }

            return result;
        }

        public bool ConvertArrayToParams(string[] arr, out uint num1, out uint num2)
        {
            num1 = 0;
            num2 = 0; 
            if (!ValidateInputArray(arr))
            {
                return false;
            }

            bool result = true;
            if (!uint.TryParse(arr[0], out num1))
            {
                result = false;
            }
            if (!uint.TryParse(arr[1], out num2))
            {
                result = false;
            }

            return result;
        }
    }
}
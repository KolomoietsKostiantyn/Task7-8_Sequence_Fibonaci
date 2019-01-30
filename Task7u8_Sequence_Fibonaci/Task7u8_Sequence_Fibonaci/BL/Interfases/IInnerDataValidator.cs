using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7u8_Sequence_Fibonaci.BL
{
    public interface IInnerDataValidator
    {
        bool ValidateInputArray(string[] arr);
        bool ConvertArrayToParams(string[] arr, out uint num1);
        bool ConvertArrayToParams(string[] arr, out uint num1, out uint num2);
    }
}

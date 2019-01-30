using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.Intermediate
{
    public interface IAlgorithm
    {
        IEnumerator<uint> GetEnumerator();
        AlgorithmName Name { get; }
    }
}

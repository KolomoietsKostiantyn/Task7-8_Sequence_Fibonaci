using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.BL
{
    public class Sequence : IAlgorithm
    {

        public AlgorithmName Name
        {
            get;
            private set;
        }

        public uint Counts
        {
            get;
            private set;
        }

        public Sequence(uint num)
        {
            Counts = (uint)Math.Sqrt(num);
            Name = AlgorithmName.Sequence;
        }

        public IEnumerator<uint> GetEnumerator()
        {
            for (uint i = 1; i <= Counts; i++)
            {
                yield return i;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.BL
{
    public class Fibonacci : IAlgorithm
    {
        uint _a = 0;
        uint _b = 1;
        uint _start;
        uint _end;

        public Fibonacci(uint start, uint end)
        {
            _start = start;
            _end = end;
            Name = AlgorithmName.Fibonacci;
            ObjectPreparation();
        }

        private void ObjectPreparation()
        {
            uint i;
            while ((_a + _b) < _start)
            {
                i = _a + _b;
                _a = _b;
                _b = i;
            }
        }

        public AlgorithmName Name
        {
            get;
            private set;
        }

        public IEnumerator<uint> GetEnumerator()
        {
            while ((_a + _b) < _end)
            {
                uint i = (_a + _b);
                yield return i;
                _a = _b;
                _b = i;
            }
        }
    }
}

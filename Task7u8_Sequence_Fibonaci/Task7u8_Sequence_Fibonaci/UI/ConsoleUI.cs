using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.UI
{
    class ConsoleUI : IVisualizer
    {
        string instruction = "If you want to get numbers in the Fibonichi series, set the numeric range " +
            "to 2 numbers.Otherwise, specify one number and get a series of natural numbers whose square " +
            "is less than the specified number.";

        public void ResiveAnswer(IAlgorithm algorithm)
        {
            Console.WriteLine(string.Format("Number resived by {0} algoritm:\n", algorithm.Name));

            bool flag = true;
            foreach (uint item in algorithm)
            {
                if (flag)
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(", {0}", item);
                }
                flag = false;
            }

            Console.ReadKey();
        }

        public void ShowInstruction()
        {
            Console.WriteLine(instruction);
            Console.ReadKey();
        }
    }
}

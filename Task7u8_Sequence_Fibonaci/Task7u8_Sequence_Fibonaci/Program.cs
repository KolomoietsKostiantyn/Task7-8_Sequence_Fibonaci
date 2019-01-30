using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.BL;
using Task7u8_Sequence_Fibonaci.Intermediate;
using Task7u8_Sequence_Fibonaci.UI;

namespace Task7u8_Sequence_Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint maxValidLenth = 2;
            uint minValidLenth = 1;

            IVisualizer visualizer = new ConsoleUI();
            IInnerDataValidator innerDataValidator = new InnerDataValidator(minValidLenth, maxValidLenth);
            IAlgoritmSelector algoritmSelector = new AlgoritmSelector(innerDataValidator, minValidLenth, maxValidLenth);

            Controller controller = new Controller(args, visualizer, algoritmSelector);

            controller.Start();

        }
    }
}

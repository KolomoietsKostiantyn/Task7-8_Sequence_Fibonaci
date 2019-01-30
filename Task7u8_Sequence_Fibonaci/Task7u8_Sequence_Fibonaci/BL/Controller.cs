using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7u8_Sequence_Fibonaci.Intermediate;

namespace Task7u8_Sequence_Fibonaci.BL
{
    class Controller
    {
        IVisualizer _visualizer;
        string[] _arr;
        IAlgoritmSelector _algoritmSelector;
        IAlgorithm _algorithm;

        public Controller(string[] arr, IVisualizer visualizer, IAlgoritmSelector algoritmSelector)
        {
            _arr = arr;
            _visualizer = visualizer;
            _algoritmSelector = algoritmSelector;
        }


        public void Start()
        {
            _algorithm = _algoritmSelector.Select(_arr);
            if (_algorithm != null)
            {
                _visualizer.ResiveAnswer(_algorithm);
            }
            else
            {
                _visualizer.ShowInstruction();
            }
        }


    }
}

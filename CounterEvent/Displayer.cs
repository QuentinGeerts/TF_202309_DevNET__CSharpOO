using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterEvent
{
    internal class Displayer
    {
        public void DisplayNewValue (int  newValue)
        {
            Console.WriteLine($"Nouvelle valeur du compteur { newValue }");
        }
    }
}

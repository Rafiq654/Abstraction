using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaction.Interface
{
    public class Singa : IHewan
    {
        public void Berjalan()
        {
            Console.WriteLine("Singa merupakan Hewan berkaki 4");
            Console.WriteLine("Ia merupakan Hewan Karnivora ");
        }
    }
}

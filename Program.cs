using System;




//using Abstaction.AbstractClass;
using Abstaction.Interface;

namespace Abstaction
{
    class Program
    {
        static void Main(string[] args)
        {
            IHewan hewan;

            hewan = new Sapi();
            hewan.Berjalan();

            Console.WriteLine();
            hewan = new Singa();
            hewan.Berjalan();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaction.Interface
{
    public class Sapi : IHewan 
    {
        public void Berjalan()
        {
            Console.WriteLine("Sapi Hewan berkaki 4");
            Console.WriteLine("Ia termassuk Hewan vegetarian");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._4
{
    internal class Schet
    {
        public int temp;

        public Schet() 
        { 
            this.temp = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Текущее состояние счетчика: {temp}");
        }
    }
}

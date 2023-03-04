using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._3
{
    internal class Nums
    {
        public int x;
        public int y;

        public Nums() 
        { 
            this.x = 5;
            this.y = 5;
        }
        public void Print()
        {
            Console.WriteLine($"Число x: {x}, число y: {y}");
        }
    }
}

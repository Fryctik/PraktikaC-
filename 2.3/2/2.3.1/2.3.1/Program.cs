using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Worker worker = new Worker();
                ConsoleKeyInfo key;
                Console.WriteLine("Нажмите Enter что бы узнать зарплату");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    worker.GetSalary();
                }
            }
        }
    }
}

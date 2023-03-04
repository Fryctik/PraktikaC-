using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Schet schet = new Schet();
            while (true)
            {
                Console.WriteLine("Выберите инициализацию" +
                    "\nДефолтное значение - 1" +
                    "\nРандомное значение - 2" +
                    "\nЗапустить счетчик в + - 3" +
                    "\nЗапустить счетчик в - - 4" +
                    "\nУзнать значение счетчика - 5");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: schet.temp = 0; break;
                    case 2: 
                        Random rng= new Random();
                        schet.temp = rng.Next(-1000, 1000);
                        break;
                    case 3: StartPlus(schet); break;
                    case 4: StartMinus(schet); break;
                    case 5: schet.Print(); break;
                }
            }
        }
        public static void StartPlus(Schet schet)
        {
            ConsoleKeyInfo key;
            Console.WriteLine("Нажмите + для прибавления");
            key = Console.ReadKey();
            while (key.Key == ConsoleKey.OemPlus)
            {
                schet.temp++;
                key = Console.ReadKey();
            }
        }
        public static void StartMinus(Schet schet) 
        {
            ConsoleKeyInfo key;
            Console.WriteLine("Нажмите - для вычитания");
            key = Console.ReadKey();
            while (key.Key == ConsoleKey.OemPlus)
            {
                schet.temp--;
                key = Console.ReadKey();
            }
        }
    }
}

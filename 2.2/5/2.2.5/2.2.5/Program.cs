using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Создать с своими значениями - 1" +
                    "\nСоздать с значениями по умолчанию - 2" +
                    "\nУдалить - 3");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Struct str = new Struct();
                        NewStruct(str);
                        break;
                    case 2:
                        Struct stry = new Struct();
                        break;
                    case 3:
                        Console.WriteLine("Класс удален");
                        break;
                }
            }
        }
        public static void NewStruct(Struct str)
        {
            Console.WriteLine("Введите значения для х");
            str.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения для у");
            str.y = Convert.ToInt32(Console.ReadLine());
        }
    }
}

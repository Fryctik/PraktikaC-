using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Train> train = new List<Train>()
            {
                new Train()
                {
                    nameOfFinalPoint = "Москва",
                    number = 21,
                    timeOfStart = new DateTime(2023, 02, 17, 15, 10, 00)
                },
                new Train()
                {
                    nameOfFinalPoint = "Томск",
                    number = 31,
                    timeOfStart = new DateTime(2023, 02, 18, 18, 22, 00)
                },
                new Train()
                {
                    nameOfFinalPoint = "Санкт-Питербург",
                    number = 22,
                    timeOfStart = new DateTime(2023, 02, 17, 10, 5, 00)
                }
            };
            while (true)
            {
                Console.WriteLine($"Введите номер поезда для получения информации о нем");
                int temp = Convert.ToInt32(Console.ReadLine());
                foreach (Train i in train)
                {
                    if (temp == i.number)
                    {
                        Console.WriteLine($"{i.nameOfFinalPoint} \n{i.number}\n{i.timeOfStart}");
                    }
                }
            }
        }
    }
}

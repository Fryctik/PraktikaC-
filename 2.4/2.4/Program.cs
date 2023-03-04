using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Выберите пункт:"
                            + "\nПеревести число - 1"
                            + "\nВыйти из системы - 2");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.Write("Введите значение для перевода от 1 до 2999: ");
                        int nums = int.Parse(Console.ReadLine());

                        if (nums == 0)
                        {
                            Console.WriteLine("Выбранное число не подходит требованию, попробуйте еще раз");
                        }

                        if (nums > 0 || nums <= 2999)
                        {
                            Console.WriteLine("Ваше число: " + Transfer(nums));
                        }
                        break;
                    case 2:
                        return;
                }

            }
        }
        public static string Transfer(int number)
        {
            int[] values = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


            StringBuilder result = new StringBuilder();


            for (int i = 0; i < 13; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }
            return result.ToString();
        }
    }
}

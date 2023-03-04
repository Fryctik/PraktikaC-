using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nums nums = new Nums();
            while (true)
            {
                
                Console.WriteLine("Выберите желаему операцию:\nВывести числа - 1\nСложить числа - 2\nИзменить числа - 3\nНайти наибольшее число - 4");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: nums.Print(); break;
                    case 2: Summa(nums); break;
                    case 3: EditNums(nums); break;
                    case 4: Max(nums); break;
                }
            }
        }

        public static void Summa(Nums nums) 
        {
            Console.WriteLine(nums.y + nums.x);
        }
        public static void EditNums(Nums nums)
        {
            Console.WriteLine("Введите число x");
            nums.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y");
            nums.y = Convert.ToInt32(Console.ReadLine());
        }
        public static void Max(Nums nums)
        {
            if(nums.y > nums.x)
            {
                Console.WriteLine("Y больше");
            }
            else if (nums.x > nums.y)
            {
                Console.WriteLine("X больше");
            }
            else
            {
                Console.WriteLine("Они равны");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            while(true)
            {
                Console.WriteLine("Изменить значение свойства - 1" +
                    "\nДобавить символ в конец строки - 2" +
                    "\nВывести значение - 3" +
                    "\nПолучить последний символ - 4" +
                    "\nУдалить последний символ - 5");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: calculation.SetCalculationLine(); break;
                    case 2: calculation.SetLastSymbolCalculationLine(); break;
                    case 3: calculation.GetCalculationLine(); break;
                    case 4: calculation.GetLastSymbol(); break;
                    case 5: calculation.DeleteLastSymbol(); break;
                }
            }
        }
        
    }
}

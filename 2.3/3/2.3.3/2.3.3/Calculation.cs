using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._3
{
    internal class Calculation
    {
        private String calculationLine { get; set; }

        public Calculation()
        {
            calculationLine = "";
        }
        public void SetCalculationLine()
        {
            Console.WriteLine("Введите новое значение");
            calculationLine = Console.ReadLine();
        }
        public void SetLastSymbolCalculationLine()
        {
            calculationLine += Console.ReadLine();
        }
        public void GetCalculationLine()
        {
            Console.WriteLine(calculationLine);
        }
        public void GetLastSymbol()
        {
            Console.WriteLine(calculationLine[calculationLine.Length]);
        }
        public void DeleteLastSymbol()
        {
            calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}

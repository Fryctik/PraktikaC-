using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._1
{
    internal class Worker
    {
        public String name;
        public String surName;
        public double rate;
        public int days;

        public Worker()
        {
            this.name = "Иван";
            this.surName = "Иванов";
            this.rate = 125.23;
            this.days = 30;
        }

        public void GetSalary()
        {
            Console.WriteLine($"Зарпалата {name} == {rate*days}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._1
{
    internal class Worker
    {
        private String name { get; set; }
        private String surName { get; set; }
        private double rate { get; set; }
        private int days { get; set; }

        public Worker()
        {
            name = "Иван";
            surName = "Иванов";
            rate = 125.23;
            days = 30;
        }

        public void GetSalary()
        {
            Console.WriteLine($"Зарпалата {name} == {rate*days}");
        }
    }
}

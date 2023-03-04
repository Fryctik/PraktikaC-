using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Student
    {
        public String lastName;
        public String dataRoz;
        public int numGroup;
        public int[] uspevaimost;

        public Student(string lastName, string dataRoz, int numGroup, int[] uspevaimost)
        {
            this.lastName = lastName;
            this.dataRoz = dataRoz;
            this.numGroup = numGroup;
            this.uspevaimost = uspevaimost;
        }

        public void Print()
        {
            Console.WriteLine("/ Ввывод данных о студенте /");
            Console.WriteLine($"Фамилию: {lastName}");
            Console.WriteLine($"Дату рождения: {dataRoz}");
            Console.WriteLine($"Номер группы: {numGroup}");
            Console.WriteLine("Успеваимость студента:");
            uspevaimost = new int[5];
            foreach(int i in uspevaimost){
                Console.Write(uspevaimost[i] + " ");
            }
            Console.WriteLine();
        }   
    }
}

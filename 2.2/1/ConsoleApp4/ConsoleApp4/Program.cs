using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4{

    
    class Program{
        
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                
                Console.WriteLine("Здравствуйте, выберете желаемую операцию:");
                Console.WriteLine("Ввести студента - 1 \nИзменить студента - 2 \nВывести студентов - 3");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: students.Add(NewStudent()); break;
                    case 2:
                        Console.WriteLine($"Выберите студента по номеру от 0 до {students.Count - 1}");
                        EditStudent(students[Convert.ToInt32(Console.ReadLine())]);
                        break;
                    case 3:
                        foreach(Student student in students)
                        {
                            student.Print(); 
                        }
                        break;
                }
            }
        }
        static public Student NewStudent()
        {
            Console.WriteLine("Введите Фамилию:");
            String lastName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (**.**.****):");
            String dateRoz = Console.ReadLine();
            Console.WriteLine("Введите номер группы:");
            int numGroup = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 5 оценок:");
            int[] uspevaimost = new int[5];
            for (int i = 0; i < uspevaimost.Length; i++)
            {
                uspevaimost[i] = Convert.ToInt32(Console.ReadLine());
            }
            return new Student(lastName, dateRoz, numGroup, uspevaimost);
        }
        static public void EditStudent(Student temp)
        {
            Console.WriteLine("Введите новую фамилию:");
            temp.lastName = Console.ReadLine();
            Console.WriteLine("Введите новую дату рождения (**.**.****):");
            temp.dataRoz= Console.ReadLine();
            Console.WriteLine("Введите новый номер группы:");
            temp.numGroup= Convert.ToInt32(Console.ReadLine());
            
        }
    }
}

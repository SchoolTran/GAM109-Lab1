using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Alice", 20));
            studentList.Add(new Student("Bod", 22));
            studentList.Add(new Student("Charlie", 21));

            foreach (var student in studentList)
            {
                Console.WriteLine(student.DisplayInfo());
            }
            Console.ReadKey();
        }
    }
}

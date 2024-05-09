using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps()
            {
                ID = "2024",
                Name = "URF"
            };
            Console.WriteLine(maps2.ShowData());
            Console.ReadLine();
        }
    }
}

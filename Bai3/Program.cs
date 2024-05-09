using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(4,3);
            int cong = calculator.Cong();
            Console.WriteLine(cong);
            int tru = calculator.Tru();
            Console.WriteLine(tru);
            int nhan = calculator.Nhan();
            Console.WriteLine(nhan);
            int Chia = calculator.Chia();
            Console.WriteLine(Chia);
            Console.ReadLine();

        }
    }
}

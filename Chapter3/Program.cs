using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //3-1
            //var exists = numbers.Exists(s => s %8 == 0 || s %9 == 0 );
            //Console.WriteLine(exists);

            //3-2
            //numbers.ForEach(s => Console.WriteLine(s/2.0));

            //3-3
            //var num = numbers.Where(s => s >= 50);
            //
            //foreach (var s in num)
            //{
            //    Console.WriteLine(s);
            //}


            //3-4

           // List<int> list = numbers.(s=> s*2);
        }

    }
}

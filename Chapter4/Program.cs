using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),

            };

            Console.WriteLine("--4.2.2---");

            foreach (var item in ymCollection)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("----------");
        }
    }
}

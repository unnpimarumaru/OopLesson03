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
            var list = new List<string>
            {

            "Tokyo","New Delhi","Bankoku","London","Paris","Berlin","Canberra","Hong Kong",
            };

            //list.ForEach(s => Console.WriteLine(s));


            list.ConvertAll(s => s.ToUpper()).ForEach(s=>Console.WriteLine(s));
            

        }

    }
}

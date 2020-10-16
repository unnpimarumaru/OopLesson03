using hapter7;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {

        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text); //問題7.1.1

        }
        static void Exercise1_1(string text)
        {
            var dict = new SortedDictionary<char, int>();

            foreach (var ch in text.ToUpper())
            {
                if ('A' <= ch && ch <= 'Z')
                {

                    if (dict.ContainsKey(ch))
                    {
                        //既に登録済み
                        dict[ch]+=1;
                    }
                        //未登録
                        else
                        {
                        dict.Add(ch ,1);
                        }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }




        }

    }
}

using hapter7;
using System;
using System.CodeDom;
using System.Collections.Generic;
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
            // *辞書登録プログラム *表示
            #region
            Console.WriteLine("**********************");
            Console.Write("* ");
            Console.Write("辞書登録プログラム");
            Console.Write(" *");
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();
            #endregion

            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>();

            // ディクショナリに追加
            while (true)
            {
                Console.WriteLine("1．登録　 2．内容を表示  3. 終了");

                Console.Write(">");
                var select = Console.ReadLine();
                if (select == "1")
                { 

                    Console.Write("keyを入力:");
                    var key = Console.ReadLine();
                    Console.Write("VALUEを入力:");
                    var value = Console.ReadLine();

                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key] = new List<string> { value };
                    }
                    Console.WriteLine("登録しました");
                }

                // ディクショナリの内容を列挙
                else if (select == "2")
                {
                    foreach (var item in dict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                }
                //終了
                else if (select == "3")
                {
                    break;
                }
            }
           
           
        }
    }
}

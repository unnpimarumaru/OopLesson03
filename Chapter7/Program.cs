﻿using Chapter7;
using Section03;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter7
{

    // List 7-20
    class Program
    {
        static void Main(string[] args)
        {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //Cunterプロパティを呼び出して数を出力させる 7.2.3
            Console.WriteLine(abbrs.Count);
            //Removeメソッドを呼び出して要素を削除する
            if (abbrs.Remove("NPT")) 
            {
                Console.WriteLine("削除成功");          
            }else
            {
                Console.WriteLine("削除失敗");
            }


            

            //

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            foreach (var item in abbrs.Where(X => X.Key.Length == 3))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}



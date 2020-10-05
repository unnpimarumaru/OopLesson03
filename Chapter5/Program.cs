using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

             string str1 = Console.ReadLine();
             Console.WriteLine("文字列1:");
             Console.WriteLine("文字列2:");
             string str2 = Console.ReadLine();
             
             if (String.Compare(str1, str2, true) == 0)
             {
                 Console.WriteLine("等しい");
             }
             else Console.WriteLine("等しくない");
             
             
             
             Console.WriteLine("数値文字列:");
             var line= Console.ReadLine();
             int num;//変換後の数値格納用
             if (int.TryParse(line, out num))
             {
                 Console.WriteLine(num.ToString("#,#"));
             }
             else Console.WriteLine("数値文字列ではありません");


            var text = "Jackdaws Love my big sphinx of quartz";
             //空白カウント
            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数:{0}", spaces);
            //文字列置き換え
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);

            //単語カウント
            int count = text.Split(' ').Count();
            Console.WriteLine("単語数:{0}", count);

            //4文字以下の単語を列挙
            var words= text.Split(' ').Where(s=> s.Length <= 4);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
             
            var array = text.Split(' ').ToArray();
            if (array.Length >0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                Console.WriteLine(sb);


                var lines = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

                foreach (var item in lines.Split(';'))
                {
                  var Word =  item.Split('=');
                    Console.WriteLine("{0}:{1}", ToJapanese(Word[0]), Word[1]);
                }
 
            }
            string ToJapanese(string key) {
                switch (key)
                {
                    case "Novelist":
                        return "作家　";
                    case "BestWork":
                        return "代表作　";
                    case "Born":
                        return "誕生年　";
                    default:
                        return "        ";
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数の例
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings)
            {
                Console.Write(str + " ");
                
            }
            Console.WriteLine();//改行
            var sortedNumber = numbers.OrderBy(n=>n);
            foreach (var nums in sortedNumber)
            {
                Console.Write(nums + " ");
            }

            Console.WriteLine();//改行
            //文字の例
            var words = new List<string> { "Microsoft", "Aplle", "Google", "Oracle", "Facebook", };
            var Lowes = words.Select(nameof => nameof.ToLower()).ToArray();
            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルのみリスト
            var titles = books.Select(name => name.Title);
            foreach (var title in titles)
            {
                Console.WriteLine(title + " ");

            }

            Console.WriteLine();//改行
            var sortedBooks = books.OrderByDescending(x => x.Pages);

            //foreach (var book in sortedBooks)
            //{
            //    Console.WriteLine( book.Title + " "+book.Pages);
            //}

            Console.WriteLine();//改行
            Console.WriteLine($"最大値は{ numbers.Where(n => n > 0).Max()}です。");

            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.WriteLine(number + " ");
            }

            var strNum = numbers.Select(n=> n.ToString());
            foreach (var strnum in strNum)
            {
                Console.Write(strnum + " ");
            }

            Console.WriteLine();
            foreach (var item in numbers.OrderBy(n => n).Take(3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine( numbers.Distinct().Count(n => n > 10));
            
            {
              
            }

            var bookss = new List<Book> {
   new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
   new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
   new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
   new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
   new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
   new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
   new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
};
            //6-1
            var book = bookss.Where(n => n.Title== "ワンダフル・C#ライフ");
            foreach (var booksss in book)
            {
                Console.WriteLine($"{booksss.Title} {booksss.Price}円 　P{booksss.Pages}");
            }

            //6-2
            Console.WriteLine(bookss.Count(x=> x.Title.Contains("C#")));
            //6-3
            Console.WriteLine(bookss.Where(x => x.Title.Contains("C#")).Average(x=> x.Pages));

            //6-4
            Console.WriteLine(bookss.FirstOrDefault(x => x.Price >= 4000 ).Title);

            //6-5
            Console.WriteLine(bookss.Where(x => x.Price < 4000).Max(x=> x.Pages));

            //6-6
          
            foreach (var item in bookss.Where(x => x.Pages >= 400).OrderByDescending(x=> x.Price))
            {
                Console.WriteLine(item.Title+" "+item.Price);
            }

            //6-7
            foreach (var item in bookss.Where(x => x.Title.Contains("C#") && x.Pages <= 500))
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            /*
            //6.1.1
            Console.WriteLine(numbers.Max(x => x));

            //6.1.2
            var gyaku = numbers.Reverse();
            foreach (var item in gyaku.Take(2)) {
                Console.WriteLine(item);
            }

            //6.1.3
            Console.Write(string.Join(",", numbers));
            Console.WriteLine();

            //6.1.4
            var tisai = numbers.OrderBy(x => x).Take(3);
            foreach (var small in tisai) {
                Console.WriteLine(small);
            }

            //6.1.5
            Console.WriteLine(numbers.Distinct().Count(x => x >= 10));
            */


            //6.2.1
            var books = Books.GetBooks();
            var wan = books.Where(x => x.Title.Contains("ワンダフル・C#ライフ"));
            foreach (var wanwan in wan) {
                Console.WriteLine(wanwan.Price + "," + wanwan.Pages);
            }

            //6.2.2
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")));

            //6.2.3
            var cs = books.Where(x => x.Title.Contains("C#"));
            Console.WriteLine(cs.Average(x => x.Pages));

            //6.2.4
            var yonsenijo = books.Where(x => x.Price >= 4000);
            Console.WriteLine(yonsenijo.First().Title);

            Console.WriteLine();

            //6.2.5 
            Console.WriteLine("問題6.2.5");
            Console.WriteLine(books.Where(x => x.Price <= 4000).Max(x => x.Pages));

            //6.2.6
            Console.WriteLine(numbers.Max());
            var yonsenijo2 = books.Where(x => x.Price >= 4000).OrderByDescending(x=>x.Price);
            foreach (var item in yonsenijo2) {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine();

            //6.2.7
            var hukumu = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach (var huku in hukumu) {
                Console.WriteLine(huku.Title);
            }

            //タイトルにC#を含むやつを、配列に入れて、配列の最後から2番目のタイトルと価格を表示
            var i = books.Where(x => x.Title.Contains("C#")).ToArray();
            Console.WriteLine(i[i.Length-2].Title + i[i.Length - 2].Price);
           
        }
    }
}

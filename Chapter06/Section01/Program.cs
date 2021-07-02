using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //Console.WriteLine("本の平均価格は" + books.Average(x => x.Price) + "円");
            //Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages).ToString("#,0") + "ページ");
            //Console.WriteLine("本の冊数は"+books.Count().ToString()+"冊");
            //Console.WriteLine("最も高い本の値段は" + books.Max(x => x.Price).ToString("#,0") + "円");
            //Console.WriteLine("最も安い本の値段は" + books.Min(x => x.Price).ToString("#,0") + "円");
            //Console.WriteLine("500円以上の本の冊数は"+books.Count(x=> x.Price >=500));

            

            //Console.WriteLine("「物語」がついてる本の冊数は"+books.Count(x=>x.Title.Contains("物語"))+"冊");

            ////金額高い順ベスト3
            //var kojun = books.OrderByDescending(x=>x.Price).Take(3);
            //Console.WriteLine("本の高額ベスト3\r\n");
            //foreach (var takai in kojun) {
            //    Console.WriteLine(takai.Title);
            //}

           
            


            //6.2.1
            foreach (var item in books.Where(x => x.Title.Contains("物語"))) {
                Console.WriteLine("値段:" + item.Price + ",ページ数:" + item.Pages);
            };

            //6.2.2
            Console.WriteLine(books.Count(x => x.Title.Contains("物語")));

            //6.2.3
            var monos = books.Where(x => x.Title.Contains("物語"));
            Console.WriteLine("「物語」がつく本の平均ページ数は" + monos.Average(x => x.Pages) + "ページ");

            //6.2.4
            //var yonsen = books.Where(x=>x.Price>=400);
            //Console.WriteLine(yonsen.First(x=>x.Title));

            Console.WriteLine();

        }
    }
}

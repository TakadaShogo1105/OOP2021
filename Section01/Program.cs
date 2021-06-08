using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 0, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };


                   // 3.1.1
               /* Exercise1_1(numbers);
                  Console.WriteLine("-----");

                   // 3.1.2
                   Exercise1_2(numbers);
                   Console.WriteLine("-----");

                   // 3.1.3
                   Exercise1_3(numbers);
                   Console.WriteLine("-----");

                   // 3.1.4
                   Exercise1_4(numbers); 

                   // 3.2.1
                   //Exercise2_1(names);
                   //Console.WriteLine();*/

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine();

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine();

            // 3.2.4
            Exercise2_4(names);

            //できた人用
            Exercise2_5(names);


        }

        private static void Exercise2_5(List<string> names) {
            int count = 0;

            foreach (var name in names) {
               count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }

        //P100 3.1
        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名、入力");
            var line = Console.ReadLine();//入力データ取り込み
            var index = names.FindIndex(s=>s==line);
            Console.WriteLine(index);
        }

        //P100 3.2
        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        //P100 3.3
        private static void Exercise2_3(List<string> names) {
            //リストにするToList(),配列にするToArray()
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var item in selected) {
                Console.WriteLine(item);
            }
        }

        //P100 3.4
        private static void Exercise2_4(List<string> names) {

            //Whereは抽出、Selectは変換、Lengthは文字数
            var n = names.Where(s => s.StartsWith("B")).Select(s=>s.Length);
            foreach (var item in n) {
                Console.WriteLine(item);
            }
        }

        //P99 3.1
        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exist)
                Console.WriteLine("存在します");
            else
                Console.WriteLine("存在しません");
        }

        //P99 3.2
        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s/2.0));
        }

        //P99 3.3
        private static void Exercise1_3(List<int> numbers) {
            foreach (var n in numbers.Where(n=> n>=50))
                Console.WriteLine(n);
           
        }

        //P99 3.4
        private static void Exercise1_4(List<int> numbers) {
            var nums = numbers.Select(n=> n *2);
            foreach (var n in nums) {
                Console.WriteLine(n);
            }
        }
    }
}


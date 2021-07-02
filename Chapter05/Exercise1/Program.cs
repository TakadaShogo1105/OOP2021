using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            //#region 問題5.1
            //Console.WriteLine("文字を入力");
            //var s1 = Console.ReadLine();

            //Console.WriteLine("文字を入力");
            //var s2 = Console.ReadLine();

            //if (String.Compare(s1, s2, ignoreCase: true) == 0) {
            //    Console.WriteLine("等しい");
            //} else {
            //    Console.WriteLine("等しくない");
            //}
            //#endregion 

            #region　問題5.2
            Console.WriteLine("文字を入力");
            int num1 = int.Parse(Console.ReadLine());
            var n1 = num1.ToString("#,0");
            Console.WriteLine(n1);
            #endregion

            #region 問題5.3
            String long = "Jackdaws Love my big sphinx of quartz";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enshumondai5_4 {
    class Program {
        static void Main(string[] args) {
            string str = "Novelist=谷埼潤一郎;BestWork=春琴抄;Born=1886";
            string moji = "作家:" + str.Substring(9, 5);
            moji += " \r\n代表作:" + str.Substring(24, 3) + " \r\n誕生年:" + str.Substring(33, 4);
            Console.WriteLine(moji);
            
        }
    }
}

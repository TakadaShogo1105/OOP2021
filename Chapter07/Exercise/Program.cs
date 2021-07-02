using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            var Retu = "Cozy Lummox gives smart squid who asks for job pen";

            Exercise_1(Retu);
            Console.WriteLine("----------");

            Exercise_2(Retu);
            Console.WriteLine("----------");
        }

        private static void Exercise_1(string retu) {
            
            var dict = new Dictionary<char, int>();
            foreach (var c in retu) {
                var uc = char.ToUpper(c);
                if ('A'<=uc && uc <='Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            foreach (var i in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("'" + i.Key + "':" + i.Value);
            }
        }

        private static void Exercise_2(string retu) {
            var sor = new SortedDictionary<char,int>();
            foreach (var c in retu) {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (sor.ContainsKey(uc)) {
                        sor[uc]++;
                    } else {
                        sor[uc] = 1;
                    }
                }
            }
            foreach (var i in sor) {
                Console.WriteLine("'" + i.Key + "':" + i.Value);
            }
        }
    }
}

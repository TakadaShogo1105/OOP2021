using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            var ymCollection = new YearMonth[] {

               new YearMonth(1980,1),new YearMonth(1990,2),new YearMonth(1996,11),
               new YearMonth(2000,5),new YearMonth(1985,6),
            };

            Exercise2_2(ymCollection);

            Console.WriteLine("---");

            Exercise2_4(ymCollection);

            Console.WriteLine("---");

            Exercise2_5(ymCollection);

        }


        private static void Exercise2_2(YearMonth[] ymCollection) {

            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }

        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {

                    return ym;
                }
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var Is21 = ymCollection.Contains(FindFirst21C(ymCollection)) ?
                FindFirst21C(ymCollection).Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(Is21);
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToList();

            foreach (var ym in array) {
                Console.WriteLine(ym);
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelemnts = xdoc.Root.Elements();
            foreach (var xnovelist in xelemnts) {
                XElement xt = xnovelist.Element("teammembers");
                XElement xn = xnovelist.Element("name");
                Console.WriteLine("{0}:{1}",xn.Value , xt.Value);
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load(file);
            var sample2 = xdoc.Root.Elements().OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var xsanple2 in sample2) {
                var xname = xsanple2.Element("name").Attribute("kanji");
                Console.WriteLine(xname);
            }
         

        }

        private static void Exercise1_3(string file) {
            
        }
    }
}

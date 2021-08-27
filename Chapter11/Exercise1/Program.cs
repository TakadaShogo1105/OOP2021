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
            var xdoc = XDocument.Load("Sample.xml");
            var xelemnts = xdoc.Root.Elements();
            foreach (var xnovelist in xelemnts) {
                XElement xt = xnovelist.Element("teammembers");
                Console.WriteLine(xt.Value+"人");
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load("Sample.xml");
            var xelemnts = xdoc.Root.Elements()
                .OrderBy(x=>x.Element("firstplayed").Attribute("name kanji"));

            foreach (var xsample in xelemnts) {
                
            }

        }

        private static void Exercise1_3(string file) {
        }
    }
}

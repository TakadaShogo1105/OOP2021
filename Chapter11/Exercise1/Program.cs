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
                XElement xn = xnovelist.Element("name");
                Console.WriteLine(xn.Value +":"+ xt.Value);
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load("Sample.xml");
            var xelemnts = xdoc.Root.Elements()
                .OrderBy(x=>(string)x.Element("firstplayed").Attribute("name kanji"));

            foreach (var xsample in xelemnts) {
                var xkanji = xsample.Element("name kanji");
                Console.WriteLine(xkanji.Value);
            }

        }

        private static void Exercise1_3(string file) {

        }
    }
}

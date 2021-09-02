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
            var xfile = "11_2.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");

            Exercise1_4(file);
            Console.WriteLine("-------");

            Exercise2_1(xfile);
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
            var sports = xdoc.Root.Elements().Select(x => new {
                Firstplayed = x.Element("firstplayed").
                Value, Name = x.Element("name").Attribute("kanji").Value
            }).OrderBy(x => int.Parse(x.Firstplayed));

            foreach (var sport in sports) {
                Console.WriteLine("{0},{1}",sport.Name,sport.Firstplayed);
            }

        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Teammembers = x.Element("teammembers").Value
                })
                .OrderByDescending(x=>int.Parse(x.Teammembers)).First();

            Console.WriteLine("{0}",sports.Name);
        }

        private static void Exercise1_4(string file) {
            var xdoc = XDocument.Load(file);
            var element = new XElement("file",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴玉")),
                            new XElement("firstplayed", "1872-11-30"),
                            new XElement("teammember", "11"));

            xdoc.Root.Add(element);

            xdoc.Save("Sports.xml");//XML　ファイルに保存
        }

        private static void Exercise2_1(string xfile) {
            var xdoc = XDocument.Load(xfile);
            var dict = new Dictionary<string, string> {
                ["鬼灯"] = "ほおずき",
                ["暖簾"] = "のれん",
                ["杜撰"] = "ずさん",
                ["坩堝"] = "るつぼ",

            };
            var query = dict.Select(x => new XElement("word",
                                           new XAttribute("kanji", x.Key),
                                           new XAttribute("yomi", x.Value)));
            var root = new XElement("xfile", query);
            root.Save("xfile");
        }

    }
}

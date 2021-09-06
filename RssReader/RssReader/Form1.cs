using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            //System.Diagnostics.Process.Start(tbUrl.Text);
            //String URLString = tbUrl.Text;
            //XmlTextReader reader = new XmlTextReader(URLString);
            //var xdoc = XmlDocument.Load(tbUrl.Text);

            SetRssTitle(tbUrl.Text);
        }

        private void SetRssTitle(string uri) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");

                /*var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);*/

                var url = new Uri(uri);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    lbTitles.Items.Add(
                        Regex.Replace(node.Value, "【|】", ""));
                    
                }
                
            }
        }
    }
}


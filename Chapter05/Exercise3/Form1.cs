using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {

        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        //フォームがロードされるタイミングで1回実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            textBox1.Text = "Novelist=谷埼潤一郎;BestWork=春琴抄;Born=1886";
        }
        //5.3.1
        private void Button5_3_1_Click(object sender, EventArgs e) {

            outputText.Text = inputStrText.Text.Count(f => f == ' ').ToString();

        }

        //5.3.2
        private void button1_Click(object sender, EventArgs e) {

            outPutText2.Text = inputStrText.Text.Replace("big", "small").ToString();

        }
        //5.3.3
        private void Buttontango_Click(object sender, EventArgs e) {

            Tangotext.Text = inputStrText.Text.Split().Count().ToString() ;
            
        }

        //5.3.4
        private void Yonikabutton_Click(object sender, EventArgs e) {

            var moji = inputStrText.Text.Split().Where(c=> c.Length <=4);
            foreach (var item in moji) {
                YonikaText.Text += item + ",";
            }
        }

        //5.3.5
        private void ShibuButton_Click(object sender, EventArgs e) {
            //ToArrayで配列に格納
            var moji = inputStrText.Text.Split(' ').ToArray();
            var sb = new StringBuilder();
            foreach (var item in moji) {
                ShibuText.Text += item + " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox1.Text = "Novelist=谷埼潤一郎;BestWork=春琴抄;Born=1886";
            
        }

        private void takadabutton_Click(object sender, EventArgs e) {

            foreach (var pair in textBox1.Text.Split(';')) {
                var array = pair.Split('=');
                takadaoutputbutton.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";
            }
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}

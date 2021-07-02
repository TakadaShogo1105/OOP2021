using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            //int num1 = int.Parse(Console.ReadLine());
            //var n1 = num1.ToString("#,0");
            //Console.WriteLine(n1);
            
           

            if(int.TryParse(inStrNum.Text, out int num)) {
                outStrNum.Text = num.ToString("#,0");
            } else {
                outStrNum.Text = "エラー";
            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}

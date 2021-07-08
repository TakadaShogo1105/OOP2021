using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();
        Timer tm = new Timer();

        public Form1() {
            InitializeComponent();
        }

        //スタートボタン
        private void button4_Click(object sender, EventArgs e) {
            tm.Start();
            sw.Start();
            //タイマーを呼び出す tm.Tick +=　まで売ったらTabキーを2回押す
            tm.Tick += Tm_Tick;
        }

        private void Tm_Tick(object sender, EventArgs e) {
            LB.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        //ストップ
        private void buttonStop_Click_Click(object sender, EventArgs e) {
            sw.Stop();
            tm.Stop();
        }

        //リセットさん
        private void buttonReset_Click_Click(object sender, EventArgs e) {
            sw.Reset();
            LB.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Form1_Load(object sender, EventArgs e) {
            LB.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        //ラップ
        private void button3_Click(object sender, EventArgs e) {
            Rapbox.Text = LB.Text + "\r\n" + Rapbox.Text;
        }
    }
}


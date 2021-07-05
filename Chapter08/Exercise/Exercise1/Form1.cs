using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}",today) + "\r\n";
            tbDateDisp.Text += today.ToString("yyyy年MM月dd日 HH分mm秒") + "\r\n";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);
            tbDateDisp.Text += today.ToString("ggyy年 M月dd日(dddd)", culture);
        }

        private void Form1_Load(object sender, EventArgs e) {
            var td = DateTime.Now;
            tssTimeLabel.Text = string.Format("{0:yyyy/M/d HH:mm}",td);

            var tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 1000;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            var td = DateTime.Now;
            tssTimeLabel.Text = string.Format("{0:yyyy/M/d HH:mm:ss}", td);
        }
    }
}

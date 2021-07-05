using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {

            //var today = DateTime.Today;
            var today = new DateTime((int)nubYear.Value, (int)nubMonth.Value, (int)nubDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;

            string dow ="";

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日です";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日です";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日です";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日です";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日です";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日です";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日です";
                    break;
                
            }

            tbOutput.Text = "今日は" + dow ;

            //閏年の判定
            var isLeapYear = DateTime.IsLeapYear(today.Year);
            if (isLeapYear) {
               tbLeepYear.Text = "閏年です";
            } else {
               tbLeepYear.Text= "閏年ではありません";
            }

            var dt1 = new DateTime((int)nubYear.Value, (int)nubMonth.Value, (int)nubDay.Value);
            var dt2 = DateTime.Today;
            TimeSpan diff = dt2.Date - dt1.Date;
            tbnanniti.Text = diff.Days.ToString();

            //GetAgeで年齢求める
            var birthday = new DateTime(1996,11,5);
            var t = DateTime.Today;
            int age = GetAge(birthday,t);
            tanjoBox.Text = age.ToString()+"歳";



        }

        private void seinenButton_Click(object sender, EventArgs e) {
            
        }

        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

    }
}

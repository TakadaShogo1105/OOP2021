using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btDefault_Click(object sender, EventArgs e) {
            Settings settings = new Settings();
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
        }

        //OKボタン
        private void btOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e) {
           
        }
    }
}

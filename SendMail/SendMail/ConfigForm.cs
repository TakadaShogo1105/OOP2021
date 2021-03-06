using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {
        Form1 f1;
        private Settings settings = Settings.getInstance();
        public ConfigForm() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            tbSender.Text = settings.sMailAddr();
        }

        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e) {
            //f1 = new Form1();
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }

        

        //OKボタン
        private void btOk_Click(object sender, EventArgs e) {
            btApply_Click(sender,e);//適用ボタンの処理を呼び出し
            this.Close();
        }

        //送信データ登録
        private void SettingRegist() {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
            //シリアル化
            var xws = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws)) {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                                   tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

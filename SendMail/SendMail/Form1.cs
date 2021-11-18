using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class Form1 : Form {
        //設定画面
        private ConfigForm configForm = new ConfigForm();
        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }

        

        private void btSend_Click(object sender, EventArgs e) {

            if (!Settings.Set) {
                MessageBox.Show("送信情報を設定してください");
            }

            try {

                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                mailMessage.CC.Add(toCC.Text);
//                mailMessage.Bcc.Add(toBCC.Text);

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメール送信
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials 
                    = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                //smtpClient.Send(mailMessage);

                smtpClient.SendCompleted += SmtpClient_SendCompleted1; ;

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage,userState);


            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted1(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }
            else {
                MessageBox.Show("送信完了");
                tbTo.Clear();
                toCC.Clear();
                toBCC.Clear();
                tbTitle.Clear();
                tbMessage.Clear();

            }
        }


        private void toBCC_TextChanged(object sender, EventArgs e) {

        }

        private void btConfig_Click(object sender,EventArgs e) {
            new ConfigForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //起動時に送信情報が未設定の場合設定画面を表示する
            if (!Settings.Set) {
                configForm.ShowDialog();
            }
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {
            tbTo.Clear();
            toCC.Clear();
            toBCC.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
            
        }

        private void tbTo_TextChanged(object sender, EventArgs e) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        //設定画面
        private ConfigForm configForm = new ConfigForm();
        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btSend_Click(object sender, EventArgs e) {
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
                    = new NetworkCredential("ojsinfosys01@gmail.com", "Infosys2021");
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void toBCC_TextChanged(object sender, EventArgs e) {

        }

        private void btConfig_Click(object sender,EventArgs e) {
            new ConfigForm().ShowDialog();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class fmMain : Form {

        BindingList<CarReport> listcarReports = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistDate.DataSource = listcarReports;
        }

        //終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリ終了
        }

        //開くピクチャーボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //削除ピクチャーボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void btDateAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text =="" || cbCarName.Text == "") {
                MessageBox.Show("正しい値を入力してください。", "エラー",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }
            CarReport carReport = new CarReport {

                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };

            listcarReports.Add(carReport);//1レコード
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {

            foreach (var rb in gbMaker.Controls) {

                if(((RadioButton)rb).Checked){
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistDate_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvRegistDate_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            CarReport selectedCar = listcarReports[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {

            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default://その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDateDelete_Click(object sender, EventArgs e) {

            listcarReports.RemoveAt(dgvRegistDate.CurrentRow.Index);
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = null;
            cbCarName.Text = null;
            rbOther.Checked = true;
            tbReport.Text = null;
            pbPicture.Image = null;
        }

        private void btDateCorrect_Click(object sender, EventArgs e) {
            listcarReports[dgvRegistDate.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text,selectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);
            
            dgvRegistDate.Refresh(); //コントロールの強制再描画

            
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdFileSave.ShowDialog()==DialogResult.OK) {
                var bf = new BinaryFormatter();

                using (FileStream fs = File.Open(sfdFileSave.FileName,FileMode.Create)) {
                    bf.Serialize(fs, listcarReports);
                }

            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFireOpen.ShowDialog()==DialogResult.OK) {
                //バイナリ形式で逆シリアル化
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(ofdFireOpen.FileName,FileMode.Open,FileAccess.Read)) {
                    //逆シリアル化して読み込む
                    listcarReports = (BindingList<CarReport>) bf.Deserialize(fs);
                    dgvRegistDate.DataSource = null;
                    dgvRegistDate.DataSource = listcarReports;
                }
            }
        }
    }
}

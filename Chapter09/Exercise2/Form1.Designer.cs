
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btOpen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btChange = new System.Windows.Forms.Button();
            this.btGyoban = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.outputtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(52, 32);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(112, 56);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(192, 37);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(112, 56);
            this.btChange.TabIndex = 4;
            this.btChange.Text = "変換";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btGyoban
            // 
            this.btGyoban.Location = new System.Drawing.Point(366, 37);
            this.btGyoban.Name = "btGyoban";
            this.btGyoban.Size = new System.Drawing.Size(112, 56);
            this.btGyoban.TabIndex = 5;
            this.btGyoban.Text = "行";
            this.btGyoban.UseVisualStyleBackColor = true;
            this.btGyoban.Click += new System.EventHandler(this.btGyoban_Click);
            // 
            // outputtext
            // 
            this.outputtext.Location = new System.Drawing.Point(12, 128);
            this.outputtext.Multiline = true;
            this.outputtext.Name = "outputtext";
            this.outputtext.Size = new System.Drawing.Size(587, 308);
            this.outputtext.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.btGyoban);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btGyoban;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.TextBox outputtext;
    }
}


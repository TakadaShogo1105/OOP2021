
namespace Exercise1 {
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
            this.openbt = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.keywordbox = new System.Windows.Forms.TextBox();
            this.readallbt = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openbt
            // 
            this.openbt.Location = new System.Drawing.Point(22, 12);
            this.openbt.Name = "openbt";
            this.openbt.Size = new System.Drawing.Size(75, 23);
            this.openbt.TabIndex = 0;
            this.openbt.Text = "開く";
            this.openbt.UseVisualStyleBackColor = true;
            this.openbt.Click += new System.EventHandler(this.openbt_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(22, 41);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(733, 545);
            this.textbox1.TabIndex = 1;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // keywordbox
            // 
            this.keywordbox.Location = new System.Drawing.Point(119, 12);
            this.keywordbox.Name = "keywordbox";
            this.keywordbox.Size = new System.Drawing.Size(376, 19);
            this.keywordbox.TabIndex = 2;
            // 
            // readallbt
            // 
            this.readallbt.Location = new System.Drawing.Point(559, 8);
            this.readallbt.Name = "readallbt";
            this.readallbt.Size = new System.Drawing.Size(75, 23);
            this.readallbt.TabIndex = 3;
            this.readallbt.Text = "ReadAllLines";
            this.readallbt.UseVisualStyleBackColor = true;
            this.readallbt.Click += new System.EventHandler(this.readallbt_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(671, 10);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(75, 23);
            this.btReadLines.TabIndex = 4;
            this.btReadLines.Text = "ReadLines";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 633);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.readallbt);
            this.Controls.Add(this.keywordbox);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.openbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openbt;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox keywordbox;
        private System.Windows.Forms.Button readallbt;
        private System.Windows.Forms.Button btReadLines;
    }
}


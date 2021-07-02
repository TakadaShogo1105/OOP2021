
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
            this.inStrNum = new System.Windows.Forms.TextBox();
            this.Button5_2 = new System.Windows.Forms.Button();
            this.outStrNum = new System.Windows.Forms.TextBox();
            this.変換前 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inStrNum
            // 
            this.inStrNum.Location = new System.Drawing.Point(182, 119);
            this.inStrNum.Name = "inStrNum";
            this.inStrNum.Size = new System.Drawing.Size(100, 19);
            this.inStrNum.TabIndex = 0;
            // 
            // Button5_2
            // 
            this.Button5_2.Location = new System.Drawing.Point(355, 119);
            this.Button5_2.Name = "Button5_2";
            this.Button5_2.Size = new System.Drawing.Size(75, 23);
            this.Button5_2.TabIndex = 1;
            this.Button5_2.Text = "問題5.2";
            this.Button5_2.UseVisualStyleBackColor = true;
            this.Button5_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // outStrNum
            // 
            this.outStrNum.Location = new System.Drawing.Point(182, 185);
            this.outStrNum.Name = "outStrNum";
            this.outStrNum.Size = new System.Drawing.Size(100, 19);
            this.outStrNum.TabIndex = 2;
            // 
            // 変換前
            // 
            this.変換前.AutoSize = true;
            this.変換前.Location = new System.Drawing.Point(45, 119);
            this.変換前.Name = "変換前";
            this.変換前.Size = new System.Drawing.Size(41, 12);
            this.変換前.TabIndex = 3;
            this.変換前.Text = "変換前";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "変換後";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.変換前);
            this.Controls.Add(this.outStrNum);
            this.Controls.Add(this.Button5_2);
            this.Controls.Add(this.inStrNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inStrNum;
        private System.Windows.Forms.Button Button5_2;
        private System.Windows.Forms.TextBox outStrNum;
        private System.Windows.Forms.Label 変換前;
        private System.Windows.Forms.Label label1;
    }
}


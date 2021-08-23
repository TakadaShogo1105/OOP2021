
namespace Sample0823 {
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
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JyoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExecButton = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(722, 67);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(179, 49);
            this.ResultBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(220, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // JyoBox
            // 
            this.JyoBox.Location = new System.Drawing.Point(282, 67);
            this.JyoBox.Multiline = true;
            this.JyoBox.Name = "JyoBox";
            this.JyoBox.Size = new System.Drawing.Size(179, 49);
            this.JyoBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(467, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "乗";
            // 
            // ExecButton
            // 
            this.ExecButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExecButton.Location = new System.Drawing.Point(537, 67);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new System.Drawing.Size(129, 54);
            this.ExecButton.TabIndex = 2;
            this.ExecButton.Text = "結果→";
            this.ExecButton.UseVisualStyleBackColor = true;
            this.ExecButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(12, 67);
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(179, 49);
            this.ValueBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.ExecButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JyoBox);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.ResultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JyoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExecButton;
        private System.Windows.Forms.TextBox ValueBox;
    }
}


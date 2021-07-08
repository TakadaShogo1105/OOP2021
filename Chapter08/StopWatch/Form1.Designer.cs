
namespace StopWatch {
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
            this.buttonReset_Click = new System.Windows.Forms.Button();
            this.buttonStop_Click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonStart_Click = new System.Windows.Forms.Button();
            this.LB = new System.Windows.Forms.TextBox();
            this.Rapbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReset_Click
            // 
            this.buttonReset_Click.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReset_Click.Location = new System.Drawing.Point(158, 189);
            this.buttonReset_Click.Name = "buttonReset_Click";
            this.buttonReset_Click.Size = new System.Drawing.Size(107, 48);
            this.buttonReset_Click.TabIndex = 2;
            this.buttonReset_Click.Text = "リセット";
            this.buttonReset_Click.UseVisualStyleBackColor = true;
            this.buttonReset_Click.Click += new System.EventHandler(this.buttonReset_Click_Click);
            // 
            // buttonStop_Click
            // 
            this.buttonStop_Click.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStop_Click.Location = new System.Drawing.Point(33, 255);
            this.buttonStop_Click.Name = "buttonStop_Click";
            this.buttonStop_Click.Size = new System.Drawing.Size(107, 44);
            this.buttonStop_Click.TabIndex = 3;
            this.buttonStop_Click.Text = "ストップ";
            this.buttonStop_Click.UseVisualStyleBackColor = true;
            this.buttonStop_Click.Click += new System.EventHandler(this.buttonStop_Click_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(158, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "ラップ⇒";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonStart_Click
            // 
            this.buttonStart_Click.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStart_Click.Location = new System.Drawing.Point(33, 189);
            this.buttonStart_Click.Name = "buttonStart_Click";
            this.buttonStart_Click.Size = new System.Drawing.Size(107, 48);
            this.buttonStart_Click.TabIndex = 5;
            this.buttonStart_Click.Text = "スタート";
            this.buttonStart_Click.UseVisualStyleBackColor = true;
            this.buttonStart_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // LB
            // 
            this.LB.Location = new System.Drawing.Point(33, 119);
            this.LB.Multiline = true;
            this.LB.Name = "LB";
            this.LB.ReadOnly = true;
            this.LB.Size = new System.Drawing.Size(278, 51);
            this.LB.TabIndex = 6;
            // 
            // Rapbox
            // 
            this.Rapbox.Location = new System.Drawing.Point(370, 119);
            this.Rapbox.Multiline = true;
            this.Rapbox.Name = "Rapbox";
            this.Rapbox.ReadOnly = true;
            this.Rapbox.Size = new System.Drawing.Size(278, 264);
            this.Rapbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rapbox);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.buttonStart_Click);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonStop_Click);
            this.Controls.Add(this.buttonReset_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset_Click;
        private System.Windows.Forms.Button buttonStop_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStart_Click;
        private System.Windows.Forms.TextBox LB;
        private System.Windows.Forms.TextBox Rapbox;
    }
}


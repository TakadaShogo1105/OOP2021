
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.outPutText2 = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.Buttontango = new System.Windows.Forms.Button();
            this.Tangotext = new System.Windows.Forms.TextBox();
            this.Yonikabutton = new System.Windows.Forms.Button();
            this.YonikaText = new System.Windows.Forms.TextBox();
            this.ShibuButton = new System.Windows.Forms.Button();
            this.ShibuText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.takadabutton = new System.Windows.Forms.Button();
            this.takadaoutputbutton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(112, 69);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(629, 31);
            this.inputStrText.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Location = new System.Drawing.Point(12, 134);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(75, 23);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白カウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputText.Location = new System.Drawing.Point(112, 126);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(83, 31);
            this.outputText.TabIndex = 3;
            // 
            // outPutText2
            // 
            this.outPutText2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outPutText2.Location = new System.Drawing.Point(112, 228);
            this.outPutText2.Name = "outPutText2";
            this.outPutText2.Size = new System.Drawing.Size(629, 31);
            this.outPutText2.TabIndex = 4;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Location = new System.Drawing.Point(12, 237);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(75, 23);
            this.Button5_3_2.TabIndex = 6;
            this.Button5_3_2.Text = "big ⇒ small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buttontango
            // 
            this.Buttontango.Location = new System.Drawing.Point(12, 322);
            this.Buttontango.Name = "Buttontango";
            this.Buttontango.Size = new System.Drawing.Size(75, 23);
            this.Buttontango.TabIndex = 7;
            this.Buttontango.Text = "単語数";
            this.Buttontango.UseVisualStyleBackColor = true;
            this.Buttontango.Click += new System.EventHandler(this.Buttontango_Click);
            // 
            // Tangotext
            // 
            this.Tangotext.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tangotext.Location = new System.Drawing.Point(126, 322);
            this.Tangotext.Name = "Tangotext";
            this.Tangotext.Size = new System.Drawing.Size(83, 31);
            this.Tangotext.TabIndex = 8;
            // 
            // Yonikabutton
            // 
            this.Yonikabutton.Location = new System.Drawing.Point(12, 391);
            this.Yonikabutton.Name = "Yonikabutton";
            this.Yonikabutton.Size = new System.Drawing.Size(75, 23);
            this.Yonikabutton.TabIndex = 9;
            this.Yonikabutton.Text = "4文字以下";
            this.Yonikabutton.UseVisualStyleBackColor = true;
            this.Yonikabutton.Click += new System.EventHandler(this.Yonikabutton_Click);
            // 
            // YonikaText
            // 
            this.YonikaText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.YonikaText.Location = new System.Drawing.Point(112, 383);
            this.YonikaText.Name = "YonikaText";
            this.YonikaText.Size = new System.Drawing.Size(629, 31);
            this.YonikaText.TabIndex = 10;
            // 
            // ShibuButton
            // 
            this.ShibuButton.Location = new System.Drawing.Point(12, 467);
            this.ShibuButton.Name = "ShibuButton";
            this.ShibuButton.Size = new System.Drawing.Size(75, 23);
            this.ShibuButton.TabIndex = 11;
            this.ShibuButton.Text = "5.3.5";
            this.ShibuButton.UseVisualStyleBackColor = true;
            this.ShibuButton.Click += new System.EventHandler(this.ShibuButton_Click);
            // 
            // ShibuText
            // 
            this.ShibuText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShibuText.Location = new System.Drawing.Point(112, 458);
            this.ShibuText.Name = "ShibuText";
            this.ShibuText.Size = new System.Drawing.Size(629, 31);
            this.ShibuText.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(112, 521);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 31);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // takadabutton
            // 
            this.takadabutton.Location = new System.Drawing.Point(12, 529);
            this.takadabutton.Name = "takadabutton";
            this.takadabutton.Size = new System.Drawing.Size(75, 23);
            this.takadabutton.TabIndex = 14;
            this.takadabutton.Text = "5.4";
            this.takadabutton.UseVisualStyleBackColor = true;
            this.takadabutton.Click += new System.EventHandler(this.takadabutton_Click);
            // 
            // takadaoutputbutton
            // 
            this.takadaoutputbutton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.takadaoutputbutton.Location = new System.Drawing.Point(112, 576);
            this.takadaoutputbutton.Multiline = true;
            this.takadaoutputbutton.Name = "takadaoutputbutton";
            this.takadaoutputbutton.Size = new System.Drawing.Size(629, 80);
            this.takadaoutputbutton.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 692);
            this.Controls.Add(this.takadaoutputbutton);
            this.Controls.Add(this.takadabutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShibuText);
            this.Controls.Add(this.ShibuButton);
            this.Controls.Add(this.YonikaText);
            this.Controls.Add(this.Yonikabutton);
            this.Controls.Add(this.Tangotext);
            this.Controls.Add(this.Buttontango);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.outPutText2);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox outPutText2;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.Button Buttontango;
        private System.Windows.Forms.TextBox Tangotext;
        private System.Windows.Forms.Button Yonikabutton;
        private System.Windows.Forms.TextBox YonikaText;
        private System.Windows.Forms.Button ShibuButton;
        private System.Windows.Forms.TextBox ShibuText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button takadabutton;
        private System.Windows.Forms.TextBox takadaoutputbutton;
    }
}


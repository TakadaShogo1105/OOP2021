
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nubYear = new System.Windows.Forms.NumericUpDown();
            this.nubMonth = new System.Windows.Forms.NumericUpDown();
            this.nubDay = new System.Windows.Forms.NumericUpDown();
            this.tbLeepYear = new System.Windows.Forms.TextBox();
            this.tbnanniti = new System.Windows.Forms.TextBox();
            this.tanjoBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nubYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(22, 54);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(331, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(397, 59);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(84, 31);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(155, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(319, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(485, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "日";
            // 
            // nubYear
            // 
            this.nubYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubYear.Location = new System.Drawing.Point(22, 217);
            this.nubYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nubYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nubYear.Name = "nubYear";
            this.nubYear.Size = new System.Drawing.Size(120, 31);
            this.nubYear.TabIndex = 9;
            this.nubYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nubMonth
            // 
            this.nubMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubMonth.Location = new System.Drawing.Point(195, 219);
            this.nubMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nubMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubMonth.Name = "nubMonth";
            this.nubMonth.Size = new System.Drawing.Size(120, 31);
            this.nubMonth.TabIndex = 10;
            this.nubMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nubDay
            // 
            this.nubDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubDay.Location = new System.Drawing.Point(361, 219);
            this.nubDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nubDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubDay.Name = "nubDay";
            this.nubDay.Size = new System.Drawing.Size(120, 31);
            this.nubDay.TabIndex = 11;
            this.nubDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbLeepYear
            // 
            this.tbLeepYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeepYear.Location = new System.Drawing.Point(22, 119);
            this.tbLeepYear.Name = "tbLeepYear";
            this.tbLeepYear.Size = new System.Drawing.Size(331, 31);
            this.tbLeepYear.TabIndex = 12;
            // 
            // tbnanniti
            // 
            this.tbnanniti.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbnanniti.Location = new System.Drawing.Point(22, 168);
            this.tbnanniti.Name = "tbnanniti";
            this.tbnanniti.Size = new System.Drawing.Size(331, 31);
            this.tbnanniti.TabIndex = 13;
            // 
            // tanjoBox
            // 
            this.tanjoBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tanjoBox.Location = new System.Drawing.Point(22, 291);
            this.tanjoBox.Name = "tanjoBox";
            this.tanjoBox.Size = new System.Drawing.Size(331, 31);
            this.tanjoBox.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tanjoBox);
            this.Controls.Add(this.tbnanniti);
            this.Controls.Add(this.tbLeepYear);
            this.Controls.Add(this.nubDay);
            this.Controls.Add(this.nubMonth);
            this.Controls.Add(this.nubYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nubYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nubYear;
        private System.Windows.Forms.NumericUpDown nubMonth;
        private System.Windows.Forms.NumericUpDown nubDay;
        private System.Windows.Forms.TextBox tbLeepYear;
        private System.Windows.Forms.TextBox tbnanniti;
        private System.Windows.Forms.TextBox tanjoBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


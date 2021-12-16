using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Sample01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Startbt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Visible = false;
                Workbook wb = ExcelApp.Workbooks.Open(openFileDialog1.FileName,
                  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                  Type.Missing);

                Worksheet ws1 = wb.Sheets[1];
                ws1.Select(Type.Missing);
                Range range = ExcelApp.get_Range("A1", Type.Missing);
                if (range != null)
                {
                    var val = range.Value2;
                    textBox1.Text += Convert.ToString(val);
                }

                wb.Close(false, Type.Missing, Type.Missing);
                ExcelApp.Quit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += "漢字クイズ";
        }
    }
}

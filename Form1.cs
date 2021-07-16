using IronPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Pdf_using_IronPdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Code for Select the folder to save the file.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"D:\";      
            saveFileDialog1.Title = "Save Pdf File";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // actual code that will create Pdf files
                var HtmlLine = new HtmlToPdf();
                HtmlLine.RenderHtmlAsPdf(PdfText.Text).SaveAs(filename);
                // MessageBox to display that file save
                MessageBox.Show("File Saved Successfully!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PdfText.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

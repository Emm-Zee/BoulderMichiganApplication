using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;


namespace BoulderMichigan
{
    public partial class frm_Waiver : Form
    {
        public frm_Waiver()
        {
            InitializeComponent();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void bookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_Book BookForm = new frm_Book();
            BookForm.Show();
        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Book BookForm = new frm_Book();
            BookForm.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FAQ FAQForm = new frm_FAQ();
            FAQForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_About AboutForm = new frm_About();
            AboutForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_DownloadWaiver_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);
            StreamReader reader = new StreamReader(@"C:\Users\emily\Documents\Boulder Michigan\BoulderMichigan\resources\waiver.txt", Encoding.ASCII);
            string text = reader.ReadToEnd();
            reader.Close();
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Top;
            /*format.ParagraphIndent = 15f;*/
            graphics.DrawString(text, font, PdfBrushes.Black, new RectangleF(new PointF(0, 0), page.GetClientSize()), format);
            document.Save("BoulderMichiganWaiver.pdf");
            document.Close(true);
            Process.Start("BoulderMichiganWaiver.pdf");
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderMichigan
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Book BookForm = new frm_Book();
            BookForm.Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FAQ FAQForm = new frm_FAQ();
            FAQForm.Show();
        }

        private void waiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Waiver WaiverForm = new frm_Waiver();
            WaiverForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

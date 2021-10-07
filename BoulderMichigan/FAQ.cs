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
    public partial class frm_FAQ : Form
    {
        public frm_FAQ()
        {
            InitializeComponent();

    }

        private void servicesFAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Book BookForm = new frm_Book();
            BookForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_About AboutForm = new frm_About();
            AboutForm.Show();
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

        private void btn_FAQ1_Click(object sender, EventArgs e)
        {
            frm_FAQImNewHereAnswer FAQOneForm = new frm_FAQImNewHereAnswer();
            FAQOneForm.Show();
        }

        private void btn_FAQ2_Click(object sender, EventArgs e)
        {
            frm_FAQAnswer2 FAQTwoForm = new frm_FAQAnswer2();
            FAQTwoForm.Show();
        }

        private void btn_FAQ3_Click(object sender, EventArgs e)
        {
            frm_FAQAnswer3 FAQThreeForm = new frm_FAQAnswer3();
            FAQThreeForm.Show();
        }
    }
}

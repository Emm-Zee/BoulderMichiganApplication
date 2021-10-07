using System;
using System.Windows.Forms;

namespace BoulderMichigan
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Book BookForm = new frm_Book();
            BookForm.Show();
        }

        private void btn_Services_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_About AboutForm = new frm_About();
            AboutForm.Show();
        }

        private void btn_FAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FAQ FAQForm = new frm_FAQ();
            FAQForm.Show();
        }

        private void btn_Waiver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Waiver WaiverForm = new frm_Waiver();
            WaiverForm.Show();
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}

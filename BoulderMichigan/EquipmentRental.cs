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
    public partial class frm_EquipmentRental : Form
    {
        public frm_EquipmentRental()
        {
            InitializeComponent();
        }

        private void servicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FAQ FAQForm = new frm_FAQ();
            FAQForm.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

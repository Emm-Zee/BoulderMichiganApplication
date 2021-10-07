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
    public partial class frm_Services : Form
    {
        public frm_Services()
        {
            InitializeComponent();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_DailyRates_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DailyRates DailyRatesForm = new frm_DailyRates();
            DailyRatesForm.Show();
        }

        private void btn_Memberships_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Memberships MembershipsForm = new frm_Memberships();
            MembershipsForm.Show();
        }

        private void btn_GroupRates_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_GroupRates GroupRatesForm = new frm_GroupRates();
            GroupRatesForm.Show();
        }

        private void btn_Classes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Classes ClassesForm = new frm_Classes();
            ClassesForm.Show();
        }

        private void btn_Specials_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Specials SpecialsForm = new frm_Specials();
            SpecialsForm.Show();
        }

        private void btn_EquipRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EquipmentRental EquipmentRentalForm = new frm_EquipmentRental();
            EquipmentRentalForm.Show();
        }

        private void btn_FitnessLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FitnessLab FitnessLabForm = new frm_FitnessLab();
            FitnessLabForm.Show();
        }
    }
}

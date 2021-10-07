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
    public partial class frm_Book : Form
    {
        public frm_Book()
        {
            InitializeComponent();
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

        private void btn_Individual_Click(object sender, EventArgs e)
        {
            tmr_Individual.Start();
            if (panel1.Height != 0)
            {
                panel1.Height = 0;
                tmr_Individual.Enabled = false;
            }
        }

        private void tmr_Individual_Tick(object sender, EventArgs e)
        {
            panel1.Height = 500;
            tmr_Individual.Stop();
        }

        private void btn_Couples_Click(object sender, EventArgs e)
        {
            tmr_Couples.Start();
            if (pnl_Couples.Height != 0)
            {
                pnl_Couples.Height = 0;
                tmr_Couples.Enabled = false;
            }
        }

        private void tmr_Couples_Tick(object sender, EventArgs e)
        {
            pnl_Couples.Height = 500;
            tmr_Couples.Stop();
        }

        private void btn_Family_Click(object sender, EventArgs e)
        {
            tmr_Family.Start();
            if (pnl_Family.Height != 0)
            {
                pnl_Family.Height = 0;
                tmr_Family.Enabled = false;
            }
        }

        private void tmr_Family_Tick(object sender, EventArgs e)
        {
            pnl_Family.Height = 500;
            tmr_Family.Stop();
        }

        private void btn_Group_Click(object sender, EventArgs e)
        {
            tmr_Groups.Start();
            if (pnl_Group.Height != 0)
            {
                pnl_Group.Height = 0;
                tmr_Groups.Enabled = false;
            }
        }

        private void tmr_Groups_Tick(object sender, EventArgs e)
        {
            pnl_Group.Height = 500;
            tmr_Groups.Stop();
        }

        private void btn_Classes_Click_1(object sender, EventArgs e)
        {
            tmr_Classes.Start();
            if (pnl_Classes.Height != 0)
            {
                pnl_Classes.Height = 0;
                tmr_Classes.Enabled = false;
            }
        }

        private void tmr_Classes_Tick(object sender, EventArgs e)
        {
            pnl_Classes.Height = 75;
            tmr_Classes.Stop();
        }

        private void btn_FitnessLab_Click(object sender, EventArgs e)
        {
            tmr_FitnessLab.Start();
            if (pnl_FitnessLab.Height != 0)
            {
                pnl_FitnessLab.Height = 0;
                tmr_FitnessLab.Enabled = false;
            }
        }

        private void tmr_FitnessLab_Tick(object sender, EventArgs e)
        {
            pnl_FitnessLab.Height = 500;
            tmr_FitnessLab.Stop();
        }

        private void btn_LabDaily_Click(object sender, EventArgs e)
        {
            frm_FitnessLabDayPass FitnessLabDayPassForm = new frm_FitnessLabDayPass();
            FitnessLabDayPassForm.Show();
        }

        private void btn_LabMonthly_Click(object sender, EventArgs e)
        {
            frm_FitnessLabMonthlyMembership FitnessLabMonthlyMembershipForm = new frm_FitnessLabMonthlyMembership();
            FitnessLabMonthlyMembershipForm.Show();
        }

        private void btn_LabAnnual_Click(object sender, EventArgs e)
        {
            frm_FitnessLabAnnualMembership FitnessLabAnnualMembershipForm = new frm_FitnessLabAnnualMembership();
            FitnessLabAnnualMembershipForm.Show();
        }

        private void btn_InroToBoulderingClass_Click(object sender, EventArgs e)
        {
            frm_BoulderingClass IntroToBoulderingClassForm = new frm_BoulderingClass();
            IntroToBoulderingClassForm.Show();
        }

        private void btn_IndividualDayPass_Click(object sender, EventArgs e)
        {
            frm_IndividualBoulderDayPass IndividualBoulderDayPassForm = new frm_IndividualBoulderDayPass();
            IndividualBoulderDayPassForm.Show();
        }

        private void btn_TenPassBundle_Click(object sender, EventArgs e)
        {
            frm_TenPunchPass TenPunchPassForm = new frm_TenPunchPass();
            TenPunchPassForm.Show();
        }

        private void btn_MonthlyMembership_Click(object sender, EventArgs e)
        {
            frm_IndividualBoulderMonthlyMembership IndividualBoulderMonthlyMembershipForm = new frm_IndividualBoulderMonthlyMembership();
            IndividualBoulderMonthlyMembershipForm.Show();
        }

        private void btn_IndivAnnualMembership_Click(object sender, EventArgs e)
        {
            frm_IndividualBoulderAnnualMembership IndiviudalBoulderAnnualMembershipForm = new frm_IndividualBoulderAnnualMembership();
            IndiviudalBoulderAnnualMembershipForm.Show();
        }


        private void btn_CouplesMonthly_Click(object sender, EventArgs e)
        {
            frm_CouplesBoulderMonthlyMembership CouplesBoulderMonthlyMembershipForm = new frm_CouplesBoulderMonthlyMembership();
            CouplesBoulderMonthlyMembershipForm.Show();
        }

        private void btn_CouplesAnnual_Click(object sender, EventArgs e)
        {
            frm_CouplesBoulderAnnualMembershipForm CouplesBoulderAnnualMembershipForm = new frm_CouplesBoulderAnnualMembershipForm();
            CouplesBoulderAnnualMembershipForm.Show();
        }

        private void btn_CouplesDay_Click(object sender, EventArgs e)
        {
            frm_CouplesBoulderDayPass CouplesBoulderDayPassForm = new frm_CouplesBoulderDayPass();
            CouplesBoulderDayPassForm.Show();
        }

        private void btn_FamilyMonthly_Click(object sender, EventArgs e)
        {
            frm_FamilyBoulderMonthlyMembership FamilyBoulderMonthlyMembershipForm = new frm_FamilyBoulderMonthlyMembership();
            FamilyBoulderMonthlyMembershipForm.Show();
        }

        private void btn_FamilyAnnual_Click(object sender, EventArgs e)
        {
            frm_FamilyBoulderAnnualMembership FamilyBoulderAnnualMembership = new frm_FamilyBoulderAnnualMembership();
            FamilyBoulderAnnualMembership.Show();
        }

        private void btn_GroupUnder10_Click(object sender, EventArgs e)
        {
            frm_GroupsLessThan10Book GroupsLessThan10Form = new frm_GroupsLessThan10Book();
            GroupsLessThan10Form.Show();
        }

        private void btn_GroupOver10_Click(object sender, EventArgs e)
        {
            frm_GroupsMoreThan10Book GroupsMoreThan10Form = new frm_GroupsMoreThan10Book();
            GroupsMoreThan10Form.Show();
        }
    }
}
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
    public partial class frm_FitnessLabMonthlyMembership : Form
    {
        public frm_FitnessLabMonthlyMembership()
        {
            InitializeComponent();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            string message = ($"Thank you for signing up for a monthly membership, {textBox_FirstName.Text}. See you soon!");
            MessageBox.Show(message);
            this.Close();
        }

        private void textBox_ZipCode_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_ZipCode.Text, out int zipCode))
            {
                MessageBox.Show("Please enter a valid zipcode.");
            }
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_Phone.Text, out int zipCode))
            {
                MessageBox.Show("Please enter numbers only.");
            }
        }

        private void textBox_WaiverDisclaimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_MonthlyFitnessLabMembership_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_StreetAddress.Text == string.Empty ||
                textBox_City.Text == string.Empty || textBox_State.Text == string.Empty || textBox_ZipCode.Text == string.Empty ||
                textBox_Phone.Text == string.Empty || textBox_Email.Text == string.Empty)
            {
                string message = ($"Please fill in all the fields.");
                MessageBox.Show(message);
            }
            else
            {
                if (!this.textBox_Email.Text.Contains('@') || !this.textBox_Email.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email");
                }

                if (!int.TryParse(textBox_ZipCode.Text, out int zipCodeWrong) || textBox_ZipCode.Text.Length < 5)
                {
                    MessageBox.Show("Please enter a valid zipcode.");
                }

                if (!long.TryParse(textBox_Phone.Text, out long PhoneWrong) || textBox_Phone.Text.Length < 10)
                {
                    MessageBox.Show("Please enter a valid phone number.");
                }
                if (int.TryParse(textBox_ZipCode.Text, out int zipCode) && long.TryParse(textBox_Phone.Text, out long Phone) && textBox_ZipCode.Text.Length == 5 && textBox_Phone.Text.Length == 10 && this.textBox_Email.Text.Contains('@') && this.textBox_Email.Text.Contains('.'))
                {
                    string message = ($"Thank you for becoming a member, {textBox_FirstName.Text}. See you soon!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Phone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_Phone_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ZipCode_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_State_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_State_Click(object sender, EventArgs e)
        {

        }

        private void textBox_City_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_City_Click(object sender, EventArgs e)
        {

        }

        private void textBox_StreetAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Address_Click(object sender, EventArgs e)
        {

        }

        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_LastName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_FitnessLabMonthlyMembership_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frm_CouplesBoulderDayPass : Form
    {
        public frm_CouplesBoulderDayPass()
        {
            InitializeComponent();
        }

        private void radioButton_HalfDay_CheckedChanged(object sender, EventArgs e)
        {
            string halfDay = ("$35.00");
            textBox_Total.Text = halfDay;
        }

        private void radioButton_FullDay_CheckedChanged(object sender, EventArgs e)
        {
            string fullDay = ("$60.00");
            textBox_Total.Text = fullDay;
        }
        private void btn_Book_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_PartnerFirstName.Text == String.Empty || textBox_PartnerLastName.Text == string.Empty || textBox_StreetAddress.Text == string.Empty ||
textBox_City.Text == string.Empty || textBox_State.Text == string.Empty || textBox_ZipCode.Text == string.Empty ||
dateTimePicker_FitnessLabDayPass.Text == string.Empty || textBox_Phone.Text == string.Empty || textBox_Email.Text == string.Empty || (!radioButton_HalfDay.Checked && !radioButton_FullDay.Checked))
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
                    string message = ($"Thank you for booking a visit with us. We look forward to seeing you and {textBox_PartnerFirstName.Text} soon!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

    }
}

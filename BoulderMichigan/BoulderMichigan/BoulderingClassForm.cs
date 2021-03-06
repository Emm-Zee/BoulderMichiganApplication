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
    public partial class frm_BoulderingClass : Form
    {
        public frm_BoulderingClass()
        {
            InitializeComponent();
        }

        private void btn_MonthlyFitnessLabMembership_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_StreetAddress.Text == string.Empty ||
              textBox_City.Text == string.Empty || textBox_State.Text == string.Empty || textBox_ZipCode.Text == string.Empty ||
              textBox_Phone.Text == string.Empty || textBox_Email.Text == string.Empty || (!radioButton_Wednesday.Checked 
              && !radioButton_Thursday.Checked && !radioButton_Saturday.Checked && !radioButton_Sunday.Checked))
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
                if (int.TryParse(textBox_ZipCode.Text, out int zipCode) && long.TryParse(textBox_Phone.Text, out long Phone) && 
                    textBox_ZipCode.Text.Length == 5 && textBox_Phone.Text.Length == 10 && this.textBox_Email.Text.Contains('@') 
                    && this.textBox_Email.Text.Contains('.') && (radioButton_Wednesday.Checked
              || radioButton_Thursday.Checked || radioButton_Saturday.Checked || radioButton_Sunday.Checked))
                {
                    string message = ($"You have signed up for an Intro to Bouldering class, {textBox_FirstName.Text}. See you soon!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frm_FamilyBoulderMonthlyMembership : Form
    {
        public frm_FamilyBoulderMonthlyMembership()
        {
            InitializeComponent();
        }

        private void radioButton_ThreeFamilyMember_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ThreeFamilyMembers.Show();
            pnl_FourFamilyMember.Hide();
            pnl_FiveFamilyMember2.Hide();
            string threeMembers = ("$170.00");
            textBox_3FamilyMemberTotal.Text = threeMembers;
            pnl_ThreeFamilyMembers.Height = 300;
        }

        private void radioButton_FourFamilyMember_CheckedChanged(object sender, EventArgs e)
        {
            pnl_FourFamilyMember.Show();
            pnl_ThreeFamilyMembers.Hide();
            pnl_FiveFamilyMember2.Hide();
            string fourMembers = ("$200.00");
            textBox_4FamilyMemberTotal.Text = fourMembers;
            pnl_FourFamilyMember.Height = 350;
        }

        private void radioButton_FiveFamilyMembers2_CheckedChanged_1(object sender, EventArgs e)
        {
            pnl_FiveFamilyMember2.Show();
            pnl_ThreeFamilyMembers.Hide();
            pnl_FourFamilyMember.Hide();
            string fiveMembers = ("$220.00");
            textBox_5FamilyMemberTotal.Text = fiveMembers;
            pnl_FiveFamilyMember2.Height = 430;
        }

        private void btn_MonthlyFitnessLabMembership_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_3FamilyMember2FirstName.Text == string.Empty ||
                textBox_3FamilyMember2LastName.Text == string.Empty || textBox_3FamilyMember3FirstName.Text == string.Empty || textBox_3FamilyMember3LastName.Text == string.Empty ||
                textBox_StreetAddress.Text == string.Empty ||
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
                    string message = ($"Thank you for joining! We look forward to seeing your family soon soon, {textBox_FirstName.Text}!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

        private void btn_4FamilyMemberMonthlyJoin_Click_1(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_4Member2FirstName.Text == string.Empty ||
textBox_4Member2LastName.Text == string.Empty || textBox_4Member3FirstName.Text == string.Empty || textBox_4Member3LastName.Text == string.Empty ||
textBox_4Member4FirstName.Text == string.Empty || textBox_4Member4LastName.Text == string.Empty || textBox_StreetAddress.Text == string.Empty ||
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
                    string message = ($"Thank you for joining! We look forward to seeing your family soon soon, {textBox_FirstName.Text}!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

        private void btn_FiveFamilyMember_Click_1(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == string.Empty || textBox_LastName.Text == string.Empty || textBox_5Member2FirstName.Text == string.Empty ||
     textBox_5Member2LastName.Text == string.Empty || textBox_5Member3FirstName.Text == string.Empty || textBox_5Member3LastName.Text == string.Empty ||
     textBox_5Member4FirstName.Text == string.Empty || textBox_5Member4LastName.Text == string.Empty || textBox_5Member5FirstName.Text == string.Empty ||
     textBox_5Member5LastName.Text == string.Empty || textBox_StreetAddress.Text == string.Empty || textBox_City.Text == string.Empty ||
     textBox_State.Text == string.Empty || textBox_ZipCode.Text == string.Empty || textBox_Phone.Text == string.Empty || textBox_Email.Text == string.Empty)

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
                    string message = ($"Thank you for joining! We look forward to seeing your family soon soon, {textBox_FirstName.Text}!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }

    }
}
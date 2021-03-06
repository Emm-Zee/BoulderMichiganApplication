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
    public partial class frm_TenPunchPass : Form
    {
        public frm_TenPunchPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    string message = ($"Thank you for booking a 10 Punch pass with us, {textBox_FirstName.Text}. Don't forget to pick up your pass at your first visit!");
                    MessageBox.Show(message);
                    this.Close();
                }
            }
        }
    }
}

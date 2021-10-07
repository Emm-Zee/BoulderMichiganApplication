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
    public partial class frm_GroupsLessThan10Book : Form
    {
        public frm_GroupsLessThan10Book()
        {
            InitializeComponent();
        }

        private void btn_ReturnToBookingMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frm_GroupsMoreThan10Book : Form
    {
        public frm_GroupsMoreThan10Book()
        {
            InitializeComponent();
        }

        private void btn_ReturnToBookingMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

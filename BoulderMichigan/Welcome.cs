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
    public partial class frm_Welcome : Form
    {
        public frm_Welcome()
        {
            InitializeComponent();
        }

         void frm_Welcome_Load(object sender, EventArgs e)
        {
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu MenuForm = new frm_Menu();
            MenuForm.Show();
        }
    }
}

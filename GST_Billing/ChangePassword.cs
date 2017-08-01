using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // TODO : Compare current password

            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            // TODO : Get current user name
        }
    }
}

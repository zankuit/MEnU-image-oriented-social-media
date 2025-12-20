using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU
{
    public partial class frmForgetPassword2 : Form
    {
        public frmForgetPassword2()
        {
            InitializeComponent();
        }

        private void btnLoginForgetPassword_Click(object sender, EventArgs e)
        {
            var f = new frmLogin();
            f.Show();
            this.Hide();
        }
    }
}

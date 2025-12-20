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
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSendForgetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmailForgetPassword.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email");
                return;
            }

            try
            {
                var emailSent = await FirebaseAuthService.SendPasswordResetEmailAsync(email);

                if (emailSent)
                {
                    var f = new frmForgetPassword2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown Error!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Unknow error: {ex.Message}");
            }
        }
    }
}

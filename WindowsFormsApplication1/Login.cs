using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "admin" && PasswordTB.Text == "admin")
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(".اطلاعات وارد شده اشتباه است", "خطا");
        }

        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                LoginBtn_Click(sender, e);
        }
    }
}

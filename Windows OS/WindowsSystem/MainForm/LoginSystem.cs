using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_OS
{
    public partial class LoginSystem : Form
    {

        public LoginSystem()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_anmelden_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_passwort.Text == "admin")
            {
                Windows windows = new Windows();
                windows.Show();

                LoginSystem loginSystem = new LoginSystem();
                loginSystem.Hide();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch!");
            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Windows windows = new Windows();
            windows.Show();
        }
    }
}

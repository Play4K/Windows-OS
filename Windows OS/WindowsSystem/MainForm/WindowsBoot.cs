using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_OS.WindowsSystem.MainForm
{
    public partial class windowsBoot : Form
    {
        Point MouseDownLocation;

        public windowsBoot()
        {
            InitializeComponent();
        }

        public void WindowsBooting()
        {
            tmr_windowsBoot.Start();
            lbl_loading.Text = "Booting up Windows";
        }

        private void tmr_windowsBoot_Tick(object sender, EventArgs e)
        {
            xui_pbar_loading.Value += 1;
            if (xui_pbar_loading.Value == 10)
                lbl_loading.Text += ".";
            if (xui_pbar_loading.Value == 30)
                lbl_loading.Text += ".";
            if (xui_pbar_loading.Value == 50)
            {
                tmr_windowsBoot.Stop();
                this.Hide();
                LoginSystem loginSystemForm = new LoginSystem();
                loginSystemForm.Show();
            }

        }

        private void windowsBoot_Load(object sender, EventArgs e)
        {
            WindowsBooting();
        }

        private void windowsBoot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                windowsBoot.ActiveForm.Left += e.X - MouseDownLocation.X;
                windowsBoot.ActiveForm.Top += e.Y - MouseDownLocation.Y;
            }
        }

        private void windowsBoot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
    }
}

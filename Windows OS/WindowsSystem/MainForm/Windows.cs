using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Windows_OS.WindowsSystem.Forms;

namespace Windows_OS
{
    public partial class Windows : Form
    {
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        public Windows()
        {
            InitializeComponent();
            
        }
        private void Windows_Load(object sender, EventArgs e)
        {
            Lbl_Time.Text = DateTime.Now.ToString("HH:mm");
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void btn_windows_Click(object sender, EventArgs e)
        {
            if (pn_windowsStartMenu.Visible == false)
            {
                pn_windowsStartMenu.Visible = true;
            }
            else
            {
                pn_windowsStartMenu.Visible = false;
            }
        }

        private void btn_herunterfahren_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_neuStartenDropDown_Click(object sender, EventArgs e)
        {
            if (btn_neustarten.Visible == false)
            {
                btn_neustarten.Visible = true;
            }
            else
            {
                btn_neustarten.Visible = false;
            }
        }

        private void lbl_einstellungen_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void pb_profil_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil();
            profilForm.Show();
        }

        private void pn_computer_desktopElement_Click(object sender, EventArgs e)
        {
            Computer computerForm = new Computer();
            computerForm.Show();
        }
        
        private void txt_windowsBarSearch_Click(object sender, EventArgs e)
        {
            if (txt_windowsBarSearch.Text == "Search")
            {
                txt_windowsBarSearch.Text = "";
            }
        }

        private void btn_abmelden_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lbl_computer_Click(object sender, EventArgs e)
        {
            Computer computerForm = new Computer();
            int computerFormCount = Application.OpenForms.OfType<Computer>().Count();
            if (computerFormCount < 1)
            {
                computerForm.Show();
            }
            else
            {
                computerForm.BringToFront();
            }
        }

        private void lbl_Profil_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil();
            profilForm.Show();
        }

        private void pn_einstellungen_desktop(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            int openCount = 0;
            if (openCount < 1)
            {
                settingsForm.Show();
                openCount += 1;
            }
            else
            {
                settingsForm.Focus();
                settingsForm.BringToFront();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pb_taschenrechner_desktop_Click(object sender, EventArgs e)
        {

        }

        private void pb_netBrowser_desktop_Click(object sender, EventArgs e)
        {
            NetBrowser netBrowserForm = NetBrowser.NetBrowserInstance;
            netBrowserForm.Show();
            netBrowserForm.BringToFront();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTime_Tick(object sender, EventArgs e)
        {
            
        }

        private void pn_ordner_desktopElement_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Dtp_Windows_Leave(object sender, EventArgs e)
        {
            Dtp_Windows.Value = DateTime.Now;
        }

        private void Pbx_ComputerDesktop_Click(object sender, EventArgs e)
        {
            Computer computerForm = new Computer();
            computerForm.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void Pbx_EmailDesktop_Click(object sender, EventArgs e)
        {
            Email emailForm = new Email();
            emailForm.Show();
        }

        private void Pbx_MessengerDekstop_Click(object sender, EventArgs e)
        {
            Messenger messengerForm = new Messenger();
            messengerForm.Show();
        }
    }
}

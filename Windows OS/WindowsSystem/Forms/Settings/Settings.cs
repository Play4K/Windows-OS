using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_OS.WindowsSystem.Forms
{
    public partial class Settings : Form
    {
        public static Settings settingsInstance = null;
        Point MouseDownLocation;

        public Settings()
        {
            if (settingsInstance != null)
            {
                return;
            }
            settingsInstance = this;
            InitializeComponent();
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {
            SettingsMenu settingsMenu = new SettingsMenu();
            Pnl_Container.Controls.Add(settingsMenu);
        }

        public Panel PanelContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }

        private void ts_close_pc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ts_pc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void ts_pc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Settings.ActiveForm.Left += e.X - MouseDownLocation.X;
                Settings.ActiveForm.Top += e.Y - MouseDownLocation.Y;

            }
        }

        
    }
}

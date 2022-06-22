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
    public partial class SettingsMenu : UserControl
    {
        Point MouseDownLocation;

        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil();
            profilForm.Show();
        }

        private void Tsp_MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Tsp_MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Settings.ActiveForm.Left += e.X - MouseDownLocation.X;
                Settings.ActiveForm.Top += e.Y - MouseDownLocation.Y;

            }
        }

        private void Apperance_Click(object sender, EventArgs e)
        {
            ApperanceSettings apperanceSettingsControl = new ApperanceSettings();
            Settings.settingsInstance.PanelContainer.Controls.Clear();
            Settings.settingsInstance.PanelContainer.Controls.Add(apperanceSettingsControl);
        }
    }
}

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
    public partial class ApperanceSettings : UserControl
    {
        Point MouseDownLocation;

        public ApperanceSettings()
        {
            InitializeComponent();
        }

        private void Tsp_Close_Click(object sender, EventArgs e)
        {
            ActiveControl.Hide();
        }

        private void Tsp_Minimize_Click(object sender, EventArgs e)
        {
            ActiveControl.Hide();
        }

        private void Tsp_MenuBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Tsp_MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Settings.ActiveForm.Left += e.X - MouseDownLocation.X;
                Settings.ActiveForm.Top += e.Y - MouseDownLocation.Y;

            }
        }
    }
}

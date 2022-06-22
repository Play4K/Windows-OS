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
    public partial class Profil : Form
    {
        Point MouseDownLoaction;

        public Profil()
        {
            InitializeComponent();
        }

        private void ts_close_pc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ts_pc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLoaction = e.Location;
            }
        }

        private void ts_pc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Profil.ActiveForm.Left += e.X - MouseDownLoaction.X;
                Profil.ActiveForm.Top += e.Y - MouseDownLoaction.Y;
            }
        }
    }
}

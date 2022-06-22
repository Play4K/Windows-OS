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
    public partial class Computer : Form
    {
        Point MouseDownLocation;

        public Computer()
        {
            InitializeComponent();
            
        }

        private void tsb_close_pc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tsb_Minimze_pc_Click(object sender, EventArgs e)
        {

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
                Computer.ActiveForm.Left += e.X - MouseDownLocation.X;
                Computer.ActiveForm.Top += e.Y - MouseDownLocation.Y;

            }
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
                Computer.ActiveForm.Left += e.X - MouseDownLocation.X;
                Computer.ActiveForm.Top += e.Y - MouseDownLocation.Y;

            }
        }
    }
}

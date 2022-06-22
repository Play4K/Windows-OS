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
    public partial class NetBrowser : Form
    {
        public static NetBrowser netBrowserInstance = new NetBrowser();

        public static NetBrowser NetBrowserInstance
        {
            get { return netBrowserInstance; }
        }

        public NetBrowser()
        {
            InitializeComponent();
        }

        private void NetBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}

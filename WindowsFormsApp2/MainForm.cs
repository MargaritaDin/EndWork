using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loginUserControl1.LoginEvent += OnLogin;
        }

        public void OnLogin(object sender, EventArgs e)
        {
            loginUserControl1.Visible = false;
        }
    }
}

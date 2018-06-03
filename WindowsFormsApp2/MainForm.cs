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
            if (loginUserControl1.Visible == false)
                button2.Visible = true;
                label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}

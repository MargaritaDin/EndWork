using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler LoginEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new LoginService();
            if (login.Login(textBox1.Text.Trim(), textBox2.Text.Trim()))
            {
                if(LoginEvent != null)
                {
                    LoginEvent(this, EventArgs.Empty);
                }
            }
        }
    }
}

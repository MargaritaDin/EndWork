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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form3();
            ifrm.Show();
        }

        private void постачальникиПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }
    }
}

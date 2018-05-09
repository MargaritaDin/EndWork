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

        private void postachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servisniy_CentrDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Zapchastunu". При необходимости она может быть перемещена или удалена.
            this.zapchastunuTableAdapter.Fill(this.servisniy_CentrDataSet.Zapchastunu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.servisniy_CentrDataSet.Postavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Postach". При необходимости она может быть перемещена или удалена.
            this.postachTableAdapter.Fill(this.servisniy_CentrDataSet.Postach);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.postachTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.postavkiTableAdapter.Update(this.servisniy_CentrDataSet);
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void postachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servisniy_CentrDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Postach". При необходимости она может быть перемещена или удалена.
            this.postachTableAdapter.Fill(this.servisniy_CentrDataSet.Postach);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.postachTableAdapter.Update(this.servisniy_CentrDataSet);
        }
    }
}

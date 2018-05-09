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

   
       


        private void постачальникиПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           tabControl1.Visible = true;
            tabControl2.Visible = false;

        }

        private void postachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servisniy_CentrDataSet);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Type_Zap". При необходимости она может быть перемещена или удалена.
            this.type_ZapTableAdapter.Fill(this.servisniy_CentrDataSet.Type_Zap);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Zapchastunu". При необходимости она может быть перемещена или удалена.
            this.zapchastunuTableAdapter.Fill(this.servisniy_CentrDataSet.Zapchastunu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.servisniy_CentrDataSet.Postavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Postach". При необходимости она может быть перемещена или удалена.
            this.postachTableAdapter.Fill(this.servisniy_CentrDataSet.Postach);
        }
              private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
                {
                    {
                        MessageBox.Show("Ошибка ввода !");
                        anError.ThrowException = false;
                    }

                    
                 } 
            
        


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.postachTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.postavkiTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.zapchastunuTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void запчастиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl2.Visible = true; 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

    }
}

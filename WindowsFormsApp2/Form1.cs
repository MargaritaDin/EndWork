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
        private Servisniy_CentrDataSet.Akt_peredachi_v_remontDataTable akt_peredachi_v_remontDataTable;

        public Form1()
        {
            InitializeComponent();
           
        }

   
       


        private void постачальникиПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           tabControl1.Visible = true;
           tabControl2.Visible = false;
           tabControl3.Visible = false;
            tabControl4.Visible = false;
            tabControl5.Visible = false;
            tabControl6.Visible = false;
            tabControl7.Visible = false;

        }

        private void postachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servisniy_CentrDataSet);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Akt_peredachi_v_remont". При необходимости она может быть перемещена или удалена.
            this.akt_peredachi_v_remontTableAdapter.Fill(this.servisniy_CentrDataSet.Akt_peredachi_v_remont);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Pracivnuku". При необходимости она может быть перемещена или удалена.
            this.pracivnukuTableAdapter.Fill(this.servisniy_CentrDataSet.Pracivnuku);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Stan". При необходимости она может быть перемещена или удалена.
            this.stanTableAdapter.Fill(this.servisniy_CentrDataSet.Stan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.servisniy_CentrDataSet.Tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Tehnika". При необходимости она может быть перемещена или удалена.
            this.tehnikaTableAdapter.Fill(this.servisniy_CentrDataSet.Tehnika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Posluga". При необходимости она может быть перемещена или удалена.
            this.poslugaTableAdapter.Fill(this.servisniy_CentrDataSet.Posluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Zdiysn_Poslugi". При необходимости она может быть перемещена или удалена.
            this.zdiysn_PoslugiTableAdapter.Fill(this.servisniy_CentrDataSet.Zdiysn_Poslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Prodaj_Tehn". При необходимости она может быть перемещена или удалена.
            this.prodaj_TehnTableAdapter.Fill(this.servisniy_CentrDataSet.Prodaj_Tehn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "servisniy_CentrDataSet.Prodaj_Zap". При необходимости она может быть перемещена или удалена.
            this.prodaj_ZapTableAdapter.Fill(this.servisniy_CentrDataSet.Prodaj_Zap);

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
            tabControl2.Visible = true; 
            tabControl1.Visible = false;
            tabControl3.Visible = false;
            tabControl4.Visible = false;
            tabControl5.Visible = false;
            tabControl6.Visible = false;
            tabControl7.Visible = false;

        }

        

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            this.prodaj_ZapTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton37_Click(object sender, EventArgs e)
        {
            this.prodaj_TehnTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            this.type_ZapTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void продажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Visible = true;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl5.Visible = false;
            tabControl4.Visible = false;
            tabControl6.Visible = false;
            tabControl7.Visible = false;
        }

        private void toolStripButton44_Click(object sender, EventArgs e)
        {
            this.zdiysn_PoslugiTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton51_Click(object sender, EventArgs e)
        {
            this.poslugaTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void послугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl4.Visible = true;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            tabControl5.Visible = false;
            tabControl6.Visible = false;
            tabControl7.Visible = false;
        }

        private void технікаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl5.Visible = true;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl4.Visible = false;
            tabControl3.Visible = false;
            tabControl6.Visible = false;
            tabControl7.Visible = false;
        }

        private void оформленняПослугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            tabControl6.Visible = true;
            tabControl5.Visible = false;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl4.Visible = false;
            tabControl3.Visible = false;
            tabControl7.Visible = false;
        }

        private void списокПрацівниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl7.Visible = true;
            tabControl6.Visible = false;
            tabControl5.Visible = false;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl4.Visible = false;
            tabControl3.Visible = false;
        }

        private void toolStripButton79_Click(object sender, EventArgs e)
        {
            this.akt_peredachi_v_remontTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton58_Click(object sender, EventArgs e)
        {
            this.tehnikaTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton72_Click(object sender, EventArgs e)
        {
            this.stanTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton65_Click(object sender, EventArgs e)
        {
            this.tipTableAdapter.Update(this.servisniy_CentrDataSet);
        }

        private void toolStripButton86_Click(object sender, EventArgs e)
        {
            this.pracivnukuTableAdapter.Update(this.servisniy_CentrDataSet);
        }
    }
}

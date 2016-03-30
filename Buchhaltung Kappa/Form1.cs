using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchhaltung_Kappa
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                neger();
            }
            catch
            {
                MessageBox.Show("ayy lmao");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            neger();
        }
        public void neger()
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Eingang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.eingangTableAdapter.Fill(this.databaseDataSet1.Eingang);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Ausgang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.ausgangTableAdapter.Fill(this.databaseDataSet1.Ausgang);
        }
    }
}

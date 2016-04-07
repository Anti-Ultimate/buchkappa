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
        private int ID;


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
                dataLoad();
            }
            catch
            {
                MessageBox.Show("ayy lmao");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Eingang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.eingangTableAdapter.Fill(this.databaseDataSet1.Eingang);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Ausgang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.ausgangTableAdapter.Fill(this.databaseDataSet1.Ausgang);
        }

        public void dataLoad()
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Eingang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.eingangTableAdapter.Fill(this.databaseDataSet1.Eingang);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Ausgang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.ausgangTableAdapter.Fill(this.databaseDataSet1.Ausgang);
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void eingangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (betragsart.SelectedItem.ToString() == "Eingang\t")
            {
                this.eingangTableAdapter.Insert(Datum.Text, vDatum.Text, bezeichnung.Text, betrag.Text, mwststeuer.Text, mwst.Text);
                this.eingangTableAdapter.Update(this.databaseDataSet1.Eingang);
                this.dataGridView2.Refresh();
                dataLoad();
            }
            else
            {
                this.ausgangTableAdapter.Insert(Datum.Text, vDatum.Text, bezeichnung.Text, betrag.Text, mwststeuer.Text, mwst.Text);
                this.ausgangTableAdapter.Update(this.databaseDataSet1.Ausgang);
                this.dataGridView1.Refresh();
                dataLoad();
            }
        }

        private void mwststeuer_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (mwststeuer.Text != "")
                {
                    double iMwstPercent;
                    iMwstPercent = double.Parse(mwststeuer.Text);

                    double dBetrag;
                    dBetrag = double.Parse(betrag.Text);

                    double dMwst;
                    dMwst = dBetrag / 100 * iMwstPercent;

                    mwst.Text = dMwst.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Steuerbetrag ein");
            }
        }
    }
}

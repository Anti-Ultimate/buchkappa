﻿using System;
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
    public partial class Buchhaltung : Form
    {
        private int ID;
        private double gefahrenekm;


        public Buchhaltung()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet4.KMBuch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kMBuchTableAdapter.Fill(this.kmBuchDataset.KMBuch);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet3.KMBuch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kMBuchTableAdapter.Fill(this.kmBuchDataset.KMBuch);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kmBuchDataset.KMBuch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kMBuchTableAdapter.Fill(this.kmBuchDataset.KMBuch);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Eingang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.eingangTableAdapter.Fill(this.databaseDataSet1.Eingang);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet1.Ausgang". Sie können sie bei Bedarf verschieben oder entfernen.
            this.ausgangTableAdapter.Fill(this.databaseDataSet1.Ausgang);
        }

        public void dataLoad()
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kmBuchDataset.KMBuch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kMBuchTableAdapter.Fill(this.kmBuchDataset.KMBuch);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Bitte wählen Sie eine Betrags - Art aus!s");
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
                mwststeuer.Text = "";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Bitte wählen Sie eine Betrags - Art aus!s");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bezeichnung.Text = "";
            Datum.Text = "";
            vDatum.Text = "";
            betrag.Text = "";
            mwst.Text = "";
            betragsart.Text = "";
            mwststeuer.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            Datum.Text = dataGridView1[0, row].Value.ToString();
            vDatum.Text = dataGridView1[1, row].Value.ToString();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.eingangTableAdapter.Insert(Datum.Text, vDatum.Text, bezeichnung.Text, betrag.Text, mwststeuer.Text, mwst.Text);
            //this.eingangTableAdapter.Update(this.databaseDataSet1.Eingang);
            //this.dataGridView2.Refresh();
            this.kMBuchTableAdapter.Insert(kmDatumUser.Text, kmStreckeUser.Text, kmZweckUser.Text, int.Parse(kmAnfangUser.Text), int.Parse(kmEndeUser.Text), 0);

            // this.kMBuchTableAdapter.Insert(kmDatumUser.Text, kmStreckeUser.Text, kmZweckUser.Text, int.Parse(kmAnfangUser.Text), int.Parse(kmEndeUser.Text), int.Parse(kmGefahrKMUser.Text));
            this.kMBuchTableAdapter.Update(this.kmBuchDataset.KMBuch);
            this.dataGridViewKM.Refresh();
            dataLoad();
        }

        private void dataGridViewKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            kmStreckeUser.Text = "";
            kmDatumUser.Text = "";
            kmZweckUser.Text = "";
            kmAnfangUser.Text = "";
            kmEndeUser.Text = "";
            kmGefahrKMUser.Text = "0";
        }

        private void kmAnfangUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kmAnfangUser.Text != "" && kmEndeUser.Text != "")
                {
                    gefahrenekm = int.Parse(kmEndeUser.Text) - int.Parse(kmAnfangUser.Text);
                    kmGefahrKMUser.Text = gefahrenekm.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Keine Zahl als Kilometerwert angegeben");
                resetkmbox();
            }
        }

        private void kmEndeUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kmAnfangUser.Text != "" && kmEndeUser.Text != "")
                {
                    gefahrenekm = int.Parse(kmEndeUser.Text) - int.Parse(kmAnfangUser.Text);
                    kmGefahrKMUser.Text = gefahrenekm.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Keine Zahl als Kilometerwert angegeben");
                resetkmbox();

            }
        }

        private void resetkmbox()
        {
            kmEndeUser.Text = "";
            kmAnfangUser.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

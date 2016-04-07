namespace Buchhaltung_Kappa
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eintragen = new System.Windows.Forms.Button();
            this.mwststeuer = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.mwst = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.betrag = new System.Windows.Forms.TextBox();
            this.vDatum = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.betragsart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechnungsDatumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eingangsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustSummeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eingangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Buchhaltung_Kappa.databaseDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechnungsDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausgangsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustSummeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausgangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ausgangTableAdapter = new Buchhaltung_Kappa.databaseDataSet1TableAdapters.AusgangTableAdapter();
            this.eingangTableAdapter = new Buchhaltung_Kappa.databaseDataSet1TableAdapters.EingangTableAdapter();
            this.bezeichnung = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eingangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 605);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.bezeichnung);
            this.tabPage1.Controls.Add(this.eintragen);
            this.tabPage1.Controls.Add(this.mwststeuer);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.mwst);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.betrag);
            this.tabPage1.Controls.Add(this.vDatum);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.Datum);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.betragsart);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Journal";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // eintragen
            // 
            this.eintragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eintragen.Location = new System.Drawing.Point(753, 506);
            this.eintragen.Name = "eintragen";
            this.eintragen.Size = new System.Drawing.Size(160, 52);
            this.eintragen.TabIndex = 3;
            this.eintragen.Text = "Eintragen";
            this.eintragen.UseVisualStyleBackColor = true;
            this.eintragen.Click += new System.EventHandler(this.button3_Click);
            // 
            // mwststeuer
            // 
            this.mwststeuer.Location = new System.Drawing.Point(621, 536);
            this.mwststeuer.Name = "mwststeuer";
            this.mwststeuer.Size = new System.Drawing.Size(120, 20);
            this.mwststeuer.TabIndex = 15;
            this.mwststeuer.TextChanged += new System.EventHandler(this.mwststeuer_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(531, 538);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(85, 15);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "Prozentsatz :";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(363, 538);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 15);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "Mwst :";
            // 
            // mwst
            // 
            this.mwst.Enabled = false;
            this.mwst.Location = new System.Drawing.Point(408, 537);
            this.mwst.Name = "mwst";
            this.mwst.Size = new System.Drawing.Size(100, 20);
            this.mwst.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(356, 511);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(46, 15);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Betrag:";
            // 
            // betrag
            // 
            this.betrag.Location = new System.Drawing.Point(408, 510);
            this.betrag.Name = "betrag";
            this.betrag.Size = new System.Drawing.Size(100, 20);
            this.betrag.TabIndex = 3;
            // 
            // vDatum
            // 
            this.vDatum.Location = new System.Drawing.Point(170, 536);
            this.vDatum.Name = "vDatum";
            this.vDatum.Size = new System.Drawing.Size(121, 20);
            this.vDatum.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(39, 537);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 15);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Verarbeitungsdatum:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(121, 511);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 15);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Datum:";
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(170, 510);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(531, 510);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 15);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Betrags - Art:";
            // 
            // betragsart
            // 
            this.betragsart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betragsart.FormattingEnabled = true;
            this.betragsart.Items.AddRange(new object[] {
            "Eingang\t",
            "Ausgang"});
            this.betragsart.Location = new System.Drawing.Point(621, 506);
            this.betragsart.Name = "betragsart";
            this.betragsart.Size = new System.Drawing.Size(120, 24);
            this.betragsart.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(753, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fenster aktualisieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Ausgang";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Eingang";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.rechnungsDatumDataGridViewTextBoxColumn1,
            this.eingangsdatumDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn1,
            this.wertDataGridViewTextBoxColumn1,
            this.ustDataGridViewTextBoxColumn1,
            this.ustSummeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.eingangBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(169, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 210);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // rechnungsDatumDataGridViewTextBoxColumn1
            // 
            this.rechnungsDatumDataGridViewTextBoxColumn1.DataPropertyName = "Rechnungs - Datum";
            this.rechnungsDatumDataGridViewTextBoxColumn1.HeaderText = "Rechnungs - Datum";
            this.rechnungsDatumDataGridViewTextBoxColumn1.Name = "rechnungsDatumDataGridViewTextBoxColumn1";
            // 
            // eingangsdatumDataGridViewTextBoxColumn
            // 
            this.eingangsdatumDataGridViewTextBoxColumn.DataPropertyName = "Eingangsdatum";
            this.eingangsdatumDataGridViewTextBoxColumn.HeaderText = "Eingangsdatum";
            this.eingangsdatumDataGridViewTextBoxColumn.Name = "eingangsdatumDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn1
            // 
            this.bezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn1.Name = "bezeichnungDataGridViewTextBoxColumn1";
            // 
            // wertDataGridViewTextBoxColumn1
            // 
            this.wertDataGridViewTextBoxColumn1.DataPropertyName = "Wert";
            this.wertDataGridViewTextBoxColumn1.HeaderText = "Wert";
            this.wertDataGridViewTextBoxColumn1.Name = "wertDataGridViewTextBoxColumn1";
            // 
            // ustDataGridViewTextBoxColumn1
            // 
            this.ustDataGridViewTextBoxColumn1.DataPropertyName = "Ust";
            this.ustDataGridViewTextBoxColumn1.HeaderText = "Ust";
            this.ustDataGridViewTextBoxColumn1.Name = "ustDataGridViewTextBoxColumn1";
            // 
            // ustSummeDataGridViewTextBoxColumn1
            // 
            this.ustSummeDataGridViewTextBoxColumn1.DataPropertyName = "Ust - Summe";
            this.ustSummeDataGridViewTextBoxColumn1.HeaderText = "Ust - Summe";
            this.ustSummeDataGridViewTextBoxColumn1.Name = "ustSummeDataGridViewTextBoxColumn1";
            // 
            // eingangBindingSource
            // 
            this.eingangBindingSource.DataMember = "Eingang";
            this.eingangBindingSource.DataSource = this.databaseDataSet1BindingSource;
            this.eingangBindingSource.CurrentChanged += new System.EventHandler(this.eingangBindingSource_CurrentChanged);
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rechnungsDatumDataGridViewTextBoxColumn,
            this.ausgangsdatumDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.wertDataGridViewTextBoxColumn,
            this.ustDataGridViewTextBoxColumn,
            this.ustSummeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ausgangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(170, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // rechnungsDatumDataGridViewTextBoxColumn
            // 
            this.rechnungsDatumDataGridViewTextBoxColumn.DataPropertyName = "Rechnungs - Datum";
            this.rechnungsDatumDataGridViewTextBoxColumn.HeaderText = "Rechnungs - Datum";
            this.rechnungsDatumDataGridViewTextBoxColumn.Name = "rechnungsDatumDataGridViewTextBoxColumn";
            // 
            // ausgangsdatumDataGridViewTextBoxColumn
            // 
            this.ausgangsdatumDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsdatum";
            this.ausgangsdatumDataGridViewTextBoxColumn.HeaderText = "Ausgangsdatum";
            this.ausgangsdatumDataGridViewTextBoxColumn.Name = "ausgangsdatumDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // wertDataGridViewTextBoxColumn
            // 
            this.wertDataGridViewTextBoxColumn.DataPropertyName = "Wert";
            this.wertDataGridViewTextBoxColumn.HeaderText = "Wert";
            this.wertDataGridViewTextBoxColumn.Name = "wertDataGridViewTextBoxColumn";
            // 
            // ustDataGridViewTextBoxColumn
            // 
            this.ustDataGridViewTextBoxColumn.DataPropertyName = "Ust";
            this.ustDataGridViewTextBoxColumn.HeaderText = "Ust";
            this.ustDataGridViewTextBoxColumn.Name = "ustDataGridViewTextBoxColumn";
            // 
            // ustSummeDataGridViewTextBoxColumn
            // 
            this.ustSummeDataGridViewTextBoxColumn.DataPropertyName = "Ust - Summe";
            this.ustSummeDataGridViewTextBoxColumn.HeaderText = "Ust - Summe";
            this.ustSummeDataGridViewTextBoxColumn.Name = "ustSummeDataGridViewTextBoxColumn";
            // 
            // ausgangBindingSource
            // 
            this.ausgangBindingSource.DataMember = "Ausgang";
            this.ausgangBindingSource.DataSource = this.databaseDataSet1BindingSource;
            // 
            // ausgangTableAdapter
            // 
            this.ausgangTableAdapter.ClearBeforeFill = true;
            // 
            // eingangTableAdapter
            // 
            this.eingangTableAdapter.ClearBeforeFill = true;
            // 
            // bezeichnung
            // 
            this.bezeichnung.Location = new System.Drawing.Point(169, 475);
            this.bezeichnung.Name = "bezeichnung";
            this.bezeichnung.Size = new System.Drawing.Size(572, 20);
            this.bezeichnung.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(63, 476);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 15);
            this.textBox12.TabIndex = 17;
            this.textBox12.Text = "Bezeichnung:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 620);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eingangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource databaseDataSet1BindingSource;
        private databaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource ausgangBindingSource;
        private databaseDataSet1TableAdapters.AusgangTableAdapter ausgangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rechnungsDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ausgangsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustSummeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eingangBindingSource;
        private databaseDataSet1TableAdapters.EingangTableAdapter eingangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rechnungsDatumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eingangsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustSummeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox betragsart;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Datum;
        private System.Windows.Forms.TextBox vDatum;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox betrag;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox mwst;
        private System.Windows.Forms.TextBox mwststeuer;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button eintragen;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox bezeichnung;
    }
}


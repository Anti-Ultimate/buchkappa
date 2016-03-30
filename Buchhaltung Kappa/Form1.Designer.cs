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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet1 = new Buchhaltung_Kappa.databaseDataSet1();
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ausgangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ausgangTableAdapter = new Buchhaltung_Kappa.databaseDataSet1TableAdapters.AusgangTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechnungsDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausgangsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustSummeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eingangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eingangTableAdapter = new Buchhaltung_Kappa.databaseDataSet1TableAdapters.EingangTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechnungsDatumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eingangsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustSummeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eingangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 593);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übersicht";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.Location = new System.Drawing.Point(311, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 210);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(311, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1077, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bearbeiten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Eingang";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(56, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Ausgang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
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
            // eingangBindingSource
            // 
            this.eingangBindingSource.DataMember = "Eingang";
            this.eingangBindingSource.DataSource = this.databaseDataSet1BindingSource;
            // 
            // eingangTableAdapter
            // 
            this.eingangTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 617);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eingangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}


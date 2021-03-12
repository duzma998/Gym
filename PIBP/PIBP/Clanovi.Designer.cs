namespace PIBP
{
    partial class Clanovi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataClanovi = new PIBP.DataClanovi();
            this.cLANOVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLANOVITableAdapter = new PIBP.DataClanoviTableAdapters.CLANOVITableAdapter();
            this.cLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREZIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bROJTELEFONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMRODJENJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLANARINAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLANOVIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLANIDDataGridViewTextBoxColumn,
            this.iMEDataGridViewTextBoxColumn,
            this.pREZIMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.bROJTELEFONADataGridViewTextBoxColumn,
            this.dATUMRODJENJADataGridViewTextBoxColumn,
            this.cLANARINAIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLANOVIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataClanovi
            // 
            this.dataClanovi.DataSetName = "DataClanovi";
            this.dataClanovi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLANOVIBindingSource
            // 
            this.cLANOVIBindingSource.DataMember = "CLANOVI";
            this.cLANOVIBindingSource.DataSource = this.dataClanovi;
            this.cLANOVIBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.cLANOVIBindingSource_AddingNew);
            // 
            // cLANOVITableAdapter
            // 
            this.cLANOVITableAdapter.ClearBeforeFill = true;
            // 
            // cLANIDDataGridViewTextBoxColumn
            // 
            this.cLANIDDataGridViewTextBoxColumn.DataPropertyName = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.HeaderText = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.Name = "cLANIDDataGridViewTextBoxColumn";
            // 
            // iMEDataGridViewTextBoxColumn
            // 
            this.iMEDataGridViewTextBoxColumn.DataPropertyName = "IME";
            this.iMEDataGridViewTextBoxColumn.HeaderText = "IME";
            this.iMEDataGridViewTextBoxColumn.Name = "iMEDataGridViewTextBoxColumn";
            // 
            // pREZIMEDataGridViewTextBoxColumn
            // 
            this.pREZIMEDataGridViewTextBoxColumn.DataPropertyName = "PREZIME";
            this.pREZIMEDataGridViewTextBoxColumn.HeaderText = "PREZIME";
            this.pREZIMEDataGridViewTextBoxColumn.Name = "pREZIMEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // bROJTELEFONADataGridViewTextBoxColumn
            // 
            this.bROJTELEFONADataGridViewTextBoxColumn.DataPropertyName = "BROJTELEFONA";
            this.bROJTELEFONADataGridViewTextBoxColumn.HeaderText = "BROJTELEFONA";
            this.bROJTELEFONADataGridViewTextBoxColumn.Name = "bROJTELEFONADataGridViewTextBoxColumn";
            // 
            // dATUMRODJENJADataGridViewTextBoxColumn
            // 
            this.dATUMRODJENJADataGridViewTextBoxColumn.DataPropertyName = "DATUMRODJENJA";
            this.dATUMRODJENJADataGridViewTextBoxColumn.HeaderText = "DATUMRODJENJA";
            this.dATUMRODJENJADataGridViewTextBoxColumn.Name = "dATUMRODJENJADataGridViewTextBoxColumn";
            // 
            // cLANARINAIDDataGridViewTextBoxColumn
            // 
            this.cLANARINAIDDataGridViewTextBoxColumn.DataPropertyName = "CLANARINAID";
            this.cLANARINAIDDataGridViewTextBoxColumn.HeaderText = "CLANARINAID";
            this.cLANARINAIDDataGridViewTextBoxColumn.Name = "cLANARINAIDDataGridViewTextBoxColumn";
            // 
            // Clanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 536);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clanovi";
            this.Text = "Clanovi";
            this.Load += new System.EventHandler(this.Clanovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLANOVIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataClanovi dataClanovi;
        private System.Windows.Forms.BindingSource cLANOVIBindingSource;
        private DataClanoviTableAdapters.CLANOVITableAdapter cLANOVITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREZIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bROJTELEFONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMRODJENJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLANARINAIDDataGridViewTextBoxColumn;
    }
}
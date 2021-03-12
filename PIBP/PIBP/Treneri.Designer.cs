namespace PIBP
{
    partial class Treneri
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
            this.tRENERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREZIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMRODJENJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRENERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTreneri = new PIBP.DataTreneri();
            this.dataClanovi = new PIBP.DataClanovi();
            this.dataClanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRENERITableAdapter = new PIBP.DataTreneriTableAdapters.TRENERITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTreneri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRENERIDDataGridViewTextBoxColumn,
            this.iMEDataGridViewTextBoxColumn,
            this.pREZIMEDataGridViewTextBoxColumn,
            this.pOLIDDataGridViewTextBoxColumn,
            this.dATUMRODJENJADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRENERIBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 567);
            this.dataGridView1.TabIndex = 0;
            // 
            // tRENERIDDataGridViewTextBoxColumn
            // 
            this.tRENERIDDataGridViewTextBoxColumn.DataPropertyName = "TRENERID";
            this.tRENERIDDataGridViewTextBoxColumn.HeaderText = "TRENERID";
            this.tRENERIDDataGridViewTextBoxColumn.Name = "tRENERIDDataGridViewTextBoxColumn";
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
            // pOLIDDataGridViewTextBoxColumn
            // 
            this.pOLIDDataGridViewTextBoxColumn.DataPropertyName = "POLID";
            this.pOLIDDataGridViewTextBoxColumn.HeaderText = "POLID";
            this.pOLIDDataGridViewTextBoxColumn.Name = "pOLIDDataGridViewTextBoxColumn";
            // 
            // dATUMRODJENJADataGridViewTextBoxColumn
            // 
            this.dATUMRODJENJADataGridViewTextBoxColumn.DataPropertyName = "DATUMRODJENJA";
            this.dATUMRODJENJADataGridViewTextBoxColumn.HeaderText = "DATUMRODJENJA";
            this.dATUMRODJENJADataGridViewTextBoxColumn.Name = "dATUMRODJENJADataGridViewTextBoxColumn";
            // 
            // tRENERIBindingSource
            // 
            this.tRENERIBindingSource.DataMember = "TRENERI";
            this.tRENERIBindingSource.DataSource = this.dataTreneri;
            this.tRENERIBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tRENERIBindingSource_AddingNew);
            // 
            // dataTreneri
            // 
            this.dataTreneri.DataSetName = "DataTreneri";
            this.dataTreneri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataClanovi
            // 
            this.dataClanovi.DataSetName = "DataClanovi";
            this.dataClanovi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataClanoviBindingSource
            // 
            this.dataClanoviBindingSource.DataSource = this.dataClanovi;
            this.dataClanoviBindingSource.Position = 0;
            // 
            // tRENERITableAdapter
            // 
            this.tRENERITableAdapter.ClearBeforeFill = true;
            // 
            // Treneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Treneri";
            this.Text = "Treneri";
            this.Load += new System.EventHandler(this.Treneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTreneri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClanoviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataClanoviBindingSource;
        private DataClanovi dataClanovi;
        private DataTreneri dataTreneri;
        private System.Windows.Forms.BindingSource tRENERIBindingSource;
        private DataTreneriTableAdapters.TRENERITableAdapter tRENERITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRENERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREZIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMRODJENJADataGridViewTextBoxColumn;
    }
}
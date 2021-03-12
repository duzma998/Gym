namespace PIBP
{
    partial class Evidencija
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
            this.dataEvidencije1 = new PIBP.DataEvidencije1();
            this.eVIDENCIJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVIDENCIJETableAdapter = new PIBP.DataEvidencije1TableAdapters.EVIDENCIJETableAdapter();
            this.cLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSLUGAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMUCLANJENJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMOBNOVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bROJDOLAZAKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvidencije1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIJEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLANIDDataGridViewTextBoxColumn,
            this.uSLUGAIDDataGridViewTextBoxColumn,
            this.dATUMUCLANJENJADataGridViewTextBoxColumn,
            this.dATUMOBNOVEDataGridViewTextBoxColumn,
            this.bROJDOLAZAKADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eVIDENCIJEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 602);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataEvidencije1
            // 
            this.dataEvidencije1.DataSetName = "DataEvidencije1";
            this.dataEvidencije1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVIDENCIJEBindingSource
            // 
            this.eVIDENCIJEBindingSource.DataMember = "EVIDENCIJE";
            this.eVIDENCIJEBindingSource.DataSource = this.dataEvidencije1;
            // 
            // eVIDENCIJETableAdapter
            // 
            this.eVIDENCIJETableAdapter.ClearBeforeFill = true;
            // 
            // cLANIDDataGridViewTextBoxColumn
            // 
            this.cLANIDDataGridViewTextBoxColumn.DataPropertyName = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.HeaderText = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.Name = "cLANIDDataGridViewTextBoxColumn";
            // 
            // uSLUGAIDDataGridViewTextBoxColumn
            // 
            this.uSLUGAIDDataGridViewTextBoxColumn.DataPropertyName = "USLUGAID";
            this.uSLUGAIDDataGridViewTextBoxColumn.HeaderText = "USLUGAID";
            this.uSLUGAIDDataGridViewTextBoxColumn.Name = "uSLUGAIDDataGridViewTextBoxColumn";
            // 
            // dATUMUCLANJENJADataGridViewTextBoxColumn
            // 
            this.dATUMUCLANJENJADataGridViewTextBoxColumn.DataPropertyName = "DATUMUCLANJENJA";
            this.dATUMUCLANJENJADataGridViewTextBoxColumn.HeaderText = "DATUMUCLANJENJA";
            this.dATUMUCLANJENJADataGridViewTextBoxColumn.Name = "dATUMUCLANJENJADataGridViewTextBoxColumn";
            // 
            // dATUMOBNOVEDataGridViewTextBoxColumn
            // 
            this.dATUMOBNOVEDataGridViewTextBoxColumn.DataPropertyName = "DATUMOBNOVE";
            this.dATUMOBNOVEDataGridViewTextBoxColumn.HeaderText = "DATUMOBNOVE";
            this.dATUMOBNOVEDataGridViewTextBoxColumn.Name = "dATUMOBNOVEDataGridViewTextBoxColumn";
            // 
            // bROJDOLAZAKADataGridViewTextBoxColumn
            // 
            this.bROJDOLAZAKADataGridViewTextBoxColumn.DataPropertyName = "BROJDOLAZAKA";
            this.bROJDOLAZAKADataGridViewTextBoxColumn.HeaderText = "BROJDOLAZAKA";
            this.bROJDOLAZAKADataGridViewTextBoxColumn.Name = "bROJDOLAZAKADataGridViewTextBoxColumn";
            // 
            // Evidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 602);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Evidencija";
            this.Text = "Evidencija";
            this.Load += new System.EventHandler(this.Evidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvidencije1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIJEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataEvidencije1 dataEvidencije1;
        private System.Windows.Forms.BindingSource eVIDENCIJEBindingSource;
        private DataEvidencije1TableAdapters.EVIDENCIJETableAdapter eVIDENCIJETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSLUGAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMUCLANJENJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMOBNOVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bROJDOLAZAKADataGridViewTextBoxColumn;
    }
}
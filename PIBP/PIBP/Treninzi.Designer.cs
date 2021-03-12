namespace PIBP
{
    partial class Treninzi
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
            this.cLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vREMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRSTETRENINGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMETRENERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRENINZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTreninzi = new PIBP.DataTreninzi();
            this.tRENINZITableAdapter = new PIBP.DataTreninziTableAdapters.TRENINZITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENINZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRENERIDDataGridViewTextBoxColumn,
            this.cLANIDDataGridViewTextBoxColumn,
            this.dATUMDataGridViewTextBoxColumn,
            this.vREMEDataGridViewTextBoxColumn,
            this.vRSTETRENINGADataGridViewTextBoxColumn,
            this.iMETRENERADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRENINZIBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 730);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // tRENERIDDataGridViewTextBoxColumn
            // 
            this.tRENERIDDataGridViewTextBoxColumn.DataPropertyName = "TRENERID";
            this.tRENERIDDataGridViewTextBoxColumn.HeaderText = "TRENERID";
            this.tRENERIDDataGridViewTextBoxColumn.Name = "tRENERIDDataGridViewTextBoxColumn";
            // 
            // cLANIDDataGridViewTextBoxColumn
            // 
            this.cLANIDDataGridViewTextBoxColumn.DataPropertyName = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.HeaderText = "CLANID";
            this.cLANIDDataGridViewTextBoxColumn.Name = "cLANIDDataGridViewTextBoxColumn";
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            // 
            // vREMEDataGridViewTextBoxColumn
            // 
            this.vREMEDataGridViewTextBoxColumn.DataPropertyName = "VREME";
            this.vREMEDataGridViewTextBoxColumn.HeaderText = "VREME";
            this.vREMEDataGridViewTextBoxColumn.Name = "vREMEDataGridViewTextBoxColumn";
            // 
            // vRSTETRENINGADataGridViewTextBoxColumn
            // 
            this.vRSTETRENINGADataGridViewTextBoxColumn.DataPropertyName = "VRSTETRENINGA";
            this.vRSTETRENINGADataGridViewTextBoxColumn.HeaderText = "VRSTETRENINGA";
            this.vRSTETRENINGADataGridViewTextBoxColumn.Name = "vRSTETRENINGADataGridViewTextBoxColumn";
            // 
            // iMETRENERADataGridViewTextBoxColumn
            // 
            this.iMETRENERADataGridViewTextBoxColumn.DataPropertyName = "IMETRENERA";
            this.iMETRENERADataGridViewTextBoxColumn.HeaderText = "IMETRENERA";
            this.iMETRENERADataGridViewTextBoxColumn.Name = "iMETRENERADataGridViewTextBoxColumn";
            // 
            // tRENINZIBindingSource
            // 
            this.tRENINZIBindingSource.DataMember = "TRENINZI";
            this.tRENINZIBindingSource.DataSource = this.dataTreninzi;
            this.tRENINZIBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.tRENINZIBindingSource_AddingNew);
            // 
            // dataTreninzi
            // 
            this.dataTreninzi.DataSetName = "DataTreninzi";
            this.dataTreninzi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRENINZITableAdapter
            // 
            this.tRENINZITableAdapter.ClearBeforeFill = true;
            // 
            // Treninzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 730);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Treninzi";
            this.Text = "Treninzi";
            this.Load += new System.EventHandler(this.Treninzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENINZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTreninzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataTreninzi dataTreninzi;
        private System.Windows.Forms.BindingSource tRENINZIBindingSource;
        private DataTreninziTableAdapters.TRENINZITableAdapter tRENINZITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRENERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vREMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRSTETRENINGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMETRENERADataGridViewTextBoxColumn;
    }
}
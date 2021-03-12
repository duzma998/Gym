namespace PIBP
{
    partial class Usluge
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
            this.dataUsluge = new PIBP.DataUsluge();
            this.uSLUGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSLUGETableAdapter = new PIBP.DataUslugeTableAdapters.USLUGETableAdapter();
            this.uSLUGEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZIVUSLUGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSLUGEIDDataGridViewTextBoxColumn,
            this.nAZIVUSLUGEDataGridViewTextBoxColumn,
            this.cENADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSLUGEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataUsluge
            // 
            this.dataUsluge.DataSetName = "DataUsluge";
            this.dataUsluge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSLUGEBindingSource
            // 
            this.uSLUGEBindingSource.DataMember = "USLUGE";
            this.uSLUGEBindingSource.DataSource = this.dataUsluge;
            // 
            // uSLUGETableAdapter
            // 
            this.uSLUGETableAdapter.ClearBeforeFill = true;
            // 
            // uSLUGEIDDataGridViewTextBoxColumn
            // 
            this.uSLUGEIDDataGridViewTextBoxColumn.DataPropertyName = "USLUGEID";
            this.uSLUGEIDDataGridViewTextBoxColumn.HeaderText = "USLUGEID";
            this.uSLUGEIDDataGridViewTextBoxColumn.Name = "uSLUGEIDDataGridViewTextBoxColumn";
            // 
            // nAZIVUSLUGEDataGridViewTextBoxColumn
            // 
            this.nAZIVUSLUGEDataGridViewTextBoxColumn.DataPropertyName = "NAZIVUSLUGE";
            this.nAZIVUSLUGEDataGridViewTextBoxColumn.HeaderText = "NAZIVUSLUGE";
            this.nAZIVUSLUGEDataGridViewTextBoxColumn.Name = "nAZIVUSLUGEDataGridViewTextBoxColumn";
            // 
            // cENADataGridViewTextBoxColumn
            // 
            this.cENADataGridViewTextBoxColumn.DataPropertyName = "CENA";
            this.cENADataGridViewTextBoxColumn.HeaderText = "CENA";
            this.cENADataGridViewTextBoxColumn.Name = "cENADataGridViewTextBoxColumn";
            // 
            // Usluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usluge";
            this.Text = "Usluge";
            this.Load += new System.EventHandler(this.Usluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataUsluge dataUsluge;
        private System.Windows.Forms.BindingSource uSLUGEBindingSource;
        private DataUslugeTableAdapters.USLUGETableAdapter uSLUGETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSLUGEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZIVUSLUGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADataGridViewTextBoxColumn;
    }
}
namespace oyun_alim_takas
{
    partial class Form5
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
            this.kullaniciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.il3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guvenliksorusu2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniuyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet = new oyun_alim_takas.proje1DataSet();
            this.yeniuyeTableAdapter = new oyun_alim_takas.proje1DataSetTableAdapters.yeniuyeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniuyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciadiDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.il3DataGridViewTextBoxColumn,
            this.guvenliksorusu2DataGridViewTextBoxColumn,
            this.cevapDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yeniuyeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullaniciadiDataGridViewTextBoxColumn
            // 
            this.kullaniciadiDataGridViewTextBoxColumn.DataPropertyName = "kullanici_adi";
            this.kullaniciadiDataGridViewTextBoxColumn.HeaderText = "kullanici_adi";
            this.kullaniciadiDataGridViewTextBoxColumn.Name = "kullaniciadiDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "e_posta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "e_posta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // il3DataGridViewTextBoxColumn
            // 
            this.il3DataGridViewTextBoxColumn.DataPropertyName = "il3";
            this.il3DataGridViewTextBoxColumn.HeaderText = "il3";
            this.il3DataGridViewTextBoxColumn.Name = "il3DataGridViewTextBoxColumn";
            // 
            // guvenliksorusu2DataGridViewTextBoxColumn
            // 
            this.guvenliksorusu2DataGridViewTextBoxColumn.DataPropertyName = "guvenlik_sorusu2";
            this.guvenliksorusu2DataGridViewTextBoxColumn.HeaderText = "guvenlik_sorusu2";
            this.guvenliksorusu2DataGridViewTextBoxColumn.Name = "guvenliksorusu2DataGridViewTextBoxColumn";
            // 
            // cevapDataGridViewTextBoxColumn
            // 
            this.cevapDataGridViewTextBoxColumn.DataPropertyName = "cevap";
            this.cevapDataGridViewTextBoxColumn.HeaderText = "cevap";
            this.cevapDataGridViewTextBoxColumn.Name = "cevapDataGridViewTextBoxColumn";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yeniuyeBindingSource
            // 
            this.yeniuyeBindingSource.DataMember = "yeniuye";
            this.yeniuyeBindingSource.DataSource = this.proje1DataSet;
            // 
            // proje1DataSet
            // 
            this.proje1DataSet.DataSetName = "proje1DataSet";
            this.proje1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yeniuyeTableAdapter
            // 
            this.yeniuyeTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 392);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniuyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private proje1DataSet proje1DataSet;
        private System.Windows.Forms.BindingSource yeniuyeBindingSource;
        private oyun_alim_takas.proje1DataSetTableAdapters.yeniuyeTableAdapter yeniuyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn il3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guvenliksorusu2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;


    }
}
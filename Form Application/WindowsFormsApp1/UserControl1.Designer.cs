
namespace WindowsFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cargo_databaseDataSet3 = new WindowsFormsApp1.cargo_databaseDataSet3();
            this.cargodatabaseDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_databaseDataSet2 = new WindowsFormsApp1.cargo_databaseDataSet2();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new WindowsFormsApp1.cargo_databaseDataSet2TableAdapters.branchTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.branchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_database2DataSet = new WindowsFormsApp1.cargo_database2DataSet();
            this.branchTableAdapter1 = new WindowsFormsApp1.cargo_database2DataSetTableAdapters.branchTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargodatabaseDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cargo_databaseDataSet3
            // 
            this.cargo_databaseDataSet3.DataSetName = "cargo_databaseDataSet3";
            this.cargo_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargodatabaseDataSet3BindingSource
            // 
            this.cargodatabaseDataSet3BindingSource.DataSource = this.cargo_databaseDataSet3;
            this.cargodatabaseDataSet3BindingSource.Position = 0;
            // 
            // cargo_databaseDataSet2
            // 
            this.cargo_databaseDataSet2.DataSetName = "cargo_databaseDataSet2";
            this.cargo_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.cargo_databaseDataSet2;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 173);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(558, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchBindingSource1
            // 
            this.branchBindingSource1.DataMember = "branch";
            this.branchBindingSource1.DataSource = this.cargo_database2DataSet;
            // 
            // cargo_database2DataSet
            // 
            this.cargo_database2DataSet.DataSetName = "cargo_database2DataSet";
            this.cargo_database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter1
            // 
            this.branchTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 44;
            this.comboBox1.Location = new System.Drawing.Point(260, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 52);
            this.comboBox1.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1215, 604);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargodatabaseDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_database2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private cargo_databaseDataSet3 cargo_databaseDataSet3;
        private System.Windows.Forms.BindingSource cargodatabaseDataSet3BindingSource;
        private cargo_databaseDataSet2 cargo_databaseDataSet2;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private cargo_databaseDataSet2TableAdapters.branchTableAdapter branchTableAdapter;
        private System.Windows.Forms.BindingSource branchBindingSource1;
        private cargo_database2DataSet cargo_database2DataSet;
        private cargo_database2DataSetTableAdapters.branchTableAdapter branchTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

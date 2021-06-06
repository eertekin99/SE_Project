using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_databaseDataSet3 = new WindowsFormsApp1.cargo_databaseDataSet3();
            this.branchTableAdapter = new WindowsFormsApp1.cargo_databaseDataSet3TableAdapters.branchTableAdapter();
            this.cargo_databaseDataSet1 = new WindowsFormsApp1.cargo_databaseDataSet();
            this.receive_cargo_fromTableAdapter1 = new WindowsFormsApp1.cargo_databaseDataSet1TableAdapters.receive_cargo_fromTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCargo = new System.Windows.Forms.Button();
            this.userControl71 = new WindowsFormsApp1.UserControl7();
            this.userControl61 = new WindowsFormsApp1.UserControl6();
            this.userControl51 = new WindowsFormsApp1.UserControl5();
            this.userControl41 = new WindowsFormsApp1.UserControl4();
            this.userControl31 = new WindowsFormsApp1.UserControl3();
            this.userControl21 = new WindowsFormsApp1.UserControl2();
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.cargo_databaseDataSet3;
            // 
            // cargo_databaseDataSet3
            // 
            this.cargo_databaseDataSet3.DataSetName = "cargo_databaseDataSet3";
            this.cargo_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // cargo_databaseDataSet1
            // 
            this.cargo_databaseDataSet1.DataSetName = "cargo_databaseDataSet";
            this.cargo_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receive_cargo_fromTableAdapter1
            // 
            this.receive_cargo_fromTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddCargo);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 886);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(-3, 686);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 73);
            this.button6.TabIndex = 10;
            this.button6.Text = "View Tables";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(-4, 18);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(271, 69);
            this.button5.TabIndex = 7;
            this.button5.Text = "Main Page";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(-3, 614);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 73);
            this.button4.TabIndex = 6;
            this.button4.Text = "Customer History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(-4, 543);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "Deliver Cargo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(-4, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Cargo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(-4, 400);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search Cargo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCargo
            // 
            this.AddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCargo.Location = new System.Drawing.Point(-4, 332);
            this.AddCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCargo.Name = "AddCargo";
            this.AddCargo.Size = new System.Drawing.Size(271, 69);
            this.AddCargo.TabIndex = 1;
            this.AddCargo.Text = "Add Customer";
            this.AddCargo.UseVisualStyleBackColor = true;
            this.AddCargo.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl71
            // 
            this.userControl71.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl71.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userControl71.Location = new System.Drawing.Point(292, 15);
            this.userControl71.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl71.Name = "userControl71";
            this.userControl71.Size = new System.Drawing.Size(1312, 1231);
            this.userControl71.TabIndex = 11;
            // 
            // userControl61
            // 
            this.userControl61.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl61.Location = new System.Drawing.Point(291, 15);
            this.userControl61.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl61.Name = "userControl61";
            this.userControl61.Size = new System.Drawing.Size(1295, 886);
            this.userControl61.TabIndex = 8;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl51.Location = new System.Drawing.Point(291, 15);
            this.userControl51.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(1295, 886);
            this.userControl51.TabIndex = 7;
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl41.Location = new System.Drawing.Point(292, 15);
            this.userControl41.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1295, 886);
            this.userControl41.TabIndex = 6;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl31.Location = new System.Drawing.Point(291, 15);
            this.userControl31.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1295, 886);
            this.userControl31.TabIndex = 5;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl21.Location = new System.Drawing.Point(291, 15);
            this.userControl21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1295, 886);
            this.userControl21.TabIndex = 4;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.DarkCyan;
            this.userControl11.Location = new System.Drawing.Point(291, 15);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1295, 886);
            this.userControl11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 912);
            this.Controls.Add(this.userControl71);
            this.Controls.Add(this.userControl61);
            this.Controls.Add(this.userControl51);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BEY Cargo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_databaseDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private cargo_databaseDataSet3 cargo_databaseDataSet3;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private cargo_databaseDataSet3TableAdapters.branchTableAdapter branchTableAdapter;
        private cargo_databaseDataSet cargo_databaseDataSet1;
        private cargo_databaseDataSet1TableAdapters.receive_cargo_fromTableAdapter receive_cargo_fromTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCargo;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Button button1;
        private UserControl3 userControl31;
        private System.Windows.Forms.Button button3;
        private UserControl4 userControl41;
        private System.Windows.Forms.Button button4;
        private UserControl5 userControl51;
        private System.Windows.Forms.Button button5;
        private UserControl6 userControl61;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private UserControl7 userControl71;
    }
}


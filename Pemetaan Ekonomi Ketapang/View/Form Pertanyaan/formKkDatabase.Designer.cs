namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    partial class formKkDatabase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.edt_cari_kepalaKeluarga = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.edt_cari_noKK = new System.Windows.Forms.TextBox();
            this.dataGridKepalaKeluarga = new System.Windows.Forms.DataGridView();
            this.edt_col = new System.Windows.Forms.TextBox();
            this.edt_row = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbStasi = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKepalaKeluarga)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.cmbStasi);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.edt_cari_kepalaKeluarga);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.edt_cari_noKK);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Kepala Keluarga";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama";
            // 
            // edt_cari_kepalaKeluarga
            // 
            this.edt_cari_kepalaKeluarga.Location = new System.Drawing.Point(71, 73);
            this.edt_cari_kepalaKeluarga.Name = "edt_cari_kepalaKeluarga";
            this.edt_cari_kepalaKeluarga.Size = new System.Drawing.Size(301, 20);
            this.edt_cari_kepalaKeluarga.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "No KK";
            // 
            // edt_cari_noKK
            // 
            this.edt_cari_noKK.Location = new System.Drawing.Point(71, 37);
            this.edt_cari_noKK.Name = "edt_cari_noKK";
            this.edt_cari_noKK.Size = new System.Drawing.Size(301, 20);
            this.edt_cari_noKK.TabIndex = 3;
            // 
            // dataGridKepalaKeluarga
            // 
            this.dataGridKepalaKeluarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKepalaKeluarga.Location = new System.Drawing.Point(23, 228);
            this.dataGridKepalaKeluarga.Name = "dataGridKepalaKeluarga";
            this.dataGridKepalaKeluarga.Size = new System.Drawing.Size(912, 350);
            this.dataGridKepalaKeluarga.TabIndex = 7;
            this.dataGridKepalaKeluarga.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKepalaKeluarga_CellContentDoubleClick_1);
            // 
            // edt_col
            // 
            this.edt_col.Location = new System.Drawing.Point(835, 59);
            this.edt_col.Name = "edt_col";
            this.edt_col.Size = new System.Drawing.Size(100, 20);
            this.edt_col.TabIndex = 9;
            this.edt_col.Visible = false;
            // 
            // edt_row
            // 
            this.edt_row.Location = new System.Drawing.Point(835, 32);
            this.edt_row.Name = "edt_row";
            this.edt_row.Size = new System.Drawing.Size(100, 20);
            this.edt_row.TabIndex = 8;
            this.edt_row.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Stasi ";
            // 
            // cmbStasi
            // 
            this.cmbStasi.FormattingEnabled = true;
            this.cmbStasi.Location = new System.Drawing.Point(71, 104);
            this.cmbStasi.Name = "cmbStasi";
            this.cmbStasi.Size = new System.Drawing.Size(301, 21);
            this.cmbStasi.TabIndex = 6;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(409, 60);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 43);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "CARI";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // formKkDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.edt_col);
            this.Controls.Add(this.edt_row);
            this.Controls.Add(this.dataGridKepalaKeluarga);
            this.Controls.Add(this.groupBox1);
            this.Name = "formKkDatabase";
            this.Text = "Form Identitas Dari Database";
            this.Load += new System.EventHandler(this.formKkDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKepalaKeluarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox edt_cari_kepalaKeluarga;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox edt_cari_noKK;
        private System.Windows.Forms.DataGridView dataGridKepalaKeluarga;
        private System.Windows.Forms.TextBox edt_col;
        private System.Windows.Forms.TextBox edt_row;
        private System.Windows.Forms.ComboBox cmbStasi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
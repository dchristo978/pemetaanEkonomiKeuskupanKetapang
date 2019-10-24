namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    partial class formRekomendasiSampling
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
            this.cmbError = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnTampil = new MetroFramework.Controls.MetroButton();
            this.lbTotalKK = new MetroFramework.Controls.MetroLabel();
            this.cmbParoki = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCetak = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbError);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btnTampil);
            this.groupBox1.Controls.Add(this.lbTotalKK);
            this.groupBox1.Controls.Add(this.cmbParoki);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(32, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(556, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Pencarian Beradasarkan Paroki";
            // 
            // cmbError
            // 
            this.cmbError.FormattingEnabled = true;
            this.cmbError.Location = new System.Drawing.Point(205, 92);
            this.cmbError.Margin = new System.Windows.Forms.Padding(2);
            this.cmbError.Name = "cmbError";
            this.cmbError.Size = new System.Drawing.Size(212, 21);
            this.cmbError.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 95);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Toleransi Kesalahan : ";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(448, 89);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(86, 28);
            this.btnTampil.TabIndex = 3;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseSelectable = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // lbTotalKK
            // 
            this.lbTotalKK.AutoSize = true;
            this.lbTotalKK.Location = new System.Drawing.Point(297, 60);
            this.lbTotalKK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalKK.Name = "lbTotalKK";
            this.lbTotalKK.Size = new System.Drawing.Size(15, 19);
            this.lbTotalKK.TabIndex = 3;
            this.lbTotalKK.Text = "-";
            // 
            // cmbParoki
            // 
            this.cmbParoki.FormattingEnabled = true;
            this.cmbParoki.Location = new System.Drawing.Point(205, 26);
            this.cmbParoki.Margin = new System.Windows.Forms.Padding(2);
            this.cmbParoki.Name = "cmbParoki";
            this.cmbParoki.Size = new System.Drawing.Size(212, 21);
            this.cmbParoki.TabIndex = 2;
            this.cmbParoki.SelectedIndexChanged += new System.EventHandler(this.cmbParoki_SelectedIndexChanged);
            this.cmbParoki.SelectedValueChanged += new System.EventHandler(this.cmbParoki_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 60);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Total Kepala Keluarga Aktif : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 26);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Paroki :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(624, 123);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(2);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(110, 42);
            this.btnCetak.TabIndex = 2;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.UseSelectable = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // formRekomendasiSampling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 544);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formRekomendasiSampling";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Form Rekomendasi Sampling Pemetaan Ekonomi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.formRekomendasiSampling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lbTotalKK;
        private System.Windows.Forms.ComboBox cmbParoki;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnCetak;
        private MetroFramework.Controls.MetroButton btnTampil;
        private System.Windows.Forms.ComboBox cmbError;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
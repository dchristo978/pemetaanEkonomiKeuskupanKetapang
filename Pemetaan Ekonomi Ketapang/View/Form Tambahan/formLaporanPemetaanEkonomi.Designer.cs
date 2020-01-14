namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    partial class formLaporanPemetaanEkonomi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTampilkanBerdasarkan = new System.Windows.Forms.ComboBox();
            this.cmbJenisTampilan = new System.Windows.Forms.ComboBox();
            this.cmbCakupanWilayah = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCetak = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTampil = new MetroFramework.Controls.MetroButton();
            this.lbRegion = new MetroFramework.Controls.MetroLabel();
            this.cmbReginParoki = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTampil);
            this.groupBox1.Controls.Add(this.cmbReginParoki);
            this.groupBox1.Controls.Add(this.lbRegion);
            this.groupBox1.Controls.Add(this.cmbTampilkanBerdasarkan);
            this.groupBox1.Controls.Add(this.cmbJenisTampilan);
            this.groupBox1.Controls.Add(this.cmbCakupanWilayah);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Laporan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTampilkanBerdasarkan
            // 
            this.cmbTampilkanBerdasarkan.FormattingEnabled = true;
            this.cmbTampilkanBerdasarkan.Location = new System.Drawing.Point(211, 75);
            this.cmbTampilkanBerdasarkan.Name = "cmbTampilkanBerdasarkan";
            this.cmbTampilkanBerdasarkan.Size = new System.Drawing.Size(208, 21);
            this.cmbTampilkanBerdasarkan.TabIndex = 5;
            this.cmbTampilkanBerdasarkan.SelectedIndexChanged += new System.EventHandler(this.cmbTampilkanBerdasarkan_SelectedIndexChanged);
            // 
            // cmbJenisTampilan
            // 
            this.cmbJenisTampilan.FormattingEnabled = true;
            this.cmbJenisTampilan.Location = new System.Drawing.Point(543, 32);
            this.cmbJenisTampilan.Name = "cmbJenisTampilan";
            this.cmbJenisTampilan.Size = new System.Drawing.Size(208, 21);
            this.cmbJenisTampilan.TabIndex = 4;
            this.cmbJenisTampilan.Visible = false;
            this.cmbJenisTampilan.SelectedIndexChanged += new System.EventHandler(this.cmbJenisTampilan_SelectedIndexChanged);
            // 
            // cmbCakupanWilayah
            // 
            this.cmbCakupanWilayah.FormattingEnabled = true;
            this.cmbCakupanWilayah.Location = new System.Drawing.Point(211, 32);
            this.cmbCakupanWilayah.Name = "cmbCakupanWilayah";
            this.cmbCakupanWilayah.Size = new System.Drawing.Size(208, 21);
            this.cmbCakupanWilayah.TabIndex = 3;
            this.cmbCakupanWilayah.SelectedIndexChanged += new System.EventHandler(this.cmbCakupanWilayah_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(434, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Jenis Tampilan : ";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(154, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tampilkan Berdasarkan : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cakupan Wilayah :";
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(796, 240);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(128, 60);
            this.btnCetak.TabIndex = 1;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseSelectable = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 370);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(72, 277);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(773, 34);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(128, 60);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseSelectable = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(434, 77);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(101, 19);
            this.lbRegion.TabIndex = 6;
            this.lbRegion.Text = "Region Paroki : ";
            this.lbRegion.Visible = false;
            // 
            // cmbReginParoki
            // 
            this.cmbReginParoki.FormattingEnabled = true;
            this.cmbReginParoki.Location = new System.Drawing.Point(543, 77);
            this.cmbReginParoki.Name = "cmbReginParoki";
            this.cmbReginParoki.Size = new System.Drawing.Size(208, 21);
            this.cmbReginParoki.TabIndex = 7;
            this.cmbReginParoki.Visible = false;
            // 
            // formLaporanPemetaanEkonomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 648);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.groupBox1);
            this.Name = "formLaporanPemetaanEkonomi";
            this.Text = "Laporan Pemetaan Ekonomi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.formLaporanPemetaanEkonomi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTampilkanBerdasarkan;
        private System.Windows.Forms.ComboBox cmbJenisTampilan;
        private System.Windows.Forms.ComboBox cmbCakupanWilayah;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCetak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btnTampil;
        private MetroFramework.Controls.MetroLabel lbRegion;
        private System.Windows.Forms.ComboBox cmbReginParoki;
    }
}
namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    partial class formDatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbIdParoki = new System.Windows.Forms.TextBox();
            this.tbNamaParoki = new System.Windows.Forms.TextBox();
            this.tbNamaDatabase = new System.Windows.Forms.TextBox();
            this.btnUbah = new MetroFramework.Controls.MetroButton();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.btnTambah = new MetroFramework.Controls.MetroButton();
            this.tempdatabase = new MetroFramework.Controls.MetroLabel();
            this.tempnama = new MetroFramework.Controls.MetroLabel();
            this.tempId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(662, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Id Paroki : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(662, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama Paroki : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(662, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Nama Database : ";
            // 
            // tbIdParoki
            // 
            this.tbIdParoki.Location = new System.Drawing.Point(788, 99);
            this.tbIdParoki.Name = "tbIdParoki";
            this.tbIdParoki.Size = new System.Drawing.Size(233, 20);
            this.tbIdParoki.TabIndex = 4;
            // 
            // tbNamaParoki
            // 
            this.tbNamaParoki.Location = new System.Drawing.Point(788, 141);
            this.tbNamaParoki.Name = "tbNamaParoki";
            this.tbNamaParoki.Size = new System.Drawing.Size(233, 20);
            this.tbNamaParoki.TabIndex = 5;
            // 
            // tbNamaDatabase
            // 
            this.tbNamaDatabase.Location = new System.Drawing.Point(788, 183);
            this.tbNamaDatabase.Name = "tbNamaDatabase";
            this.tbNamaDatabase.Size = new System.Drawing.Size(233, 20);
            this.tbNamaDatabase.TabIndex = 6;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(725, 275);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(114, 43);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseSelectable = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(887, 275);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(114, 43);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseSelectable = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(810, 346);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(114, 43);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseSelectable = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tempdatabase
            // 
            this.tempdatabase.AutoSize = true;
            this.tempdatabase.Location = new System.Drawing.Point(43, 27);
            this.tempdatabase.Name = "tempdatabase";
            this.tempdatabase.Size = new System.Drawing.Size(83, 19);
            this.tempdatabase.TabIndex = 10;
            this.tempdatabase.Text = "metroLabel4";
            this.tempdatabase.Visible = false;
            // 
            // tempnama
            // 
            this.tempnama.AutoSize = true;
            this.tempnama.Location = new System.Drawing.Point(43, 50);
            this.tempnama.Name = "tempnama";
            this.tempnama.Size = new System.Drawing.Size(83, 19);
            this.tempnama.TabIndex = 11;
            this.tempnama.Text = "metroLabel5";
            this.tempnama.Visible = false;
            this.tempnama.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // tempId
            // 
            this.tempId.AutoSize = true;
            this.tempId.Location = new System.Drawing.Point(43, 73);
            this.tempId.Name = "tempId";
            this.tempId.Size = new System.Drawing.Size(83, 19);
            this.tempId.TabIndex = 12;
            this.tempId.Text = "metroLabel6";
            this.tempId.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(649, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Halaman ini hanya digunakan apabila terdapat penambahan atau perubahan basis data" +
    " paroki yang ada saja!";
            // 
            // formDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 506);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tempId);
            this.Controls.Add(this.tempnama);
            this.Controls.Add(this.tempdatabase);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.tbNamaDatabase);
            this.Controls.Add(this.tbNamaParoki);
            this.Controls.Add(this.tbIdParoki);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formDatabase";
            this.Text = "Setting Master Database";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.formDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox tbIdParoki;
        private System.Windows.Forms.TextBox tbNamaParoki;
        private System.Windows.Forms.TextBox tbNamaDatabase;
        private MetroFramework.Controls.MetroButton btnUbah;
        private MetroFramework.Controls.MetroButton btnHapus;
        private MetroFramework.Controls.MetroButton btnTambah;
        private MetroFramework.Controls.MetroLabel tempdatabase;
        private MetroFramework.Controls.MetroLabel tempnama;
        private MetroFramework.Controls.MetroLabel tempId;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
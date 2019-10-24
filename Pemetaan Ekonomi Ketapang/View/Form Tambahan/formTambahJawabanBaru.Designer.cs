namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    partial class formTambahJawabanLainnya
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPertanyaan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtJawaban = new System.Windows.Forms.TextBox();
            this.btnSimpanJawaban = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSimpanBobot = new System.Windows.Forms.Button();
            this.edtHeaderBobot = new System.Windows.Forms.TextBox();
            this.edtDesBobot = new System.Windows.Forms.TextBox();
            this.edtBatasAtasBobot = new System.Windows.Forms.TextBox();
            this.edtBatasBawahBobot = new System.Windows.Forms.TextBox();
            this.edtBobot = new System.Windows.Forms.TextBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapusJawaban = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pertanyaan :";
            // 
            // cmbPertanyaan
            // 
            this.cmbPertanyaan.FormattingEnabled = true;
            this.cmbPertanyaan.Location = new System.Drawing.Point(241, 87);
            this.cmbPertanyaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPertanyaan.Name = "cmbPertanyaan";
            this.cmbPertanyaan.Size = new System.Drawing.Size(299, 24);
            this.cmbPertanyaan.TabIndex = 1;
            this.cmbPertanyaan.SelectedIndexChanged += new System.EventHandler(this.cmbPertanyaan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jawaban Baru :";
            // 
            // edtJawaban
            // 
            this.edtJawaban.Location = new System.Drawing.Point(241, 135);
            this.edtJawaban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtJawaban.Name = "edtJawaban";
            this.edtJawaban.Size = new System.Drawing.Size(299, 22);
            this.edtJawaban.TabIndex = 3;
            // 
            // btnSimpanJawaban
            // 
            this.btnSimpanJawaban.Location = new System.Drawing.Point(241, 167);
            this.btnSimpanJawaban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpanJawaban.Name = "btnSimpanJawaban";
            this.btnSimpanJawaban.Size = new System.Drawing.Size(147, 50);
            this.btnSimpanJawaban.TabIndex = 4;
            this.btnSimpanJawaban.Text = "Simpan Jawaban";
            this.btnSimpanJawaban.UseVisualStyleBackColor = true;
            this.btnSimpanJawaban.Click += new System.EventHandler(this.btnSimpanJawaban_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 373);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabel Referensi Bobot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Judul Bobot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deskripsi Bobot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Batas Atas Bobot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Batas Bawah Bobot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bobot";
            // 
            // btnSimpanBobot
            // 
            this.btnSimpanBobot.Location = new System.Drawing.Point(241, 422);
            this.btnSimpanBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpanBobot.Name = "btnSimpanBobot";
            this.btnSimpanBobot.Size = new System.Drawing.Size(152, 52);
            this.btnSimpanBobot.TabIndex = 12;
            this.btnSimpanBobot.Text = "Simpan Bobot";
            this.btnSimpanBobot.UseVisualStyleBackColor = true;
            this.btnSimpanBobot.Click += new System.EventHandler(this.btnSimpanBobot_Click);
            // 
            // edtHeaderBobot
            // 
            this.edtHeaderBobot.Location = new System.Drawing.Point(244, 250);
            this.edtHeaderBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtHeaderBobot.Name = "edtHeaderBobot";
            this.edtHeaderBobot.Size = new System.Drawing.Size(235, 22);
            this.edtHeaderBobot.TabIndex = 13;
            // 
            // edtDesBobot
            // 
            this.edtDesBobot.Location = new System.Drawing.Point(244, 286);
            this.edtDesBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtDesBobot.Name = "edtDesBobot";
            this.edtDesBobot.Size = new System.Drawing.Size(235, 22);
            this.edtDesBobot.TabIndex = 14;
            // 
            // edtBatasAtasBobot
            // 
            this.edtBatasAtasBobot.Location = new System.Drawing.Point(244, 319);
            this.edtBatasAtasBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtBatasAtasBobot.Name = "edtBatasAtasBobot";
            this.edtBatasAtasBobot.Size = new System.Drawing.Size(235, 22);
            this.edtBatasAtasBobot.TabIndex = 15;
            // 
            // edtBatasBawahBobot
            // 
            this.edtBatasBawahBobot.Location = new System.Drawing.Point(244, 351);
            this.edtBatasBawahBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtBatasBawahBobot.Name = "edtBatasBawahBobot";
            this.edtBatasBawahBobot.Size = new System.Drawing.Size(235, 22);
            this.edtBatasBawahBobot.TabIndex = 16;
            // 
            // edtBobot
            // 
            this.edtBobot.Location = new System.Drawing.Point(244, 382);
            this.edtBobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtBobot.Name = "edtBobot";
            this.edtBobot.Size = new System.Drawing.Size(148, 22);
            this.edtBobot.TabIndex = 17;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(608, 521);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(240, 63);
            this.btnSelesai.TabIndex = 18;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapusJawaban
            // 
            this.btnHapusJawaban.Location = new System.Drawing.Point(396, 167);
            this.btnHapusJawaban.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusJawaban.Name = "btnHapusJawaban";
            this.btnHapusJawaban.Size = new System.Drawing.Size(147, 50);
            this.btnHapusJawaban.TabIndex = 19;
            this.btnHapusJawaban.Text = "Hapus Jawaban";
            this.btnHapusJawaban.UseVisualStyleBackColor = true;
            // 
            // formTambahJawabanLainnya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 612);
            this.Controls.Add(this.btnHapusJawaban);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.edtBobot);
            this.Controls.Add(this.edtBatasBawahBobot);
            this.Controls.Add(this.edtBatasAtasBobot);
            this.Controls.Add(this.edtDesBobot);
            this.Controls.Add(this.edtHeaderBobot);
            this.Controls.Add(this.btnSimpanBobot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSimpanJawaban);
            this.Controls.Add(this.edtJawaban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPertanyaan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formTambahJawabanLainnya";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Tambah Jawaban";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.formTambahJawabanLainnya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPertanyaan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtJawaban;
        private System.Windows.Forms.Button btnSimpanJawaban;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSimpanBobot;
        private System.Windows.Forms.TextBox edtHeaderBobot;
        private System.Windows.Forms.TextBox edtDesBobot;
        private System.Windows.Forms.TextBox edtBatasAtasBobot;
        private System.Windows.Forms.TextBox edtBatasBawahBobot;
        private System.Windows.Forms.TextBox edtBobot;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapusJawaban;
    }
}
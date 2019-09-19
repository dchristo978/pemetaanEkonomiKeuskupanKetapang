namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    partial class formJawabanLainnya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPertanyaan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbJawaban = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtDescJawaban1 = new System.Windows.Forms.TextBox();
            this.edtDescJawaban2 = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edtIdRefJawaban = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabel Jawaban tambahan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pertanyaan : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPertanyaan
            // 
            this.lbPertanyaan.AutoSize = true;
            this.lbPertanyaan.Location = new System.Drawing.Point(400, 128);
            this.lbPertanyaan.Name = "lbPertanyaan";
            this.lbPertanyaan.Size = new System.Drawing.Size(35, 13);
            this.lbPertanyaan.TabIndex = 3;
            this.lbPertanyaan.Text = "label3";
            this.lbPertanyaan.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jawaban : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbJawaban
            // 
            this.lbJawaban.AutoSize = true;
            this.lbJawaban.Location = new System.Drawing.Point(400, 157);
            this.lbJawaban.Name = "lbJawaban";
            this.lbJawaban.Size = new System.Drawing.Size(35, 13);
            this.lbJawaban.TabIndex = 5;
            this.lbJawaban.Text = "label5";
            this.lbJawaban.Click += new System.EventHandler(this.lbJawaban_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bab : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbBab
            // 
            this.lbBab.AutoSize = true;
            this.lbBab.Location = new System.Drawing.Point(400, 97);
            this.lbBab.Name = "lbBab";
            this.lbBab.Size = new System.Drawing.Size(35, 13);
            this.lbBab.TabIndex = 7;
            this.lbBab.Text = "label7";
            this.lbBab.Click += new System.EventHandler(this.lbBab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deskripsi Jawaban 1 :";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deskripsi Jawaban 2 :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // edtDescJawaban1
            // 
            this.edtDescJawaban1.Location = new System.Drawing.Point(451, 192);
            this.edtDescJawaban1.Name = "edtDescJawaban1";
            this.edtDescJawaban1.Size = new System.Drawing.Size(202, 20);
            this.edtDescJawaban1.TabIndex = 10;
            // 
            // edtDescJawaban2
            // 
            this.edtDescJawaban2.Location = new System.Drawing.Point(451, 234);
            this.edtDescJawaban2.Name = "edtDescJawaban2";
            this.edtDescJawaban2.Size = new System.Drawing.Size(202, 20);
            this.edtDescJawaban2.TabIndex = 11;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(472, 290);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(156, 59);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tidak menemukan jawaban tambahan yang diinginkan?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tambah Jawaban Baru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtIdRefJawaban
            // 
            this.edtIdRefJawaban.Location = new System.Drawing.Point(22, 50);
            this.edtIdRefJawaban.Name = "edtIdRefJawaban";
            this.edtIdRefJawaban.Size = new System.Drawing.Size(100, 20);
            this.edtIdRefJawaban.TabIndex = 16;
            this.edtIdRefJawaban.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formJawabanLainnya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.edtIdRefJawaban);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.edtDescJawaban2);
            this.Controls.Add(this.edtDescJawaban1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbJawaban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPertanyaan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formJawabanLainnya";
            this.Text = "Form Jawaban Lainnya";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Activated += new System.EventHandler(this.formJawabanLainnya_Activated);
            this.Load += new System.EventHandler(this.formJawabanLainnya_Load);
            this.Enter += new System.EventHandler(this.formJawabanLainnya_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPertanyaan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbJawaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtDescJawaban1;
        private System.Windows.Forms.TextBox edtDescJawaban2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edtIdRefJawaban;
        private System.Windows.Forms.Button button2;
    }
}
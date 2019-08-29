namespace Pemetaan_Ekonomi_Ketapang.View
{
    partial class formKepalaKeluarga
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
            this.dataGridKepalaKeluarga = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.edt_cari_noKK = new System.Windows.Forms.TextBox();
            this.edt_cari_kepalaKeluarga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_row = new System.Windows.Forms.TextBox();
            this.edt_col = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKepalaKeluarga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridKepalaKeluarga
            // 
            this.dataGridKepalaKeluarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKepalaKeluarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKepalaKeluarga.Location = new System.Drawing.Point(75, 208);
            this.dataGridKepalaKeluarga.Name = "dataGridKepalaKeluarga";
            this.dataGridKepalaKeluarga.Size = new System.Drawing.Size(808, 320);
            this.dataGridKepalaKeluarga.TabIndex = 0;
            this.dataGridKepalaKeluarga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKepalaKeluarga_CellClick);
            this.dataGridKepalaKeluarga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKepalaKeluarga_CellContentClick);
            this.dataGridKepalaKeluarga.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKepalaKeluarga_CellContentDoubleClick);
            this.dataGridKepalaKeluarga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridKepalaKeluarga_KeyUp);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama";
            // 
            // edt_cari_noKK
            // 
            this.edt_cari_noKK.Location = new System.Drawing.Point(71, 37);
            this.edt_cari_noKK.Name = "edt_cari_noKK";
            this.edt_cari_noKK.Size = new System.Drawing.Size(301, 20);
            this.edt_cari_noKK.TabIndex = 3;
            this.edt_cari_noKK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edt_cari_noKK_KeyUp);
            // 
            // edt_cari_kepalaKeluarga
            // 
            this.edt_cari_kepalaKeluarga.Location = new System.Drawing.Point(71, 73);
            this.edt_cari_kepalaKeluarga.Name = "edt_cari_kepalaKeluarga";
            this.edt_cari_kepalaKeluarga.Size = new System.Drawing.Size(301, 20);
            this.edt_cari_kepalaKeluarga.TabIndex = 4;
            this.edt_cari_kepalaKeluarga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edt_cari_kepalaKeluarga_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.edt_cari_kepalaKeluarga);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.edt_cari_noKK);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Kepala Keluarga";
            // 
            // edt_row
            // 
            this.edt_row.Location = new System.Drawing.Point(619, 29);
            this.edt_row.Name = "edt_row";
            this.edt_row.Size = new System.Drawing.Size(100, 20);
            this.edt_row.TabIndex = 6;
            this.edt_row.Visible = false;
            // 
            // edt_col
            // 
            this.edt_col.Location = new System.Drawing.Point(619, 56);
            this.edt_col.Name = "edt_col";
            this.edt_col.Size = new System.Drawing.Size(100, 20);
            this.edt_col.TabIndex = 7;
            this.edt_col.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 521);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(883, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 521);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(75, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 148);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(75, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(808, 53);
            this.panel4.TabIndex = 9;
            // 
            // formKepalaKeluarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.dataGridKepalaKeluarga);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edt_col);
            this.Controls.Add(this.edt_row);
            this.Name = "formKepalaKeluarga";
            this.Text = "Daftar Kepala Keluarga";
            this.Load += new System.EventHandler(this.formKepalaKeluarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKepalaKeluarga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKepalaKeluarga;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox edt_cari_noKK;
        private System.Windows.Forms.TextBox edt_cari_kepalaKeluarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edt_row;
        private System.Windows.Forms.TextBox edt_col;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
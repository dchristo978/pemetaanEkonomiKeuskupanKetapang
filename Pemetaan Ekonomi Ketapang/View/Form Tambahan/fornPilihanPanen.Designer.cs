namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    partial class fornPilihanPanen
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
            this.cbPangan = new System.Windows.Forms.CheckBox();
            this.cbKeras = new System.Windows.Forms.CheckBox();
            this.cbTernak = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPangan
            // 
            this.cbPangan.AutoSize = true;
            this.cbPangan.Location = new System.Drawing.Point(129, 126);
            this.cbPangan.Name = "cbPangan";
            this.cbPangan.Size = new System.Drawing.Size(192, 17);
            this.cbPangan.TabIndex = 3;
            this.cbPangan.Text = "Form hasil panen tanaman pangan ";
            this.cbPangan.UseVisualStyleBackColor = true;
            this.cbPangan.CheckedChanged += new System.EventHandler(this.cbPangan_CheckedChanged);
            // 
            // cbKeras
            // 
            this.cbKeras.AutoSize = true;
            this.cbKeras.Location = new System.Drawing.Point(129, 168);
            this.cbKeras.Name = "cbKeras";
            this.cbKeras.Size = new System.Drawing.Size(179, 17);
            this.cbKeras.TabIndex = 4;
            this.cbKeras.Text = "Form hasil panen tanaman keras";
            this.cbKeras.UseVisualStyleBackColor = true;
            // 
            // cbTernak
            // 
            this.cbTernak.AutoSize = true;
            this.cbTernak.Location = new System.Drawing.Point(129, 206);
            this.cbTernak.Name = "cbTernak";
            this.cbTernak.Size = new System.Drawing.Size(139, 17);
            this.cbTernak.TabIndex = 5;
            this.cbTernak.Text = "Form hasil panen ternak";
            this.cbTernak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Centang pada pilihan form-form yang akan diisi sesuai dengan formulir yang  sudah" +
    " terisi!";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(198, 248);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 41);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Pilih";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // fornPilihanPanen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 340);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTernak);
            this.Controls.Add(this.cbKeras);
            this.Controls.Add(this.cbPangan);
            this.Name = "fornPilihanPanen";
            this.Text = "Pilih Jenis Panen";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPangan;
        private System.Windows.Forms.CheckBox cbKeras;
        private System.Windows.Forms.CheckBox cbTernak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
    }
}
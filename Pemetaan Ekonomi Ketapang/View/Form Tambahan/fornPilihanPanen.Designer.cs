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
            this.cbPangan.Location = new System.Drawing.Point(172, 155);
            this.cbPangan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPangan.Name = "cbPangan";
            this.cbPangan.Size = new System.Drawing.Size(254, 21);
            this.cbPangan.TabIndex = 3;
            this.cbPangan.Text = "Form hasil panen tanaman pangan ";
            this.cbPangan.UseVisualStyleBackColor = true;
            this.cbPangan.CheckedChanged += new System.EventHandler(this.cbPangan_CheckedChanged);
            // 
            // cbKeras
            // 
            this.cbKeras.AutoSize = true;
            this.cbKeras.Location = new System.Drawing.Point(172, 207);
            this.cbKeras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKeras.Name = "cbKeras";
            this.cbKeras.Size = new System.Drawing.Size(237, 21);
            this.cbKeras.TabIndex = 4;
            this.cbKeras.Text = "Form hasil panen tanaman keras";
            this.cbKeras.UseVisualStyleBackColor = true;
            // 
            // cbTernak
            // 
            this.cbTernak.AutoSize = true;
            this.cbTernak.Location = new System.Drawing.Point(172, 254);
            this.cbTernak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTernak.Name = "cbTernak";
            this.cbTernak.Size = new System.Drawing.Size(183, 21);
            this.cbTernak.TabIndex = 5;
            this.cbTernak.Text = "Form hasil panen ternak";
            this.cbTernak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Centang pada pilihan form-form yang akan diisi sesuai dengan formulir yang  sudah" +
    " terisi!";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(264, 305);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(147, 50);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Pilih";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // fornPilihanPanen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 418);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTernak);
            this.Controls.Add(this.cbKeras);
            this.Controls.Add(this.cbPangan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fornPilihanPanen";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
namespace Pemetaan_Ekonomi_Ketapang
{
    partial class form_login
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
            this.edt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.edt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button_login = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_versiAplikasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_username
            // 
            this.edt_username.Depth = 0;
            this.edt_username.Hint = "Username";
            this.edt_username.Location = new System.Drawing.Point(325, 143);
            this.edt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.edt_username.Name = "edt_username";
            this.edt_username.PasswordChar = '\0';
            this.edt_username.SelectedText = "";
            this.edt_username.SelectionLength = 0;
            this.edt_username.SelectionStart = 0;
            this.edt_username.Size = new System.Drawing.Size(262, 23);
            this.edt_username.TabIndex = 0;
            this.edt_username.UseSystemPasswordChar = false;
            this.edt_username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.edt_username_PreviewKeyDown);
            // 
            // edt_password
            // 
            this.edt_password.Depth = 0;
            this.edt_password.Hint = "Password";
            this.edt_password.Location = new System.Drawing.Point(325, 182);
            this.edt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.edt_password.Name = "edt_password";
            this.edt_password.PasswordChar = '*';
            this.edt_password.SelectedText = "";
            this.edt_password.SelectionLength = 0;
            this.edt_password.SelectionStart = 0;
            this.edt_password.Size = new System.Drawing.Size(262, 23);
            this.edt_password.TabIndex = 1;
            this.edt_password.UseSystemPasswordChar = false;
            this.edt_password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.edt_password_PreviewKeyDown);
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_login.BackColor = System.Drawing.Color.DarkBlue;
            this.button_login.Depth = 0;
            this.button_login.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_login.Location = new System.Drawing.Point(436, 233);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_login.Name = "button_login";
            this.button_login.Primary = false;
            this.button_login.Size = new System.Drawing.Size(52, 36);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tb_versiAplikasi
            // 
            this.tb_versiAplikasi.AutoSize = true;
            this.tb_versiAplikasi.Location = new System.Drawing.Point(594, 334);
            this.tb_versiAplikasi.Name = "tb_versiAplikasi";
            this.tb_versiAplikasi.Size = new System.Drawing.Size(35, 13);
            this.tb_versiAplikasi.TabIndex = 5;
            this.tb_versiAplikasi.Text = "label1";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 356);
            this.Controls.Add(this.tb_versiAplikasi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.edt_password);
            this.Controls.Add(this.edt_username);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_login";
            this.Text = "Pemetaan Ekonomi Keuskupan Ketapang";
            this.Load += new System.EventHandler(this.form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField edt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField edt_password;
        private MaterialSkin.Controls.MaterialFlatButton button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tb_versiAplikasi;
    }
}


namespace Pemetaan_Ekonomi_Ketapang
{
    using Pemetaan_Ekonomi_Ketapang.Model;
    using System;
    using System.Data;
    using System.Windows.Forms;
    using Pemetaan_Ekonomi_Ketapang.Controller;
    
    public partial class form_login : MaterialSkin.Controls.MaterialForm
    {
        private mstuserControl uc = new mstuserControl();
        
        public form_login()
        {
            InitializeComponent();
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edt_username.Text) || string.IsNullOrWhiteSpace(edt_password.Text))
            {
                MessageBox.Show("Silahkan isi username dan password terlebih dahulu");
            }
            else
            {
                if (uc.loginUser(edt_username.Text,edt_password.Text))
                {
                    this.Hide();
                    View.formUtama tempForm = new View.formUtama();
                    tempForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username / Password yang dimasukan salah!");
                    edt_username.Text = String.Empty;
                    edt_password.Text = String.Empty;
                }
            }
        }
        
        private void edt_username_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                edt_password.Select();
            }
        }
        
        private void edt_password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            tb_versiAplikasi.Text = CoreCode.versiAplikasi;
            edt_username.Select();
            pictureBox1.Image = Properties.Resources.KKKetapang;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}

namespace Pemetaan_Ekonomi_Ketapang
{
    using MySql.Data.MySqlClient;
    using Pemetaan_Ekonomi_Ketapang.Model;
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="form_login" />
    /// </summary>
    public partial class form_login : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="form_login"/> class.
        /// </summary>
        public form_login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button_login_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edt_username.Text) || string.IsNullOrWhiteSpace(edt_password.Text))
            {
                MessageBox.Show("Silahkan isi username dan password terlebih dahulu");
            }
            else
            {

                MySqlConnection conn = null;
                conn = new MySqlConnection(CoreCode.koneksi);
                conn.Open();

                MySqlCommand command = new MySqlCommand("Select username from mstuser where username = '" + edt_username.Text + "' and password = '" + edt_password.Text + "' limit 0, 1", conn);
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());

                String temp = "belum ada isi";

                foreach (DataRow row in data.Rows)
                {
                    temp = (string)row["username"];
                }

                if (temp == edt_username.Text)
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
                conn.Close();

            }
        }

        /// <summary>
        /// The edt_username_PreviewKeyDown
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="PreviewKeyDownEventArgs"/></param>
        private void edt_username_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                edt_password.Select();
            }
        }

        /// <summary>
        /// The edt_password_PreviewKeyDown
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="PreviewKeyDownEventArgs"/></param>
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

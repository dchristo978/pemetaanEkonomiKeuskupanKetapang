namespace Pemetaan_Ekonomi_Ketapang.View
{
    using MetroFramework.Forms;
    using System;
    using System.Windows.Forms;
    using System.Diagnostics;
    using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;

    /// <summary>
    /// Defines the <see cref="formUtama" />
    /// </summary>
    public partial class formUtama : MetroForm
    {
      
        /// <summary>
        /// Initializes a new instance of the <see cref="formUtama"/> class.
        /// </summary>
        public formUtama()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The formUtama_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void formUtama_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// The input2ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void input2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_login tempForm = new form_login();
            this.Hide();
            tempForm.Show();
        }

        private void logoutAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void keluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan!", "Apakah anda yakin ingin keluar aplikasi?", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pendataanUmatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void cariKepalaKeluargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKepalaKeluarga formKK = new formKepalaKeluarga();
            formKK.MdiParent = this;
            formKK.Show();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inputFormSamplingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kepalaKeluargaBaruTidakTerdataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formIdentitas formInputKKBaru = new formIdentitas();
            formInputKKBaru.MdiParent = this;
            formInputKKBaru.Show();
        }

        private void aplikasiPendataanUmatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files\Keuskupan Ketapang\PendataanUmat\SIUMAT_APP.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan, silahkan hubungi yang bersangkutan dengan menampilkan code error berikut : " + ex.Message, "Kesalahan!");
                return;
            }
        }

        private void kepalaKeluargaTerdataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKkDatabase fr = new formKkDatabase();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}

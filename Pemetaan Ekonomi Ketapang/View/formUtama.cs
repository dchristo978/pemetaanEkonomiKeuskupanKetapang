namespace Pemetaan_Ekonomi_Ketapang.View
{
    using MetroFramework.Forms;
    using System;
    using System.Windows.Forms;
    using System.Diagnostics;
    using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;
    using Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan;
    using Pemetaan_Ekonomi_Ketapang.Controller;


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
            GlobalParam.formParent = "formKepalaKeluarga";
            formPilihParoki formPilihParoki = new formPilihParoki();
            formPilihParoki.Text = "Form Kepala Keluarga";
            formPilihParoki.MdiParent = this;
            formPilihParoki.Show();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inputFormSamplingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kepalaKeluargaBaruTidakTerdataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalParam.formParent = "formIdentitas";
            formPilihParoki formPilihParoki = new formPilihParoki();
            formPilihParoki.MdiParent = this;
            formPilihParoki.Show();
            //formIdentitas formInputKKBaru = new formIdentitas();
            //formInputKKBaru.MdiParent = this;
            //formInputKKBaru.Show();
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
            GlobalParam.formParent = "formKkDatabase";
            formPilihParoki formPilihParoki = new formPilihParoki();
            formPilihParoki.MdiParent = this;
            formPilihParoki.Show();
            //formKkDatabase fr = new formKkDatabase();
            //fr.MdiParent = this;
            //fr.Show();
        }

        private void tambahJawabanBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pertanyaan.formTambahJawabanLainnya form = new formTambahJawabanLainnya();
            GlobalParam.formParent = "formUtama";
            form.MdiParent = this;
            form.Show();
        }

        private void lihatRekomendasiSamplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRekomendasiSampling form = new formRekomendasiSampling();
            form.MdiParent = this;
            form.Show();
        }

        private void masterDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDatabase form = new formDatabase();
            form.MdiParent = this;
            form.Show();
        }

        private void daftarKepalaKeluargaTersamplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKKTersample form = new formKKTersample();
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lihatLaporanPemetaanEkonomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLaporanPemetaanEkonomi form = new formLaporanPemetaanEkonomi();
            form.MdiParent = this;
            form.Show();
        }
    }
}

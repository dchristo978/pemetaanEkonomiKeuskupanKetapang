using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formPendapatanAnggotaKeluargaPerBulan : MetroForm
    {
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();

        public formPendapatanAnggotaKeluargaPerBulan()
        {
            InitializeComponent();
        }

        private void initializeHeader()
        {
            tbl_umat umat = umatControl.getDataUmatSatuan(Convert.ToInt32(formIdentitas.idUmat));

            Debug.Write("ISI NOMOR IDENTIAS : " + " KTP " + umat.no_ktp + " KK " + umat.no_kk + "K5 " + umat.no_k5);

            lb_namaKK.Text = umat.nama;
            lb_nok5.Text = umatControl.getNomorIdentitas(umat);
            lb_umur.Text = umat.umur.ToString() + " Tahun";
            lb_stasi.Text = stasiControl.getNamaStasi(umat.id_stasi);
            lb_paroki.Text = parokiControl.getNamaParokiByID(umat.id_paroki);
            lb_jenisKelamin.Text = umat.jenis_kelamin;
        }

        private void formPendapatanAnggotaKeluargaPerBulan_Load(object sender, EventArgs e)
        {
            initializeHeader();
            GlobalParam.idPertanyaan = 22;
        }

        private void cbSuami_CheckedChanged(object sender, EventArgs e)
        {
            this.edtSuami.Enabled = this.cbSuami.Checked;
            this.edtSuami.Text = "";
        }

        private void cbIstri_CheckedChanged(object sender, EventArgs e)
        {
            this.edtIstri.Enabled = this.cbIstri.Checked;
            this.edtIstri.Text = "";
        }

        private void cbAnak_CheckedChanged(object sender, EventArgs e)
        {
            this.edtAnak.Enabled = this.cbAnak.Checked;
            this.edtAnak.Text = "";
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.edtSuami.Text) && !String.IsNullOrWhiteSpace(this.edtIstri.Text) && !String.IsNullOrWhiteSpace(this.edtAnak.Text))
            {
                MessageBox.Show("Pastikan salah satu data sudah diisi sesuai dengan form yang ada!");
            }
            else
            {
                try
                {
                    if(!String.IsNullOrWhiteSpace(this.edtSuami.Text))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 188, GlobalParam.id_umat, this.edtSuami.Text, ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtIstri.Text))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 189, GlobalParam.id_umat, this.edtIstri.Text, ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtAnak.Text))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 190, GlobalParam.id_umat, this.edtAnak.Text, ""));
                    }

                    MessageBox.Show("Data berhasil di masukan, silahkan lanjutkan ke form berikutnya !");
                    formPengeluaranKeluargaPerBulan temp = new formPengeluaranKeluargaPerBulan();
                    temp.Show();
                    this.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Terjadi kesalahan pada sistem, silahkan hubungi admin dengan menyertakan kalimat berikut : " + E.Message);
                }
            }
        }

        private void checkTotal()
        {
            int temp = 0;

            if (!String.IsNullOrWhiteSpace(this.edtSuami.Text))
                temp += Convert.ToInt32(this.edtSuami.Text);

            if (!String.IsNullOrWhiteSpace(this.edtIstri.Text))
                temp += Convert.ToInt32(this.edtIstri.Text);

            if (!String.IsNullOrWhiteSpace(this.edtAnak.Text))
                temp += Convert.ToInt32(this.edtAnak.Text);

            if (temp >= 0)
                this.lbTotal.Text = "Rp." + temp.ToString();
            else
                this.lbTotal.Text = "Total akan ditampilkan di sini";
        }

        private void edtSuami_TextChanged(object sender, EventArgs e)
        {
            checkTotal();
        }

        private void edtIstri_TextChanged(object sender, EventArgs e)
        {
            checkTotal();
        }

        private void edtAnak_TextChanged(object sender, EventArgs e)
        {
            checkTotal();
        }
    }
}

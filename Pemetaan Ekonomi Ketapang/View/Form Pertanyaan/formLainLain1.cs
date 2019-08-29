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
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using System.Diagnostics;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formLainLain1 : MetroForm
    {
        db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        ref_pekerjaanTableAdapter pekerjaanAdapter = new ref_pekerjaanTableAdapter();
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();
        private int tempFlag = 0;

        public formLainLain1()
        {
            InitializeComponent();
        }

        private void formLainLain1_Load(object sender, EventArgs e)
        {
            initializeHeader();
            this.populateComboBox(12, this.cmbMengatasiMasalahKesehatan);
            this.populateComboBox(13, this.cmbPembiayaanUntukKesehatan);
            this.populateComboBox(14, this.cmbSumberPenghasilanKK);
            this.populateComboBox(15, this.cmbPendidikanTertinggiKK);
            this.populateComboBox(16, this.cmbKepemilikanTabungan);
            this.populateComboBox(17, this.cmbKondisiKepemilikanTabungan);
            this.populateComboBox(18, this.cmbKondisiKepemilikanTabungan);
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

        private void populateComboBox(int id, ComboBox cmb)
        {
            List<ref_jawaban> temp = refJawabanControl.populateComboBox();
            cmb.DataSource = temp.Where(ref_jawaban => ref_jawaban.id_pertanyaan == id).ToList();
            cmb.DisplayMember = "jawaban";
            cmb.ValueMember = "id_ref_jawaban";
        }

        private void populateComboBoxPekerjaan(ComboBox cmb)
        {
            ds.EnforceConstraints = false;
            pekerjaanAdapter.Fill(ds.ref_pekerjaan);
            cmb.DataSource = ds.ref_pekerjaan;
            cmb.DisplayMember = "pekerjaan";
            cmb.ValueMember = "id_pekerjaan";
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            if(!cbEmas.Checked && !cbMobilPribadi.Checked && !cbTruk.Checked && !cbMotor.Checked && !cbSepit.Checked && !cbTidakAda.Checked)
            {
                MessageBox.Show("Pastikan semua pilihan pertanyaan sudah terjawab!");
            }
            else
            {
                try {
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbMengatasiMasalahKesehatan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    tempFlag = 1;
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbPembiayaanUntukKesehatan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    tempFlag = 2;
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbSumberPenghasilanKK.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    tempFlag = 3;
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbPendidikanTertinggiKK.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    tempFlag = 4;
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbKepemilikanTabungan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    tempFlag = 5;
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbKondisiKepemilikanTabungan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));

                    tempFlag = 6;
                    if (this.cbEmas.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,71, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    if (this.cbMobilPribadi.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,72, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    if (this.cbTruk.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,73, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    if (this.cbMotor.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,74, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    if (this.cbSepit.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,75, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                    if (this.cbTidakAda.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,76, Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));

                    MessageBox.Show("Data Lain Lain berhasil di masukan, silahkan lanjutkan ke form berikut!");
                    formTanamanPangan fr = new formTanamanPangan();
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Terjadi kesalahan, silahkan hubungi admin dengan error code : " + tempFlag + "  Tempflagnya  " + E.Message);
                }
            }
        }

        private void cbEmas_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTidakAda.Checked = false;
        }

        private void cbMobilPribadi_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTidakAda.Checked = false;
        }

        private void cbTruk_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTidakAda.Checked = false;
        }

        private void cbMotor_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTidakAda.Checked = false;
        }

        private void cbSepit_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTidakAda.Checked = false;
        }

        private void cbTidakAda_CheckedChanged(object sender, EventArgs e)
        {
            this.cbEmas.Checked = false;
            this.cbMobilPribadi.Checked = false;
            this.cbTruk.Checked = false;
            this.cbMotor.Checked = false;
            this.cbSepit.Checked = false;
        }
    }
}

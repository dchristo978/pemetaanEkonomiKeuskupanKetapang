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
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formFasilitasTempatTinggal : MetroForm
    {
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();

        public formFasilitasTempatTinggal()
        {
            InitializeComponent();
        }

        private void formFasilitasTempatTinggal_Load(object sender, EventArgs e)
        {
            initializeHeader();
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

        private void cbTidakAdaListrik_CheckStateChanged(object sender, EventArgs e)
        {
            if(this.cbTidakAdaListrik.Checked)
            {
                this.cbListrikIkutRumahLain.Checked = false;
                this.cbListrikTenagaSurya.Checked = false;
                this.cbListrikGenset.Checked = false;
                this.cbListrikPLN.Checked = false;
            }
            else if (this.cbListrikIkutRumahLain.Checked || this.cbListrikTenagaSurya.Checked || this.cbListrikGenset.Checked || this.cbListrikPLN.Checked)
            {
                this.cbTidakAdaListrik.Checked = false;
            }
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            if ((!this.cbListrikIkutRumahLain.Checked && !this.cbListrikTenagaSurya.Checked && !this.cbListrikGenset.Checked && !this.cbListrikPLN.Checked && !this.cbTidakAdaListrik.Checked) || (!this.cbSumurSendiri.Checked && !this.cbMataAir.Checked && !this.cbSungai.Checked && !this.cbTadahHujan.Checked && !this.cbPAM.Checked) || (!this.cbKayuBakar.Checked && !this.cbArang.Checked && !this.cbMinyakTanah.Checked && !this.cbGasLPG.Checked))
            {
                MessageBox.Show("Pastikan tiap pertanyaan sudah memiliki jawaban!");
            }
            else
            {
                int tempIdUmat = Convert.ToInt32(formIdentitas.idUmat);
                String tempNamaCBError = "";
                try
                {
                    tempNamaCBError = this.cbTidakAdaListrik.Name;
                    if (this.cbTidakAdaListrik.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 20, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbListrikIkutRumahLain.Name;
                    if (this.cbListrikIkutRumahLain.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 21, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbListrikTenagaSurya.Name;
                    if (this.cbListrikTenagaSurya.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 22, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbListrikGenset.Name;
                    if (this.cbListrikGenset.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 23, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbListrikPLN.Name;
                    if (this.cbListrikPLN.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 24, tempIdUmat, "Null", "Null"));



                    tempNamaCBError = this.cbSumurSendiri.Name;
                    if (this.cbSumurSendiri.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 25, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbMataAir.Name;
                    if (this.cbMataAir.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 26, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbSungai.Name;
                    if (this.cbSungai.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 27, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbTadahHujan.Name;
                    if (this.cbTadahHujan.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 28, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbPAM.Name;
                    if (this.cbPAM.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 29, tempIdUmat, "Null", "Null"));



                    tempNamaCBError = this.cbKayuBakar.Name;
                    if (this.cbKayuBakar.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 30, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbArang.Name;
                    if (this.cbArang.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 31, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbMinyakTanah.Name;
                    if (this.cbMinyakTanah.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 32, tempIdUmat, "Null", "Null"));

                    tempNamaCBError = this.cbGasLPG.Name;
                    if (this.cbGasLPG.Checked)
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 33, tempIdUmat, "Null", "Null"));

                    MessageBox.Show("Penginputan data fasilitas tempat tinggal berhasil, silahkan lanjutkan ke form berikutnya !");
                    this.Hide();
                    formKebutuhanHidupSehariHari formKebutuhanHidupSehariHari = new formKebutuhanHidupSehariHari();
                    formKebutuhanHidupSehariHari.ShowDialog();
                    this.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Terjadi kesalahan pada proses penginputan, silahkan hubungi admin dengan error code : " + E.Message + " CHECK BOX : " + tempNamaCBError);
                }
            }
        }
    }
}

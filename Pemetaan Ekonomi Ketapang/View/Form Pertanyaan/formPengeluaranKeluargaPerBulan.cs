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
    public partial class formPengeluaranKeluargaPerBulan : MetroForm
    {

        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();
        private String tempListStringJawabanLain = "";

        private ToolTip tempTooltip = new ToolTip();

        public formPengeluaranKeluargaPerBulan()
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

        private void formPengeluaranKeluargaPerBulan_Load(object sender, EventArgs e)
        {
            initializeHeader();

            GlobalParam.idPertanyaan = 22;

            this.edtTotalLain.Enabled = false;


            CheckAlreadyPickedJawabanLain();
        }

        private void CheckAlreadyPickedJawabanLain()
        {
            tempListStringJawabanLain = tblJawaanControl.getListStringCustomJawabanPickedBasedOnIDUmat();
            if (!String.IsNullOrWhiteSpace(tempListStringJawabanLain))
            {
                this.edtTotalLain.Visible = Visible;
                this.btnEditLain.Visible = Visible;
                this.lbNamaLain.Visible = Visible;

                this.edtTotalLain.Text = tempListStringJawabanLain;
                tempTooltip.Active = true;
                tempTooltip.ShowAlways = true;
            }
            else
            {
                tempListStringJawabanLain = "";
                tempTooltip.Active = false;
                this.edtTotalLain.Text = "";
                this.edtTotalLain.Visible = false;
                this.btnEditLain.Visible = false;
                this.lbNamaLain.Visible = false;
            }
        }


        private void edtSuami_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBahanBakar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtSembako);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBumbuDapur);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtUangJajan);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtAir);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtListrik);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtPAM);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtUangSekolahAnak);
        }

        public void nominalChecker(TextBox param)
        {
            if (Convert.ToInt32(param.Text) <= 0 || String.IsNullOrWhiteSpace(param.Text))
            {
                param.Text = "0";
            }
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(edtAir.Text) == 0
                    && Convert.ToInt32(edtBahanBakar.Text) == 0
                    && Convert.ToInt32(edtBumbuDapur.Text) == 0
                    && Convert.ToInt32(edtListrik) == 0
                    && Convert.ToInt32(edtPAM) == 0
                    && Convert.ToInt32(edtSembako) == 0
                    && Convert.ToInt32(edtUangJajan) == 0
                    && Convert.ToInt32(edtUangSekolahAnak) == 0)
                {
                    DialogResult temp = MessageBox.Show("Apakah anda yakin semua jawaban adalah 0 rupiah?", "Peringatan!", MessageBoxButtons.YesNo);
                    if (temp == DialogResult.Yes)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 191, GlobalParam.id_umat, this.edtBahanBakar.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 192, GlobalParam.id_umat, this.edtSembako.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 193, GlobalParam.id_umat, this.edtBumbuDapur.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 194, GlobalParam.id_umat, this.edtUangJajan.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 195, GlobalParam.id_umat, this.edtAir.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 196, GlobalParam.id_umat, this.edtListrik.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 197, GlobalParam.id_umat, this.edtPAM.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 198, GlobalParam.id_umat, this.edtUangSekolahAnak.Text, ""));

                        MessageBox.Show("Data berhasil di masukan, silahkan lanjutkan ke form berikutnya !");
                        formPengeluaranSandang tempForm = new formPengeluaranSandang();
                        tempForm.Show();
                        this.Close();
                    }
                    else if (temp == DialogResult.No)
                    {

                    }
                }
                else
                {
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 191, GlobalParam.id_umat, this.edtBahanBakar.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 192, GlobalParam.id_umat, this.edtSembako.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 193, GlobalParam.id_umat, this.edtBumbuDapur.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 194, GlobalParam.id_umat, this.edtUangJajan.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 195, GlobalParam.id_umat, this.edtAir.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 196, GlobalParam.id_umat, this.edtListrik.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 197, GlobalParam.id_umat, this.edtPAM.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 198, GlobalParam.id_umat, this.edtUangSekolahAnak.Text, ""));
                    MessageBox.Show("Data berhasil di masukan, silahkan lanjutkan ke form berikutnya !");
                    formPengeluaranSandang tempForm = new formPengeluaranSandang();
                    tempForm.Show();
                    this.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Terjadi kesalahan pada sistem, silahkan hubungi admin dengan menyertakan kalimat berikut : " + E.Message);
            }
        }
    }
}

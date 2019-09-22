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
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.Controller;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formTanamanPangan : MetroForm
    {

        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();

        private ToolTip tempTooltip = new ToolTip();
        private String tempListStringJawabanLain;

        public formTanamanPangan()
        {
            InitializeComponent();
        }

        private void formTanamanPangan_Load(object sender, EventArgs e)
        {
            this.initializeHeader();
            GlobalParam.idPertanyaan = 19;

            this.edtTotalLain.Enabled = false;


            CheckAlreadyPickedJawabanLain();
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

        private void cmbSimpan_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(this.edtPadi.Text.ToString()) && String.IsNullOrWhiteSpace(this.edtJagung.Text.ToString()) && String.IsNullOrWhiteSpace(this.edtUbi.Text.ToString()) && String.IsNullOrWhiteSpace(this.edtKedelai.Text.ToString()) && String.IsNullOrWhiteSpace(this.edtKacang.Text.ToString()) && String.IsNullOrWhiteSpace(this.edtTotalLain.Text.ToString()))
            {
                MessageBox.Show("Pastikan salah satu data sudah diisi sesuai dengan form yang ada!");
            }
            else
            { 
                try
                {

                    if (!String.IsNullOrWhiteSpace(this.edtPadi.Text.ToString()))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 175, GlobalParam.id_umat, this.edtPadi.Text.ToString(), ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtJagung.Text.ToString()))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 176, GlobalParam.id_umat, this.edtJagung.Text.ToString(), ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtUbi.Text.ToString()))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 177, GlobalParam.id_umat, this.edtUbi.Text.ToString(), ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtKedelai.Text.ToString()))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 178, GlobalParam.id_umat, this.edtKedelai.Text.ToString(), ""));
                    }
                    if (!String.IsNullOrWhiteSpace(this.edtKacang.Text.ToString()))
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 179, GlobalParam.id_umat, this.edtKacang.Text.ToString(), ""));
                    }

                    MessageBox.Show("Data berhasil di masukan, silahkan lanjutkan ke form berikutnya !");
                    this.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Terjadi kesalahan pada sistem, silahkan hubungi admin dengan menyertakan kalimat berikut : " + E.Message);
                }
            }

        }

        private void btnEditLain_Click(object sender, EventArgs e)
        {
            formListJawabanLainTerpilih form = new formListJawabanLainTerpilih();
            form.Show();
        }

        private void btnTambahLain_Click(object sender, EventArgs e)
        {
            GlobalParam.formParent = "formTanamanPangan";
            GlobalParam.idPertanyaan = 19;
            formJawabanLainnya fr = new formJawabanLainnya();
            fr.ShowDialog();
        }

        private void formTanamanPangan_Activated(object sender, EventArgs e)
        {
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
                tempTooltip.SetToolTip(this.edtTotalLain, tempListStringJawabanLain);
                tempTooltip.ShowAlways = true;
            }
            else
            {
                tempTooltip.Active = false;
                this.edtTotalLain.Text = "";
                this.edtTotalLain.Visible = false;
                this.btnEditLain.Visible = false;
                this.lbNamaLain.Visible = false;
            }
        }

        private void edtTotalLain_MouseHover(object sender, EventArgs e)
        {

        }
    }
}

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
using System.Diagnostics;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formPengeluaranSandang : MetroForm 
    {
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();
        private String tempListStringJawabanLain = "";

        private ToolTip tempTooltip = new ToolTip();

        public formPengeluaranSandang()
        {
            InitializeComponent();
        }

        private void formPengeluaranSandang_Load(object sender, EventArgs e)
        {
            initializeHeader();
            GlobalParam.idPertanyaan = 23;

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

        public void nominalChecker(TextBox param)
        {
            if (Convert.ToInt32(param.Text) <= 0 || String.IsNullOrWhiteSpace(param.Text))
            {
                param.Text = "0";
            }
        }

        private void edtBeliBaju_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBeliBaju);
        }

        private void edtBeliSepatu_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBeliSepatu);
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(this.edtBeliBaju.Text) == 0 && Convert.ToInt32(this.edtBeliSepatu.Text) == 0 && String.IsNullOrWhiteSpace(edtTotalLain.Text))
                {
                    DialogResult temp = MessageBox.Show("Apakah anda yakin semua jawaban adalah 0?", "Peringatan", MessageBoxButtons.YesNo);
                    if (temp == DialogResult.Yes)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 199, GlobalParam.id_umat, this.edtBeliBaju.Text, ""));
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 200, GlobalParam.id_umat, this.edtBeliSepatu.Text, ""));
                        MessageBox.Show("Semua Data berhasil dimasukan, anda dapat mengubahnya di form edit data sampling.");
                        this.Close();
                    }
                    else if (temp == DialogResult.No)
                    {

                    }
                }
                else
                {
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 199, GlobalParam.id_umat, this.edtBeliBaju.Text, ""));
                    tblJawaanControl.insertJawaban(new tbl_jawaban(0, 200, GlobalParam.id_umat, this.edtBeliSepatu.Text, ""));
                    MessageBox.Show("Semua Data berhasil dimasukan, anda dapat mengubahnya di form edit data sampling.");
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

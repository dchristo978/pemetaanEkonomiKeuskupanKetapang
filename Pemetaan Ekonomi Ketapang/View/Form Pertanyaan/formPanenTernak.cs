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
    public partial class formPanenTernak : MetroForm
    {
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();
        private String tempListStringJawabanLain = "";

        private ToolTip tempTooltip = new ToolTip();

        public formPanenTernak()
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

        private void formPanenTernak_Load(object sender, EventArgs e)
        {
            initializeHeader();

            GlobalParam.idPertanyaan = 24;

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

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(this.edtAyamRp.Text) &&
                    String.IsNullOrWhiteSpace(this.edtBabiRp.Text) && 
                    String.IsNullOrWhiteSpace(this.edtBebekRp.Text) &&
                    String.IsNullOrWhiteSpace(this.edtIkanRp.Text) &&
                    String.IsNullOrWhiteSpace(this.edtKambingRp.Text) && 
                    String.IsNullOrWhiteSpace(this.edtSapiRp.Text) &&
                    String.IsNullOrWhiteSpace(this.edtTotalLain.Text))
                {
                    MessageBox.Show("Tidak ada data untuk disimpan ke dalam database! Silahkan isi minimal satu data yang disediakan");
                }
                else
                {
                    if(this.edtSapiRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0,182,GlobalParam.id_umat,this.edtSapiEkor.Text,this.edtSapiRp.Text));
                    }
                    if (this.edtKambingRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 183, GlobalParam.id_umat, this.edtKambingEkor.Text, this.edtKambingRp.Text));
                    }
                    if (this.edtAyamRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 184, GlobalParam.id_umat, this.edtAyamEkor.Text, this.edtAyamRp.Text));
                    }
                    if (this.edtBabiRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 185, GlobalParam.id_umat, this.edtBabiEkor.Text, this.edtBabiRp.Text));
                    }
                    if (this.edtIkanRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 186, GlobalParam.id_umat, this.edtIkanKg.Text, this.edtIkanRp.Text));
                    }
                    if (this.edtBebekRp.Enabled)
                    {
                        tblJawaanControl.insertJawaban(new tbl_jawaban(0, 187, GlobalParam.id_umat, this.edtBebekKg.Text, this.edtBebekRp.Text));
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Terjadi kesalahan pada sistem, silahkan hubungi admin dengan menyertakan kalimat berikut : " + E.Message);
            }
        }

        public void nominalChecker(TextBox param)
        {
            if (Convert.ToInt32(param.Text) <= 0 || String.IsNullOrWhiteSpace(param.Text))
            {
                param.Text = "0";
            }
        }

        private void edtSapiEkor_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtSapiEkor);

            if(Convert.ToInt32(this.edtSapiEkor.Text)<=0)
            {
                this.edtSapiRp.Enabled = false;
            }
            else
            {
                this.edtSapiRp.Enabled = true;
            }
        }

        private void edtKambingEkor_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtKambingEkor);
            if (Convert.ToInt32(this.edtKambingEkor.Text) <= 0)
            {
                this.edtKambingRp.Enabled = false;
            }
            else
            {
                this.edtKambingRp.Enabled = true;
            }
        }

        private void edtAyamEkor_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtAyamEkor);
            if (Convert.ToInt32(this.edtAyamEkor.Text) <= 0)
            {
                this.edtAyamRp.Enabled = false;
            }
            else
            {
                this.edtAyamRp.Enabled = true;
            }
        }

        private void edtBabiEkor_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBabiEkor);
            if (Convert.ToInt32(this.edtBabiEkor.Text) <= 0)
            {
                this.edtBabiRp.Enabled = false;
            }
            else
            {
                this.edtBabiRp.Enabled = true;
            }
        }

        private void edtIkanKg_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtIkanKg);
            if (Convert.ToInt32(this.edtIkanKg.Text) <= 0)
            {
                this.edtIkanRp.Enabled = false;
            }
            else
            {
                this.edtIkanRp.Enabled = true;
            }
        }

        private void edtBebekKg_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBebekKg);
            if (Convert.ToInt32(this.edtBebekKg.Text) <= 0)
            {
                this.edtBebekRp.Enabled = false;
            }
            else
            {
                this.edtBebekRp.Enabled = true;
            }

        }

        private void edtSapiRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtSapiRp);
        }

        private void edtKambingRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtKambingRp);
        }

        private void edtAyamRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtAyamRp);
        }

        private void edtBabiRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBabiRp);
        }

        private void edtIkanRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtIkanRp);
        }

        private void edtBebekRp_TextChanged(object sender, EventArgs e)
        {
            nominalChecker(this.edtBebekRp);
        }
    }
}

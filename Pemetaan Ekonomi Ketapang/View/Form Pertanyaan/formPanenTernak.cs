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
    }
}

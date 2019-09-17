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

        public formTanamanPangan()
        {
            InitializeComponent();
        }

        private void formTanamanPangan_Load(object sender, EventArgs e)
        {
            this.initializeHeader();
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
            if((string.IsNullOrEmpty(this.edtJagung.Text) || string.IsNullOrEmpty(this.edtKacang.Text) || string.IsNullOrEmpty(this.edtKedelai.Text) || string.IsNullOrEmpty(this.edtPadi.Text) || string.IsNullOrEmpty(this.edtUbi.Text)) && string.IsNullOrEmpty(this.edtTotalLain.Text))
            {
                MessageBox.Show("Pastikan data sudah terisi sesuai dengan Form");
            }
            else
            {

            }
        }

        private void btnEditLain_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahLain_Click(object sender, EventArgs e)
        {
            GlobalParam.formParent = "formTanamanPangan";
            GlobalParam.idPertanyaan = 19;
            formJawabanLainnya fr = new formJawabanLainnya();
            fr.ShowDialog();
        }
    }
}

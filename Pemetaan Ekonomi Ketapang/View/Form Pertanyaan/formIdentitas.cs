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
using Pemetaan_Ekonomi_Ketapang.Controller;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formIdentitas : MetroForm
    {
        DatabasesConnector dbConnector = new DatabasesConnector();
        DataSet dataNamaParoki= new DataSet();
        db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        private tbl_parokiTableAdapter parokiAdapter = new tbl_parokiTableAdapter();
        private ref_pekerjaanTableAdapter pekerjaanAdapter = new ref_pekerjaanTableAdapter();
        private tbl_stasiTableAdapter stasiAdapter = new tbl_stasiTableAdapter();
        private StasiControl stasiControl = new StasiControl();
        private UmatControl umatControl = new UmatControl();
        public static String idUmat = "";

        internal ParokiControl parokiControl = new ParokiControl();

        public formIdentitas()
        {
            InitializeComponent();
        }

        private void formIdentitas_Load(object sender, EventArgs e)
        {
            this.edtNamaKepalaKeluarga.Clear();
            this.edtNoK5.Clear();
            this.edtUmur.Clear();
            this.radioK5.Select();
            
            populateComboBoxPekerjaan(); 
            populateComboBoxKelamin();
            populateComboBoxParokiAlternate();
            populateComboBoxStasi();
            checkIfFromformKkDatabase();
        }
        
        private void populateComboBoxParokiAlternate()
        {
            this.cmbParoki.DataSource = dbConnector.getListDatabases();
            this.cmbParoki.DisplayMember = "lokasi_paroki";
            this.cmbParoki.ValueMember = "id_paroki";
            this.cmbParoki.SelectedValue = dbConnector.getIDParoki(GlobalParam.nama_database);
        }

        private void populateComboBoxPekerjaan()
        {
            ds.EnforceConstraints = false;
            pekerjaanAdapter.Fill(ds.ref_pekerjaan);
            this.cmbPekerjaan.DataSource = ds.ref_pekerjaan;
            this.cmbPekerjaan.DisplayMember = "pekerjaan";
            this.cmbPekerjaan.ValueMember = "id_pekerjaan";
        }

        private void populateComboBoxStasi()
        {
            List<tbl_stasi> temp = new List<tbl_stasi>();
            temp = stasiControl.getStasiBasedOnIdParokiNew(Convert.ToInt32(dbConnector.getIDParoki(GlobalParam.nama_database)),GlobalParam.nama_database);
            this.cmbStasi.DataSource = temp;
            this.cmbStasi.DisplayMember = "nama_stasi";
            this.cmbStasi.ValueMember = "kode_stasi";
        }

        private void cmbParoki_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkIfFromformKkDatabase()
        {
            if (String.Equals(GlobalParam.formParent, "formKkDatabase"))
            {
                
                List<tbl_stasi> temp = new List<tbl_stasi>();
                temp = stasiControl.getStasiBasedOnIdParokiNew(Convert.ToInt32(dbConnector.getIDParoki(GlobalParam.nama_database)), GlobalParam.nama_database);
                int indexItemNamaStasi = temp.FindIndex(a => a.nama_stasi == stasiControl.getStasiNameFromGlobalKodeStasiAndGlobalIdParoki());
                this.cmbParoki.Enabled = false;
                this.cmbStasi.Enabled = false;
                this.edtNamaKepalaKeluarga.Text = GlobalParam.nama;
                this.edtNoK5.Text = GlobalParam.no_k5;
                

                this.cmbStasi.SelectedIndex = indexItemNamaStasi;

                //Selected Value
                this.cmbKelamin.SelectedValue = (GlobalParam.jenis_kelamin);
                this.cmbPekerjaan.SelectedValue = (GlobalParam.id_ref_pekerjaan);
            }
        }

        private void populateComboBoxKelamin()
        {
            List<jenis_kelamin> dataKelamin = new List<jenis_kelamin>();
            dataKelamin.Add(new jenis_kelamin() { id_jenis_kelamin = "L", desc_jenis_kelamin = "Laki-Laki" });
            dataKelamin.Add(new jenis_kelamin() { id_jenis_kelamin = "P", desc_jenis_kelamin = "Perempuan" });
            this.cmbKelamin.DataSource = dataKelamin;
            this.cmbKelamin.DisplayMember = "desc_jenis_kelamin";
            this.cmbKelamin.ValueMember = "id_jenis_kelamin";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.edtNamaKepalaKeluarga.Text) || string.IsNullOrWhiteSpace(this.edtNoK5.Text) || string.IsNullOrWhiteSpace(this.edtUmur.Text))
            {
                MessageBox.Show("Silahkan isi data detail kepala keluarga terlebih dahulu!");
            }
            else if(!edtUmur.Text.All(char.IsDigit))
            {
                MessageBox.Show("Kolom umur hanya dapat diisi dengan angka saja!");
            }
            else
            {
                tbl_umat temp = new tbl_umat();
                temp.nama = this.edtNamaKepalaKeluarga.Text.ToString();
                temp.umur = Convert.ToInt32( this.edtUmur.Text);
                temp.jenis_kelamin = this.cmbKelamin.SelectedValue.ToString();
                temp.id_ref_pekerjaan = Convert.ToInt32(this.cmbPekerjaan.SelectedValue);
                temp.id_paroki = Convert.ToInt32(this.cmbParoki.SelectedValue);
                temp.id_stasi = Convert.ToInt32(this.cmbStasi.SelectedValue);

                if(this.radioK5.Checked)
                {
                    temp.no_k5 = this.edtNoK5.Text;

                    temp.no_kk = "Null";
                    temp.no_ktp = "Null";
;                }
                else if (this.radioKK.Checked)
                {
                    temp.no_kk = this.edtNoK5.Text;

                    temp.no_k5 = "Null";
                    temp.no_ktp = "Null";
                }
                else if (this.radioKTP.Checked)
                {
                    temp.no_ktp = this.edtNoK5.Text;

                    temp.no_k5 = "Null";
                    temp.no_kk = "Null";
                }

                if(string.IsNullOrWhiteSpace(this.edtNoTelp.Text))
                {
                    temp.no_telp = "Null";
                }
                else
                {
                    temp.no_telp = this.edtNoTelp.Text;
                }

                try
                {
                   if(umatControl.insertSamplingUmatBaru(temp) == "1")
                    {
                        MessageBox.Show("Data umat baru berhasil dimasukan, silahkan isi data hasil sampling pada form berikutnya!");
                        idUmat = umatControl.getLastID();
                        GlobalParam.id_umat = Convert.ToInt32(idUmat);
                        this.Hide();
                        formKondisiTempatTinggal formKondisiTempatTinggal = new formKondisiTempatTinggal();
                        formKondisiTempatTinggal.ShowDialog();
                        this.Close();
                    }
                   else
                    {
                        MessageBox.Show("Data gagal dimasukan, silahkan hubungi admin!");
                    }
                }
                catch(Exception E)
                {
                    MessageBox.Show("Data gagal dimasukan dengan error code : " + E.Message.ToString());
                }
            }
        }
    }
}

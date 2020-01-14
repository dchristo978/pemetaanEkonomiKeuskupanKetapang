using System;
using MetroFramework.Forms;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Diagnostics;
using Pemetaan_Ekonomi_Ketapang.Controller;
namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formTambahJawabanLainnya : MetroForm
    {
        private Tbl_BobotControl bobotControl = new Tbl_BobotControl();
        private Tbl_PertanyaanControl pertanyaanControl = new Tbl_PertanyaanControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private bool isBatasAtasBawah = false;
        public static int idJawabanBaru = 0;

        public formTambahJawabanLainnya()
        {
            InitializeComponent();
        }

        private void formTambahJawabanLainnya_Load(object sender, EventArgs e)
        {
            List<tbl_pertanyaan> temp = pertanyaanControl.getAllPertanyaan();
            this.cmbPertanyaan.DisplayMember = "pertanyaan";
            this.cmbPertanyaan.ValueMember = "id_pertanyaan";
            this.cmbPertanyaan.DataSource = temp;
            this.cmbPertanyaan.SelectedValue = GlobalParam.idPertanyaan;

            if (!String.Equals(GlobalParam.formParent, "formUtama"))
                this.cmbPertanyaan.Enabled = false;

            disableBobot(false);
        }

        private void disableBobot(bool temp)
        {
            this.btnSimpanBobot.Enabled = temp;
            this.dataGridView1.Enabled = temp;
            this.edtBatasAtasBobot.Enabled = temp;
            this.edtBatasBawahBobot.Enabled = temp;
            this.edtBobot.Enabled = temp;
            this.edtDesBobot.Enabled = temp;
            this.edtHeaderBobot.Enabled = temp;
        }

        private void clearBobot()
        {
            this.edtBatasAtasBobot.Clear();
            this.edtBatasBawahBobot.Clear();
            this.edtBobot.Clear();
            this.edtDesBobot.Clear();
            this.edtHeaderBobot.Clear();
        }

        private void disableJawaban(bool temp)
        {
            this.btnSimpanJawaban.Enabled = temp;
            this.edtJawaban.Enabled = temp;
            this.cmbPertanyaan.Enabled = temp;
        }

        private void disableAll(bool temp)
        {
            this.btnSimpanBobot.Enabled = temp;
            this.dataGridView1.Enabled = temp;
            this.edtBatasAtasBobot.Enabled = temp;
            this.edtBatasBawahBobot.Enabled = temp;
            this.edtBobot.Enabled = temp;
            this.edtDesBobot.Enabled = temp;
            this.edtHeaderBobot.Enabled = temp;
            this.btnSimpanJawaban.Enabled = temp;
            this.edtJawaban.Enabled = temp;
            this.cmbPertanyaan.Enabled = temp;
        }

        private void cmbPertanyaan_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepareBobotParameter();
        }

        private void btnSimpanJawaban_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.edtJawaban.Text))
            {
                MessageBox.Show("Silahkan masukan jawaban baru pada textbox yang sudah di sediakan!");
            }
            else
            {
                try
                {
                    if (refJawabanControl.insertNewRefJawaban(new ref_jawaban(0, "0", this.edtJawaban.Text, Convert.ToInt32(this.cmbPertanyaan.SelectedValue.ToString())))==1)                    {
                        MessageBox.Show("Jawaban baru berhasil di masukan, silahkan lanjutkan dengan mengisi bobot dari jawaban yang baru dimasukan!");
                        disableBobot(true);
                        disableJawaban(false);
                        prepareBobotParameter();
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan pada saat menginputkan jawaban baru. Jawaban gagal dimasukan!");
                    }
                } catch (Exception E)
                {
                    MessageBox.Show("Terjadi kesalahan pada sistem, silahkan hubungi admin dengan menyertakan kalimat setelah ini : " + E.Message);
                }
            }
        }
        private void prepareBobotParameter()
        {
            bool tempFlag = pertanyaanControl.isPertanyaanDenganBobotJawabanBatasAtasBawahBasedOnIdPertanyaan(Convert.ToInt32(this.cmbPertanyaan.SelectedValue));

            if (!tempFlag)
            {
                edtBatasAtasBobot.Enabled = false;
                edtBatasBawahBobot.Enabled = false;
            }
            else
            {
                isBatasAtasBawah = true;
            }

            loadDatagridview(tempFlag);
        }

        private void btnSimpanBobot_Click(object sender, EventArgs e)
        {
            if (isBatasAtasBawah)
            {
                if (String.IsNullOrEmpty(this.edtBobot.Text) || String.IsNullOrEmpty(this.edtBatasAtasBobot.Text) || String.IsNullOrEmpty(this.edtBatasBawahBobot.Text))
                {
                    MessageBox.Show("Silahkan isi nominal bobot dan batas atas dan batas bawah untuk bobot yang dimaksud!");
                }
                else
                {
                    tbl_bobot temp = new tbl_bobot(0, Convert.ToDouble(this.edtBobot.Text), this.edtHeaderBobot.Text, this.edtDesBobot.Text, Convert.ToDouble(this.edtBatasBawahBobot.Text), Convert.ToDouble(this.edtBatasAtasBobot.Text), "Y", refJawabanControl.getIdRefJawabanBasedOnJawaban(this.edtJawaban.Text));
                    simpanBobotBaru(temp);
                    this.dataGridView1.Refresh();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(this.edtBobot.Text))
                {
                    MessageBox.Show("Silahkan isi nomimal bobot terlebih dahulu!");
                }
                else
                {
                    tbl_bobot temp = new tbl_bobot(0, Convert.ToDouble(this.edtBobot.Text), this.edtHeaderBobot.Text, this.edtDesBobot.Text, 0, 0, "Y", Convert.ToInt32(this.cmbPertanyaan.SelectedValue));
                    simpanBobotBaru(temp);
                    this.dataGridView1.Refresh();
                }
            }
        }

        private void simpanBobotBaru(tbl_bobot temp)
        {
            try
            {
                bobotControl.insertBobotBaru(temp);
                MessageBox.Show("Data jawaban dan bobot baru berhasil di masukan!");
                idJawabanBaru = Convert.ToInt32(this.cmbPertanyaan.SelectedValue);
                clearBobot();
            }
            catch(Exception E)
            {
                MessageBox.Show("Terjadi kesalahan pada saat memasukan bobot baru, silahkan hubungi admin dengan error code : " + E.Message);
            }
            dataGridView1.Refresh();
        }

        private void loadDatagridview(bool tempFlag)
        {
            if(!tempFlag)
            {
                //DataTable temp = bobotControl.getBobotDataTable(Convert.ToInt32(this.cmbPertanyaan.SelectedValue));
                DataTable temp = bobotControl.getBobotDataTable(GlobalParam.idPertanyaan);
                temp.Columns.Remove("batas_bawah_bobot");
                temp.Columns.Remove("batas_atas_bobot");
                this.dataGridView1.DataSource = temp;
            }
            else
            {
                DataTable temp = bobotControl.getBobotDataTable(Convert.ToInt32(this.cmbPertanyaan.SelectedValue));
                this.dataGridView1.DataSource = temp;
            }


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapusJawaban_Click(object sender, EventArgs e)
        {

        }
    }
}

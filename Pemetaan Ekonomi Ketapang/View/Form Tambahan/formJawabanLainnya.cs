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
using Pemetaan_Ekonomi_Ketapang.Controller;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Model;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formJawabanLainnya : MetroForm
    {
        Tbl_JawabanControl tblJawabanControl = new Tbl_JawabanControl();
        Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        Tbl_PertanyaanControl pertanyaanControl = new Tbl_PertanyaanControl();

        public formJawabanLainnya()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbBab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbJawaban_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void formJawabanLainnya_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = refJawabanControl.populateDataGridBasedOnIDPertanyaan(GlobalParam.idPertanyaan);
            dataGridView1.Columns["id_ref_jawaban"].Visible = false;
            dataGridView1.Columns["no_jawaban"].Visible = false;
            dataGridView1.Columns["id_pertanyaan"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbBab.Text = pertanyaanControl.getBabPertanyaanBasedOnIDpertanyaan(GlobalParam.idPertanyaan);
            lbPertanyaan.Text = pertanyaanControl.getPertanyaanBasedOnIdPertanyaan(GlobalParam.idPertanyaan);

            lbJawaban.Text = "Belum ada jawaban yang dipilh";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.edtDescJawaban1.Text))
            {

                if (this.edtDescJawaban2.Enabled == false)
                {
                    tblJawabanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.edtIdRefJawaban.Text), GlobalParam.id_umat, this.edtDescJawaban1.Text, ""));

                    this.edtDescJawaban2.Enabled = true;
                    lbJawaban.Text = "Belum ada jawaban yang dipilh";

                    MessageBox.Show("Jawaban berhasil dimasukan, silahkan lanjutkan pilih jawaban lainnya atau keluar dari form ini untuk melanjutkan pengisian data!");
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(this.edtDescJawaban2.Text))
                    {
                        tblJawabanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.edtIdRefJawaban.Text), GlobalParam.id_umat, this.edtDescJawaban1.Text, this.edtDescJawaban2.Text));

                        lbJawaban.Text = "Belum ada jawaban yang dipilh";
                        MessageBox.Show("Jawaban berhasil dimasukan, silahkan lanjutkan pilih jawaban lainnya atau keluar dari form ini untuk melanjutkan pengisian data!");
                    }
                    else
                    {
                        MessageBox.Show("Silahkan isi deksripsi jawaban dua terlebih dahulu!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan isi deskripsi jawaban satu terlebih dahulu!");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!tblJawabanControl.checkCustomJawabanAlreadyPickedBasedOnIdUmatAndIdRefJawaban(GlobalParam.id_umat.ToString(), dataGridView1.Rows[e.RowIndex].Cells["id_ref_jawaban"].Value.ToString()))
            {
                lbJawaban.Text = dataGridView1.Rows[e.RowIndex].Cells["jawaban"].Value.ToString();
                edtIdRefJawaban.Text = dataGridView1.Rows[e.RowIndex].Cells["id_ref_jawaban"].Value.ToString();

                if (pertanyaanControl.getIdJenispertanyaanBasedOnIdPertanyaan(Convert.ToInt32(GlobalParam.idPertanyaan)) == 3)
                {
                    this.edtDescJawaban2.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Jawaban " + dataGridView1.Rows[e.RowIndex].Cells["jawaban"].Value.ToString() + " sudah terinput, silahkan pilih jawaban lainnya !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formTambahJawabanLainnya fr = new formTambahJawabanLainnya();
            fr.ShowDialog();
        }

        private void formJawabanLainnya_Activated(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void formJawabanLainnya_Enter(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

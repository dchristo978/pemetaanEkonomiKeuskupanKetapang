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
    public partial class formListJawabanLainTerpilih : MetroForm
    {

        private Tbl_PertanyaanControl pertanyaanControl = new Tbl_PertanyaanControl();
        private Tbl_JawabanControl tblJawabanControl = new Tbl_JawabanControl();
        private String tempDesc1;
        private String tempDesc2;
        private int rowIndex;

        public formListJawabanLainTerpilih()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void formListJawabanLainTerpilih_Load(object sender, EventArgs e)
        {
            populateDataGrid();
        }


        private void populateComboboxPertanyaan()
        {
            List<tbl_pertanyaan> temp = pertanyaanControl.getAllPertanyaan();
            this.cmbPertanyaan.DisplayMember = "pertanyaan";
            this.cmbPertanyaan.ValueMember = "id_pertanyaan";
            this.cmbPertanyaan.DataSource = temp;
            this.cmbPertanyaan.SelectedValue = GlobalParam.idPertanyaan;
        }

        private void populateComboBoxRefJawaban()
        {

        }

        private void populateDataGrid()
        {
            String[] selected = new[] {"jawaban","deskripsi_jawaban_1","deskripsi_jawaban_2"};
            DataTable temp = new DataView(tblJawabanControl.getCustomJawabanPickedBasedOnIdUmatAndIdPertanyaan()).ToTable(false,selected);

            this.dataGridView1.DataSource = temp;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            tempDesc1 = dataGridView1.Rows[e.RowIndex].Cells["deskripsi_jawaban_1"].Value.ToString();
            tempDesc2 = dataGridView1.Rows[e.RowIndex].Cells["deskripsi_jawaban_2"].Value.ToString();
            this.edtDescJawaban1.Text = tempDesc1;
            this.edtDescJawaban2.Text = tempDesc2;

            if (String.IsNullOrWhiteSpace(tempDesc2) || String.Equals("Null", tempDesc2))
                this.edtDescJawaban2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formTambahJawabanLainnya fr = new formTambahJawabanLainnya();
            fr.ShowDialog();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

            DataTable temp = tblJawabanControl.getCustomJawabanPickedBasedOnIdUmatAndIdPertanyaan();
            tblJawabanControl.updateJawabanBasedOnIdUmatIdRefJawaban(GlobalParam.id_umat,Convert.ToInt32(temp.Rows[rowIndex]["id_ref_jawaban"].ToString()),this.edtDescJawaban1.Text,this.edtDescJawaban2.Text);
            btnUbah.Enabled = false;
            populateDataGrid();
        }

        private void edtDescJawaban1_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(edtDescJawaban1.Text.Trim(), tempDesc1))
            {
                btnUbah.Enabled = false;
            }
            else
                btnUbah.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            tempDesc1 = dataGridView1.Rows[e.RowIndex].Cells["deskripsi_jawaban_1"].Value.ToString();
            tempDesc2 = dataGridView1.Rows[e.RowIndex].Cells["deskripsi_jawaban_2"].Value.ToString();
            this.edtDescJawaban1.Text = tempDesc1;
            this.edtDescJawaban2.Text = tempDesc2;

            if (String.IsNullOrWhiteSpace(tempDesc2) || String.Equals("Null", tempDesc2))
                this.edtDescJawaban2.Enabled = false;
        }
    }
}

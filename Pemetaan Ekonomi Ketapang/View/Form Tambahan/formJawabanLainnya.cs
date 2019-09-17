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

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formJawabanLainnya : MetroForm
    {
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
            lbBab.Text = pertanyaanControl.getBabPertanyaanBasedOnIDpertanyaan(GlobalParam.idPertanyaan);
            lbPertanyaan.Text = pertanyaanControl.getPertanyaanBasedOnIdPertanyaan(GlobalParam.idPertanyaan);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbJawaban.Text = dataGridView1.Rows[e.ColumnIndex].Cells["jawaban"].Value.ToString();
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
    }
}

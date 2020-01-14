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
using Pemetaan_Ekonomi_Ketapang.Controller;
using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class formKKTersample : MetroForm
    {
        private UmatControl umatControl = new UmatControl();
        private Tbl_JawabanControl jawabanControl = new Tbl_JawabanControl();

        public formKKTersample()
        {
            InitializeComponent();
        }

        private void formKKTersample_Load(object sender, EventArgs e)
        {
            setDataGridView();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        public void setDataGridView()
        {
            this.dataGridView1.DataSource = umatControl.getMstUmat();
            this.dataGridView1.Columns[0].Visible = false;

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {

                this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

                //this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            this.dataGridView1.Columns["Nama Kepala Keluarga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["Nomor Identitas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["Pekerjaan KK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["Paroki"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["Stasi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.tbNama.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nama Kepala Keluarga"].Value.ToString();
                this.tbParoki.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Paroki"].Value.ToString();
                this.tbPekerjaan.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Pekerjaan KK"].Value.ToString();
                this.tbNoIdentitas.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nomor Identitas"].Value.ToString();

                GlobalParam.id_umat = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.tbNama.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nama Kepala Keluarga"].Value.ToString();
                this.tbParoki.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Paroki"].Value.ToString();
                this.tbPekerjaan.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Pekerjaan KK"].Value.ToString();
                this.tbNoIdentitas.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nomor Identitas"].Value.ToString();

                GlobalParam.id_umat = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.tbNama.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nama Kepala Keluarga"].Value.ToString();
                this.tbParoki.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Paroki"].Value.ToString();
                this.tbPekerjaan.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Pekerjaan KK"].Value.ToString();
                this.tbNoIdentitas.Text = this.dataGridView1.Rows[e.RowIndex].Cells["Nomor Identitas"].Value.ToString();

                GlobalParam.id_umat = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(String.Equals(this.tbNama.Text,"-"))
            {
                MessageBox.Show("Tidak ada KK yang dipilih untuk di hapus!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus KK?","Peringatan",MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Hasil dari proses penghapusan : \n" + jawabanControl.deleteJawabanBasedOnIdUmat(GlobalParam.id_umat) + "\n"  + umatControl.deleteUmatBasedOnIDUmat(GlobalParam.id_umat));
                    clearTB();
                }

            }
        }

        private void clearTB()
        {
            GlobalParam.id_umat = 0;
            this.tbNama.Text =  "-";
            this.tbNoIdentitas.Text =  "-";
            this.tbParoki.Text =  "-";
            this.tbNoIdentitas.Text =  "-";
            this.tbPekerjaan.Text =  "-";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            GlobalParam.formParent = "formKKTersample";
            
        }
    }
}

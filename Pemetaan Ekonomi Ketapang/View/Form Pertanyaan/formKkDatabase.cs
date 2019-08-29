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

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{
    public partial class formKkDatabase : MetroForm
    {
        public formKkDatabase()
        {
            InitializeComponent();
        }

        internal KepalaKeluargaControl KKC = new KepalaKeluargaControl();

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = KKC.getAll();
            DG.Columns.Remove("id_mst_umat");
        }

        public void cariNoKK_KepalaKeluarga(DataGridView DG)
        {
            DG.DataSource = KKC.cariNoKK_KepalaKeluarga(edt_cari_noKK.Text, edt_cari_kepalaKeluarga.Text);
        }

        private void dataGridKepalaKeluarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setTempEdt();
        }

        private void dataGridKepalaKeluarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setTempEdt();
        }

        private void dataGridKepalaKeluarga_KeyUp(object sender, KeyEventArgs e)
        {
            setTempEdt();
        }
        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }
        private void setTempEdt()
        {
            edt_col.Text = getKolom(dataGridKepalaKeluarga, 0);
            edt_row.Text = getRow(dataGridKepalaKeluarga);
        }

        private void edt_cari_noKK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                cariNoKK_KepalaKeluarga(this.dataGridKepalaKeluarga);
        }

        private void edt_cari_kepalaKeluarga_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)

                cariNoKK_KepalaKeluarga(this.dataGridKepalaKeluarga);
        }

        private void dataGridKepalaKeluarga_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.no_k5 = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["no_kk"].ToString();
            Global.nama = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["nama"].ToString();
            Global.jenis_kelamin = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["jenis_kelamin"].ToString();

            Global.id_ref_pekerjaan = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_ref_pekerjaan"]);
            Global.id_paroki = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_paroki"]);
            Global.id_stasi = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_stasi"]);

            formIdentitas fr = new formIdentitas();
            fr.ShowDialog();
            this.Hide();
        }

        private void formKkDatabase_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridKepalaKeluarga);
        }

        private void dataGridKepalaKeluarga_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Global.no_k5 = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["no_kk"].ToString();
            Global.nama = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["nama_kepala"].ToString();
            Global.jenis_kelamin = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["jenis_kelamin"].ToString();

            Global.id_ref_pekerjaan = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_ref_pekerjaan"]);
            Global.id_paroki = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_paroki"]);
            Global.id_stasi = Convert.ToInt32(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["id_stasi"]);

            formIdentitas fr = new formIdentitas();
            fr.ShowDialog();
            this.Hide();
        }
    }
}

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
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;
using Pemetaan_Ekonomi_Ketapang.Model;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan
{

    public partial class formKkDatabase : MetroForm
    {
        DatabasesConnector dbConnector = new DatabasesConnector();
        UmatControl umatControl = new UmatControl();
        StasiControl stasiControl = new StasiControl();

        public formKkDatabase()
        {
            InitializeComponent();
        }

        internal KepalaKeluargaControl KKC = new KepalaKeluargaControl();

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = umatControl.getMstUmatBasedOnParoki();
            DG.Columns[0].HeaderText = "No K5";
            for (int i = 0; i < DG.Columns.Count; i++)
                DG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void cariNoKK_KepalaKeluarga(DataGridView DG)
        {
            DG.DataSource = umatControl.searchUmatBasedOnNamaK5Stasi(this.edt_cari_kepalaKeluarga.Text, this.edt_cari_noKK.Text, this.cmbStasi.SelectedValue.ToString());
            DG.Columns[0].HeaderText = "No K5";
            for (int i = 0; i < DG.Columns.Count; i++)
                DG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            goToFormIdentitas(e);
        }

        private void formKkDatabase_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridKepalaKeluarga);
            List<tbl_stasi> temp = new List<tbl_stasi>();
            temp = stasiControl.getStasiBasedOnIdParokiNew(Convert.ToInt32(dbConnector.getIDParoki(GlobalParam.nama_database)), GlobalParam.nama_database);

            temp.Add(new tbl_stasi("-1", "", "", "TIDAK MEMILIH STASI", 0, "1"));
            this.cmbStasi.DataSource = temp;
            this.cmbStasi.DisplayMember = "nama_stasi";
            this.cmbStasi.ValueMember = "id_stasi";
            this.cmbStasi.SelectedValue = "-1";

        }

        private void dataGridKepalaKeluarga_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            goToFormIdentitas(e);
        }

        public void goToFormIdentitas(DataGridViewCellEventArgs e)
        {
            if (!String.Equals(GlobalParam.formParent, "formKepalaKeluarga"))
            {
                GlobalParam.no_k5 = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["no_kk"].Value.ToString();
                GlobalParam.nama = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["nama"].Value.ToString();

                GlobalParam.jenis_kelamin = dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["jenis_kelamin"].Value.ToString();
                GlobalParam.id_ref_pekerjaan = umatControl.getIdRefPekerjaanBasedOnPekerjaan(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["pekerjaan"].Value.ToString());
                GlobalParam.id_paroki = Convert.ToInt32(dbConnector.getIDParoki(GlobalParam.nama_database));
                GlobalParam.kode_stasi = umatControl.getKodeStasiBasedOnNamaStasi(dataGridKepalaKeluarga.Rows[e.RowIndex].Cells["nama_stasi"].Value.ToString());

                if (!umatControl.getSamePerson(new tbl_umat("","","",GlobalParam.nama,0,"","",0,GlobalParam.id_paroki,GlobalParam.kode_stasi)))
                {
                    formIdentitas fr = new formIdentitas();
                    fr.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sudah terdapat sample dengan nama orang, paroki dan stasi yang sama pada basis data!");
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.cariNoKK_KepalaKeluarga(this.dataGridKepalaKeluarga);
        }

        private void dataGridKepalaKeluarga_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

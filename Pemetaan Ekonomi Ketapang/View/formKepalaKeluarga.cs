namespace Pemetaan_Ekonomi_Ketapang.View
{
    using MetroFramework.Forms;
    using Pemetaan_Ekonomi_Ketapang.Controller;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="formKepalaKeluarga" />
    /// </summary>
    public partial class formKepalaKeluarga : MetroForm
    {
        public formKepalaKeluarga()
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
        
        private void formKepalaKeluarga_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridKepalaKeluarga);
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

        }
    }
}

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
using Pemetaan_Ekonomi_Ketapang.Controller.Global;
namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class formDatabase : MetroForm
    {
        DatabasesConnector databasesConnector = new DatabasesConnector();

        public formDatabase()
        {
            InitializeComponent();
        }

        private void formDatabase_Load(object sender, EventArgs e)
        {
            setDataGridView();
            clearTB();
        }

        private void setDataGridView()
        {
            this.dataGridView1.DataSource = databasesConnector.getDatabaseDataTable();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.tbIdParoki.Text) && !String.IsNullOrWhiteSpace(this.tbNamaParoki.Text) && !String.IsNullOrWhiteSpace(this.tbNamaDatabase.Text))
            {
                if (databasesConnector.tambahDatabase(new DatabasesConnector(this.tbIdParoki.Text, this.tbNamaParoki.Text, this.tbNamaDatabase.Text)))
                {
                    MessageBox.Show("Database paroki " + this.tbNamaParoki.Text + " berhasil ditambahkan ke dalam sistem");
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan saat menambahkan database paroki baru!");
                }
                clearTB();
                setDataGridView();
            }
            else
            {
                MessageBox.Show("Silahkan isi semua kolom yang tersedia!");
            }
            
        }

        private void clearTB()
        {
            this.tbIdParoki.Clear();
            this.tbNamaDatabase.Clear();
            this.tbNamaParoki.Clear();
            this.tempdatabase.Text = "";
            this.tempId.Text = "";
            this.tempnama.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tempId.Text))
            {
                MessageBox.Show("Belum ada baris data yang dipilih!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus database paroki " + this.tbNamaParoki.Text, "Peringatan!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (databasesConnector.deleteDatabase(new DatabasesConnector(this.tempId.Text, this.tempnama.Text, this.tempdatabase.Text)))
                    {
                        MessageBox.Show("Database paroki " + this.tempnama.Text + " berhasil dihapus!");
                        clearTB();
                        setDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Database paroki gagal dihapus, silahkan hubungi admin");
                    }

                    clearTB();
                    setDataGridView();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.tempId.Text))
            {
                MessageBox.Show("Belum ada baris data yang dipilih!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin merubah database paroki " + this.tbNamaParoki.Text, "Peringatan!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DatabasesConnector param = new DatabasesConnector(this.tbIdParoki.Text, this.tbNamaParoki.Text, this.tbNamaDatabase.Text);
                    DatabasesConnector input = new DatabasesConnector(this.tempId.Text, this.tempnama.Text, this.tempdatabase.Text);
                    if (databasesConnector.updateDatabase(input, param))
                    {
                        MessageBox.Show("Database paroki " + this.tempnama.Text + " berhasil diubah!");
                        clearTB();
                        setDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Database paroki gagal diubah, silahkan hubungi admin");
                    }
                    clearTB();
                    setDataGridView();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbIdParoki.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.tbNamaParoki.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.tbNamaDatabase.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.tempId.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.tempnama.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.tempdatabase.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}

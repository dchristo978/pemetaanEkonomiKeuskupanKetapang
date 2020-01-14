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
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.Controller;
using DGVPrinterHelper;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class formLaporanPemetaanEkonomi : MetroForm
    {
        private Tbl_BobotControl bobotControl = new Tbl_BobotControl();

        public formLaporanPemetaanEkonomi()
        {
            InitializeComponent();
        }

        private void populateComboboxJenisTampilan()
        {
            this.cmbJenisTampilan.Items.Clear();
            this.cmbJenisTampilan.Items.Add("Tabel");
            this.cmbJenisTampilan.Items.Add("Grafik");
            this.cmbJenisTampilan.SelectedIndex = 0;
        }

        private void populateComboboxCakupanWilayah()
        {
            this.cmbCakupanWilayah.Items.Clear();
            this.cmbCakupanWilayah.Items.Add("Keseluruhan Keuskupan");
            this.cmbCakupanWilayah.Items.Add("Region Paroki");
            this.cmbCakupanWilayah.SelectedIndex = 0;
        }

        private void populateComboboxTampilkanBerdasarkan()
        {
            this.cmbTampilkanBerdasarkan.ValueMember = "id_bab";
            this.cmbTampilkanBerdasarkan.DisplayMember = "bab";
            this.cmbTampilkanBerdasarkan.DataSource = bobotControl.populateComboboxBab();
        }

        private void populateComboboxRegionParoki()
        {
            this.cmbReginParoki.Items.Clear();
            this.cmbReginParoki.Items.Add("Pantai");
            this.cmbReginParoki.Items.Add("Selatan");
            this.cmbReginParoki.Items.Add("Tengah");
            this.cmbReginParoki.Items.Add("Timur");
            this.cmbReginParoki.Items.Add("Utara");
            this.cmbReginParoki.SelectedIndex = 0;
        }

        private void formLaporanPemetaanEkonomi_Load(object sender, EventArgs e)
        {
            populateComboboxCakupanWilayah();
            populateComboboxJenisTampilan();
            populateComboboxTampilkanBerdasarkan();
            populateComboboxRegionParoki();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada data yang ditampilkan untuk di cetak!");
            }
            else
            {

                Bitmap bmp = new Bitmap(Properties.Resources.LogoKKetapang);
                DGVPrinter.ImbeddedImage B1 = new DGVPrinter.ImbeddedImage();
                B1.ImageAlignment = DGVPrinter.Alignment.NotSet;
                B1.ImageLocation = DGVPrinter.Location.Header;
                B1.ImageX = 80;
                B1.ImageY = -55;
                B1.theImage = bmp;

                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Laporan Pemetaan Bobot Ekonomi\n";

                if (this.cmbCakupanWilayah.SelectedIndex == 0)
                {
                    printer.SubTitle = "Keuskupan Ketapang\nKeseluruhan Keuskupan\nPermasalahan : " + this.cmbTampilkanBerdasarkan.Text.ToString() + "\n\n";

                }
                else
                {
                    printer.SubTitle = "Keuskupan Ketapang\nRegion : " + this.cmbReginParoki.Text.ToString() + " \nPermasalahan : " + this.cmbTampilkanBerdasarkan.Text.ToString() + "\n\n";

                }

                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

                printer.PageNumbers = true;

                printer.PageText = "Halaman ";

                printer.PageNumberInHeader = false;

                printer.ShowTotalPageNumber = true;

                printer.PageSeparator = " dari ";

                printer.PorportionalColumns = true;

                printer.HeaderCellAlignment = StringAlignment.Near;

                printer.Footer = "Keuskupan Ketapang";

                printer.FooterSpacing = 15;

                printer.ImbeddedImageList.Add(B1);
                printer.PrintDataGridView(this.dataGridView1);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if (this.cmbJenisTampilan.SelectedIndex == 0)
            {
                this.dataGridView1.Visible = true;
                this.chart1.Visible = false;
            }
            else
            {
                this.dataGridView1.Visible = false;
                this.chart1.Visible = true;
            }


            if (this.cmbCakupanWilayah.SelectedIndex == 0)
            {
                GlobalParam.babPertanyaan = Convert.ToInt32(this.cmbTampilkanBerdasarkan.SelectedValue.ToString());
                DataTable tempView = bobotControl.hitungBobotSatuKeuskupan();

                this.dataGridView1.DataSource = tempView;

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (this.cmbCakupanWilayah.SelectedIndex == 1)
            {
                GlobalParam.babPertanyaan = Convert.ToInt32(this.cmbTampilkanBerdasarkan.SelectedValue.ToString());
                GlobalParam.reginParoki = this.cmbReginParoki.Text.ToString();

                DataTable tempView = bobotControl.hitungBobotPerRegion();

                this.dataGridView1.DataSource = tempView;

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void cmbJenisTampilan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTampilkanBerdasarkan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCakupanWilayah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCakupanWilayah.SelectedIndex == 1)
            {
                lbRegion.Visible = true;
                cmbReginParoki.Visible = true;
            }
            else
            {
                lbRegion.Visible = false;
                cmbReginParoki.Visible = false;
                this.cmbTampilkanBerdasarkan.Insert();
            }
        }
    }
}

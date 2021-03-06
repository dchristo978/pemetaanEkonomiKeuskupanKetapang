﻿using System;
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
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;
using System.Diagnostics;
using DGVPrinterHelper;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class formRekomendasiSampling : MetroForm
    {

        UmatControl umatControl = new UmatControl();
        private DatabasesConnector dbConnector = new DatabasesConnector();
        private List<DatabasesConnector> listDatabbase = new List<DatabasesConnector>();

        public formRekomendasiSampling()
        {
            InitializeComponent();
        }

        private void formRekomendasiSampling_Load(object sender, EventArgs e)
        {
            listDatabbase = dbConnector.getListDatabases();
            this.cmbParoki.DataSource = listDatabbase;
            this.cmbParoki.DisplayMember = "lokasi_paroki";
            this.cmbParoki.ValueMember = "nama_database";

            this.cmbError.Items.Clear();
            this.cmbError.Items.Add("5%");
            this.cmbError.Items.Add("7.5%");
            this.cmbError.Items.Add("10%");

            this.cmbError.SelectedIndex = 0;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        { 
            if(this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada data yang ditampilkan untuk di cetak!");
            }
            else{

                Bitmap bmp = new Bitmap(Properties.Resources.LogoKKetapang);
                DGVPrinter.ImbeddedImage B1 = new DGVPrinter.ImbeddedImage();
                B1.ImageAlignment = DGVPrinter.Alignment.NotSet;
                B1.ImageLocation = DGVPrinter.Location.Header;
                B1.ImageX = 80;
                B1.ImageY = -55;
                B1.theImage = bmp;
                
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Laporan Rekomendasi Sampling\n";
                printer.SubTitle = "Keuskupan Ketapang\nParoki : " + this.cmbParoki.Text+ "\n\n";
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

        private void cmbParoki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("REKOMENDASI SAMPLING : NAMA DATABASE YANG DIPILIH : " + this.cmbParoki.SelectedValue.ToString());
        }

        private void refreshForm()
        {
            if (this.cmbError.SelectedIndex == 0)
                GlobalParam.marginOfError = 0.05;
            else if (this.cmbError.SelectedIndex == 1)
                GlobalParam.marginOfError = 0.075;
            else if (this.cmbError.SelectedIndex == 2)
                GlobalParam.marginOfError = 0.1;

            GlobalParam.nama_database = this.cmbParoki.SelectedValue.ToString();
            this.lbTotalKK.Text = umatControl.getTotalKepalaKeluagaParoki().ToString();

            this.dataGridView1.DataSource = umatControl.datagridRekomendasiSampling();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (i != 0)
                {
                    this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void cmbParoki_SelectedValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("REKOMENDASI SAMPLING : NAMA DATABASE YANG DIPILIH : " + this.cmbParoki.SelectedValue.ToString());
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}

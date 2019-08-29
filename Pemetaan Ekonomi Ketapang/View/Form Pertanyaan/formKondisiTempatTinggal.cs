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
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.Controller.Umat;
using Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi;
using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.View
{
    public partial class formKondisiTempatTinggal : MetroForm
    {
        private UmatControl umatControl = new UmatControl();
        private StasiControl stasiControl = new StasiControl();
        private ParokiControl parokiControl = new ParokiControl();
        private Ref_JawabanControl refJawabanControl = new Ref_JawabanControl();
        private Tbl_JawabanControl tblJawaanControl = new Tbl_JawabanControl();

        public formKondisiTempatTinggal()
        {
            InitializeComponent();

        }

        private void initializeHeader()
        {
            tbl_umat umat = umatControl.getDataUmatSatuan(Convert.ToInt32(formIdentitas.idUmat));

            Debug.Write("ISI NOMOR IDENTIAS : " + " KTP " + umat.no_ktp + " KK " + umat.no_kk + "K5 " + umat.no_k5);

            lb_namaKK.Text = umat.nama;
            lb_nok5.Text = umatControl.getNomorIdentitas(umat);
            lb_umur.Text = umat.umur.ToString() + " Tahun";
            lb_stasi.Text = stasiControl.getNamaStasi(umat.id_stasi);
            lb_paroki.Text = parokiControl.getNamaParokiByID(umat.id_paroki);
            lb_jenisKelamin.Text = umat.jenis_kelamin;            
        }

        private void metroLabel7_Click(object sender, EventArgs e){}

        private void formKondisiTempatTinggal_Load(object sender, EventArgs e)
        {
            initializeHeader();
            populateComboBox(2,this.cmbStatusKepemilikan);
            populateComboBox(3,this.cmbJenisLantaiBangunan);
            populateComboBox(4,this.cmbJenisDinding);
            populateComboBox(5,this.cmbKepemilikanMCK);
            populateComboBox(6,this.cmbLuasBangunan);
        }

        private void populateComboBox(int id, ComboBox cmb)
        {
            List<ref_jawaban> temp = refJawabanControl.populateComboBox();
            cmb.DataSource = temp.Where(ref_jawaban => ref_jawaban.id_pertanyaan == id).ToList();
            cmb.DisplayMember = "jawaban";
            cmb.ValueMember = "id_ref_jawaban";
        }

        private void cmbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbStatusKepemilikan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbJenisDinding.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbJenisLantaiBangunan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbKepemilikanMCK.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                tblJawaanControl.insertJawaban(new tbl_jawaban(0, Convert.ToInt32(this.cmbLuasBangunan.SelectedValue), Convert.ToInt32(formIdentitas.idUmat), "Null", "Null"));
                MessageBox.Show("Data kondisi tempat tinggal berhasil di masukan, silahkan lanjutkan ke form berikut!");
                formFasilitasTempatTinggal fr = new formFasilitasTempatTinggal();
                this.Hide();
                fr.ShowDialog();
                this.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show("Terjadi kesalahan, silahkan hubungi admin!" + E.Message);
            }
        }
    }
}

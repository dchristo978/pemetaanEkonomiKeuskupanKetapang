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
using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class fornPilihanPanen : MetroForm
    {


        public fornPilihanPanen()
        {
            InitializeComponent();
        }

        private void cbPangan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (cbTernak.Checked)
            {
                GlobalParam.isPanenTernak = true;
            }

            if (cbKeras.Checked)
            {
                GlobalParam.isPanenKeras = true;
            }

            if (cbPangan.Checked)
            {
                GlobalParam.isPanenPangan = true;
            }

            if (GlobalParam.isPanenPangan)
            {
                formTanamanPangan temp = new formTanamanPangan();
                temp.Show();
                this.Close();
            }
            else if (GlobalParam.isPanenKeras)
            {
                formTanamanKeras temp = new formTanamanKeras();
                temp.Show();
                this.Close();
            }
            else if (GlobalParam.isPanenTernak == true)
            {
                formPanenTernak temp = new formPanenTernak();
                temp.Show();
                this.Close();
            }
            else if (!GlobalParam.isPanenKeras && !GlobalParam.isPanenPangan && !GlobalParam.isPanenTernak)
            {
                formPendapatanAnggotaKeluargaPerBulan temp = new formPendapatanAnggotaKeluargaPerBulan();
                temp.Show();
                this.Close();
            }

        }
    }
}

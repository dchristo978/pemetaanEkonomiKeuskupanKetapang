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
            if(!cbPangan.Checked && !cbKeras.Checked && !cbTernak.Checked)
            {
                MessageBox.Show("Melanjutkan ke pengisian form Pendapatan Anggota Keluarga perbulan");
            }
            else
            {
                if(cbTernak.Checked)
                {
                    GlobalParam.isPanenTernak = true;
                }

                if(cbKeras.Checked)
                {
                    GlobalParam.isPanenKeras = true;
                }

                if(cbPangan.Checked)
                {
                    GlobalParam.isPanenPangan = true;
                }
            }
        }
    }
}

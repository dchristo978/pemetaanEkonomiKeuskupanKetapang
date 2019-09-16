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
using Pemetaan_Ekonomi_Ketapang.Controller;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.View.Form_Pertanyaan;

namespace Pemetaan_Ekonomi_Ketapang.View.Form_Tambahan
{
    public partial class formPilihParoki : MetroForm
    {
        private DatabasesConnector dbConnector = new DatabasesConnector();
        private List<DatabasesConnector> listDatabbase = new List<DatabasesConnector>();
        
        public formPilihParoki()
        {
            InitializeComponent();
        }

        private void formPilihParoki_Load(object sender, EventArgs e)
        {
            listDatabbase = dbConnector.getListDatabases();
            this.comboBox1.DataSource = listDatabbase;
            this.comboBox1.DisplayMember = "lokasi_paroki";
            this.comboBox1.ValueMember = "nama_database";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GlobalParam.nama_database = this.comboBox1.SelectedValue.ToString();

            if(String.Equals(GlobalParam.formParent,"formIdentitas"))
            {
                formIdentitas form = new formIdentitas();
                form.Show();
                this.Close();
            }
            else if (String.Equals(GlobalParam.formParent,"formKkDatabase"))
            {
                formKkDatabase form = new formKkDatabase();
                form.Show();
                this.Close();
            }
        }
    }
}

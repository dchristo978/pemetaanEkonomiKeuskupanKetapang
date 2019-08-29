using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;
using Pemetaan_Ekonomi_Ketapang.Model;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Umat
{
    class ParokiControl
    {
        private tbl_parokiTableAdapter parokiAdapter = new tbl_parokiTableAdapter();

        public DataSet getPopulateCombobox()
        {
            db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
            ds.EnforceConstraints = false;
            parokiAdapter.Fill(ds.tbl_paroki);
            return ds;
        }

        public String getNamaParokiByID(int idParoki)
        {
            return parokiAdapter.getNamaParokiByID(idParoki);
        }
    }
}

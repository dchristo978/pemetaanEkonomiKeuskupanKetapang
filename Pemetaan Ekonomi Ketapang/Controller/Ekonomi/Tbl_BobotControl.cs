using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;
using Pemetaan_Ekonomi_Ketapang.Model;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    class Tbl_BobotControl
    {
        private tbl_bobotTableAdapter bobotAdapter = new tbl_bobotTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        
        public DataTable getBobotDataTable(int idPertanyaan)
        {
            return bobotAdapter.GetBobotById(idPertanyaan);
        }

        public int getLastIndexbobot()
        {
            int balikan = 0;
            ds.Clear();
            ds.EnforceConstraints = false;
            bobotAdapter.Fill(ds.tbl_bobot);
            if (ds.tbl_bobot.Rows.Count == 0)
            {
                return balikan;
            }
            else
            {
                balikan = Convert.ToInt32(ds.tbl_bobot.Rows[ds.tbl_bobot.Rows.Count - 1][0].ToString());
                return balikan + 1;
            }
        }

        public int insertBobotBaru (tbl_bobot temp)
        {
            return bobotAdapter.insertBobotBaru(this.getLastIndexbobot(), (decimal) temp.bobot, temp.header_bobot, temp.deskripsi_bobot, (decimal)temp.batas_bawah_bobot, (decimal)temp.batas_atas_bobot, temp.is_custom, temp.id_ref_jawaban);
        }

    }
}

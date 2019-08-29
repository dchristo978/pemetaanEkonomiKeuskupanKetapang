using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Umat
{
    class StasiControl
    {
        private tbl_stasiTableAdapter stasiAdapter = new tbl_stasiTableAdapter();

        public List<tbl_stasi> getAllStasiList()
        {
            DataTable dt = new DataTable();
            dt.Clear();

            dt = stasiAdapter.GetData();

            List<tbl_stasi> balikan = new List<tbl_stasi>();
            for(int i = 0; i < dt.Rows.Count; i ++)
            {
                tbl_stasi temp = new tbl_stasi();
                temp.id_stasi = dt.Rows[i]["id_stasi"].ToString();
                temp.kode_stasi = dt.Rows[i]["kode_stasi"].ToString();
                temp.id_paroki = dt.Rows[i]["id_paroki"].ToString();
                temp.nama_stasi = dt.Rows[i]["nama_stasi"].ToString();
                temp.jumlah_umat_stasi = Convert.ToInt32( dt.Rows[i]["jumlah_umat_stasi"]);
                temp.id_ref_kondisi_ekonomi = dt.Rows[i]["id_ref_kondisi_ekonomi"].ToString();
                balikan.Add(temp);
            }

            return balikan;
        }

        public String getNamaStasi(int umat)
        {
            return stasiAdapter.getNamaStasiByID(umat);
        }
    }
}

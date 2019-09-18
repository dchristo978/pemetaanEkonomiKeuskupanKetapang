using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    class Tbl_JawabanControl
    {
        private tbl_jawabanTableAdapter tblJawabanAdapter = new tbl_jawabanTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();

        public int insertJawaban(tbl_jawaban temp)
        {
            return tblJawabanAdapter.insertJawaban(this.getLastIndexJawaban(), temp.id_ref_jawaban,temp.id_umat,temp.deskripsi_jawaban_1, temp.deskripsi_jawaban_2);
        }


        public int getLastIndexJawaban()
        {
            int balikan = 0;
            ds.Clear();
            ds.EnforceConstraints = false;
            tblJawabanAdapter.Fill(ds.tbl_jawaban);
            if (ds.tbl_jawaban.Rows.Count == 0)
            {
                return balikan;
            }
            else
            {
                balikan = Convert.ToInt32(ds.tbl_jawaban.Rows[ds.tbl_jawaban.Rows.Count - 1][0].ToString());
                return balikan + 1;
            }
        }

        public DataTable getCustomJawabanPickedBasedIDUmat()
        {
            DataTable temp = new DataTable();

            temp = tblJawabanAdapter.getCustomJawabanPickedBasedOnIdUmat(GlobalParam.id_umat);

            return temp;
        }
    }
}

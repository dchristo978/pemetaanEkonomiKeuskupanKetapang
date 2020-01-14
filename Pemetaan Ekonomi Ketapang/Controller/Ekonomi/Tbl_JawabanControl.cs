using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.Model;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    class Tbl_JawabanControl
    {
        private tbl_jawabanTableAdapter tblJawabanAdapter = new tbl_jawabanTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        private ref_jawabanTableAdapter refjawabanAdapter = new ref_jawabanTableAdapter();

        public int insertJawaban(tbl_jawaban temp)
        {
            return tblJawabanAdapter.insertJawaban(this.getLastIndexJawaban(), temp.id_ref_jawaban, temp.id_umat, temp.deskripsi_jawaban_1, temp.deskripsi_jawaban_2);
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

        public DataTable getCustomJawabanPickedBasedOnIdUmatAndIdPertanyaan()
        {
            DataTable temp = new DataTable();

            temp = tblJawabanAdapter.getPickedCustomJawabanBasedOnIdPertanyaanAndIdUmat(GlobalParam.idPertanyaan,GlobalParam.id_umat);

            return temp;
        }

        public bool checkCustomJawabanAlreadyPickedBasedOnIdUmatAndIdRefJawaban(String idUmat, String idRefJawaban)
        {
            DataTable temp = tblJawabanAdapter.getCustomJawabanPickedBasedOnIdUmat(Convert.ToInt32(idUmat));

            DataRow[] result = temp.Select("id_ref_jawaban = " + idRefJawaban);

            foreach (DataRow row in result)
            {
                return true;
            }

            return false;
        }

        public int updateJawabanBasedOnIdUmatIdRefJawaban(int idUmat, int idRefJawaban, String descJawaban1, String descJawaban2)
        {
            int balikan = 0;

            if (String.IsNullOrWhiteSpace(descJawaban2))
                descJawaban2 = "Null";

            balikan = tblJawabanAdapter.updateDescJawaban12BasedOnIdUmatAndIdRefJawaban(descJawaban2, descJawaban1, idRefJawaban, idUmat);

            return balikan;
        }

        public String getListStringCustomJawabanPickedBasedOnIDUmat()
        {
            String balikan = "";

            DataTable temp = getCustomJawabanPickedBasedOnIdUmatAndIdPertanyaan();

            if (temp != null)
            {
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    Debug.WriteLine("JAWABAN DI ROW : " + i + " ADALAH : " + temp.Rows[i]["jawaban"]);
                    if (!(i < temp.Rows.Count - 1))
                    {

                        balikan += temp.Rows[i]["jawaban"] + ", ";
                    }
                    else
                    {
                        balikan += temp.Rows[i]["jawaban"];
                    }
                }
            }

            return balikan;
        }

        public String deleteJawabanBasedOnIdUmat(int idUmat)
        {
            int temp = tblJawabanAdapter.DeleteAllJawabanBasedOnIdUmat(idUmat);
            if (temp > 0)
            {
                return temp + " jawaban sampling berhasil di hapus";
            }
            else
            {
                return " tidak ada jawaban sampling terhapus";
            }
        }
    }
}

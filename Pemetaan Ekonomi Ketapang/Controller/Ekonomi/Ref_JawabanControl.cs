using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Data;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    class Ref_JawabanControl
    {
        private ref_jawabanTableAdapter refJawabanAdapter = new ref_jawabanTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();

        public List<ref_jawaban> populateComboBox()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = refJawabanAdapter.GetData();

            List<ref_jawaban> balikan = new List<ref_jawaban>();
            for(int i = 0; i < dt.Rows.Count; i ++)
            {
                ref_jawaban temp = new ref_jawaban();
                temp.id_pertanyaan = Convert.ToInt32(dt.Rows[i]["id_pertanyaan"]);
                temp.no_jawaban = dt.Rows[i]["no_jawaban"].ToString();
                temp.jawaban = dt.Rows[i]["jawaban"].ToString();
                temp.id_ref_jawaban = Convert.ToInt32(dt.Rows[i]["id_ref_jawaban"]);

                balikan.Add(temp);
            }

            return balikan;
        }

        public int insertNewRefJawaban(ref_jawaban temp)
        {
            return refJawabanAdapter.insertNewRefJawaban(this.getLastIndexRefJawaban(), "z", temp.jawaban, temp.id_pertanyaan);
        }

        public int getLastIndexRefJawaban()
        {
            int balikan = 0;
            ds.Clear();
            ds.EnforceConstraints = false;
            refJawabanAdapter.Fill(ds.ref_jawaban);
            if (ds.ref_jawaban.Rows.Count == 0)
            {
                return balikan;
            }
            else
            {
                balikan = Convert.ToInt32(ds.ref_jawaban.Rows[ds.ref_jawaban.Rows.Count - 1][0].ToString());
                return balikan + 1;
            }
        }

        public DataTable populateDataGridBasedOnIDPertanyaan(int idPertanyaan)
        {
            DataTable temp = new DataTable();
            temp = refJawabanAdapter.GetData();
            temp = temp.Select("id_pertanyaan = " + idPertanyaan, "id_ref_jawaban DESC").CopyToDataTable();

            return temp;
        }
    }
}


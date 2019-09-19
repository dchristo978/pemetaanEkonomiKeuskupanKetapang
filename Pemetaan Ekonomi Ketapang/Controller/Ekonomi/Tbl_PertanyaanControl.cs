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
    class Tbl_PertanyaanControl
    {
        private tbl_pertanyaanTableAdapter pertanyaanAdapter = new tbl_pertanyaanTableAdapter();

        public List<tbl_pertanyaan> getAllPertanyaan()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = pertanyaanAdapter.GetData();

            List<tbl_pertanyaan> balikan = new List<tbl_pertanyaan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tbl_pertanyaan temp = new tbl_pertanyaan();
                temp.id_pertanyaan = Convert.ToInt32(dt.Rows[i]["id_pertanyaan"]);
                temp.pertanyaan = dt.Rows[i]["pertanyaan"].ToString();
                temp.id_pertanyaan_bab = Convert.ToInt32(dt.Rows[i]["id_pertanyaan_bab"].ToString());
                temp.id_pertanyaan_jenis = Convert.ToInt32(dt.Rows[i]["id_pertanyaan_jenis"]);

                balikan.Add(temp);
            }

            return balikan;
        }

        public bool isPertanyaanDenganBobotJawabanBatasAtasBawahBasedOnIdPertanyaan(int idPertanyaan)
        {
            return pertanyaanAdapter.getIDJenisPertanyaan(idPertanyaan) == 3;
        }

        public String getBabPertanyaanBasedOnIDpertanyaan(int idPertanyaan)
        {
            return pertanyaanAdapter.getBabPertanyaanBasedOnIdPertanyaan(idPertanyaan);
        }

        public String getPertanyaanBasedOnIdPertanyaan(int idPertanyaan)
        {
            return pertanyaanAdapter.getPertanyaanBasedOnIdPertanyaan(idPertanyaan);
        }

        public int getIdJenispertanyaanBasedOnIdPertanyaan(int idPertanyaan)
        {
            return Convert.ToInt32(pertanyaanAdapter.getIdJenisPertanyaanBasedOnIdPertanyaan(idPertanyaan));
        }
    }
}

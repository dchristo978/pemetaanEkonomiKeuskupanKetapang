using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    class Tbl_BobotControl
    {
        private tbl_bobotTableAdapter bobotAdapter = new tbl_bobotTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        private DatabasesConnector dbConnector = new DatabasesConnector();

        public DataTable getBobotDataTable(int idPertanyaan)
        {
            DataTable temp = new DataTable();
            //Debug.Write("ID PERTANYAAN UNTUK GET BOBOTDATATABLE : " + idPertanyaan);
            //temp = bobotAdapter.GetBobotById(idPertanyaan);

            //if(temp == null)
            //{
            //    return new DataTable();
            //}

            //return temp;

            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            String query = "SELECT " +
                "ref_jawaban.jawaban as Jawaban, " +
                "tbl_bobot.bobot as Nilai_Bobot, " +
                "tbl_bobot.header_bobot as Header_Bobot, " +
                "tbl_bobot.deskripsi_bobot as Deskripsi_Bobot, " +
                "tbl_bobot.batas_bawah_bobot as Batas_Bawah_Bobot, " +
                "tbl_bobot.batas_atas_bobot as Batas_Atas_Bobot " +
                "FROM tbl_pertanyaan INNER JOIN ref_jawaban ON tbl_pertanyaan.id_pertanyaan = ref_jawaban.id_pertanyaan " +
                "INNER JOIN tbl_bobot ON ref_jawaban.id_ref_jawaban = tbl_bobot.id_ref_jawaban " +
                "WHERE(tbl_pertanyaan.id_pertanyaan = @p)";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@p",idPertanyaan);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            return balikan;

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

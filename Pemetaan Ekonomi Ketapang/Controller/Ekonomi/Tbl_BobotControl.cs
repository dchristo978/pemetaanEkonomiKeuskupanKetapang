namespace Pemetaan_Ekonomi_Ketapang.Controller.Ekonomi
{
    using MySql.Data.MySqlClient;
    using Pemetaan_Ekonomi_Ketapang.Controller.Global;
    using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
    using Pemetaan_Ekonomi_Ketapang.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// Defines the <see cref="Tbl_BobotControl" />
    /// </summary>
    internal class Tbl_BobotControl
    {
        /// <summary>
        /// Defines the bobotAdapter
        /// </summary>
        private tbl_bobotTableAdapter bobotAdapter = new tbl_bobotTableAdapter();

        /// <summary>
        /// Defines the ds
        /// </summary>
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();

        /// <summary>
        /// Defines the babAdapter
        /// </summary>
        private ref_pertanyaan_babTableAdapter babAdapter = new ref_pertanyaan_babTableAdapter();

        /// <summary>
        /// Defines the dbConnector
        /// </summary>
        private DatabasesConnector dbConnector = new DatabasesConnector();

        /// <summary>
        /// The getBobotDataTable
        /// </summary>
        /// <param name="idPertanyaan">The idPertanyaan<see cref="int"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
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
            command.Parameters.AddWithValue("@p", idPertanyaan);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            return balikan;
        }

        /// <summary>
        /// The getLastIndexbobot
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
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

        /// <summary>
        /// The insertBobotBaru
        /// </summary>
        /// <param name="temp">The temp<see cref="tbl_bobot"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int insertBobotBaru(tbl_bobot temp)
        {
            return bobotAdapter.insertBobotBaru(this.getLastIndexbobot(), (decimal)temp.bobot, temp.header_bobot, temp.deskripsi_bobot, (decimal)temp.batas_bawah_bobot, (decimal)temp.batas_atas_bobot, temp.is_custom, temp.id_ref_jawaban);
        }

        /// <summary>
        /// The populateComboboxBab
        /// </summary>
        /// <returns>The <see cref="List{refBab}"/></returns>
        public List<refBab> populateComboboxBab()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = babAdapter.GetData();

            List<refBab> balikan = new List<refBab>();
            for (int i = 1; i < dt.Rows.Count - 1; i++)
            {
                refBab temp = new refBab();
                temp.id_bab = dt.Rows[i]["id_pertanyaan_bab"].ToString();
                temp.bab = dt.Rows[i]["bab_pertanyaan"].ToString(); ;

                balikan.Add(temp);
            }

            return balikan;
        }

        /// <summary>
        /// The hitungBobotSatuKeuskupan
        /// </summary>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable hitungBobotSatuKeuskupan()
        {
            DataTable balikan = new DataTable();
            String query =
                "select sum(bobot)/count(tbl_umat.id_umat), " +
                "tbl_paroki.region_paroki " +
                "from tbl_bobot " +
                "join ref_jawaban on tbl_bobot.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                "join tbl_jawaban on tbl_jawaban.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                "join tbl_umat on tbl_umat.id_umat = tbl_jawaban.id_umat " +
                "join tbl_paroki on tbl_umat.id_paroki = tbl_paroki.id_paroki " +
                "join tbl_pertanyaan on tbl_pertanyaan.id_pertanyaan = ref_jawaban.id_pertanyaan " +
                "join ref_pertanyaan_bab on ref_pertanyaan_bab.id_pertanyaan_bab = tbl_pertanyaan.id_pertanyaan_bab " +
                "where ref_pertanyaan_bab.id_pertanyaan_bab = @p " +
                "group by tbl_paroki.region_paroki";


            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@p", GlobalParam.babPertanyaan);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);

            balikan.Columns[1].ColumnName = "Region Paroki";
            balikan.Columns[0].ColumnName = "Rata-Rata Bobot";

            reader.Close();
            return balikan;
        }

        /// <summary>
        /// The hitungBobotPerRegion
        /// </summary>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable hitungBobotPerRegion()
        {
            DataTable balikan = new DataTable();
            String query =
                "select sum(bobot)/count(tbl_umat.id_umat), " +
                "tbl_paroki.nama_paroki " +
                "from tbl_bobot " +
                "join ref_jawaban on tbl_bobot.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                "join tbl_jawaban on tbl_jawaban.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                "join tbl_umat on tbl_umat.id_umat = tbl_jawaban.id_umat " +
                "join tbl_paroki on tbl_umat.id_paroki = tbl_paroki.id_paroki " +
                "join tbl_pertanyaan on tbl_pertanyaan.id_pertanyaan = ref_jawaban.id_pertanyaan " +
                "join ref_pertanyaan_bab on ref_pertanyaan_bab.id_pertanyaan_bab = tbl_pertanyaan.id_pertanyaan_bab " +
                "where ref_pertanyaan_bab.id_pertanyaan_bab = @p AND tbl_paroki.region_paroki = @p2 " +
                "group by tbl_paroki.nama_paroki";


            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@p", GlobalParam.babPertanyaan);
            command.Parameters.AddWithValue("@p2", GlobalParam.reginParoki);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);

            balikan.Columns[1].ColumnName = "Region Paroki";
            balikan.Columns[0].ColumnName = "Rata-Rata Bobot";

            reader.Close();
            return balikan;
        }

        /// <summary>
        /// The hitungPengeluaranKeluargaTerbesar
        /// </summary>
        /// <param name="flagKeuskupan">The flagKeuskupan<see cref="bool"/></param>
        /// <param name="flagParoki">The flagParoki<see cref="bool"/></param>
        /// <param name="flagStasi">The flagStasi<see cref="bool"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable hitungPengeluaranKeluargaTerbesar(bool flagKeuskupan, bool flagParoki, bool flagStasi)
        {
            DataTable balikan = new DataTable();
            String query = "";
            DataSet ds = new DataSet();
            MySqlDataReader reader;

            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            connection.Open();
            if (flagKeuskupan)
            {
                query = "select " +
                        "ref_jawaban.jawaban," +
                        "max(tbl_jawaban.deskripsi_jawaban_1) as nilai_tertinggi, " +
                        "sum(tbl_jawaban.deskripsi_jawaban_1) / count(tbl_umat.id_umat) as rata2_pengeluaran" +
                        "from tbl_bobot " +
                        "join ref_jawaban on tbl_bobot.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                        "join tbl_jawaban on tbl_jawaban.id_ref_jawaban = ref_jawaban.id_ref_jawaban " +
                        "join tbl_umat on tbl_umat.id_umat = tbl_jawaban.id_umat " +
                        "join tbl_pertanyaan on tbl_pertanyaan.id_pertanyaan = ref_jawaban.id_pertanyaan " +
                        "where tbl_pertanyaan.id_pertanyaan > 22 " +
                        "group by ref_jawaban.jawaban";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@p", GlobalParam.babPertanyaan);
                command.Parameters.AddWithValue("@p2", GlobalParam.reginParoki);
                reader = command.ExecuteReader();

                ds.Tables.Add(balikan);
                ds.EnforceConstraints = false;
                balikan.Load(reader);
                reader.Close();
            }
            else if (flagParoki)
            {

            }
            else if (flagStasi)
            {

            }
            
            return balikan;
        }
    }
}

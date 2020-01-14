using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using Pemetaan_Ekonomi_Ketapang.Controller.Global;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Umat
{
    class UmatControl
    {
        private tbl_umatTableAdapter umatAdapter = new tbl_umatTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();
        private DatabasesConnector dbConnector = new DatabasesConnector();

        public String insertSamplingUmatBaru(tbl_umat temp)
        {
            String balikan;
            try
            {
                balikan = umatAdapter.insertUmat(getLastIndexIDUmatPlusOne(), temp.no_kk, temp.no_k5, temp.no_ktp, temp.nama, temp.umur, temp.jenis_kelamin, temp.no_telp, temp.id_ref_pekerjaan, temp.id_paroki, temp.id_stasi).ToString();
            }
            catch (Exception E)
            {
                balikan = E.Message.ToString() + "    " + temp.tostr();
            }

            return balikan;
        }

        public int getLastIndexIDUmatPlusOne()
        {
            int balikan = 0;
            ds.Clear();
            ds.EnforceConstraints = false;
            umatAdapter.Fill(ds.tbl_umat);
            Debug.Write("JUMLAH ISINYA : " + ds.tbl_umat.Rows[ds.tbl_umat.Rows.Count - 1][0].ToString());
            if (ds.tbl_umat.Rows.Count == 0)
            {
                return balikan;
            }
            else
            {
                balikan = Convert.ToInt32(ds.tbl_umat.Rows[ds.tbl_umat.Rows.Count - 1][0].ToString());
                return balikan + 1;
            }
        }

        public String getLastID()
        {
            ds.Clear();
            ds.EnforceConstraints = false;
            umatAdapter.Fill(ds.tbl_umat);
            return ds.tbl_umat.Rows[ds.tbl_umat.Rows.Count - 1][0].ToString();
        }

        public tbl_umat getDataUmatSatuan(int idUmat)
        {
            tbl_umat balikan = new tbl_umat();

            DataTable temp1 = umatAdapter.getUmatSatuanByIDUmat(idUmat);
            DataRow row = temp1.Rows[0];

            balikan.no_kk = row["no_kk"].ToString();
            balikan.no_ktp = row["no_ktp"].ToString();
            balikan.no_k5 = row["no_k5"].ToString();
            balikan.nama = row["nama"].ToString();
            balikan.jenis_kelamin = row["jenis_kelamin"].ToString();
            balikan.no_telp = row["no_telp"].ToString();
            balikan.id_ref_pekerjaan = Convert.ToInt32(row["id_ref_pekerjaan"]);
            balikan.id_paroki = Convert.ToInt32(row["id_paroki"].ToString());
            balikan.id_stasi = Convert.ToInt32(row["id_stasi"].ToString());
            balikan.umur = Convert.ToInt32(row["umur"].ToString());

            return balikan;
        }

        public String getNomorIdentitas(tbl_umat temp)
        {
            //if (temp.no_k5 == "Null" && temp.no_ktp == "Null")
            //    return temp.no_kk + " / KK";
            //else if (temp.no_ktp == "Null" && temp.no_kk == "Null")
            //    return temp.no_k5 + " / K5";
            //else if (temp.no_kk == "Null" && temp.no_k5 == "Null")
            //    return temp.no_ktp + " / KTP";
            //else
            //    return "Kosong"

            Debug.Write("ISI NOMOR IDENTIAS : " + " KTP " + temp.no_ktp + " KK " + temp.no_kk + "K5 " + temp.no_k5);

            if (string.Equals(temp.no_k5, "Null") && string.Equals(temp.no_ktp, "Null"))
                return temp.no_kk + " / KK";
            else if (string.Equals(temp.no_ktp, "Null") && string.Equals(temp.no_kk, "Null"))
                return temp.no_k5 + " / K5";
            else if (string.Equals(temp.no_kk, "Null") && string.Equals(temp.no_k5, "Null"))
                return temp.no_ktp + " / KTP";
            else
                return "Kosong";

        }
        public DataTable getMstUmatBasedOnParoki()
        {
            String namaDatabase = GlobalParam.nama_database;

            MySqlConnection connection = dbConnector.openConnection("", "", namaDatabase);
            String query = "Select " +
                "mu.no_kk, " +
                "mu.nama, " +
                "mu.jenis_kelamin, " +
                "rp.pekerjaan, " +
                "tp.nama_paroki, " +
                "ts.nama_stasi, " +
                "mu.tanggal_lahir " +
                "from mst_umat as mu " +
                "join ref_pekerjaan as rp " +
                "on mu.id_ref_pekerjaan = rp.id_ref_pekerjaan " +
                "join tbl_paroki as tp " +
                "on mu.id_paroki = tp.id_paroki " +
                "join tbl_stasi as ts " +
                "on mu.id_stasi = ts.id_stasi " +
                "where not ((mu.no_kk is null) or (TRIM(mu.no_kk) like '') )";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            return balikan;
        }

        public int getIdRefPekerjaanBasedOnPekerjaan(String pekerjaan)
        {
            int balikan = 0;
            MySqlConnection connection = dbConnector.openConnection("", "", GlobalParam.nama_database);
            connection.Open();
            String query = "Select id_ref_pekerjaan from ref_pekerjaan where pekerjaan = @pekerjaan";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pekerjaan", pekerjaan);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                balikan = reader.GetInt32(0);
            reader.Close();
            connection.Close();
            return balikan;
        }

        public int getKodeStasiBasedOnNamaStasi(String namaStasi)
        {
            int balikan = 0;
            MySqlConnection connection = dbConnector.openConnection("", "", GlobalParam.nama_database);
            connection.Open();
            String query = "Select id_stasi from tbl_stasi where nama_stasi = @stasi";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@stasi", namaStasi);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                balikan = reader.GetInt32(0);
            reader.Close();
            connection.Close();

            return balikan;
        }

        public DataTable searchUmatBasedOnNamaK5Stasi(String pNama, String pK5, String pStasi)
        {
            String namaDatabase = GlobalParam.nama_database;

            MySqlConnection connection = dbConnector.openConnection("", "", namaDatabase);
            String query = "Select " +
                "mu.no_kk, " +
                "mu.nama, " +
                "mu.jenis_kelamin, " +
                "rp.pekerjaan, " +
                "tp.nama_paroki, " +
                "ts.nama_stasi, " +
                "mu.tanggal_lahir " +
                "from mst_umat as mu " +
                "join ref_pekerjaan as rp " +
                "on mu.id_ref_pekerjaan = rp.id_ref_pekerjaan " +
                "join tbl_paroki as tp " +
                "on mu.id_paroki = tp.id_paroki " +
                "join tbl_stasi as ts " +
                "on mu.id_stasi = ts.id_stasi " +
                "where not ((mu.no_kk is null) or (TRIM(mu.no_kk) like '') )";


            if (!String.Equals(pStasi, "-1"))
            {
                query += " AND ts.id_stasi = @paramStasi";
            }
            if (!String.IsNullOrWhiteSpace(pNama))
            {
                query += " AND mu.nama LIKE @paramNama";
            }
            if (!String.IsNullOrWhiteSpace(pK5))
            {
                query += " AND mu.no_kk LIKE @paramK5";
            }

            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            if (!String.Equals(pStasi, "-1"))
            {
                command.Parameters.AddWithValue("@paramStasi", pStasi);
            }
            if (!String.IsNullOrWhiteSpace(pNama))
            {
                command.Parameters.AddWithValue("@paramNama", "%" + pNama + "%");
            }
            if (!String.IsNullOrWhiteSpace(pK5))
            {
                command.Parameters.AddWithValue("@paramK5", "%" + pK5 + "%");
            }
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            return balikan;
        }

        public String deleteUmatBasedOnIDUmat(int idUmat)
        {
            int temp = umatAdapter.deleteUmatBasedOnIdUmat(idUmat);
            if (temp > 0)
            {
                return temp + " data kk tersampling berhasi di hapus";
            }
            else
            {
                return " tidak ada KK sampling terhapus";


            }
        }

        public int getTotalKepalaKeluagaParoki()
        {
            int balikan = 0;
            MySqlConnection connection = dbConnector.openConnection("", "", GlobalParam.nama_database);
            Debug.WriteLine("Nama Database yang dipilih : " + GlobalParam.nama_database);
            connection.Open();
            String query = "Select count(nama_kepala) from kk where id_status_umat = 1";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                balikan = reader.GetInt32(0);
            reader.Close();
            connection.Close();

            return balikan;
        }

        public DataTable datagridRekomendasiSampling()
        {
            String query = "select tbl_stasi.nama_stasi, count(nama_kepala), tbl_stasi.id_stasi " +
                "from kk join tbl_stasi on kk.id_stasi = tbl_stasi.id_stasi " +
                "where kk.id_status_umat = 1 " +
                "group by tbl_stasi.nama_stasi ";

            String namaDatabase = GlobalParam.nama_database;
            MySqlConnection connection = dbConnector.openConnection("", "", namaDatabase);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();


            balikan.Columns[1].ColumnName = "Total Kepala Keluarga Terdata";
            balikan.Columns[0].ColumnName = "Nama Stasi";

            balikan.Columns.Add("Rekomendasi Jumlah Sampling");

            for (int i = 0; i < balikan.Rows.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(balikan.Rows[i][2].ToString()))
                    break;
                else
                {
                    double totalKK = Convert.ToInt32(balikan.Rows[i][1]);
                    double marginOfError = GlobalParam.marginOfError * GlobalParam.marginOfError;
                    double tempKKxMarginOfError = totalKK * marginOfError;
                    double onePlusTemp = 1 + tempKKxMarginOfError;
                    balikan.Rows[i][3] = Convert.ToInt32(totalKK / onePlusTemp);
                }
            }

            balikan.Columns.Add("Total KK Tersampling");

            for (int i = 0; i < balikan.Rows.Count; i++)
            {

                if (String.IsNullOrWhiteSpace(balikan.Rows[i][2].ToString()))
                    break;
                else
                {

                    if (!Convert.IsDBNull(umatAdapter.getTotalKKBasedOnIdStasi(Convert.ToInt32(balikan.Rows[i][2]))))
                    {
                        balikan.Rows[i][4] = umatAdapter.getTotalKKBasedOnIdStasi(Convert.ToInt32(balikan.Rows[i][2]));
                    }
                    else
                    {
                        balikan.Rows[i][4] = "0";
                    }
                }
            }

            balikan.Columns.Add("Persentase Penyelesaian Sampling");
            Debug.WriteLine("=======HITUNG PENYELESAIAN SAMPLING==========");
            for (int i = 0; i < balikan.Rows.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(balikan.Rows[i][2].ToString()))
                    break;
                else
                {
                    Double sampled = Convert.ToInt32(balikan.Rows[i]["Total KK Tersampling"]);
                    Double rekomendasiSample = Convert.ToInt32(balikan.Rows[i]["Rekomendasi Jumlah Sampling"]);
                    Debug.WriteLine("Total KK Tersampling : " + sampled);
                    Debug.WriteLine("Rekomendasi Total Sampling : " + rekomendasiSample);
                    Debug.WriteLine("Persentasenya :  " + sampled / rekomendasiSample);
                    balikan.Rows[i][5] = Convert.ToInt32((sampled / rekomendasiSample) * 100).ToString() + "%";

                }
            }

            balikan.Columns.Remove("id_stasi");

            return balikan;
        }


        public DataTable getMstUmat()
        {
            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            String query = "SELECT " +
                "tbl_umat.id_umat, " +
                "tbl_umat.no_kk, " +
                "tbl_umat.no_k5, " +
                "tbl_umat.no_ktp, " +
                "tbl_umat.nama, " +
                "tbl_umat.umur, " +
                "tbl_umat.jenis_kelamin, " +
                "tbl_umat.no_telp, " +
                "ref_pekerjaan.pekerjaan, " +
                "tbl_umat.id_paroki, " +
                "tbl_paroki.lokasi_paroki, " +
                "tbl_umat.id_stasi " +
                "FROM tbl_umat INNER JOIN " +
                "ref_pekerjaan ON tbl_umat.id_ref_pekerjaan = ref_pekerjaan.id_pekerjaan " +
                "INNER JOIN " +
                "tbl_paroki on tbl_umat.id_paroki = tbl_paroki.id_paroki ";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            connection.Close();

            balikan.Columns.Add("Nomor Identitas").SetOrdinal(4);
            for (int i = 0; i < balikan.Rows.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(balikan.Rows[i][0].ToString()))
                    break;

                else
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (!String.Equals(balikan.Rows[i][j].ToString(), "Null"))
                        {
                            if (j == 1)
                            {
                                balikan.Rows[i][4] = balikan.Rows[i][j] + " / KK";
                            }
                            else if (j == 2)
                            {
                                balikan.Rows[i][4] = balikan.Rows[i][j] + " / K5";
                            }
                            else if (j == 3)
                            {
                                balikan.Rows[i][4] = balikan.Rows[i][j] + " / KTP";
                            }
                        }
                    }

                }
            }

            DataTable tempIDParoki = new DataTable();
            MySqlConnection connection3 = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            connection3.Open();

            string tempQuery =
                "Select id_paroki " +
                "from tbl_umat " +
                "group by id_paroki";

            MySqlCommand command3 = new MySqlCommand(tempQuery, connection3);
            MySqlDataReader reader3 = command3.ExecuteReader();
            DataSet ds3 = new DataSet();
            ds3.Tables.Add(tempIDParoki);
            ds3.EnforceConstraints = false;
            tempIDParoki.Load(reader3);
            reader3.Close();
            connection3.Close();




            DataTable tempStasi = new DataTable();
            tempStasi.Columns.Add("id_stasi");
            tempStasi.Columns.Add("nama_stasi");
            tempStasi.Columns.Add("id_paroki");

            for (int i = 0; i < tempIDParoki.Rows.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(tempIDParoki.Rows[i][0].ToString()))
                    break;

                String tempNamaDatabase = dbConnector.getNamaDatabase(tempIDParoki.Rows[i][0].ToString());
                Debug.WriteLine("ID PAROKI DAN NAMA DATABASE NYA   : " + tempIDParoki.Rows[i][0].ToString() + "  " + tempNamaDatabase);
                MySqlConnection connection2 = dbConnector.openConnection("", "", tempNamaDatabase);
                connection2.Open();

                string queryGetStasi =
                    "Select id_stasi,nama_stasi,id_paroki from tbl_stasi where id_paroki = @p";

                MySqlCommand command2 = new MySqlCommand(queryGetStasi, connection2);
                command2.Parameters.AddWithValue("@p", tempIDParoki.Rows[i][0].ToString());
                MySqlDataReader reader2 = command2.ExecuteReader();
                DataSet ds2 = new DataSet();
                DataTable tempStasiInput = new DataTable();
                ds2.Clear();
                ds2.Tables.Add(tempStasiInput);
                ds2.EnforceConstraints = false;
                tempStasiInput.Load(reader2);
                reader2.Close();
                connection2.Close();

                for (int j = 0; j < tempStasiInput.Rows.Count; j++)
                {
                    if (String.IsNullOrWhiteSpace(tempStasiInput.Rows[j][0].ToString()))
                        break;

                    DataRow tempRow = tempStasi.NewRow();
                    tempRow["id_stasi"] = tempStasiInput.Rows[j][0];
                    tempRow["id_paroki"] = tempStasiInput.Rows[j][2];
                    tempRow["nama_stasi"] = tempStasiInput.Rows[j][1];
                    Debug.WriteLine("STASI BERHASIL DI TAMBAHKAN : " + tempRow["nama_stasi"]);
                    tempStasi.Rows.Add(tempRow);
                }
            }

            balikan.Columns.Add("Stasi");

            for (int i = 0; i < balikan.Rows.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(balikan.Rows[i][0].ToString()))
                    break;
                else
                {
                    foreach (DataRow tempRow in tempStasi.Rows)
                    {
                        if (String.Equals(balikan.Rows[i]["id_stasi"].ToString(), tempRow["id_stasi"].ToString()) && String.Equals(balikan.Rows[i]["id_paroki"].ToString(), tempRow["id_paroki"].ToString()))
                        {
                            balikan.Rows[i]["Stasi"] = tempRow["nama_stasi"];
                        }

                    }
                }
            }



            balikan.Columns.Remove("no_kk");
            balikan.Columns.Remove("no_ktp");
            balikan.Columns.Remove("no_k5");
            balikan.Columns.Remove("no_telp");
            balikan.Columns.Remove("id_paroki");
            balikan.Columns.Remove("id_stasi");
            balikan.Columns.Remove("umur");
            balikan.Columns.Remove("jenis_kelamin");
            
            //balikan.Columns.Remove("Stasi");




            balikan.Columns["nama"].ColumnName = "Nama Kepala Keluarga";
            //balikan.Columns["umur"].ColumnName = "Umur KK";
            //balikan.Columns["jenis_kelamin"].ColumnName = "Jenis Kelamin KK";
            balikan.Columns["pekerjaan"].ColumnName = "Pekerjaan KK";
            balikan.Columns["lokasi_paroki"].ColumnName = "Paroki";

            return balikan;
        }

        public bool getSamePerson(tbl_umat temp)
        {
            String query = "SELECT nama FROM tbl_umat WHERE(nama = @pNama) AND(id_paroki = @pParoki) AND(id_stasi = @pStasi)";

            MySqlConnection connection = dbConnector.openConnection("", "", DatabasesConnector.dbEkonomi);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pNama",temp.nama);
            command.Parameters.AddWithValue("@pParoki",temp.id_paroki);
            command.Parameters.AddWithValue("@pStasi",temp.id_stasi);
            MySqlDataReader reader = command.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable balikan = new DataTable();
            ds.Tables.Add(balikan);
            ds.EnforceConstraints = false;
            balikan.Load(reader);
            reader.Close();
            return balikan.Rows.Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Global
{
    class DatabasesConnector
    {
        public static String dbEkonomi = "db_ekonomi_ketapang";
        public string lokasi_paroki { get; set; }
        public string nama_database { get; set; }
        public string id_paroki { get; set; }

        public DatabasesConnector() { }

        public DatabasesConnector(string id_paroki, string lokasi_paroki, string nama_database)
        {
            this.id_paroki = id_paroki;
            this.lokasi_paroki = lokasi_paroki;
            this.nama_database = nama_database;
        }



        public List<DatabasesConnector> getListDatabases()
        {
            List<DatabasesConnector> temp = new List<DatabasesConnector>();
            temp.Add(new DatabasesConnector("1", "Air Upas", "db_umat_ketapang_air_upas"));
            temp.Add(new DatabasesConnector("2", "Balai Berkuak", "db_umat_ketapang_balai_berkuak"));
            temp.Add(new DatabasesConnector("3", "Balai Semandang", "db_umat_ketapang_balai_semandang"));
            temp.Add(new DatabasesConnector("4", "Kendawangan", "db_umat_ketapang_kendawangan"));
            temp.Add(new DatabasesConnector("5", "Gemma Galgani Ketapang", "db_umat_ketapang_gemma_galgani"));
            temp.Add(new DatabasesConnector("7", "Marau", "db_umat_ketapang_marau"));
            temp.Add(new DatabasesConnector("8", "Menyumbung", "db_umat_ketapang_menyumbung"));
            temp.Add(new DatabasesConnector("9", "Tayap", "db_umat_ketapang_tayap"));
            temp.Add(new DatabasesConnector("10", "Randau", "db_umat_ketapang_randau"));
            temp.Add(new DatabasesConnector("11", "Sandai", "db_umat_ketapang_sandai"));
            temp.Add(new DatabasesConnector("12", "Sepotong", "db_umat_ketapang_sepotong"));
            temp.Add(new DatabasesConnector("13", "Serengkah", "db_umat_ketapang_serengkah"));
            temp.Add(new DatabasesConnector("14", "Tumbang Titi", "db_umat_ketapang_tumbang_titi"));
            temp.Add(new DatabasesConnector("15", "Simpang Dua", "db_umat_ketapang_simpang_dua"));
            temp.Add(new DatabasesConnector("16", "Tanjung", "db_umat_ketapang_tanjung"));
            temp.Add(new DatabasesConnector("17", "Tembelina", "db_umat_ketapang_tembelina"));
            temp.Add(new DatabasesConnector("18", "Sukadana", "db_umat_ketapang_sukadana"));
            temp.Add(new DatabasesConnector("19", "Botong", "db_umat_ketapang_botong"));
            temp.Add(new DatabasesConnector("20", "Meraban", "db_umat_ketapang_meraban"));
            temp.Add(new DatabasesConnector("21", "Sungai Daka", "db_umat_ketapang_sungai_daka"));

            return temp;
        }

        public MySqlConnection openConnection(string ipDataSource, String port, String databaseName)
        {
            if(String.IsNullOrEmpty(ipDataSource))
            {
                ipDataSource = "127.0.0.1";
            }
            if(String.IsNullOrEmpty(port))
            {
                port = "3306";
            }

            return new MySqlConnection("datasource = " + ipDataSource + "; port= " + port + "; database = " + databaseName + "; username = root; password =;");
        }

        public string getIDParoki(string databaseName)
        {
            String temp = "0";
            List<DatabasesConnector> tempList = getListDatabases();

            foreach(DatabasesConnector database in tempList)
            {
                if(String.Equals(database.nama_database,databaseName))
                {
                    temp = database.id_paroki;
                    break;
                }
            }

            return temp;
        }

    }
}

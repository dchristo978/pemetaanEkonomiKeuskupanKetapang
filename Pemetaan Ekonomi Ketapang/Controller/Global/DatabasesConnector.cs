using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Global
{
    class DatabasesConnector
    {
        public static String dbEkonomi = "db_ekonomi_ketapang";
        public string lokasi_paroki { get; set; }
        public string nama_database { get; set; }
        public string id_paroki { get; set; }
        private tbl_database_connectorTableAdapter databaseConnector = new tbl_database_connectorTableAdapter();

        public DatabasesConnector() { }

        public DatabasesConnector(string id_paroki, string lokasi_paroki, string nama_database)
        {
            this.id_paroki = id_paroki;
            this.lokasi_paroki = lokasi_paroki;
            this.nama_database = nama_database;
        }

        public DataTable getDatabaseDataTable()
        {
            DataTable balikan =  databaseConnector.GetData();
            balikan.Columns[0].ColumnName = "ID Paroki";
            balikan.Columns[1].ColumnName = "Lokasi Paroki";
            balikan.Columns[2].ColumnName = "Nama Database";
            return balikan;
        }

        public List<DatabasesConnector> getListDatabases()
        {
            List<DatabasesConnector> balikan = new List<DatabasesConnector>();

            DataTable tempGet = databaseConnector.GetData();

            for (int i = 0; i < tempGet.Rows.Count; i ++)
            {
                DatabasesConnector temp = new DatabasesConnector();
                temp.id_paroki = tempGet.Rows[i][0].ToString();
                temp.lokasi_paroki = tempGet.Rows[i][1].ToString();
                temp.nama_database = tempGet.Rows[i][2].ToString();

                balikan.Add(temp);
            }

            return balikan;
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
        
        public string getNamaDatabase(String idParoki)
        {
            String temp = "0";
            List<DatabasesConnector> tempList = getListDatabases();

            foreach (DatabasesConnector database in tempList)
            {
                if (String.Equals(database.id_paroki, idParoki))
                {
                    temp = database.nama_database;
                    break;
                }
            }

            return temp;
        }

        public bool tambahDatabase(DatabasesConnector temp)
        {
            return databaseConnector.InsertQuery(Convert.ToInt32(temp.id_paroki),temp.lokasi_paroki,temp.nama_database)>0;
        }

        public bool deleteDatabase(DatabasesConnector temp)
        {
            return databaseConnector.DeleteQuery(Convert.ToInt32(temp.id_paroki), temp.lokasi_paroki, temp.nama_database) >0;
        }

        public bool updateDatabase(DatabasesConnector param,DatabasesConnector input)
        {
            return databaseConnector.UpdateQuery(Convert.ToInt32(input.id_paroki),input.lokasi_paroki,input.nama_database, Convert.ToInt32(param.id_paroki),param.lokasi_paroki,param.nama_database)>0;
        }

    }
}

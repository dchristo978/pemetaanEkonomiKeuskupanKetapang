using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Model;
using System.Data;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Umat
{
    class UmatControl
    {
        private tbl_umatTableAdapter umatAdapter = new tbl_umatTableAdapter();
        private db_ekonomi_ketapang ds = new db_ekonomi_ketapang();

        public String insertSamplingUmatBaru(tbl_umat temp)
        {
            String balikan;
            try
            {
                balikan = umatAdapter.insertUmat(getLastIndexIDUmatPlusOne(),temp.no_kk, temp.no_k5, temp.no_ktp, temp.nama, temp.umur, temp.jenis_kelamin, temp.no_telp, temp.id_ref_pekerjaan, temp.id_paroki, temp.id_stasi).ToString();
            }
            catch (Exception E)
            {
                balikan = E.Message.ToString() + "    " +temp.tostr();
            }

            return balikan;
        }

        public int getLastIndexIDUmatPlusOne()
        {
            int balikan = 0;
            ds.Clear();
            ds.EnforceConstraints = false;
            umatAdapter.Fill(ds.tbl_umat);
            Debug.Write("JUMLAH ISINYA : " + ds.tbl_umat.Rows[ds.tbl_umat.Rows.Count-1][0].ToString() );
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
            return  ds.tbl_umat.Rows[ds.tbl_umat.Rows.Count - 1][0].ToString();
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

            if (string.Equals(temp.no_k5,"Null") && string.Equals(temp.no_ktp, "Null"))
                return temp.no_kk + " / KK";
            else if (string.Equals(temp.no_ktp, "Null") && string.Equals(temp.no_kk, "Null"))
                return temp.no_k5 + " / K5";
            else if (string.Equals(temp.no_kk, "Null") && string.Equals(temp.no_k5, "Null"))
                return temp.no_ktp + " / KTP";
            else
                return "Kosong";
                
        }
    }
}

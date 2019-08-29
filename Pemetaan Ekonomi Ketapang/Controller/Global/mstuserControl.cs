using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_umat_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using System.Data;
using System.Diagnostics;

namespace Pemetaan_Ekonomi_Ketapang.Controller
{
    class mstuserControl
    {
        private mst_userTableAdapter useradapter = new mst_userTableAdapter();

        public Boolean loginUser(String username, String password)
        {
            Boolean tempFlag = false;
            String tempBalikanQuery = "";
            DataTable dt = new DataTable();

            try
            {
                tempBalikanQuery = (string)useradapter.loginV2(username, password);

                if (tempBalikanQuery == username)
                {
                    tempFlag = true;
                }

                Debug.Write("Berhasil login atas nama " + tempBalikanQuery);
            }
            catch(Exception e)
            {
                Debug.Write("login user terjadi kesalahan " + e.Message);
            }

            return tempFlag;
        }
    }
}

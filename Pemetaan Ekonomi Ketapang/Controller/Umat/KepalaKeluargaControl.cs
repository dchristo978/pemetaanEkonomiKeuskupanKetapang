using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_umat_ketapangTableAdapters;
using System.Data;

namespace Pemetaan_Ekonomi_Ketapang.Controller
{
    class KepalaKeluargaControl
    {
        private kkTableAdapter kktableadapter = new kkTableAdapter();

        public DataTable getAll()
        {
            return kktableadapter.getAll();
        }

        public DataTable cariNoKK_KepalaKeluarga(String noKK, String kepalaKeluarga)
        {
            if(String.IsNullOrEmpty(noKK))
            {
                return kktableadapter.cariNama_Kepala(queryLikeFormatter(kepalaKeluarga,3));
            }
            else if (String.IsNullOrEmpty(kepalaKeluarga))
            {
                return kktableadapter.cariNoKK(queryLikeFormatter(noKK,3));
            }
            else
            {
                return kktableadapter.cariNoKK_Nama_Kepala(queryLikeFormatter(noKK,3), queryLikeFormatter(kepalaKeluarga,3));
            }
        }

        public String queryLikeFormatter(String masukan, int depan_belakang_depanbelakang)
        {
            String balikan = "";

            if(depan_belakang_depanbelakang == 1)
            {
                balikan = "%" + masukan;
            }
            else if (depan_belakang_depanbelakang == 2)
            {
                balikan = masukan + "%";
            }
            else
            {
                balikan = "%" + masukan + "%";
            }

            return balikan;
        }
    }
}

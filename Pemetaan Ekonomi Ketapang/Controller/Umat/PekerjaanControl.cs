using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pemetaan_Ekonomi_Ketapang.db_ekonomi_ketapangTableAdapters;
using Pemetaan_Ekonomi_Ketapang.Model;

namespace Pemetaan_Ekonomi_Ketapang.Controller.Umat
{
    class PekerjaanControl
    {
        ref_pekerjaanTableAdapter pekerjaanAdapter = new ref_pekerjaanTableAdapter();
        
        public String getPekerjaanByID(int idPekerjaan)
        {
            return pekerjaanAdapter.getPekerjaanByID(idPekerjaan);
        }
    }
}

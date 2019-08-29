using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class ref_pekerjaan
    {
        public String id_pekerjaan { get; set; }
        public String pekerjaan { get; set; }

        public ref_pekerjaan(string id_pekerjaan, string pekerjaan)
        {
            this.id_pekerjaan = id_pekerjaan;
            this.pekerjaan = pekerjaan;
        }
    }
}

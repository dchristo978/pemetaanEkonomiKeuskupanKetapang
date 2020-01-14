using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class refBab
    {
        public String id_bab { get; set; }
        public String bab{ get; set; }

        public refBab(string id_bab, string bab)
        {
            this.id_bab = id_bab;
            this.bab = bab;
        }

        public refBab()
        {

        }
    }
}

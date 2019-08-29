using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class jenis_kelamin
    {
        public String id_jenis_kelamin { get; set; }
        public String desc_jenis_kelamin { get; set; }

        public jenis_kelamin(string id_jenis_kelamin, string desc_jenis_kelamin)
        {
            this.id_jenis_kelamin = id_jenis_kelamin;
            this.desc_jenis_kelamin = desc_jenis_kelamin;
        }

        public jenis_kelamin()
        {

        }
    }
}

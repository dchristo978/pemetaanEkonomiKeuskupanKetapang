using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class ref_jawaban
    {
        public int id_ref_jawaban { get; set; }
        public String no_jawaban { get; set; }
        public String jawaban { get; set; }
        public int id_pertanyaan { get; set; }

        public ref_jawaban() { }

        public ref_jawaban(int id_ref_jawaban, string no_jawaban, string jawaban, int id_pertanyaan)
        {
            this.id_ref_jawaban = id_ref_jawaban;
            this.no_jawaban = no_jawaban;
            this.jawaban = jawaban;
            this.id_pertanyaan = id_pertanyaan;
        }
    }
}

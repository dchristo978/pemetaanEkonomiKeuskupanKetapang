using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class tbl_pertanyaan
    {
        public  int id_pertanyaan { get; set; }
        public string pertanyaan { get; set; }
        public int id_pertanyaan_bab { get; set; }
        public int id_pertanyaan_jenis { get; set; }

        public  tbl_pertanyaan() { }

        public tbl_pertanyaan(int id_pertanyaan, string pertanyaan, int id_pertanyaan_bab, int id_pertanyaan_jenis)
        {
            this.id_pertanyaan = id_pertanyaan;
            this.pertanyaan = pertanyaan;
            this.id_pertanyaan_bab = id_pertanyaan_bab;
            this.id_pertanyaan_jenis = id_pertanyaan_jenis;
        }
    }
}

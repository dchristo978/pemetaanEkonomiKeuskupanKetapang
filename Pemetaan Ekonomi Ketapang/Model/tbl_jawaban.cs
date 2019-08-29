using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class tbl_jawaban
    {
        public int id_jawaban { get; set; }
        public int id_ref_jawaban { get; set; }
        public int id_umat { get; set; }
        public String deskripsi_jawaban_1 { get; set; }
        public String deskripsi_jawaban_2 { get; set; }

        public tbl_jawaban() { }

        public tbl_jawaban(int id_jawaban, int id_ref_jawaban, int id_umat, string deskripsi_jawaban_1, string deskripsi_jawaban_2)
        {
            this.id_jawaban = id_jawaban;
            this.id_ref_jawaban = id_ref_jawaban;
            this.id_umat = id_umat;
            this.deskripsi_jawaban_1 = deskripsi_jawaban_1;
            this.deskripsi_jawaban_2 = deskripsi_jawaban_2;
        }
    }
}

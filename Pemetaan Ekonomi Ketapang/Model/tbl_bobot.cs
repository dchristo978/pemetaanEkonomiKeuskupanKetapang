using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class tbl_bobot
    {
        public int id_bobot { get; set; }
        public double bobot { get; set; }
        public string header_bobot { get; set; }
        public string deskripsi_bobot { get; set; }
        public double batas_bawah_bobot { get; set; }
        public double batas_atas_bobot { get; set; }
        public string is_custom { get; set; }
        public int id_ref_jawaban { get; set; }

        public tbl_bobot() { }

        public tbl_bobot(int id_bobot, double bobot, string header_bobot, string deskripsi_bobot, double batas_bawah_bobot, double batas_atas_bobot, string is_custom, int id_ref_jawaban)
        {
            this.id_bobot = id_bobot;
            this.bobot = bobot;
            this.header_bobot = header_bobot;
            this.deskripsi_bobot = deskripsi_bobot;
            this.batas_bawah_bobot = batas_bawah_bobot;
            this.batas_atas_bobot = batas_atas_bobot;
            this.is_custom = is_custom;
            this.id_ref_jawaban = id_ref_jawaban;
        }

    }
}

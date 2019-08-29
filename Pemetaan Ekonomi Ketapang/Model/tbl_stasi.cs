using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class tbl_stasi
    {
        public string id_stasi { get; set; }
        public string kode_stasi { get; set; }
        public string id_paroki { get; set; }
        public string nama_stasi { get; set; }
        public int jumlah_umat_stasi { get; set; }
        public string id_ref_kondisi_ekonomi { get; set; }

        public tbl_stasi(string id_stasi, string kode_stasi, string id_paroki, string nama_stasi, int jumlah_umat_stasi, string id_ref_kondisi_ekonomi)
        {
            this.id_stasi = id_stasi;
            this.kode_stasi = kode_stasi;
            this.id_paroki = id_paroki;
            this.nama_stasi = nama_stasi;
            this.jumlah_umat_stasi = jumlah_umat_stasi;
            this.id_ref_kondisi_ekonomi = id_ref_kondisi_ekonomi;
        }

        public tbl_stasi()
        {

        }
    }
}

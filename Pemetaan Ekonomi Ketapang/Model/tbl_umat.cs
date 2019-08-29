using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class tbl_umat
    {
        public String no_kk { get; set; }
        public String no_k5 { get; set; }
        public String no_ktp { get; set; }
        public String nama { get; set; }
        public int  umur { get; set; }
        public String jenis_kelamin { get; set; }
        public String no_telp { get; set; }
        public int id_ref_pekerjaan { get; set; }
        public int id_paroki { get; set; }
        public int id_stasi { get; set; }

        public tbl_umat() { }

        public tbl_umat(string no_kk, string no_k5, string no_ktp, string nama, int umur, string jenis_kelamin, string no_telp, int id_ref_pekerjaan, int id_paroki, int id_stasi)
        {
            this.no_kk = no_kk;
            this.no_k5 = no_k5;
            this.no_ktp = no_ktp;
            this.nama = nama;
            this.umur = umur;
            this.jenis_kelamin = jenis_kelamin;
            this.no_telp = no_telp;
            this.id_ref_pekerjaan = id_ref_pekerjaan;
            this.id_paroki = id_paroki;
            this.id_stasi = id_stasi;
        }

        public string tostr()
        {
            return this.no_kk + " - " + this.no_k5 + " - " + this.no_ktp + " - " + this.nama + " - " + this.umur + " - " + this.jenis_kelamin + " - " + this.no_telp + " - " + this.id_ref_pekerjaan + " - " + this.id_paroki + " - " + this.id_paroki + " - " + this.id_stasi;
        }
    }
}

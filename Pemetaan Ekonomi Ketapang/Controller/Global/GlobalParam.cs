using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemetaan_Ekonomi_Ketapang.Controller
{
    class GlobalParam
    {
        public static int idPertanyaan = 0;


        //============= BUAT FORM IDENTITAS  ====================
        public static string no_kk = "";
        public static string no_k5 = "";
        public static string no_ktp = "";
        public static string nama = "";
        public static string jenis_kelamin = "";
        public static string no_telp = "";
        public static int umur = 0;
        public static int id_ref_pekerjaan = 0;
        public static int id_paroki = 0;
        public static int kode_stasi = 0;
        public static int id_umat = 0;

        public static String nama_database = "";

        public static String formParent = "";

        public static double marginOfError = 0;

        public static bool isPanenPangan = false;
        public static bool isPanenKeras = false;
        public static bool isPanenTernak = false;

    }
}

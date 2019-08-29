using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class CoreCode
    {
        public static readonly string koneksi = @"Server=localhost;userid=root;password=;Database=db_umat_ketapang";
        public static readonly string versiAplikasi = Properties.Resources.ResourceManager.GetString("versiAplikasi");
        public static string idFromFormBefore { set; get; }
    }
}

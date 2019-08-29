using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemetaan_Ekonomi_Ketapang.Model
{
    class mst_user
    {
        string username, fullname, password;
        int id_role;

        public mst_user(string username, string fullname, string password, int id_role)
        {
            this.Username = username;
            this.Fullname = fullname;
            this.Password = password;
            this.Id_role = id_role;
        }

        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Password { get => password; set => password = value; }
        public int Id_role { get => id_role; set => id_role = value; }
    }
}

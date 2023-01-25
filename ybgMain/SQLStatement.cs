using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgMain
{
    class SQLStatement
    {
        public static string
           SelectSQL = "select user_name,user_pswd,user_mst from ybg_user where user_id = :user_id";
        public static string
           SelectSQL3 = "select pgm_id,pgm_name,pgm_kind1,pgm_kind2,pgm_dllname,pgm_pi,pgm_ver,pgm_width,pgm_height,pgm_maximize," +
                        "auth_pgmid,auth_all,auth_read,auth_insert,auth_update,auth_delete,auth_print,pgm_auth " +
                        "from ybg_pgm, ybg_auth " +
                        "where pgm_use = :pgm_use and pgm_name like :pgm_name and pgm_id = auth_pgmid(+) and auth_userid(+) = :auth_userid " +
                        "order by pgm_seq, pgm_kind1, pgm_kind2";
    }
}

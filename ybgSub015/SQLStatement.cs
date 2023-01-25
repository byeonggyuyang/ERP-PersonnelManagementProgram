using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub015
{
    class SQLStatement
    {
        public static string
               SelectSQL = "select * from ybgtinsa_papr where papr_appno like :papr_appno and" +
                           " papr_date >= nvl(:papr_date1,00000000) and papr_date <= nvl(:papr_date2,99999999) ";

        public static string
             SelectSQL0 = " select p.*,c.cd_code||':'||c.cd_codnms pap_name  from ybgtinsa_papp p, ybgtinsa_cd c " +
                          " where p.papp_appno = :code" +
                          " and c.cd_grpcd = 'PAP' and p.papp_pap = c.cd_code ";
    }
}

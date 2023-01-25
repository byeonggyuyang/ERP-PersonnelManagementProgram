using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub017
{
    class SQLStatement
    {
        public static string
          SelectSQL = @"select * from ybgtinsa_evalp where eval_year like :eval_year and eval_no like :eval_no";

        public static string
            DeleteSQL = "delete from ybgtinsa_evalp where eval_year = :key1 and eval_no = :key2";

        public static string
            UpdateSQL = "update ybgtinsa_evalp set eval_period = :eval_period, eval_sdate = :eval_sdate, " +
                        "eval_edate = :eval_edate " +
                        "datasys1 = sysdate, datasys2 = 'U',datasys3 = :datesys3 " +
                        "where eval_year = :key1 and eval_no = :key2";

        public static string
            InsertSQL = "insert into ybgtinsa_evalp" +
                        " (eval_year,eval_no,eval_period,eval_sdate,eval_edate,datasys1,datasys2,datasys3) " +
                        "values " +
                        " (:eval_year,:eval_no,:eval_period,:eval_sdate,:eval_edate,sysdate,'A',:datasys3)";
    }
}

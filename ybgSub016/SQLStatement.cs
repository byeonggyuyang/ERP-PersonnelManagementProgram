using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub016
{
    class SQLStatement
    {
        public static string
           SelectSQL = @"select evali_type, evali_itmeno, evali_item_l, evali_item_s, evali_points, evali_gap 
                       from ybgtinsa_evali where evali_type like :evali_type and evali_itmeno like :evali_itmeno";

        public static string
            DeleteSQL = "delete from ybgtinsa_evali where evali_type = :key1 and evali_itmeno = :key2";

        public static string
            UpdateSQL = "update ybgtinsa_evali set evali_item_l = :evali_item_l, evali_item_s = :evali_item_s, " +
                        "evali_points = :evali_points, evali_gap = :evali_gap, " +
                        "datasys1 = sysdate, datasys2 = 'U',datasys3 = :datesys3 " +
                        "where evali_type = :key1 and evali_itmeno = :key2";

        public static string
            InsertSQL = "insert into ybgtinsa_evali" +
                        " (evali_type,evali_itmeno,evali_item_l,evali_item_s,evali_points,evali_gap,datasys1,datasys2,datasys3) " +
                        "values " +
                        " (:evali_type,:evali_itmeno,:evali_item_l,:evali_item_s,:evali_points,:evali_gap,sysdate,'A',:datasys3)";

    }
}

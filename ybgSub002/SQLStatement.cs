using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub002
{
    class SQLStatement
    {
        public static string
            SelectSQL = "select cd_grpcd,cd_code,cd_seq,cd_codnms,cd_codnm,cd_addinfo,cd_upper,cd_use,cd_sdate,cd_edate " +
                        "from ybgtinsa_cd " +
                        "where cd_grpcd like :cd_grpcd and cd_codnms like :cd_codnms " +
                        "order by cd_grpcd, cd_code ";
        public static string
            DeleteSQL = "delete from ybgtinsa_cd where cd_grpcd = :key1 and cd_code = :key2";
        public static string
            UpdateSQL = "update ybgtinsa_cd set cd_seq=:cd_seq, " +
                        " cd_codnms=:cd_codnms,cd_codnm=:cd_codnm,cd_addinfo=:cd_addinfo,cd_upper=:cd_upper, " +
                        " cd_use=:cd_use,cd_sdate=:cd_sdate,cd_edate=:cd_edate,datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        " where cd_grpcd = :key1 and cd_code = :key2";
        public static string
            InsertSQL = "insert into ybgtinsa_cd" +
                        " (cd_grpcd,cd_code,cd_seq,cd_codnms,cd_codnm,cd_addinfo,cd_upper,cd_use,cd_sdate,cd_edate,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:cd_grpcd,:cd_code,:cd_seq,:cd_codnms,:cd_codnm,:cd_addinfo,:cd_upper,:cd_use,:cd_sdate,:cd_edate,sysdate,'A',:datesys3)";
    }
}

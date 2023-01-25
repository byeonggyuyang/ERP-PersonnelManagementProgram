using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub001
{
    class SQLStatement
    {
        public static string
            SelectSQL = "select cdg_grpcd,cdg_grpnm,cdg_digit,cdg_length,cdg_use,cdg_kind " +
                        "from ybgtinsa_cdg " +
                        "where cdg_grpcd like :cdg_grpcd and cdg_grpnm like :cdg_grpnm " +
                        "order by cdg_grpcd";
        public static string
            DeleteSQL = "delete from ybgtinsa_cdg where cdg_grpcd = :key1";
        public static string
            UpdateSQL = "update ybgtinsa_cdg set cdg_grpcd=:cdg_grpcd,cdg_grpnm=:cdg_grpnm, " +
                        "cdg_digit=:cdg_digit,cdg_length=:cdg_length,cdg_use=:cdg_use,cdg_kind=:cdg_kind " +
                        "where cdg_grpcd = :key1";
        public static string
            InsertSQL = "insert into ybgtinsa_cdg" +
                        " (cdg_grpcd,cdg_grpnm,cdg_digit,cdg_length,cdg_use,cdg_kind) " +
                        "values " +
                        " (:cdg_grpcd,:cdg_grpnm,:cdg_digit,:cdg_length,:cdg_use,:cdg_kind)";
    }
}

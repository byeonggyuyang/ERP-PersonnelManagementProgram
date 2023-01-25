using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub013
{
    class SQLStatement
    {
        public static string
            SelectSQL = "select * from ybgtinsa_papr where papr_appno like :papr_appno and" +
                        " papr_date >= nvl(:papr_date1,00000000) and papr_date <= :papr_date2 ";
        

        public static string
            DeleteSQL = "delete from ybgtinsa_papr where papr_appno = :key1 " +
                        "and papr_date = :key2 ";

        public static string
            UpdateSQL = "update ybgtinsa_papr set papr_content = :papr_content, papr_num = :papr_num," +
            " datesys1=sysdate, datesys2='U', datesys3=:datesys3 where papr_appno = :key1 and papr_date = :key2 ";


        public static string
            InsertSQL = "insert into ybgtinsa_papr(papr_appno,papr_date,papr_content,papr_num,datesys1,datesys2,datesys3)" +
                            " values(:papr_appno ,:papr_date, :papr_content, :papr_num, sysdate, 'A', :datesys3)";

            
           

    }
}

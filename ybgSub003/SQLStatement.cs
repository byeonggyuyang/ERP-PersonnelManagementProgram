using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub003
{
    class SQLStatement
    {
        public static string
           SelectSQL = "select dept_code, dept_name, dept_names, dept_seq, dept_upp, dept_use, dept_sdate, dept_edate " +
                       "from ybgtinsa_dept " +
                       "where dept_code like :dept_code and dept_name like :dept_name " +
                       "order by dept_code ";
        public static string
            DeleteSQL = "delete from ybgtinsa_dept where dept_code = :key1 ";
        public static string
            UpdateSQL = "update ybgtinsa_dept set dept_name=:dept_name,dept_names=:dept_names,dept_seq=:dept_seq" +
                        ",dept_upp=:dept_upp,dept_use=:dept_use,dept_sdate=:dept_sdate,dept_edate=:dept_edate, " +
                        "datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        "where dept_code = :key1 ";
        public static string
            InsertSQL = "insert into ybgtinsa_dept" +
                        " (dept_code,dept_name,dept_names,dept_seq,dept_upp,dept_use,dept_sdate,dept_edate,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:dept_code,:dept_name,:dept_names,:dept_seq,:dept_upp,:dept_use,:dept_sdate,:dept_edate,sysdate,'A',:datesys3)";

        public static string
            SelectSQL_kkh_insa_dept = "select dept_code||':'||dept_name from ybgtinsa_dept";
    }
}

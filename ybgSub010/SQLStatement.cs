using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub010
{
    class SQLStatement
    {
        public static string
           SelectSQL0 = "select bas_empno, bas_name, pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name" +
                         " from ybgtinsa_bas bas, (select * from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                         " ybgtinsa_dept DEPT " +
                         " where bas.bas_empno like :bas_empno and bas.bas_name like :bas_name and nvl(bas.bas_pos, '*') like :bas_pos and nvl(bas.bas_dept, '*') like :bas_dept" +
                         " and bas.bas_pos = pos.cd_code(+) " +
                         " and bas.bas_dept = dept.dept_code(+) " +
                         " order by bas_empno ASC ";

        public static string
            SelectSQL = "select lic_empno,lic_name,lic_grade,lic_acqdate, " +
                        "lic_organ " +
                        "from ybgtinsa_lic " +
                        "where lic_empno = :lic_empno ";

        public static string
            DeleteSQL = "delete from ybgtinsa_lic where lic_empno = :key1 and lic_name = :key2";

        public static string
            UpdateSQL = "update ybgtinsa_lic set lic_empno=:lic_empno,lic_name=:lic_name, " +
                        "lic_grade=:lic_grade,lic_acqdate=:lic_acqdate,lic_organ=:lic_organ, " +
                        "datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        "where lic_empno = :key1 and lic_name = :key2";

        public static string
            InsertSQL = "insert into ybgtinsa_lic" +
                        " (lic_empno,lic_name,lic_grade,lic_acqdate,lic_organ,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:lic_empno,:lic_name,:lic_grade,:lic_acqdate,:lic_organ,sysdate,'A',:datesys3)";

        public static string
        SelectSQL_ybg_dept = "select dept_code||':'||dept_name from ybgtinsa_dept " +
                             "order by dept_code ";

        public static string
            SelectSQL_ybg_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'POS' " +
                                "order by cd_code ";
    }
}

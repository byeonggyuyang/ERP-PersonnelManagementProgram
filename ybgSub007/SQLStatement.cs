using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub007
{
    class SQLStatement
    {
        public static string
           SelectSQL0 = " select bas_empno, bas_name, pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name" +
                         " from ybgtinsa_bas bas, (select * from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                         " ybgtinsa_dept DEPT " +
                         " where bas.bas_empno like :bas_empno and bas.bas_name like :bas_name and nvl(bas.bas_pos, '*') like :bas_pos and nvl(bas.bas_dept, '*') like :bas_dept" +
                         " and bas.bas_pos = pos.cd_code(+) " +
                         " and bas.bas_dept = dept.dept_code(+) " +
                         " order by bas_empno ASC ";

        public static string
            SelectSQL = "select edu_empno,edu_loe,edu_entdate,edu_gradate, " +
                        "edu_schnm,edu_dept,edu_degree,edu_grade,edu_gra,edu_last " +
                        "from ybgtinsa_edu " +
                        "where edu_empno = :edu_empno ";

        public static string
            DeleteSQL = "delete from ybgtinsa_edu where edu_empno = :key1 and edu_loe = :key2";

        public static string
            UpdateSQL = "update ybgtinsa_edu set edu_loe=:edu_loe,edu_entdate=:edu_entdate, " +
                        "edu_gradate=:edu_gradate,edu_schnm=:edu_schnm,edu_dept=:edu_dept, " +
                        "edu_degree=:edu_degree,edu_grade=:edu_grade,edu_gra=:edu_gra,edu_last=:edu_last," +
                        "datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        "where edu_empno = :key1 and edu_loe = :key2";

        public static string
            InsertSQL = "insert into ybgtinsa_edu" +
                        " (edu_empno,edu_loe,edu_entdate,edu_gradate,edu_schnm,edu_dept,edu_degree,edu_grade,edu_gra,edu_last,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:edu_empno,:edu_loe,:edu_entdate,:edu_gradate,:edu_schnm,:edu_dept,:edu_degree,:edu_grade,:edu_gra,:edu_last,sysdate,'A',:datesys3)";

        public static string
            SelectSQL_kkh_dept = "select dept_code||':'||dept_name from ybgtinsa_dept " +
                                 "order by dept_code ";

        public static string
            SelectSQL_kkh_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'POS' " +
                                "order by cd_code ";

        public static string
            SelectSQL_kkh_rel = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'REL' ";
    }
}

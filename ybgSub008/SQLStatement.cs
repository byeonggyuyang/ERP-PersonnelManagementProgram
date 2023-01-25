using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub008
{
    class SQLStatement
    {
        public static string
           SelectSQL0 =  "select bas_empno, bas_name, pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name" +
                         " from ybgtinsa_bas bas, (select * from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                         " ybgtinsa_dept DEPT " +
                         " where bas.bas_empno like :bas_empno and bas.bas_name like :bas_name and nvl(bas.bas_pos, '*') like :bas_pos and nvl(bas.bas_dept, '*') like :bas_dept" +
                         " and bas.bas_pos = pos.cd_code(+) " +
                         " and bas.bas_dept = dept.dept_code(+) " +
                         " order by bas_empno ASC ";

        public static string
            SelectSQL = "select pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name, award.* " +
                        "from ybgtinsa_award award, " +
                        "(select* from ybgtinsa_cd where cd_grpcd = 'POS') pos, " +
                        "ybgtinsa_dept dept " +
                        "where award.award_empno = :award_empno " +
                        "and award.award_pos = pos.cd_codnm(+) " +
                        "and award.award_dept = dept.dept_name(+)";

        /*"select award_empno,award_date,award_no,award_kind, " +
        "award_organ,award_content,award_inout, " +
        "get_codinfo_kkh('POS',award_pos) as award_pos, " +
        "dept_code||':'||dept_name as award_dept " +
        "from kkh_insa_award,kkh_insa_dept " +
        "where award_empno = :award_empno and award_dept = dept_name(+) ";*/

        public static string
            DeleteSQL = "delete from ybgtinsa_award where award_empno = :key1 and award_date = :key2";

        public static string
            UpdateSQL = "update ybgtinsa_award set award_empno=:award_empno,award_date=:award_date, " +
                        "award_no=:award_no,award_kind=:award_kind,award_organ=:award_organ, " +
                        "award_content=:award_content,award_inout=:award_inout,award_pos=:award_pos,award_dept=:award_dept, " +
                        "datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        "where award_empno = :key1 and award_date = :key2";

        public static string
            InsertSQL = "insert into ybgtinsa_award" +
                        " (award_empno,award_date,award_no,award_kind,award_organ,award_content,award_inout,award_pos,award_dept,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:award_empno,:award_date,:award_no,:award_kind,:award_organ,:award_content,:award_inout,:award_pos,:award_dept,sysdate,'A',:datesys3)";

        public static string
            SelectSQL_ybg_dept = "select dept_code||':'||dept_name from ybgtinsa_dept " +
                                 "order by dept_code ";

        public static string
            SelectSQL_ybg_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'POS' " +
                                "order by cd_code ";

        public static string
            SelectSQL_ybg_rel = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'REL' ";
    }
}

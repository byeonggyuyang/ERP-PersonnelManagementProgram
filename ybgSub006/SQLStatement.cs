using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub006
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
            SelectSQL = " select rel.cd_code||':'||rel.cd_codnm rel_name, fam.* " +
                        " from ybgtinsa_fam fam, (select * from ybgtinsa_cd where cd_grpcd = 'REL') REL " +
                        " where fam_empno like :fam_empno " +
                        " and fam.fam_rel = rel.cd_code(+) " +
                        " order by fam_rel ASC ";
        /*"select fam_empno,fam_name,fam_bth,fam_ltg, " +
                    "get_codinfo_kkk_cd('REL',fam_rel) as fam_rel " +
                    "from ybgtinsa_fam " +
                    "where fam_empno = :fam_empno ";*/
        public static string
            DeleteSQL = "delete from ybgtinsa_fam where fam_empno = :key1 and fam_name = :key2";
        public static string
            UpdateSQL = "update ybgtinsa_fam set fam_name=:fam_name,fam_rel=:fam_rel,fam_bth=:fam_bth,fam_ltg=:fam_ltg, " +
                        "datesys1=sysdate, datesys2='U', datesys3=:datesys3 " +
                        "where fam_empno = :key1 and fam_name = :key2";
        public static string
            InsertSQL = "insert into ybgtinsa_fam" +
                        " (fam_empno,fam_name,fam_rel,fam_bth,fam_ltg,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:fam_empno,:fam_name,:fam_rel,:fam_bth,:fam_ltg,sysdate,'A',:datesys3)";

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

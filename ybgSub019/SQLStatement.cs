using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub019
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"select evalm_year, evalm_no, evalm_stage, evalm_tee, bas_name,
                          (select bas_dept ||':'|| dept_name from ybgtinsa_bas, ybgtinsa_dept where bas_empno = evalm_tor
                          and dept_code = bas_dept) evalm_dept_tee, 
                          (select bas_pos ||':'|| cd_codnm from ybgtinsa_bas, ybgtinsa_cd where bas_empno = evalm_tor
                          and cd_grpcd = 'POS' and cd_code = bas_pos) evalm_pos_tee, evalm_tor, 
                          (select bas_name from ybgtinsa_bas where bas_empno = evalm_tor) bas_name_tor, 
                          evalm_dept_tor, evalm_pos_tor, evalm_dut_tor, 
                          evalm_period, nvl2(evalm_findate, 'Y', 'N') evalm_findate, evalm_total, evalm_type, 
                          evalm_merit, evalm_weak
                          from ybgtinsa_evalm, ybgtinsa_bas bas, ybgtinsa_cd cd, ybgtinsa_dept dept
                          where evalm_tor like :evalm_tor and evalm_year like :evalm_year
                          and evalm_no like :evalm_no and evalm_type is not null
                          and (cd.cd_grpcd = 'POS' and cd.cd_code(+) = bas.bas_pos)
                          and (dept.dept_code(+) = bas.bas_dept)
                          and evalm_tee = bas_empno";

        public static string
            InsertSQL = "insert into ybgtinsa_evals(evals_year, evals_no, evals_tee, evals_stage, " +
                        "evals_itemno, evals_grade, evals_score, evals_sum,  datasys1, datasys2, datasys3) " +
                        "values " +
                        "(:evals_year, :evals_no, :evals_tee, :evals_stage, " +
                        ":evals_itemno, :evals_grade, :evals_score, :evals_sum, sysdate, 'A', :datasys3)";

        public static string
                   UpdateSQL = "update ybgtinsa_evals set " +
                               "evals_grade = :evals_grade, evals_score = :evals_score, evals_sum = :evals_sum, " +
                               "datasys1 = sysdate, datasys2 = 'U', datasys3 = :datasys3 " +
                               "where evals_year = :evals_year and evals_no = :evals_no " +
                               "and evals_tee = :evals_tee and evals_stage = :evals_stage and evals_itemno = :evals_itemno";

        public static string
            SelectSQL_empno = "select bas_name from ybgtinsa_bas where bas_empno = :bas_empno";

        public static string
            SelectSQL_type = "select * from ybgtinsa_evali, " +
                             "(select evals_score, evals_grade, evals_itemno from ybgtinsa_evals " +
                             "where evals_year = :evals_year and evals_no = :evals_no " +
                             "and evals_tee = :evals_tee and evals_stage = :evals_stage) " +
                             "where evali_type = :evali_type and evali_itemno = evals_itemno(+) " +
                             "order by evali_itemno";
        //"select * 
        //from thrm_evali_shy1,
        //(select evals_score,evals_grade,evals_type from thrm_evals_shy1 
        //where evals_year = :evals_year,evals_no_evals_tee,evals_stage) 
        //where evali_type = evals_type(+) and evali_type = :evali_type";

        public static string
            UpdateSQL_evalm = "update ybgtinsa_evalm set evalm_findate = to_char(sysdate, 'yyyyMMdd'), " +
                              "evalm_total = :evalm_total, evalm_merit = :evalm_merit, evalm_weak = :evalm_weak " +
                              "where evalm_year = :key1 and evalm_no = :key2 and evalm_tee = :key3 and evalm_stage = :key4";

        public static string
            SelectSQL_type1 = "select evali_type from ybgtinsa_evali where evali_type = :evali_type";
    }
}

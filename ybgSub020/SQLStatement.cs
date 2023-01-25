using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub020
{
    class SQLStatement
    {
        public static string
           SelectSQL = @"select a.*, b.bas_name as evalm_tor_name, 
                          dept.dept_name as evalm_tor_dept,
                          pos.cd_codnm as evalm_tor_pos,
                          dut.cd_codnm as evalm_tor_dut, 
                          to_char(a.max,'yyyy-MM-dd HH:mi:ss') as evalm_lastdate
                          from (select evalm_tor,count(evalm_tee) as evalm_tee_cnt,count(evalm_findate) as evalm_check, 
                          max(datasys1) as max
                          from ybgtinsa_evalm 
                          where evalm_year = :evalm_year and evalm_no = :evalm_no
                          group by evalm_tor) a, ybgtinsa_bas b,
                          (select* from ybgtinsa_cd where cd_grpcd = 'POS') POS,
                          (select* from ybgtinsa_cd where cd_grpcd = 'DUT') DUT,
                          ybgtinsa_dept dept
                          where b.bas_empno = a.evalm_tor
                          and b.bas_pos = pos.cd_code(+)
                          and b.bas_dut = dut.cd_code(+)
                          and b.bas_dept = dept.dept_code(+)
                          order by a.evalm_tor";

        public static string
            PeriodSQL = @"select eval_year, eval_no, eval_period, eval_sdate, eval_edate 
                          from ybgtinsa_evalp
                          where eval_edate > sysdate and eval_sdate < sysdate ";
    }
}

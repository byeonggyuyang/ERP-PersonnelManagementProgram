using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub021
{
    class SQLStatement
    {
         public static string
                SelectSQL = @" select evalm_tor, a.bas_name as evalm_tor_name, evalm_dept_tor, evalm_pos_tor, evalm_dut_tor,
                              evalm_tee, b.bas_name as evalm_tee_name, evalm_dept_tee, evalm_pos_tee, 
                              evalm_findate, evalm_total
                              from ybgtinsa_evalm, ybgtinsa_bas a, ybgtinsa_bas b
                              where evalm_year = :evalm_year and evalm_no = :evalm_no
                              and a.bas_name like :evalm_tor_name
                              and b.bas_name like :evalm_tee_name
                              and a.bas_empno = evalm_tor
                              and b.bas_empno = evalm_tee
                              and evalm_findate is not null
                              order by evalm_tor";
        public static string
                PeriodSQL = @"select eval_period, eval_sdate, eval_edate from ybgtinsa_evalp
                              where eval_year = :evalp_year and eval_no = :evalp_no ";
        public static string
                evalm_year_SQL = @"select distinct eval_year from ybgtinsa_evalp
                                   order by eval_year ";
        public static string
                evalm_no_SQL = @"select distinct eval_no from ybgtinsa_evalp
                                   order by eval_no ";
    }
}

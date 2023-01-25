using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub026
{
    class SQLStatement
    {
        public static string
                 SelectSQL = @"select a.papp_dept_cd,a.bas_m,a.bas_w,a.bas_sum,b.dept_name 
                          from
                                (select aa.papp_dept_cd,
                                sum(decode(bb.bas_fix,'남',1,0)) bas_m, 
                                sum(decode(bb.bas_fix,'여',1,0)) bas_w, 
                                count(*) bas_sum
                          from
                                (select papp_empno, papp_date, papp_dept_cd, papp_pos_cd, papp_pap
                                from
                                (select a.*, ROW_NUMBER() OVER(PARTITION BY papp_empno ORDER BY papp_date DESC) AS rank
                                FROM ybgtinsa_papp a
                                where papp_date <= :papp_date
                            )
                            where rank = 1) aa, ybgtinsa_bas bb
                            where aa.papp_empno = bb.bas_empno
                            and aa.papp_pap<> '55'
                            group by aa.papp_dept_cd
                            ) a, ybgtinsa_dept b
                            where a.papp_dept_cd = b.dept_code
                            order by b.dept_seq ";
    }
}

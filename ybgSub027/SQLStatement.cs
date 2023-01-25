using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub027
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"select a.papp_pos_cd, a.pos_cnt, b.cd_codnm
                           from
                            (select aa.papp_pos_cd, count(*) pos_cnt
                                from
                                (select papp_empno, papp_date, papp_dept_cd, papp_pos_cd, papp_pap
                                    from
                                (select a.*, ROW_NUMBER() OVER(PARTITION BY papp_empno ORDER BY papp_date DESC) AS rank
                                            from ybgtinsa_papp a where papp_date <= :papp_date) 
                                        where rank = 1) aa, 
                                    ybgtinsa_bas bb where aa.papp_empno = bb.bas_empno and aa.papp_pap<> '55'
                                    group by aa.papp_pos_cd) a, ybgtinsa_cd b
                                where a.papp_pos_cd = b.cd_code and cd_grpcd = 'POS'
                                order by b.cd_seq ";

    }
}

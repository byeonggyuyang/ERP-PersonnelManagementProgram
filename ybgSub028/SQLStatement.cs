using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub028
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"select a.yyyy,nvl(b.ent_cnt,0) ent, nvl(c.res_cnt,0)*-1 res, nvl(b.ent_cnt,0)-nvl(c.res_cnt,0) cnt
                            from 
                            (select :yyyy1 + LEVEL - 1 as yyyy 
                                from dual
                                connect by level <= (:yyyy2 - :yyyy1) + 1) a,
                            (select substr(bas_entdate,0,4) as yyyy, count(*) as ent_cnt 
                                from ybgtinsa_bas
                                where substr(bas_entdate,0,4) between :yyyy1 and :yyyy2
                                group by substr(bas_entdate,0,4)) b,
                            (select substr(bas_resdate,0,4) as yyyy, count(*) as res_cnt 
                                from ybgtinsa_bas
                                where substr(bas_resdate,0,4) between :yyyy1 and :yyyy2
                                group by substr(bas_resdate,0,4)) c
                            where a.yyyy = b.yyyy(+) and a.yyyy = c.yyyy(+)
                            order by a.yyyy";

    }
}

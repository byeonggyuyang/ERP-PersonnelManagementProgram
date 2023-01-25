using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace ybgSub029
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"select a.yyyy,nvl(b.cnt,0) cnt
                                from
                                (select :yyyy1 + LEVEL - 1 as yyyy 
                                from dual
                                connect by level <= (:yyyy2 - :yyyy1) + 1) a,
                                (select substr(bas_entdate,0,4) as yyyy,count(*) as cnt 
                                from ybgtinsa_bas
                                where substr(bas_entdate,0,4) between :yyyy1 and :yyyy2
                                group by substr(bas_entdate,0,4)
                                order by substr(bas_entdate,0,4)) b
                                where a.yyyy = b.yyyy(+)
                                order by a.yyyy";
    }
}
 
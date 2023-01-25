using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub005
{
    class SQLStatement
    {
        public static string
            SelectSQL = "select bas_empno,bas_name,bas_cont,bas_emp_sdate,bas_emp_edate,bas_entdate, " +
                        "bas_resdate,bas_levdate,bas_reidate,bas_dptdate,bas_jkpdate,bas_posdate, " +
                        "bas_wsta,bas_dept||':'||dept_name as bas_dept,bas_rmk, " +
                        "get_codinfo_kkk_cd('STS',bas_sts) as bas_sts, " +
                        "get_codinfo_kkk_cd('POS',bas_pos) as bas_pos, " +
                        "get_codinfo_kkk_cd('DUT',bas_dut) as bas_dut " +
                        "from kkh_insa_bas, kkh_insa_dept " +
                        "where bas_empno like :bas_empno and bas_name like :bas_name and " +
                        "bas_dept like :bas_dept and bas_pos like :bas_pos " +
                        "and bas_dept = dept_code(+) " +
                        "order by bas_empno ";

        public static string
            UpdateSQL = "update kkh_insa_bas set bas_cont=:bas_cont, " +
                        "bas_emp_sdate=:bas_emp_sdate,bas_emp_edate=:bas_emp_edate,bas_entdate=:bas_entdate, " +
                        "bas_resdate=:bas_resdate,bas_levdate=:bas_levdate,bas_reidate=:bas_reidate, " +
                        "bas_dptdate=:bas_dptdate,bas_jkpdate=:bas_jkpdate,bas_posdate=:bas_posdate, " +
                        "bas_wsta=:bas_wsta,bas_dept=:bas_dept,bas_rmk=:bas_rmk,bas_sts=:bas_sts,bas_pos=:bas_pos,bas_dut=:bas_dut " +
                        "where bas_empno = :key1 ";

        public static string
            SelectSQL_kkh_insa_sts = "select cd_code||':'||cd_codnm from kkh_insa_cd " +
                                     "where cd_grpcd = 'STS' ";
        public static string
            SelectSQL_kkh_insa_dut = "select cd_code||':'||cd_codnm from kkh_insa_cd " +
                                     "where cd_grpcd = 'DUT' ";
        public static string
            SelectSQL_kkh_insa_dept = "select dept_code||':'||dept_names from kkh_insa_dept " +
                                      "order by dept_code ";
        public static string
            SelectSQL_kkh_insa_pos = "select cd_code||':'||cd_codnm from kkh_insa_cd " +
                                     "where cd_grpcd = 'POS' " +
                                     "order by cd_code ";
    }
}

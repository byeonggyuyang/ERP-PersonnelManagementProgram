using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub018
{
    class SQLStatement
    {
        public static string
        SelectSQL = @"select ybgtinsa_evalm.*,evalm_tee||':'||(select bas_name from ybgtinsa_bas where bas_empno = evalm_tee) name_tee,
                      evalm_tor||':'||(select bas_name from ybgtinsa_bas where bas_empno = evalm_tor) name_tor from
                      ybgtinsa_evalm, ybgtinsa_bas  where evalm_year like :evalm_year and evalm_no like :evalm_no
                      and evalm_tee like :evalm_tee and evalm_stage like :evalm_stage
                      and evalm_tee(+) = bas_empno";

        public static string
           DeleteSQL = "delete from ybgtinsa_evalm where evalm_year = :key1 and evalm_no = :key2 and evalm_tee = :key3 and evalm_stage = key4";

        public static string
            UpdateSQL = "update ybgtinsa_evalm set evalm_tor = :evalm_tor, evalm_type = :evalm_type, evalm_period = :evalm_period, " +
                        "evalm_dept_tee = :evalm_dept_tee, evalm_pos_tee = :evalm_pos_tee, evalm_dept_tor = :evalm_dept_tor, evalm_pos_tor = :evalm_pos_tor, " +
                        "evalm_dut_tor = :evalm_dut_tor, datasys1 = sysdate, datasys2 = 'U',datasys3 = :datasys3 " +
                        "where evalm_year = :key1 and evalm_no = :key2 and evalm_tee = :key3 and evalm_stage = :key4";

        public static string
            InsertSQL = "insert into ybgtinsa_evalm" +
                        " (evalm_year,evalm_no,evalm_tee,evalm_stage,evalm_tor,evalm_type,evalm_period,evalm_dept_tee,evalm_pos_tee,evalm_dept_tor,evalm_pos_tor,evalm_dut_tor,datasys1,datasys2,datasys3) " +
                        "values " +
                        " (:evalm_year,:evalm_no,:evalm_tee,:evalm_stage,:evalm_tor,:evalm_type,:evalm_period,:evalm_dept_tee,:evalm_pos_tee,:evalm_dept_tor,:evalm_pos_tor,:evalm_dut_tor,sysdate,'A',:datasys3)";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub014
{
    class SQLStatement
    {
        public static string
           SelectSQL = "select p.*,c.cd_code||':'||c.cd_codnms pap_name  from ybgtinsa_papp p, ybgtinsa_cd c " +
                          " where p.papp_empno like :papp_empno and p.papp_appno like :papp_appno " +
                          "and p.papp_pap like :PAP and p.papp_date >= nvl(:papp_date1,00000000)  and p.papp_date <= :papp_date2 " +
                          " and c.cd_grpcd = 'PAP' and p.papp_pap = c.cd_code";
            
            
           /* "select papp_empno, papp_appno, papp_date, papp_content, " +
                       "get_codinfo_kkk_cd('PAP',papp_pap) as papp_pap, " +
                       "papp_auth, papp_basis, papp_rmk, papp_pos_cd, papp_dut_cd, " +
                       "papp_dept_cd, papp_pos_nm, papp_dut_nm, papp_dept_nm, papp_cont, " +
                       "get_codinfo_kkk_cd('STS',papp_sts) as papp_sts " +
                       "from kkh_insa_papp " +
                       "where papp_empno like :papp_empno and papp_appno like :papp_appno " +
                       "and papp_date >= nvl(:papp_date1,00000000) and papp_date <= :papp_date2 " +
                       "order by papp_empno, papp_appno ";*/

        public static string
            DeleteSQL = "delete from ybgtinsa_papp where papp_empno = :key1 " +
                        "and papp_appno = :key2 and papp_date = :key3 and papp_pap = :key4 ";

        public static string
            UpdateSQL = "update ybgtinsa_papp set papp_appno=:papp_appno,papp_date=:papp_date, " +
                        "papp_pap=:papp_pap,papp_content=:papp_content,papp_auth=:papp_auth,papp_basis=:papp_basis, " +
                        "papp_rmk=:papp_rmk,papp_pos_cd=:papp_pos_cd,papp_dut_cd=:papp_dut_cd,papp_dept_cd=:papp_dept_cd, " +
                        "papp_pos_nm=:papp_pos_nm,papp_dut_nm=:papp_dut_nm,papp_dept_nm=:papp_dept_nm, " +
                        "datasys1 = sysdate, datasys2 = 'U', datasys3 = :datasys3 " +
                        "where papp_empno = :key1 and papp_appno = :key2 and papp_date = :key3 and papp_pap = :key4 ";

        public static string
            InsertSQL = "insert into ybgtinsa_papp" +
                        " (papp_empno,papp_appno,papp_date,papp_pap,papp_content,papp_auth,papp_basis, " +
                        "papp_rmk,papp_pos_cd,papp_dut_cd,papp_dept_cd,papp_pos_nm,papp_dut_nm,papp_dept_nm, " +
                        "datasys1, datasys2, datasys3) " +
                        "values " +
                        " (:papp_empno,:papp_appno,:papp_date,:papp_pap,:papp_content,:papp_auth,:papp_basis, " +
                        ":papp_rmk,:papp_pos_cd,:papp_dut_cd,:papp_dept_cd,:papp_pos_nm,:papp_dut_nm,:papp_dept_nm, " +
                        "sysdate,'A',:datasys3) ";

        public static string
            SelectSQL_ybg_insa_pos = "select cd_codnms from ybgtinsa_cd where cd_grpcd = 'POS'";

        public static string
            SelectSQL_ybg_insa_dut = "select cd_codnms from ybgtinsa_cd where cd_grpcd = 'DUT'";

        public static string
           SelectSQL_ybg_insa_dept = "select dept_name from ybgtinsa_dept";

        public static string
           SelectSQL_ybg_insa_pap = "select cd_code||':'||cd_codnm PAP from ybgtinsa_cd " +
                                    "where cd_grpcd = 'PAP' order by cd_code ";

        public static string
           SelectSQL_ybg_insa_pos_code = "select cd_code from ybgtinsa_cd where cd_codnm = :codnm ";

        public static string
           SelectSQL_ybg_insa_dut_code = "select cd_code from ybgtinsa_cd where cd_codnm = :codnm";

        public static string
           SelectSQL_ybg_insa_dept_code = "select dept_code from ybgtinsa_dept where dept_name = :name";

    }
}

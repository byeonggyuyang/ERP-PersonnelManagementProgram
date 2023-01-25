using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub023
{
    class SQLStatement
    {
        public static string
        SelectSQL = "SELECT POS.CD_CODNMS pos_name, DUT.CD_CODNMS dut_name, STS.CD_CODNMS sts_name, dept.dept_code, dept.dept_name, BAS.* FROM ybgTINSA_BAS BAS" +
                    ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'POS') POS" +
                    ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'DUT') DUT" +
                    ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'STS') STS" +
                    ", ybgTINSA_DEPT DEPT" +
                    " where BAS.bas_empno like :bas_empno and BAS.bas_name like :bas_name and  dept.dept_code like :bas_dept and POS.CD_CODE like :bas_pos" +
                    " and POS.cd_code(+) = BAS.bas_pos" +
                    " and DUT.cd_code(+) = BAS.bas_DUT" +
                    " and STS.cd_code(+) = BAS.bas_STS" +
                    " AND dept.dept_code(+) = BAS.bas_dept";

        public static string
            SelectSQL0 = "select bas_name, bas_entdate, bas_resno, bas_addr, bas_pos.cd_codnms bas_pos, " +
                         "bas_dut.cd_codnms bas_dut, bas_dept.dept_name bas_dept,to_char(sysdate,'yyyy')||'-p-'||LPAD(CERI_SEQ_ybg.nextval,4,0) as ceri_no " +
                         "from ybgtinsa_bas bas " +
                         ", (SELECT* FROM ybgTINSA_CD WHERE CD_GRPCD = 'POS') bas_pos " +
                         ", (SELECT* FROM ybgTINSA_CD WHERE CD_GRPCD = 'DUT') bas_dut " +
                         ", ybgtinsa_dept bas_dept " +
                         "where bas_empno = :bas_empno " +
                         "and bas_pos.cd_code(+) = bas.bas_pos " +
                         "and bas_dut.cd_code(+) = bas.bas_dut " +
                         "and bas_dept.dept_code(+) = bas.bas_dept ";

        public static string
                SelectCeriNo = "select to_char(sysdate,'yyyy')||'-p-'||LPAD(CERI_SEQ_ybg.nextval,4,0) as ceri_no from dual ";

        public static string
            SelectSQL_ybg_insa_dept = @"select dept_code||':'||dept_name from ybgtinsa_dept 
                                      order by dept_code ";

        public static string
            SelectSQL_ybg_insa_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                     "where cd_grpcd = 'POS' " +
                                     "order by cd_code ";
        public static string
            InsertSQL = "insert into ybgtinsa_ceri " +
                        "(ceri_no,ceri_empno,ceri_kind,ceri_date,ceri_lang,datesys1,datesys2,datesys3) " +
                        "values " +
                        "(:ceri_no,:ceri_empno,:ceri_kind,:ceri_date,:ceri_lang,sysdate,'A',:datesys3) ";

        public static string
            UpdateCNT = "update ybgtinsa_ceri set ceri_cnt=:ceri_cnt, datesys1=sysdate, datesys2='U', datesys3=:datesys3 " +
                        "where ceri_no=:ceri_no ";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub025
{
    class SQLStatement
    {
        public static string
         SelectSQL0 = "select ceri_empno, bas_name, ceri_no, " +
                      "ceri_kind, ceri_date, ceri_lang, ceri_cnt " +
                      "from ybgtinsa_bas, ybgtinsa_ceri " +
                      "where ceri_empno like :ceri_empno and bas_name like :bas_name and " +
                      "nvl(bas_dept,'*') like :bas_dept and nvl(bas_pos,'*') like :bas_pos " +
                      "and bas_empno = ceri_empno(+) " +
                      "order by bas_empno ";
        public static string
                 SelectSQL = @" select bas_name, bas_entdate, bas_resno, ceri_no, 
                                pos.cd_codnms bas_pos, dut.cd_codnms bas_dut, dept.dept_name bas_dept
                                from ybgtinsa_bas bas, ybgtinsa_ceri, ybgtinsa_dept dept
                                ,(select * from ybgtinsa_cd where cd_grpcd = 'POS') pos
                                ,(select* from ybgtinsa_cd where cd_grpcd = 'DUT') dut
                                where bas_empno = :bas_empno and
                                ceri_no = :ceri_no and ceri_kind = :ceri_kind
                                and POS.cd_code(+) = BAS.bas_pos
                                and DUT.cd_code(+) = BAS.bas_dut
                                and dept.dept_code(+) = BAS.bas_dept ";
        public static string
                SelectSQL_C = @"select bas_name, bas_addr, bas_entdate, bas_resno, ceri_no, 
                                pos.cd_codnms bas_pos, dut.cd_codnms bas_dut, dept.dept_name bas_dept
                                from ybgtinsa_bas bas, ybgtinsa_ceri ceri
                                ,(select * from ybgtinsa_cd where cd_grpcd = 'POS') pos
                                ,(select* from ybgtinsa_cd where cd_grpcd = 'DUT') dut
                                , ybgtinsa_dept dept
                                where bas_empno = :bas_empno
                                and bas.bas_empno = ceri.ceri_empno(+)
                                and ceri_no = :ceri_no and ceri_kind = :ceri_kind
                                and POS.cd_code(+) = BAS.bas_pos
                                and DUT.cd_code(+) = BAS.bas_dut
                                and dept.dept_code(+) = BAS.bas_dept";

        public static string
                SelectSQL_E = @"select bas_ename, bas_resno, bas_entdate, ceri_no, 
                                pos.cd_engnm bas_pos, dut.cd_engnm bas_dut, dept.dept_eng bas_dept
                                from ybgtinsa_bas bas, ybgtinsa_dept dept, ybgtinsa_ceri ceri
                                ,(select* from ybgtinsa_cd where cd_grpcd = 'POS') pos
                                ,(select* from ybgtinsa_cd where cd_grpcd = 'DUT') dut
                                where bas_empno = :bas_empno
                                and ceri_no = :ceri_no and ceri_kind = :ceri_kind
                                and bas_empno = ceri_empno(+)
                                and bas_dept = dept_code(+)
                                and POS.cd_code(+) = BAS.bas_pos
                                and DUT.cd_code(+) = BAS.bas_dut
                                and dept.dept_code(+) = BAS.bas_dept";

        public static string
                SelectCeriNo = "select to_char(sysdate,'yyyy')||'-p-'||LPAD(CERI_SEQ_ybg.nextval,4,0) as ceri_no from dual ";

        public static string
                SelectSQL_ybgtinsa_dept = "select dept_code||':'||dept_name from ybgtinsa_dept " +
                                          "order by dept_code ";

        public static string
                SelectSQL_ybgtinsa_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                         "where cd_grpcd = 'POS' " +
                                         "order by cd_code ";
        public static string
                InsertSQL = "insert into ybgtinsa_ceri " +
                            "(ceri_no,ceri_empno,ceri_kind,ceri_date,ceri_lang,datesys1,datesys2,datesys3) " +
                            "values " +
                            "(:ceri_no,:ceri_empno,:ceri_kind,:ceri_date,:ceri_lang,sysdate,'A',:datasys3) ";
    }
}

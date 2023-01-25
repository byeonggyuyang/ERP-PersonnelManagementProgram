using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub004
{
    class SQLStatement
    {
        public static string
           SelectSQL = " select pos.cd_code||':'||pos.cd_codnm pos_name, dut.cd_code||':'||dut.cd_codnms dut_name, sts.cd_code||':'||sts.cd_codnms sts_name," +
                        " dept.dept_code||':'||dept.dept_name dept_name, bnk.cd_code||':'||bnk.cd_codnms bnk_name, mil.cd_code||':'||mil.cd_codnms mil_name, " +
                        " rnk.cd_code||':'||rnk.cd_codnms rnk_name, bas.* " +
                        " from ybgtinsa_bas bas, (select* from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'DUT') DUT, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'STS') STS, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'BNK') BNK, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'MIL') MIL, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'RNK') RNK, " +
                        " ybgtinsa_dept DEPT " +
                        " where bas.bas_empno like :bas_empno and bas.bas_name like :bas_name and nvl(bas.bas_pos, '*') like :bas_pos and nvl(bas.bas_dept, '*') like :bas_dept " +
                        " and bas.bas_pos = pos.cd_code(+) " +
                        " and bas.bas_dut = dut.cd_code(+) " +
                        " and bas.bas_sts = sts.cd_code(+) " +
                        " and bas.bas_acc_bank = bnk.cd_code(+) " +
                        " and bas.bas_mil_mil = mil.cd_code(+) " +
                        " and bas.bas_mil_rnk = rnk.cd_code(+) " +
                        " and bas.bas_dept = dept.dept_code(+) " +
                        " order by bas_empno asc ";



        /*"select bas_empno,bas_resno,bas_name,bas_cname,bas_ename,bas_fix,bas_zip, " +
                   "bas_addr,bas_addr2,bas_hdpno,bas_telno,bas_email,bas_mil_sta,bas_mar, " +
                   "get_codinfo_kkh('MIL',bas_mil_mil) as bas_mil_mil, " +
                   "get_codinfo_kkh('RNK',bas_mil_rnk) as bas_mil_rnk, " +
                   "get_codinfo_kkh('BNK',bas_acc_bank) as bas_acc_bank, " +
                   "bas_acc_name,bas_acc_no,bas_cont,bas_emp_sdate, " +
                   "bas_emp_edate,bas_entdate,bas_resdate,bas_levdate,bas_reidate,bas_dptdate, " +
                   "bas_jkpdate,bas_posdate,bas_wsta,bas_dept||':'||dept_name as bas_dept, " +
                   "bas_rmk, " +
                   "get_codinfo_kkk_cd('STS',bas_sts) as bas_sts, " +
                   "get_codinfo_kkk_cd('POS',bas_pos) as bas_pos, " +
                   "get_codinfo_kkk_cd('DUT',bas_dut) as bas_dut " +
                   "from ybgtinsa_bas, ybgtinsa_dept " +
                   "where bas_empno like :bas_empno and bas_name like :bas_name and " +
                   "nvl(bas_dept,'*') like :bas_dept and nvl(bas_pos,'*') like :bas_pos " +
                   "and bas_dept = dept_code(+) " +
                   "order by bas_empno,bas_name ";*/
        public static string
            SelectIMG = "select img_i from ybgtinsa_img where img_ky = :bas_empno ";

        public static string
            InsertIMG = "insert into ybgtinsa_img " +
                        " values(:img_code, :img_img) ";

        public static string
            UpdateIMG = "update ybgtinsa_img set img_i=:img_img " +
                        "where img_ky = :img_code ";

        public static string
            DeleteIMG = "delete from ybgtinsa_img where img_ky = :bas_empno ";

        public static string
            DeleteSQL = "delete from ybgtinsa_bas where bas_empno = :key1 ";

        public static string
            UpdateSQL = "update ybgtinsa_bas set bas_empno=:bas_empno,bas_resno=:bas_resno,bas_name=:bas_name, " +
                        "bas_cname=:bas_cname,bas_ename=:bas_ename,bas_fix=:bas_fix,bas_zip=:bas_zip, " +
                        "bas_addr=:bas_addr,bas_addr2=:bas_addr2,bas_hdpno=:bas_hdpno,bas_telno=:bas_telno,bas_email=:bas_email, " +
                        "bas_mil_sta=:bas_mil_sta,bas_mil_mil=:bas_mil_mil,bas_mil_rnk=:bas_mil_rnk, " +
                        "bas_mar=:bas_mar,bas_acc_bank=:bas_acc_bank,bas_acc_name=:bas_acc_name,bas_acc_no=:bas_acc_no, " +
                        "datesys1=sysdate,datesys2='U',datesys3=:datesys3 " +
                        "where bas_empno = :key1 ";

        public static string
            InsertSQL = "insert into ybgtinsa_bas" +
                        " (bas_empno,bas_resno,bas_name,bas_cname,bas_ename,bas_fix,bas_zip, " +
                        "bas_addr,bas_addr2,bas_hdpno,bas_telno,bas_email,bas_mil_sta,bas_mil_mil,bas_mil_rnk, " +
                        "bas_mar,bas_acc_bank,bas_acc_name,bas_acc_no,datesys1,datesys2,datesys3) " +
                        "values " +
                        " (:bas_empno,:bas_resno,:bas_name,:bas_cname,:bas_ename,:bas_fix,:bas_zip, " +
                        ":bas_addr,:bas_addr2,:bas_hdpno,:bas_telno,:bas_email,:bas_mil_sta,:bas_mil_mil,:bas_mil_rnk, " +
                        ":bas_mar,:bas_acc_bank,:bas_acc_name,:bas_acc_no,sysdate,'A',:datesys3) ";

        public static string
            SelectSQL_ybgtinsa_mil = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                     "where cd_grpcd = 'MIL' ";
        public static string
            SelectSQL_ybgtinsa_rnk = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                     "where cd_grpcd = 'RNK' ";
        public static string
            SelectSQL_ybgtinsa_bnk = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                     "where cd_grpcd = 'BNK' ";
        public static string
            SelectSQL_ybgtinsa_dept = "select dept_code||':'||dept_names from ybgtinsa_dept " +
                                      "order by dept_code ";
        public static string
            SelectSQL_ybgtinsa_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                     "where cd_grpcd = 'POS' " +
                                     "order by cd_code ";
    }
}

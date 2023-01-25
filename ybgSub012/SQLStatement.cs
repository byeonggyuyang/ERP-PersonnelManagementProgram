using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybgSub012
{
    class SQLStatement
    {
        public static string    //사원 조회    
            SelectSQL0 = "select bas_empno, bas_name, pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name" +
                         " from ybgtinsa_bas bas, (select * from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                         " ybgtinsa_dept DEPT " +
                         " where bas.bas_empno like :bas_empno and bas.bas_name like :bas_name and nvl(bas.bas_pos, '*') like :bas_pos and nvl(bas.bas_dept, '*') like :bas_dept" +
                         " and bas.bas_pos = pos.cd_code(+) " +
                         " and bas.bas_dept = dept.dept_code(+) " +
                         " order by bas_empno ASC ";

        public static string    //인사기본사항 조회 
            SelectSQL = " select pos.cd_code||':'||pos.cd_codnm pos_name, dut.cd_code||':'||dut.cd_codnms dut_name, sts.cd_code||':'||sts.cd_codnms sts_name," +
                        " dept.dept_code||':'||dept.dept_name dept_name, bnk.cd_code||':'||bnk.cd_codnms bnk_name, mil.cd_code||':'||mil.cd_codnms mil_name, " +
                        " rnk.cd_code||':'||rnk.cd_codnms rnk_name, bas.* ,img.img_i" +
                        " from ybgtinsa_bas bas, (select* from ybgtinsa_cd where cd_grpcd = 'POS') POS, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'DUT') DUT, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'STS') STS, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'BNK') BNK, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'MIL') MIL, " +
                        " (select* from ybgtinsa_cd where cd_grpcd = 'RNK') RNK, " +
                        " ybgtinsa_dept DEPT, ybgtinsa_img img " +
                        " where bas.bas_empno like :bas_empno " +
                        " and bas.bas_pos = pos.cd_code(+) " +
                        " and bas.bas_dut = dut.cd_code(+) " +
                        " and bas.bas_sts = sts.cd_code(+) " +
                        " and bas.bas_acc_bank = bnk.cd_code(+) " +
                        " and bas.bas_mil_mil = mil.cd_code(+) " +
                        " and bas.bas_mil_rnk = rnk.cd_code(+) " +
                        " and bas.bas_dept = dept.dept_code(+) " +
                        " and bas.bas_empno = img.img_ky(+) " +
                        " order by bas_empno asc ";

        public static string    //유니온 조회
            SelectSQL_union = "select * from (select 'FAM' as type, fam_empno as column1, fam_rel as column2, " +
                              "fam_name as column3, fam_bth as column4, fam_ltg as column5," +
                              "null as column6, null as column7, null as column8, null as column9," +
                              "null as column10 " +
                              "from kkh_insa_fam " +
                              "UNION ALL " +
                              "select 'EDU', edu_empno, edu_loe, " +
                              "edu_entdate, edu_gradate, edu_schnm, " +
                              "edu_dept, edu_degree, to_char(edu_grade), " +
                              "edu_gra, edu_last " +
                              "from kkh_insa_edu " +
                              "UNION ALL " +
                              "select 'AWD', award_empno, award_date, " +
                              "award_no, award_kind, award_organ, award_content, " +
                              "award_inout, award_pos, award_dept, null " +
                              "from kkh_insa_award " +
                              "UNION ALL " +
                              "select 'CAR', car_empno, car_com, car_region, car_yyyymm_f, car_yyyymm_t, " +
                              "car_pos, car_dept, car_reason, null, null " +
                              "from kkh_insa_car " +
                              "UNION ALL " +
                              "select 'LIC', lic_empno, lic_name, lic_grade, lic_acqdate, lic_organ, null, null, null, null, null " +
                              "from kkh_insa_lic " +
                              "UNION ALL " +
                              "select 'FOR', forl_empno, forl_name, forl_score, forl_acqdate, forl_organ, null, null, null, null, null " +
                              "from kkh_insa_forl) " +
                              "where TYPE = :type and column1 = :empno ";

        public static string    //사진 조회 
            SelectIMG = "select img_i from ybgtinsa_img where img_ky = :bas_empno ";

        public static string    //가족사항 조회
            SelectSQL_fam = "select fam_name,fam_bth,fam_ltg, " +
                            "get_codinfo_kkk_cd('REL',fam_rel) as fam_rel " +
                            "from ybgtinsa_fam " +
                            "where fam_empno = :fam_empno ";

        public static string    //학력사항 조회
            SelectSQL_edu = "select edu_loe,edu_entdate,edu_gradate, " +
                            "edu_schnm,edu_dept,edu_degree,edu_grade,edu_gra,edu_last " +
                            "from ybgtinsa_edu " +
                            "where edu_empno = :edu_empno ";

        public static string    //수상경력 조회 
            SelectSQL_award = "select pos.cd_code||':'||pos.cd_codnm pos_name, dept.dept_code||':'||dept.dept_name dept_name, award.* " +
                              "from ybgtinsa_award award, " +
                              "(select* from ybgtinsa_cd where cd_grpcd = 'POS') pos, " +
                              "ybgtinsa_dept dept " +
                              "where award.award_empno = :award_empno " +
                              "and award.award_pos = pos.cd_codnm(+) " +
                              "and award.award_dept = dept.dept_name(+)";

        public static string    //경력사항 조회
            SelectSQL_car = "select car_com,car_region,car_yyyymm_f, " +
                            "car_yyyymm_t,car_pos,car_dept,car_reason " +
                            "from ybgtinsa_car " +
                            "where car_empno = :car_empno ";

        public static string    //자격면허 조회
            SelectSQL_lic = "select lic_name,lic_grade,lic_acqdate, " +
                            "lic_organ " +
                            "from ybgtinsa_lic " +
                            "where lic_empno = :lic_empno ";

        public static string    //외국어 조회
            SelectSQL_forl = "select forl_name,forl_score,forl_acqdate, " +
                             "forl_organ " +
                             "from ybgtinsa_forl " +
                             "where forl_empno = :forl_empno ";

        public static string
            SelectSQL_kkh_insa_dept = "select dept_code||':'||dept_name from ybgtinsa_dept " +
                                 "order by dept_code ";

        public static string
            SelectSQL_kkh_insa_pos = "select cd_code||':'||cd_codnm from ybgtinsa_cd " +
                                "where cd_grpcd = 'POS' " +
                                "order by cd_code ";
    }
}

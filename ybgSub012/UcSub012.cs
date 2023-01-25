using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ybgLibrary;
using System.IO;

namespace ybgSub012
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;
        public static int cnt1 = 0;
        public static int cnt2 = 0;
        public static int cnt3 = 0;
        public static int cnt4 = 0;
        public static int cnt5 = 0;
        public static int cnt6 = 0;
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public string UserNm { get; set; }              // 사용자 이름
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(q_bas_dept, SQLStatement.SelectSQL_kkh_insa_dept);
            Utility.SetComboWithCdnm(q_bas_pos, SQLStatement.SelectSQL_kkh_insa_pos);

            //*---Combox 에 "" 을 추가
            q_bas_dept.Items.Add("");
            q_bas_pos.Items.Add("");

            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView);
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);
            //--DB Handling(Start)-------------------------------------
            try
            {
                String[] s1 = q_bas_dept.Text.Split(new char[] { ':' });
                String[] s2 = q_bas_pos.Text.Split(new char[] { ':' });
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL0;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = q_bas_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + q_bas_name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + s1[0] + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + s2[0] + "%";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");
                dataGridView.DataSource = ds.Tables["TAB"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
            ct_bas_empno.Text = "";
            ct_bas_name.Text = "";
            dataGridView_fam.Rows?.Clear();
            Utility.SetTextNull(data_panel);

            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
        }
        #endregion
        #region 검색 리스트 Double Click
        //************************************************************
        //** 검색 리스트 Double Click
        //************************************************************
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.CurrentRow;
            if (row == null) return;

            ct_bas_empno.Text = (String)row.Cells["bas_empno"].Value;
            ct_bas_name.Text = (String)row.Cells["bas_name"].Value;

            BtnSearch2_Click();
        }
        public void BtnSearch2_Click()
        {
            Utility.BusyIndicator(true);
            //--DB Handling(Start)-------------------------------------
            ct_pictureBox1.Image = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //인사기본사항 조회
                    ct_bas_empno.Text = dr["bas_empno"].ToString();
                    ct_bas_resno.Text = dr["bas_resno"].ToString();
                    ct_bas_name.Text = dr["bas_name"].ToString();
                    ct_bas_cname.Text = dr["bas_cname"].ToString();
                    ct_bas_ename.Text = dr["bas_ename"].ToString();
                    ct_bas_fix.Text = dr["bas_fix"].ToString();
                    ct_bas_zip.Text = dr["bas_zip"].ToString();
                    ct_bas_addr.Text = dr["bas_addr"].ToString() + " " + dr["bas_addr2"].ToString();
                    ct_bas_hdpno.Text = dr["bas_hdpno"].ToString();
                    ct_bas_telno.Text = dr["bas_telno"].ToString();
                    ct_bas_email.Text = dr["bas_email"].ToString();
                    ct_bas_mil_sta.Text = dr["bas_mil_sta"].ToString();
                    ct_bas_mil_mil.Text = dr["bas_mil_mil"].ToString();
                    ct_bas_mil_rnk.Text = dr["bas_mil_rnk"].ToString();
                    ct_bas_mar.Text = dr["bas_mar"].ToString();
                    ct_bas_acc_bank.Text = dr["bas_acc_bank"].ToString();
                    ct_bas_acc_name.Text = dr["bas_acc_name"].ToString();
                    ct_bas_acc_no.Text = dr["bas_acc_no"].ToString();
                    ct_bas_cont.Text = dr["bas_cont"].ToString();
                    if (dr["img_i"] != System.DBNull.Value)
                    {
                        ct_pictureBox1.Image = new Bitmap(new MemoryStream(((byte[])dr["img_i"])));
                    }
                    ct_bas_emp_sdate.Text = Utility.FormatDate(dr["bas_emp_sdate"].ToString());
                    ct_bas_emp_edate.Text = Utility.FormatDate(dr["bas_emp_edate"].ToString());
                    ct_bas_entdate.Text = Utility.FormatDate(dr["bas_entdate"].ToString());
                    ct_bas_resdate.Text = Utility.FormatDate(dr["bas_resdate"].ToString());
                    ct_bas_levdate.Text = Utility.FormatDate(dr["bas_levdate"].ToString());
                    ct_bas_reidate.Text = Utility.FormatDate(dr["bas_reidate"].ToString());
                    ct_bas_dptdate.Text = Utility.FormatDate(dr["bas_dptdate"].ToString());
                    ct_bas_jkpdate.Text = Utility.FormatDate(dr["bas_jkpdate"].ToString());
                    ct_bas_posdate.Text = Utility.FormatDate(dr["bas_posdate"].ToString());
                    ct_bas_wsta.Text = dr["bas_wsta"].ToString();
                    ct_bas_sts.Text = dr["bas_sts"].ToString();
                    ct_bas_pos.Text = dr["bas_pos"].ToString();
                    ct_bas_dut.Text = dr["bas_dut"].ToString();
                    ct_bas_dept.Text = dr["bas_dept"].ToString();
                    ct_bas_rmk.Text = dr["bas_rmk"].ToString();
                }
                dr.Close();

                cnt1 = 0;
                cnt2 = 0;
                cnt3 = 0;
                cnt4 = 0;
                cnt5 = 0;
                cnt6 = 0;

                if (tabControl1.SelectedTab.Text == "가족사항")
                {
                    fam_query();
                    cnt1 = 1;
                }
                else if (tabControl1.SelectedTab.Text == "학력사항")
                {
                    edu_query();
                    cnt2 = 1;
                }
                else if (tabControl1.SelectedTab.Text == "수상경력")
                {
                    award_query();
                    cnt3 = 1;
                }
                else if (tabControl1.SelectedTab.Text == "경력사항")
                {
                    car_query();
                    cnt4 = 1;
                }
                else if (tabControl1.SelectedTab.Text == "자격면허")
                {
                    lic_query();
                    cnt5 = 1;
                }
                else if (tabControl1.SelectedTab.Text == "외국어")
                {
                    forl_query();
                    cnt6 = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 기능버튼(인쇄) Click
        //************************************************************
        //**  인쇄 버튼 Click
        //************************************************************
        public void BtnPrint_Click()
        {
            MessageBox.Show(this.Name + " 인쇄버튼 사용하지 않음.");
        }
        #endregion
        #region 기능버튼(종료) Click
        //************************************************************
        //** 종료 버튼 Click
        //************************************************************
        public void BtnClose_Click()
        {
            if (con != null) con.Close();
        }
        #endregion
        #region 가족사항 조회
        private void fam_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            dataGridView_fam.Rows?.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_fam;
                cmd.BindByName = true;
                cmd.Parameters.Add("fam_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView_fam.Rows.Add();
                    row = dataGridView_fam.Rows[rowIdx];
                    row.Cells["fam_name"].Value = dr["fam_name"].ToString();
                    row.Cells["fam_rel"].Value = dr["fam_rel"].ToString();
                    row.Cells["fam_bth"].Value = Utility.FormatDate(dr["fam_bth"].ToString());
                    row.Cells["fam_ltg"].Value = Utility.ChangeBoolType(dr["fam_ltg"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 학력사항 조회
        private void edu_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            dataGridView_edu.Rows?.Clear();
            int rowIdx2 = 0;
            DataGridViewRow row2;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_edu;
                cmd.BindByName = true;
                cmd.Parameters.Add("edu_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx2 = dataGridView_edu.Rows.Add();
                    row2 = dataGridView_edu.Rows[rowIdx2];
                    row2.Cells["edu_loe"].Value = dr["edu_loe"].ToString();
                    row2.Cells["edu_entdate"].Value = Utility.FormatDate(dr["edu_entdate"].ToString());
                    row2.Cells["edu_gradate"].Value = Utility.FormatDate(dr["edu_gradate"].ToString());
                    row2.Cells["edu_schnm"].Value = dr["edu_schnm"].ToString();
                    row2.Cells["edu_dept"].Value = dr["edu_dept"].ToString();
                    row2.Cells["edu_degree"].Value = dr["edu_degree"].ToString();
                    row2.Cells["edu_grade"].Value = dr["edu_grade"].ToString();
                    row2.Cells["edu_gra"].Value = dr["edu_gra"].ToString();
                    row2.Cells["edu_last"].Value = Utility.ChangeBoolType(dr["edu_last"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 수상경력 조회
        private void award_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            Utility.BusyIndicator(true);
            dataGridView_award.Rows?.Clear();
            int rowIdx3 = 0;
            DataGridViewRow row3;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_award;
                cmd.BindByName = true;
                cmd.Parameters.Add("award_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx3 = dataGridView_award.Rows.Add();
                    row3 = dataGridView_award.Rows[rowIdx3];
                    row3.Cells["award_date"].Value = Utility.FormatDate(dr["award_date"].ToString());
                    row3.Cells["award_no"].Value = dr["award_no"].ToString();
                    row3.Cells["award_kind"].Value = dr["award_kind"].ToString();
                    row3.Cells["award_organ"].Value = dr["award_organ"].ToString();
                    row3.Cells["award_content"].Value = dr["award_content"].ToString();
                    row3.Cells["award_inout"].Value = dr["award_inout"].ToString();
                    row3.Cells["pos_name"].Value = dr["pos_name"].ToString();
                    row3.Cells["dept_name"].Value = dr["dept_name"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 경력사항 조회
        private void car_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            Utility.BusyIndicator(true);
            dataGridView_car.Rows?.Clear();
            int rowIdx4 = 0;
            DataGridViewRow row4;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_car;
                cmd.BindByName = true;
                cmd.Parameters.Add("car_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string date1 = dr["car_yyyymm_f"].ToString().Substring(0, 4) + "-" + dr["car_yyyymm_f"].ToString().Substring(4, 2);
                    string date2 = dr["car_yyyymm_t"].ToString().Substring(0, 4) + "-" + dr["car_yyyymm_f"].ToString().Substring(4, 2);
                    rowIdx4 = dataGridView_car.Rows.Add();
                    row4 = dataGridView_car.Rows[rowIdx4];
                    row4.Cells["car_com"].Value = dr["car_com"].ToString();
                    row4.Cells["car_region"].Value = dr["car_region"].ToString();
                    row4.Cells["car_yyyymm_f"].Value = date1;
                    row4.Cells["car_yyyymm_t"].Value = date2;
                    row4.Cells["car_pos"].Value = dr["car_pos"].ToString();
                    row4.Cells["car_dept"].Value = dr["car_dept"].ToString();
                    row4.Cells["car_reason"].Value = dr["car_reason"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 자격면허 조회
        private void lic_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            Utility.BusyIndicator(true);
            dataGridView_lic.Rows?.Clear();
            int rowIdx5 = 0;
            DataGridViewRow row5;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_lic;
                cmd.BindByName = true;
                cmd.Parameters.Add("lic_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx5 = dataGridView_lic.Rows.Add();
                    row5 = dataGridView_lic.Rows[rowIdx5];
                    row5.Cells["lic_name"].Value = dr["lic_name"].ToString();
                    row5.Cells["lic_grade"].Value = dr["lic_grade"].ToString();
                    row5.Cells["lic_acqdate"].Value = Utility.FormatDate(dr["lic_acqdate"].ToString());
                    row5.Cells["lic_organ"].Value = dr["lic_organ"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 외국어 조회
        private void forl_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            Utility.BusyIndicator(true);
            dataGridView_forl.Rows?.Clear();
            int rowIdx6 = 0;
            DataGridViewRow row6;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_forl;
                cmd.BindByName = true;
                cmd.Parameters.Add("forl_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx6 = dataGridView_forl.Rows.Add();
                    row6 = dataGridView_forl.Rows[rowIdx6];
                    row6.Cells["forl_name"].Value = dr["forl_name"].ToString();
                    row6.Cells["forl_score"].Value = dr["forl_score"].ToString();
                    row6.Cells["forl_acqdate"].Value = Utility.FormatDate(dr["forl_acqdate"].ToString());
                    row6.Cells["forl_organ"].Value = dr["forl_organ"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region UNION 조회
        private void union_query()
        {
            OracleCommand cmd;
            OracleDataReader dr;
            Utility.BusyIndicator(true);
            dataGridView_fam.Rows?.Clear();
            dataGridView_edu.Rows?.Clear();
            dataGridView_award.Rows?.Clear();
            dataGridView_car.Rows?.Clear();
            dataGridView_lic.Rows?.Clear();
            dataGridView_forl.Rows?.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_union;
                cmd.BindByName = true;
                cmd.Parameters.Add("", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView_fam.Rows.Add();
                    row = dataGridView_fam.Rows[rowIdx];
                    row.Cells["forl_empno"].Value = dr["column1"].ToString();
                    row.Cells["forl_score"].Value = dr["forl_score"].ToString();
                    row.Cells["forl_acqdate"].Value = Utility.FormatDate(dr["forl_acqdate"].ToString());
                    row.Cells["forl_organ"].Value = dr["forl_organ"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
            var recCnt6 = dataGridView_forl.RowCount;
            Info_Count.Text = recCnt6.ToString();
            if (recCnt6 == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                Utility.SetTextNull(data_panel);
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView_forl, 0); //Focus를 맨 첫줄로 보내기
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }
        #endregion
        #region 이미지 Search
        private void img_search(object empno, PictureBox picture)
        {
            //--DB Handling(Start)-------------------------------------            
            picture.Image = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectIMG;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["img_i"] != System.DBNull.Value)
                    {
                        picture.Image = new Bitmap(new MemoryStream(((byte[])dr["img_i"])));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 다른 TabPage 선택시
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;
            if (tab.SelectedTab.Text == "가족사항")
            {
                if (cnt1 == 0)
                {
                    cnt1 = 1;
                    fam_query();
                }
                return;
            }
            if (tab.SelectedTab.Text == "학력사항")
            {
                if (cnt2 == 0)
                {
                    cnt2 = 1;
                    edu_query();
                }
                return;
            }
            if (tab.SelectedTab.Text == "수상경력")
            {
                if (cnt3 == 0)
                {
                    cnt3 = 1;
                    award_query();
                }
                return;
            }
            if (tab.SelectedTab.Text == "경력사항")
            {
                if (cnt4 == 0)
                {
                    cnt4 = 1;
                    car_query();
                }
                return;
            }
            if (tab.SelectedTab.Text == "자격면허")
            {
                if (cnt5 == 0)
                {
                    cnt5 = 1;
                    lic_query();
                }
                return;
            }
            if (tab.SelectedTab.Text == "외국어")
            {
                if (cnt6 == 0)
                {
                    cnt6 = 1;
                    forl_query();
                }
                return;
            }
        }
        #endregion
    }
}

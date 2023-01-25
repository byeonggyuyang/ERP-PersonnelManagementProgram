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

namespace ybgSub020
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;
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
            SearchEval();
            last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("evalm_year", OracleDbType.Varchar2).Value = q_evalp_year.Text;
                cmd.Parameters.Add("evalm_no", OracleDbType.Varchar2).Value = q_evalp_no.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["evalm_tor"].Value = dr["evalm_tor"].ToString();
                    row.Cells["evalm_tor_name"].Value = dr["evalm_tor_name"].ToString();
                    row.Cells["evalm_tor_dept"].Value = dr["evalm_tor_dept"].ToString();
                    row.Cells["evalm_tor_pos"].Value = dr["evalm_tor_pos"].ToString();
                    row.Cells["evalm_tor_dut"].Value = dr["evalm_tor_dut"].ToString();
                    row.Cells["evalm_tee_cnt"].Value = dr["evalm_tee_cnt"].ToString() + "명";
                    row.Cells["evalm_check"].Value = dr["evalm_check"].ToString() + "명";
                    row.Cells["evalm_lastdate"].Value = dr["evalm_lastdate"].ToString();
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
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }
        #endregion
        #region 평가 정보 띄우기
        private void SearchEval()
        {
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.PeriodSQL;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    q_evalp_year.Text = dr["eval_year"].ToString();
                    q_evalp_no.Text = dr["eval_no"].ToString();
                    q_evalp_period.Text = dr["eval_period"].ToString();
                    q_evalp_sdate.Text = Utility.FormatDate(dr["eval_sdate"].ToString());
                    q_evalp_edate.Text = Utility.FormatDate(dr["eval_edate"].ToString());
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
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
        }
        #endregion
    }
}

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

namespace ybgSub021
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
            Utility.SetComboWithCdnm(q_evalm_year, SQLStatement.evalm_year_SQL);
            q_evalm_year.Items.Add("");
            Utility.SetComboWithCdnm(q_evalm_no, SQLStatement.evalm_no_SQL);
            q_evalm_no.Items.Add("");

            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
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
                cmd.Parameters.Add("evalm_year", OracleDbType.Varchar2).Value = q_evalm_year.Text;
                cmd.Parameters.Add("evalm_no", OracleDbType.Varchar2).Value = q_evalm_no.Text;
                cmd.Parameters.Add("evalm_tor_name", OracleDbType.Varchar2).Value = "%" + q_evalm_tor_name.Text + "%";
                cmd.Parameters.Add("evalm_tee_name", OracleDbType.Varchar2).Value = "%" + q_evalm_tee_name.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["evalm_tor"].Value = dr["evalm_tor"].ToString();
                    row.Cells["evalm_tor_name"].Value = dr["evalm_tor_name"].ToString();
                    row.Cells["evalm_tor_dept"].Value = dr["evalm_dept_tor"].ToString();
                    row.Cells["evalm_tor_pos"].Value = dr["evalm_pos_tor"].ToString();
                    row.Cells["evalm_tor_dut"].Value = dr["evalm_dut_tor"].ToString();
                    row.Cells["evalm_tee"].Value = dr["evalm_tee"].ToString();
                    row.Cells["evalm_tee_name"].Value = dr["evalm_tee_name"].ToString();
                    row.Cells["evalm_tee_dept"].Value = dr["evalm_dept_tee"].ToString();
                    row.Cells["evalm_tee_pos"].Value = dr["evalm_pos_tee"].ToString();
                    row.Cells["evalm_findate"].Value = Utility.FormatDate(dr["evalm_findate"].ToString());
                    row.Cells["evalm_total"].Value = dr["evalm_total"].ToString();

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
        #region 평가대상기간 찾기
        private void Evalm_period(object sender, EventArgs e)
        {
            q_evalp_period.Text = "";
            dataGridView1.Rows.Clear();
            if (q_evalm_year.Text == "") return;
            if (q_evalm_no.Text == "") return;

            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.PeriodSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("evalp_year", OracleDbType.Varchar2).Value = q_evalm_year.Text;
                cmd.Parameters.Add("evalp_no", OracleDbType.Varchar2).Value = q_evalm_no.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    q_evalp_period.Text = dr["evalp_period"].ToString();
                    q_evalp_sdate.Text = Utility.FormatDate(dr["evalp_sdate"].ToString());
                    q_evalp_edate.Text = Utility.FormatDate(dr["evalp_edate"].ToString());

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
        }
        #endregion
    }
}

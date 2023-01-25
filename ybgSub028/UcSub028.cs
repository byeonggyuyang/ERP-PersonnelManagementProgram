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
using System.Windows.Forms.DataVisualization.Charting;

namespace ybgSub028
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
            chart1.Series.Clear();

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
            chart1.Series.Clear();
            if (q_papp_date1.Text == "" && q_papp_date2.Text == "")
            {
                MessageBox.Show("조회할 연도를 입력해주세요.");
                return;
            }
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
                cmd.Parameters.Add("yyyy1", OracleDbType.Varchar2).Value = q_papp_date1.Text;
                cmd.Parameters.Add("yyyy2", OracleDbType.Varchar2).Value = q_papp_date2.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["yyyy"].Value = dr["yyyy"].ToString();
                    row.Cells["ent"].Value = dr["ent"].ToString();
                    row.Cells["res"].Value = dr.GetInt32(2) * -1;
                    row.Cells["cnt"].Value = dr["cnt"].ToString();
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
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0);
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
            Chart_Cnt();
        }
        #endregion
        #region 기간별 재직인원 추이 차트
        private void Chart_Cnt()
        {
            Utility.BusyIndicator(true);
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("yyyy1", OracleDbType.Varchar2).Value = q_papp_date1.Text;
                cmd.Parameters.Add("yyyy2", OracleDbType.Varchar2).Value = q_papp_date2.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");

                chart1.Series.Add("Series1");
                chart1.Series.Add("Series2");
                chart1.Series.Add("Series3");

                chart1.DataSource = ds.Tables["TAB"];

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].XValueMember = "yyyy";
                chart1.Series[0].YValueMembers = "ent";
                chart1.Series[0].LegendText = "입사인원(명)";
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Titles[0].Text = "기간별 재직인원 추이";

                chart1.Series[1].ChartType = SeriesChartType.Column;
                chart1.Series[1].XValueMember = "yyyy";
                chart1.Series[1].YValueMembers = "res";
                chart1.Series[1].LegendText = "사직인원(명)";
                chart1.Series[1].IsValueShownAsLabel = true;

                chart1.Series[2].ChartType = SeriesChartType.Line;
                chart1.Series[2].BorderWidth = 2;
                chart1.Series[2].XValueMember = "yyyy";
                chart1.Series[2].YValueMembers = "cnt";
                chart1.Series[2].LegendText = "재직인원변동(명)";
                chart1.Series[2].IsValueShownAsLabel = false;

                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
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
        }
        #endregion
    }
}

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

namespace ybgSub026
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;

        private double sum_mP = 0;
        private double sum_wP = 0;
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
            Utility.BusyIndicator(true);
            dataGridView1.Rows.Clear();
            chart1.Series.Clear();
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("papp_date", OracleDbType.Varchar2).Value = Utility.FormatDateR(DateTime.Now.ToShortDateString());
                OracleDataReader dr = cmd.ExecuteReader();
                int rowIdx = 0;
                DataGridViewRow row;
                int sum_m = 0;
                int sum_w = 0;
                while (dr.Read())
                {
                    double a = (dr.GetDouble(1) * 100) / dr.GetDouble(3);
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["dept_name"].Value = dr["dept_name"].ToString();
                    row.Cells["bas_m"].Value = dr["bas_m"].ToString();
                    row.Cells["bas_mP"].Value = Math.Round(a, 1);
                    row.Cells["bas_w"].Value = dr["bas_w"].ToString();
                    row.Cells["bas_wP"].Value = 100 - Math.Round(a, 1);
                    row.Cells["bas_sum"].Value = dr["bas_sum"].ToString();
                    sum_m += dr.GetInt16(1);
                    sum_w += dr.GetInt16(2);
                }
                dr.Close();
                rowIdx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowIdx];
                double b = (sum_m * 100) / (sum_m + sum_w);
                row.Cells["dept_name"].Value = "합계";
                row.Cells["bas_m"].Value = sum_m;
                row.Cells["bas_mP"].Value = Math.Round(b, 1);
                row.Cells["bas_w"].Value = sum_w;
                row.Cells["bas_wP"].Value = 100 - Math.Round(b, 1);
                row.Cells["bas_sum"].Value = sum_m + sum_w;
                sum_mP = Math.Round(b, 1);
                sum_wP = 100 - Math.Round(b, 1);
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
            chart_pie();
        }
        #endregion
        #region 남녀 비율 파이 차트
        private void chart_pie()
        {
            Utility.BusyIndicator(true);
            DataTable dt = new DataTable();
            DataRow row;

            dt.Columns.Add(new DataColumn("sex", typeof(string)));
            dt.Columns.Add(new DataColumn("cnt", typeof(int)));

            row = dt.NewRow();
            row["sex"] = "남자";
            row["cnt"] = sum_mP;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["sex"] = "여자";
            row["cnt"] = sum_wP;
            dt.Rows.Add(row);

            try
            {
                chart1.Series.Add("Series1");
                chart1.DataSource = dt;
                chart1.Series[0].ChartType = SeriesChartType.Doughnut;
                chart1.Series[0].XValueMember = "sex";
                chart1.Series[0].YValueMembers = "cnt";
                //chart1.Series[0].LegendText = "남여 비율";
                chart1.Series[0].IsValueShownAsLabel = true;

                chart1.Titles[0].Text = "남/여 재직인원 현황(현재)";
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

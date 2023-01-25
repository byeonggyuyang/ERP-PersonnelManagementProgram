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

namespace ybgSub027
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

            maskedTextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");

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
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("papp_date", OracleDbType.Varchar2).Value = Utility.FormatDateR(maskedTextBox1.Text);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["papp_pos_nm"].Value = dr["cd_codnm"].ToString();
                    row.Cells["papp_pos_cnt"].Value = dr["pos_cnt"].ToString();
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
            Chart_Pos();
        }
        #endregion
        #region 직급별 인원현황
        private void Chart_Pos()
        {
            Utility.BusyIndicator(true);
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("papp_date", OracleDbType.Varchar2).Value = Utility.FormatDateR(maskedTextBox1.Text);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");

                chart1.Series.Add("Series1");

                chart1.DataSource = ds.Tables["TAB"];

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].XValueMember = "cd_codnm";
                chart1.Series[0].YValueMembers = "pos_cnt";
                chart1.Series[0].LegendText = "직급별 인원수(명)";
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Titles[0].Text = "직급별 인원현황(현재)";
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
    
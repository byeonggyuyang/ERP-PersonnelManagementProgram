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

namespace ybgSub019
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
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

            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("evalm_tor", OracleDbType.Varchar2).Value = qevalm_tor.Text + "%";
                cmd.Parameters.Add("evalm_year", OracleDbType.Varchar2).Value = "%" + qevalm_year.Text + "%";
                cmd.Parameters.Add("evalm_no", OracleDbType.Varchar2).Value = "%" + qevalm_no.Text + "%";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB"); // TAB : 테이블 이름, 아무거나 상관 無
                dataGridView1.DataSource = ds.Tables["TAB"];
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
            //--DB Handling(End)--------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
                return;
            }

            last_button_status = Utility.SetFuncBtn(MainBtn, "2");
            Info_Message.Text = "자료가 정상적으로 조회되었습니다.";
        }
        #endregion

        #region Datagridview Cell Double Click
        //************************************************************
        //** Datagridview Cell Double Click
        //************************************************************
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (row.Cells["evalm_type"].Value.ToString() == "")
            {
                MessageBox.Show("해당되는 평가표 유형이 없습니다.");
                return;
            }
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_type1;
                cmd.BindByName = true;
                cmd.Parameters.Add("evali_type", OracleDbType.Varchar2).Value = row.Cells["evalm_type"].Value.ToString();
                OracleDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("평가표 유형이 유효하지 않습니다.");
                    return;
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
            //--DB Handling(End)--------------------------------------

            EvalsWindow evals = new EvalsWindow();

            evals.evalm_dept_tee.Text = row.Cells["evalm_dept_tee"].Value.ToString();
            evals.evalm_pos_tee.Text = row.Cells["evalm_pos_tee"].Value.ToString();
            evals.name_tee.Text = row.Cells["bas_name"].Value.ToString();
            evals.evalm_period.Text = row.Cells["evalm_period"].Value.ToString();
            evals.evalm_dut_tor.Text = row.Cells["evalm_dut_tor"].Value.ToString();
            evals.name_tor.Text = row.Cells["bas_name_tor"].Value.ToString();
            evals.Type = row.Cells["evalm_type"].Value.ToString();
            evals.Year = row.Cells["evalm_year"].Value.ToString();
            evals.No = row.Cells["evalm_no"].Value.ToString();
            evals.Stage = row.Cells["evalm_stage"].Value.ToString();
            evals.Tee = row.Cells["evalm_tee"].Value.ToString();
            evals.evalm_sum.Text = row.Cells["evalm_total"].Value.ToString();
            evals.evalm_merit.Text = row.Cells["evalm_merit"].Value.ToString();
            evals.evalm_weak.Text = row.Cells["evalm_weak"].Value.ToString();
            evals.UserId = UserId;
            evals.UserNm = UserNm;
            evals.status = row.Cells["evalm_findate"].Value.ToString() == "N" ? "A" : "U";

            evals.ShowDialog();

            BtnSearch_Click();
        }
        #endregion
        #region 사원번호 검색(Leave Event)
        //************************************************************
        //** 사원번호 검색(Leave Event)
        //************************************************************
        private void qevalm_tor_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                ibas_name.Text = "";
                return;
            }
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_empno;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = qevalm_tor.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { // 나중에 함수로 만들어 제작
                    ibas_name.Text = dr["bas_name"].ToString();
                }
                else
                {
                    ibas_name.Text = "";
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
            //--DB Handling(End)--------------------------------------
        }
        #endregion
    }
}

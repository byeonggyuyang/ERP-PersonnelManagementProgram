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

namespace ybgSub015
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
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("papr_appno", OracleDbType.Varchar2).Value = q_papr_appno.Text + "%";
                cmd.Parameters.Add("papr_date1", OracleDbType.Varchar2).Value = Utility.FormatDateR(q_papr_date1.Text);
                cmd.Parameters.Add("papr_date2", OracleDbType.Varchar2).Value = Utility.FormatDateR(q_papr_date2.Text);
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
            
            BtnSearch2_Click();
        }
        public void BtnSearch2_Click()
        {

            Utility.BusyIndicator(true);
            //--DB Handling(Start)-------------------------------------
            try
            {
              
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = papr_appno.HeaderText;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //인사기본사항 조회

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

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView.CurrentRow;
            if (row == null) return;
            String code = dataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Utility.BusyIndicator(true);
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            //--DB Handling(Start)-------------------------------------
            try
            {

                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL0;
                cmd.BindByName = true;
                cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = code;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["papp_empno"].Value = dr["papp_empno"].ToString();
                    row.Cells["papp_appno"].Value = dr["papp_appno"].ToString();
                    row.Cells["papp_date"].Value = Utility.FormatDate(dr["papp_date"].ToString());
                    row.Cells["papp_pap"].Value = dr["pap_name"].ToString();
                    row.Cells["papp_content"].Value = dr["papp_content"].ToString();
                    row.Cells["papp_auth"].Value = dr["papp_auth"].ToString();
                    row.Cells["papp_basis"].Value = dr["papp_basis"].ToString();
                    row.Cells["papp_rmk"].Value = dr["papp_rmk"].ToString();
                    row.Cells["papp_pos_cd"].Value = dr["papp_pos_cd"].ToString();
                    row.Cells["papp_dut_cd"].Value = dr["papp_dut_cd"].ToString();
                    row.Cells["papp_dept_cd"].Value = dr["papp_dept_cd"].ToString();
                    row.Cells["papp_pos_nm"].Value = dr["papp_pos_nm"].ToString();
                    row.Cells["papp_dut_nm"].Value = dr["papp_dut_nm"].ToString();
                    row.Cells["papp_dept_nm"].Value = dr["papp_dept_nm"].ToString();
                    row.Cells["papp_cont"].Value = dr["papp_cont"].ToString();
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
    }
}

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

namespace ybgSub005
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
            //*---Value Changed Event Handler(Start)------------------------
            ct_bas_empno.TextChanged += InputData_TextChanged;
            ct_bas_name.TextChanged += InputData_TextChanged;
            ct_bas_cont.SelectedValueChanged += InputData_TextChanged;
            ct_bas_emp_sdate.TextChanged += InputData_TextChanged;
            ct_bas_emp_edate.TextChanged += InputData_TextChanged;
            ct_bas_entdate.TextChanged += InputData_TextChanged;
            ct_bas_resdate.TextChanged += InputData_TextChanged;
            ct_bas_levdate.TextChanged += InputData_TextChanged;
            ct_bas_reidate.TextChanged += InputData_TextChanged;
            ct_bas_dptdate.TextChanged += InputData_TextChanged;
            ct_bas_jkpdate.TextChanged += InputData_TextChanged;
            ct_bas_posdate.TextChanged += InputData_TextChanged;
            ct_bas_wsta.SelectedValueChanged += InputData_TextChanged;
            ct_bas_sts.SelectedValueChanged += InputData_TextChanged;
            ct_bas_pos.SelectedValueChanged += InputData_TextChanged;
            ct_bas_dut.SelectedValueChanged += InputData_TextChanged;
            ct_bas_dept.SelectedValueChanged += InputData_TextChanged;
            ct_bas_rmk.TextChanged += InputData_TextChanged;
            //*---Value Changed Event Handler(end)--------------------------
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(q_bas_dept, SQLStatement.SelectSQL_kkh_insa_dept);
            Utility.SetComboWithCdnm(q_bas_pos, SQLStatement.SelectSQL_kkh_insa_pos);
            Utility.SetComboWithCdnm(ct_bas_sts, SQLStatement.SelectSQL_kkh_insa_sts);
            Utility.SetComboWithCdnm(ct_bas_pos, SQLStatement.SelectSQL_kkh_insa_pos);
            Utility.SetComboWithCdnm(ct_bas_dut, SQLStatement.SelectSQL_kkh_insa_dut);
            Utility.SetComboWithCdnm(ct_bas_dept, SQLStatement.SelectSQL_kkh_insa_dept);
            //*---Combox 에 "" 을 추가
            ct_bas_sts.Items.Add("");
            ct_bas_pos.Items.Add("");
            ct_bas_dut.Items.Add("");
            ct_bas_dept.Items.Add("");
            q_bas_dept.Items.Add("");
            q_bas_pos.Items.Add("");

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
                String[] s1 = q_bas_dept.Text.Split(new char[] { ':' });
                String[] s2 = q_bas_pos.Text.Split(new char[] { ':' });
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = q_bas_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + q_bas_name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + s1[0] + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + s2[0] + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)                
                while (dr.Read())
                {

                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["bas_empno"].Value = dr["bas_empno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["bas_cont"].Value = dr["bas_cont"].ToString();
                    row.Cells["bas_emp_sdate"].Value = Utility.FormatDate(dr["bas_emp_sdate"].ToString());
                    row.Cells["bas_emp_edate"].Value = Utility.FormatDate(dr["bas_emp_edate"].ToString());
                    row.Cells["bas_entdate"].Value = Utility.FormatDate(dr["bas_entdate"].ToString());
                    row.Cells["bas_resdate"].Value = Utility.FormatDate(dr["bas_resdate"].ToString());
                    row.Cells["bas_levdate"].Value = Utility.FormatDate(dr["bas_levdate"].ToString());
                    row.Cells["bas_reidate"].Value = Utility.FormatDate(dr["bas_reidate"].ToString());
                    row.Cells["bas_dptdate"].Value = Utility.FormatDate(dr["bas_dptdate"].ToString());
                    row.Cells["bas_jkpdate"].Value = Utility.FormatDate(dr["bas_jkpdate"].ToString());
                    row.Cells["bas_posdate"].Value = Utility.FormatDate(dr["bas_posdate"].ToString());
                    row.Cells["bas_wsta"].Value = dr["bas_wsta"].ToString();
                    row.Cells["bas_sts"].Value = dr["bas_sts"].ToString();
                    row.Cells["bas_pos"].Value = dr["bas_pos"].ToString();
                    row.Cells["bas_dut"].Value = dr["bas_dut"].ToString();
                    row.Cells["bas_dept"].Value = dr["bas_dept"].ToString();
                    row.Cells["bas_rmk"].Value = dr["bas_rmk"].ToString();
                    row.Cells["key1"].Value = dr["bas_empno"].ToString();
                    row.Cells["status"].Value = "";
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
                query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
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
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }
        #endregion
        #region 기능버튼(입력) Click
        //************************************************************
        //** 입력 버튼 Click 
        //************************************************************
        public void BtnInsert_Click()
        {
            MessageBox.Show(this.Name + " 입력버튼 사용하지 않음");
        }
        #endregion
        #region 기능버튼(수정) Click
        //************************************************************
        //** 수정 버튼 Click 
        //************************************************************
        public void BtnUpdate_Click()
        {
            MessageBox.Show(this.Name + " 수정버튼 사용하지 않음");
        }
        #endregion
        #region 기능버튼(삭제) Click
        //************************************************************
        //** 삭제 버튼 Click 
        //************************************************************
        public void BtnDelete_Click()
        {
            MessageBox.Show(this.Name + " 삭제버튼 사용하지 않음");
        }
        #endregion
        #region 기능버튼(저장) Click
        //************************************************************
        //** 저장 버튼 Click (여러 건의 DATA 추가입력/수정 후 저장)
        //************************************************************
        public void BtnSave_Click()
        {
            DialogResult result = MessageBox.Show("입력 및 수정중인 자료를 저장합니다.", "저장확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //*--입력값에 오류가 있는지 여부 확인
            if (!Utility.InputErrorCheck(dataGridView1)) return;

            OracleTransaction tran = null;
            try
            {
                con = Utility.SetOracleConnection();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.Transaction = tran;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["status"].Value.Equals("")) continue;
                    if (row.Cells["status"].Value.Equals("U"))
                    {
                        cmd.CommandText = SQLStatement.UpdateSQL;
                        cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                    }

                    cmd.Parameters.Add("bas_cont", OracleDbType.Varchar2).Value = row.Cells["bas_cont"].Value;
                    cmd.Parameters.Add("bas_emp_sdate", OracleDbType.Varchar2).Value = (row.Cells["bas_emp_sdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_emp_edate", OracleDbType.Varchar2).Value = (row.Cells["bas_emp_edate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_entdate", OracleDbType.Varchar2).Value = (row.Cells["bas_entdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_resdate", OracleDbType.Varchar2).Value = (row.Cells["bas_resdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_levdate", OracleDbType.Varchar2).Value = (row.Cells["bas_levdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_reidate", OracleDbType.Varchar2).Value = (row.Cells["bas_reidate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_dptdate", OracleDbType.Varchar2).Value = (row.Cells["bas_dptdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_jkpdate", OracleDbType.Varchar2).Value = (row.Cells["bas_jkpdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_posdate", OracleDbType.Varchar2).Value = (row.Cells["bas_posdate"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_wsta", OracleDbType.Varchar2).Value = row.Cells["bas_wsta"].Value;
                    cmd.Parameters.Add("bas_sts", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_sts"].Value);
                    cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_pos"].Value);
                    cmd.Parameters.Add("bas_dut", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_dut"].Value);
                    cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = Utility.GetCode((string)row.Cells["bas_dept"].Value);
                    cmd.Parameters.Add("bas_rmk", OracleDbType.Varchar2).Value = row.Cells["bas_rmk"].Value;
                    cmd.Parameters.Add("bas_rmk", OracleDbType.Varchar2).Value = row.Cells["bas_rmk"].Value;
                    //  cmd.Parameters.Add("datasys3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();  //*----반드시 포함                    
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
            }
            //**정상 저장 후 초기화*******************************************************
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value.Equals("")) continue;
                row.Cells["key1"].Value = row.Cells["bas_empno"].Value;
                row.Cells["status"].Value = "";
            }
            Info_Message.Text = "자료가 정상적으로 저장 되었습니다.";
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
        }
        #endregion
        #region 기능버튼(취소) Click
        //************************************************************
        //** 취소 버튼 Click
        //************************************************************
        public void BtnCancel_Click()
        {
            DialogResult result = MessageBox.Show(" 입력 및 수정중인 자료를 취소합니다.", "취소메세지", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            BtnSearch_Click();
        }
        #endregion
        #region 기능버튼(인쇄) Click
        //************************************************************
        //**  인쇄 버튼 Click
        //************************************************************
        public void BtnPrint_Click()
        {
            MessageBox.Show(" 인쇄버튼 사용하지 않음.");
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
        #region Conrtrol Value Changed 공통 Event Handler
        //************************************************************
        //** Conrtrol Value Changed 공통 Event Handler
        //************************************************************
        private void InputData_TextChanged(object sender, EventArgs e)
        {
            if (select_sw) return; //GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            if (dataGridView1.SelectedRows.Count <= 0) return;

            Utility.SetValueToGridView(dataGridView1, sender as Control);

            //*--Data Status = "수정"  설정-------------------
            DataGridViewRow row = dataGridView1.CurrentRow;
            if ((String)row.Cells["status"].Value == "")
            {
                row.Cells["status"].Value = "U";
            }
            //*--Data Status = "수정"  설정-------------------

            last_button_status = Utility.SetFuncBtn2(MainBtn, "1000110");
        }
        #endregion
        #region DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        //** DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        private void DataList_SelectionChanged(object sender, EventArgs e)
        {
            if (query_sw) return;  //조회 버튼을 누를때, 수행하지 않기 위해
            if (dataGridView1.Rows.Count == 0) return;

            select_sw = true; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (On)

            Utility.SetValueToControlFromGridView(dataGridView1, data_panel);

            select_sw = false; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
        }
        #endregion
        #region TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        //** TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        private void Number_Only_Protect(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            //*--8 : BackSpace , 46 : dot  ----------------*/
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

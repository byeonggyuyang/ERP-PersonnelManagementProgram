﻿using System;
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

namespace ybgSub008
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
            ct_award_date.TextChanged += InputData_TextChanged;
            ct_award_no.TextChanged += InputData_TextChanged;
            ct_award_kind.TextChanged += InputData_TextChanged;
            ct_award_organ.TextChanged += InputData_TextChanged;
            ct_award_content.TextChanged += InputData_TextChanged;
            ct_award_inout.SelectedValueChanged += InputData_TextChanged;
            ct_pos_name.SelectedValueChanged += InputData_TextChanged;
            ct_dept_name.SelectedValueChanged += InputData_TextChanged;
            //*---Value Changed Event Handler(end)--------------------------
            //*---Validated Event Handler(Start)----------------------------
            ct_award_date.Validated += Input_Validation_Check;
            ct_award_no.Validated += Input_Validation_Check;
            ct_award_kind.Validated += Input_Validation_Check;
            ct_award_organ.Validated += Input_Validation_Check;
            ct_award_content.Validated += Input_Validation_Check;
            //*---Validated Event Handler(End)----------------------------
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(q_bas_dept, SQLStatement.SelectSQL_ybg_dept);
            Utility.SetComboWithCdnm(q_bas_pos, SQLStatement.SelectSQL_ybg_pos);
            Utility.SetComboWithCdnm(ct_pos_name, SQLStatement.SelectSQL_ybg_pos);
            Utility.SetComboWithCdnm(ct_dept_name, SQLStatement.SelectSQL_ybg_dept);

            q_bas_dept.Items.Add("");
            q_bas_pos.Items.Add("");
            ct_pos_name.Items.Add("");
            ct_dept_name.Items.Add("");

            last_button_status = Utility.SetFuncBtn(MainBtn, "0");

            Utility.DataGridView_Scrolling_SpeedUp(dataGridView);
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
            errorProvider1.Clear();
            ct_bas_empno.Text = "";
            ct_bas_name.Text = "";
            dataGridView1.Rows?.Clear();
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
            dataGridView1.Rows?.Clear();
            errorProvider1.Clear();

            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("award_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["award_empno"].Value = dr["award_empno"].ToString();
                    row.Cells["award_date"].Value = Utility.FormatDate(dr["award_date"].ToString());
                    row.Cells["award_no"].Value = dr["award_no"].ToString();
                    row.Cells["award_kind"].Value = dr["award_kind"].ToString();
                    row.Cells["award_organ"].Value = dr["award_organ"].ToString();
                    row.Cells["award_content"].Value = dr["award_content"].ToString();
                    row.Cells["award_inout"].Value = dr["award_inout"].ToString();
                    row.Cells["pos_name"].Value = dr["pos_name"].ToString();
                    row.Cells["dept_name"].Value = dr["dept_name"].ToString();
                    row.Cells["key1"].Value = dr["award_empno"].ToString();
                    row.Cells["key2"].Value = dr["award_date"].ToString();
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
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                Utility.SetTextNull(data_panel);
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                this.DataList_SelectionChanged(null, null);        //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "2");
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
            if (ct_bas_empno.Text.Equals(""))
            {
                MessageBox.Show("사원번호를 먼저 선택하세요(Double Click).", "안내메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIdx = dataGridView1.CurrentRow == null ? 0 : dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows.Count == 0)
            {
                rowIdx = dataGridView1.Rows.Add();
            }
            else
            {
                rowIdx++;
                dataGridView1.Rows.Insert(rowIdx);
            }
            dataGridView1.Rows[rowIdx].Cells["award_empno"].Value = ct_bas_empno.Text;
            dataGridView1.Rows[rowIdx].Cells["status"].Value = "A";
            //---추가된 Row로 Focus 이동-------------------------------- 
            Utility.SetFocusingDataGridView(dataGridView1, rowIdx);
            ct_award_date.Focus();

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
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
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 자료를 먼저 선택하세요.", "삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((String)row.Cells["status"].Value == "A")
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                return;
            }
            DialogResult result = MessageBox.Show(row.Cells["award_date"].Value +
                                                  " 자료를 삭제하시겠습니까.", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQLStatement.DeleteSQL;
                cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                cmd.Parameters.Add("key2", OracleDbType.Varchar2).Value = row.Cells["key2"].Value;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                    Info_Count.Text = dataGridView1.RowCount.ToString();
                    Info_Message.Text = "자료가 정상적으로 삭제 되었습니다.";
                }
                else
                {
                    Info_Message.Text = "자료삭제에 문제가 있습니다. 시스템 담당자에게 문의하세요.";
                    return;
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
            }
            //--DB Handling(End)-------------------------------------
            if (dataGridView1.RowCount == 0)
            {
                select_sw = true;
                Utility.SetTextNull(data_panel);
                select_sw = false;
            }
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
                    if (row.Cells["status"].Value.Equals("A"))
                    {
                        cmd.CommandText = SQLStatement.InsertSQL;
                        cmd.Parameters.Add("award_empno", OracleDbType.Varchar2).Value = row.Cells["award_empno"].Value;
                    }
                    if (row.Cells["status"].Value.Equals("U"))
                    {
                        cmd.CommandText = SQLStatement.UpdateSQL;
                        cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                        cmd.Parameters.Add("key2", OracleDbType.Varchar2).Value = row.Cells["key2"].Value;
                    }

                    cmd.Parameters.Add("award_empno", OracleDbType.Varchar2).Value = row.Cells["award_empno"].Value;
                    cmd.Parameters.Add("award_date", OracleDbType.Varchar2).Value = (row.Cells["award_date"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("award_no", OracleDbType.Varchar2).Value = row.Cells["award_no"].Value;
                    cmd.Parameters.Add("award_kind", OracleDbType.Varchar2).Value = row.Cells["award_kind"].Value;
                    cmd.Parameters.Add("award_organ", OracleDbType.Varchar2).Value = row.Cells["award_organ"].Value;
                    cmd.Parameters.Add("award_content", OracleDbType.Varchar2).Value = row.Cells["award_content"].Value;
                    cmd.Parameters.Add("award_inout", OracleDbType.Varchar2).Value = row.Cells["award_inout"].Value;
                    cmd.Parameters.Add("award_pos", OracleDbType.Varchar2).Value = Utility.GetCodeNM(row.Cells["award_pos"].Value.ToString());
                    cmd.Parameters.Add("award_dept", OracleDbType.Varchar2).Value = Utility.GetCodeNM(row.Cells["award_dept"].Value.ToString());
                    cmd.Parameters.Add("datesys3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;

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
                row.Cells["key1"].Value = row.Cells["award_empno"].Value;
                row.Cells["key2"].Value = row.Cells["award_date"].Value;
                row.Cells["status"].Value = "";
            }
            Info_Message.Text = "자료가 정상적으로 저장 되었습니다.";
            last_button_status = Utility.SetFuncBtn(MainBtn, "2");
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

            BtnSearch2_Click();
        }
        #endregion
        #region 기능버튼(인쇄) Click
        //************************************************************
        //**  인쇄 버튼 Click
        //************************************************************
        public void BtnPrint_Click()
        {
            MessageBox.Show(this.Name + " 인쇄버튼 클릭");
        }
        #endregion
        #region 기능버튼(종료) Click
        //************************************************************
        //** 종료 버튼 Click
        //************************************************************
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con != null) con.Close();
        }
        #endregion
        #region Conrtrol Value Changed 공통 Event Handler (Event)
        //************************************************************
        //** Conrtrol Value Changed 공통 Event Handler (Evnet)
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

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
        }
        #endregion
        #region DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting (SelectionChanged Event)
        //************************************************************
        //** DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting (SelectionChanged Event)
        //************************************************************
        private void DataList_SelectionChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Input Data Validation Check (Validated Event)
        //************************************************************
        //** Input Data Validation Check (Validated Event)
        //************************************************************
        private void Input_Validation_Check(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            dataGridView1.SelectedRows[0].ErrorText = "";

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_award_date.Text) == false)
            {
                SetError(ct_award_date, "수여일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_award_date, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_award_no.Text == "")
            {
                SetError(ct_award_no, "수여번호를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_award_no, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_award_kind.Text == "")
            {
                SetError(ct_award_kind, "수상종별을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_award_kind, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (ct_award_organ.Text == "")
            {
                SetError(ct_award_organ, "수여자(시행처)를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_award_organ, errorProvider1);
            }
        }
        private void SetError(Control ctl, String errMsg, DataGridViewRow row, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, errMsg);
            row.ErrorText = errMsg;
        }
        private void ResetError(Control ctl, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, "");
        }
        #endregion
    }
}

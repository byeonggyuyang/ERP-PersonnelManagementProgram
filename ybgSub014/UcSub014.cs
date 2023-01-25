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

namespace ybgSub014
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
            ct_papp_empno.TextChanged += InputData_TextChanged;
            ct_papp_appno.TextChanged += InputData_TextChanged;
            ct_papp_date.TextChanged += InputData_TextChanged;
            ct_papp_pap.SelectedValueChanged += InputData_TextChanged;
            ct_papp_content.TextChanged += InputData_TextChanged;
            ct_papp_auth.TextChanged += InputData_TextChanged;
            ct_papp_basis.TextChanged += InputData_TextChanged;
            ct_papp_rmk.TextChanged += InputData_TextChanged;
            ct_papp_cont.SelectedValueChanged += InputData_TextChanged;
            ct_papp_pos_cd.TextChanged += InputData_TextChanged;
            ct_papp_dut_cd.TextChanged += InputData_TextChanged;
            ct_papp_dept_cd.TextChanged += InputData_TextChanged;
            ct_papp_pos_nm.SelectedValueChanged += InputData_TextChanged;
            ct_papp_dut_nm.SelectedValueChanged += InputData_TextChanged;
            ct_papp_dept_nm.SelectedValueChanged += InputData_TextChanged;
            //*---Value Changed Event Handler(end)--------------------------
            //*---Validated Event Handler(Start)----------------------------
            ct_papp_empno.Validated += Input_Validation_Check;
            ct_papp_appno.Validated += Input_Validation_Check;
            ct_papp_date.Validated += Input_Validation_Check;
            ct_papp_pap.Validated += Input_Validation_Check;
            ct_papp_content.Validated += Input_Validation_Check;
            ct_papp_auth.Validated += Input_Validation_Check;
            ct_papp_basis.Validated += Input_Validation_Check;
            ct_papp_rmk.Validated += Input_Validation_Check;
            ct_papp_cont.Validated += Input_Validation_Check;
            ct_papp_pos_cd.Validated += Input_Validation_Check;
            ct_papp_dut_cd.Validated += Input_Validation_Check;
            ct_papp_dept_cd.Validated += Input_Validation_Check;
            ct_papp_pos_nm.Validated += Input_Validation_Check;
            ct_papp_dut_nm.Validated += Input_Validation_Check;
            ct_papp_dept_nm.Validated += Input_Validation_Check;
            //*---Validated Event Handler(End)----------------------------
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            q_papp_date2.Text = DateTime.Now.ToShortDateString();

            last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);

            Utility.SetComboWithCdnm(ct_papp_pos_nm, SQLStatement.SelectSQL_ybg_insa_pos);
            Utility.SetComboWithCdnm(ct_papp_dut_nm, SQLStatement.SelectSQL_ybg_insa_dut);
            Utility.SetComboWithCdnm(ct_papp_dept_nm, SQLStatement.SelectSQL_ybg_insa_dept);
            Utility.SetComboWithCdnm(ct_papp_pap, SQLStatement.SelectSQL_ybg_insa_pap);
            Utility.SetComboWithCdnm(pap, SQLStatement.SelectSQL_ybg_insa_pap);
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
                String[] s1 = pap.Text.Split(new char[] { ':' });
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("papp_empno", OracleDbType.Varchar2).Value = q_papp_empno.Text + "%";
                cmd.Parameters.Add("papp_appno", OracleDbType.Varchar2).Value = q_papp_appno.Text + "%";
                cmd.Parameters.Add("PAP", OracleDbType.Varchar2).Value = "%" + s1[0] + "%";
                cmd.Parameters.Add("papp_date1", OracleDbType.Varchar2).Value = Utility.FormatDateR(q_papp_date1.Text);
                cmd.Parameters.Add("papp_date2", OracleDbType.Varchar2).Value = Utility.FormatDateR(q_papp_date2.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)                
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
                    row.Cells["key1"].Value = dr["papp_empno"].ToString();
                    row.Cells["key2"].Value = dr["papp_appno"].ToString();
                    row.Cells["key3"].Value = dr["papp_date"].ToString();
                    row.Cells["key4"].Value = dr["papp_pap"].ToString();
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
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

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
            dataGridView1.Rows[rowIdx].Cells["status"].Value = "A";
            //---추가된 Row로 Focus 이동-------------------------------- 
            Utility.SetFocusingDataGridView(dataGridView1, rowIdx);
            ct_papp_empno.Focus();
            ct_papp_empno.Text = "";
            ct_papp_appno.Text = "";
            ct_papp_date.Text = "";
            ct_papp_pap.Text = "";
            ct_papp_content.Text = "";
            ct_papp_auth.Text = "";
            ct_papp_basis.Text = "";
            ct_papp_rmk.Text = "";
            ct_papp_cont.Text = "";
            ct_papp_pos_cd.Text = "";
            ct_papp_dut_cd.Text = "";
            ct_papp_dept_cd.Text = "";
            ct_papp_pos_nm.Text = "";
            ct_papp_dut_nm.Text = "";
            ct_papp_dept_nm.Text = "";
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
            DialogResult result = MessageBox.Show(row.Cells["papp_empno"].Value +
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
                cmd.Parameters.Add("key3", OracleDbType.Varchar2).Value = row.Cells["key3"].Value;
                cmd.Parameters.Add("key4", OracleDbType.Varchar2).Value = row.Cells["key4"].Value;
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
                    }
                    if (row.Cells["status"].Value.Equals("U"))
                    {
                        cmd.CommandText = SQLStatement.UpdateSQL;
                        cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                        cmd.Parameters.Add("key2", OracleDbType.Varchar2).Value = row.Cells["key2"].Value;
                        cmd.Parameters.Add("key3", OracleDbType.Varchar2).Value = row.Cells["key3"].Value;
                        cmd.Parameters.Add("key4", OracleDbType.Varchar2).Value = row.Cells["key4"].Value;
                    }

                    cmd.Parameters.Add("papp_empno", OracleDbType.Varchar2).Value = row.Cells["papp_empno"].Value;
                    cmd.Parameters.Add("papp_appno", OracleDbType.Varchar2).Value = row.Cells["papp_appno"].Value;
                    cmd.Parameters.Add("papp_date", OracleDbType.Varchar2).Value = Utility.FormatDateR(row.Cells["papp_date"].Value.ToString());
                    cmd.Parameters.Add("papp_pap", OracleDbType.Varchar2).Value = Utility.GetCode(row.Cells["papp_pap"].Value.ToString());
                    cmd.Parameters.Add("papp_content", OracleDbType.Varchar2).Value = row.Cells["papp_content"].Value;
                    cmd.Parameters.Add("papp_auth", OracleDbType.Varchar2).Value = row.Cells["papp_auth"].Value;
                    cmd.Parameters.Add("papp_basis", OracleDbType.Varchar2).Value = row.Cells["papp_basis"].Value;
                    cmd.Parameters.Add("papp_rmk", OracleDbType.Varchar2).Value = row.Cells["papp_rmk"].Value;
                    cmd.Parameters.Add("papp_pos_cd", OracleDbType.Varchar2).Value = row.Cells["papp_pos_cd"].Value;
                    cmd.Parameters.Add("papp_dut_cd", OracleDbType.Varchar2).Value = row.Cells["papp_dut_cd"].Value;
                    cmd.Parameters.Add("papp_dept_cd", OracleDbType.Varchar2).Value = row.Cells["papp_dept_cd"].Value;
                    cmd.Parameters.Add("papp_pos_nm", OracleDbType.Varchar2).Value = row.Cells["papp_pos_nm"].Value;
                    cmd.Parameters.Add("papp_dut_nm", OracleDbType.Varchar2).Value = row.Cells["papp_dut_nm"].Value;
                    cmd.Parameters.Add("papp_dept_nm", OracleDbType.Varchar2).Value = row.Cells["papp_dept_nm"].Value;
                    cmd.Parameters.Add("datasys3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;

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
                row.Cells["key1"].Value = row.Cells["papp_empno"].Value;
                row.Cells["key2"].Value = row.Cells["papp_appno"].Value;
                row.Cells["key3"].Value = row.Cells["papp_date"].Value;
                row.Cells["key4"].Value = row.Cells["papp_pap"].Value;
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

            BtnSearch_Click();
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

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
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

            Input_Validation_Check(sender, e); //*--Control 에 오류메세지 표시

            select_sw = false; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
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
            if (ct_papp_empno.Text == "")
            {
                SetError(ct_papp_empno, "사원번호를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_papp_empno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_papp_appno.Text == "")
            {
                SetError(ct_papp_appno, "인사발령번호를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_papp_appno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (Utility.Check_Date_YYYYMMDD(ct_papp_date.Text) == false)
            {
                SetError(ct_papp_date, "시행일자 날짜형태가 올바르지 않습니다.", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_papp_date, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (ct_papp_pap.Text == "")
            {
                SetError(ct_papp_pap, "발령종류를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_papp_pap, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
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
        #region 인사발령대장 조회
        private void papr_serch_Click(object sender, EventArgs e)
        {
            UcSub014papr_serch frm = new UcSub014papr_serch(this);
            frm.ShowDialog();
        }
        #endregion
        #region 사원번호 조회
        private void bas_serch_Click(object sender, EventArgs e)
        {
            UcSub014bas_serch frm = new UcSub014bas_serch(this);
            frm.ShowDialog();
        }

        #endregion
        #region 직급코드 불러오기
        private void ct_papp_pos_nm_SelectedValueChanged(object sender, EventArgs e)
        {

            con = Utility.SetOracleConnection();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = SQLStatement.SelectSQL_ybg_insa_pos_code;
            cmd.BindByName = true;
            cmd.Parameters.Add("codnm", OracleDbType.Varchar2).Value = ct_papp_pos_nm.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ct_papp_pos_cd.Text = dr["cd_code"].ToString();
            }
            cmd.Parameters.Clear();
        }
        #endregion
        #region 직책코드 불러오기
        private void ct_papp_dut_nm_SelectedValueChanged(object sender, EventArgs e)
        {
            con = Utility.SetOracleConnection();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = SQLStatement.SelectSQL_ybg_insa_dut_code;
            cmd.BindByName = true;
            cmd.Parameters.Add("codnm", OracleDbType.Varchar2).Value = ct_papp_dut_nm.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)                
            if (dr.Read())
            {
                ct_papp_dut_cd.Text = dr["cd_code"].ToString();
            }
            cmd.Parameters.Clear();
        }
        #endregion
        #region 부서코드 불러오기
        private void ct_papp_dept_nm_SelectedValueChanged(object sender, EventArgs e)
        {
            con = Utility.SetOracleConnection();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = SQLStatement.SelectSQL_ybg_insa_dept_code;
            cmd.BindByName = true;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = ct_papp_dept_nm.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)                
            if (dr.Read())
            {
                ct_papp_dept_cd.Text = dr["dept_code"].ToString();
            }
            cmd.Parameters.Clear();
        }
        #endregion
        #region 발령번호에 따른 combobox 활성화
        private void ct_papp_pap_SelectedValueChanged(object sender, EventArgs e)
        {
            ct_papp_pos_nm.Enabled = false;
            ct_papp_dut_nm.Enabled = false;
            ct_papp_dept_nm.Enabled = false;
            ct_papp_cont.Enabled = false;

            if(ct_papp_pap.Text == "01:신규채용")
            {
                ct_papp_pos_nm.Enabled = true;
                ct_papp_dut_nm.Enabled = true;
                ct_papp_dept_nm.Enabled = true;
                ct_papp_cont.Enabled = true;
            } else if(ct_papp_pap.Text == "07:정기승진" || ct_papp_pap.Text == "08:특별승진" || ct_papp_pap.Text == "30:승진")
            {
                ct_papp_pos_nm.Enabled = true;
                ct_papp_dut_nm.Enabled = true;
            } else if(ct_papp_pap.Text == "10:겸직해지" || ct_papp_pap.Text == "11:대기발령" || ct_papp_pap.Text == "12:대기해지")
            {
                ct_papp_dut_nm.Enabled = true;
                ct_papp_dept_nm.Enabled = true;
            } else if(ct_papp_pap.Text == "31:부서이동")
            {
                ct_papp_dept_nm.Enabled = true;
            } else if(ct_papp_pap.Text == "32:직책임명" || ct_papp_pap.Text == "33:직책임면" ||
                      ct_papp_pap.Text == "50:보직임명" || ct_papp_pap.Text == "52:보직해임")
            {
                ct_papp_dut_nm.Enabled = true;
            }        
        }
        #endregion
    }
}
 
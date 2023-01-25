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

namespace ybgSub004
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
        Image img;
        byte[] b;
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
            ct_bas_resno.TextChanged += InputData_TextChanged;
            ct_bas_name.TextChanged += InputData_TextChanged;
            ct_bas_cname.TextChanged += InputData_TextChanged;
            ct_bas_ename.TextChanged += InputData_TextChanged;
            ct_bas_fix.SelectedValueChanged += InputData_TextChanged;
            ct_bas_zip.TextChanged += InputData_TextChanged;
            ct_bas_addr.TextChanged += InputData_TextChanged;
            ct_bas_hdpno.TextChanged += InputData_TextChanged;
            ct_bas_telno.TextChanged += InputData_TextChanged;
            ct_bas_email.TextChanged += InputData_TextChanged;
            ct_bas_mil_sta.SelectedValueChanged += InputData_TextChanged;
            ct_bas_mil_mil.SelectedValueChanged += InputData_TextChanged;
            ct_bas_mil_rnk.SelectedValueChanged += InputData_TextChanged;
            ct_bas_mar.SelectedValueChanged += InputData_TextChanged;
            ct_bas_acc_bank.SelectedValueChanged += InputData_TextChanged;
            ct_bas_acc_name.TextChanged += InputData_TextChanged;
            ct_bas_acc_no.TextChanged += InputData_TextChanged;
            ct_bas_cont.TextChanged += InputData_TextChanged;
            ct_bas_emp_sdate.TextChanged += InputData_TextChanged;
            ct_bas_emp_edate.TextChanged += InputData_TextChanged;
            ct_bas_entdate.TextChanged += InputData_TextChanged;
            ct_bas_resdate.TextChanged += InputData_TextChanged;
            ct_bas_levdate.TextChanged += InputData_TextChanged;
            ct_bas_reidate.TextChanged += InputData_TextChanged;
            ct_bas_dptdate.TextChanged += InputData_TextChanged;
            ct_bas_jkpdate.TextChanged += InputData_TextChanged;
            ct_bas_posdate.TextChanged += InputData_TextChanged;
            ct_bas_wsta.TextChanged += InputData_TextChanged;
            ct_bas_sts.TextChanged += InputData_TextChanged;
            ct_bas_pos.TextChanged += InputData_TextChanged;
            ct_bas_dut.TextChanged += InputData_TextChanged;
            ct_bas_dept.TextChanged += InputData_TextChanged;
            ct_bas_rmk.TextChanged += InputData_TextChanged;
            //*---Value Changed Event Handler(end)--------------------------
            //*---Validated Event Handler(Start)----------------------------
            ct_bas_empno.Validated += Input_Validation_Check;
            ct_bas_resno.Validated += Input_Validation_Check;
            ct_bas_name.Validated += Input_Validation_Check;
            ct_bas_cname.Validated += Input_Validation_Check;
            ct_bas_ename.Validated += Input_Validation_Check;
            ct_bas_fix.Validated += Input_Validation_Check;
            ct_bas_zip.Validated += Input_Validation_Check;
            ct_bas_addr.Validated += Input_Validation_Check;
            ct_bas_hdpno.Validated += Input_Validation_Check;
            ct_bas_telno.Validated += Input_Validation_Check;
            ct_bas_email.Validated += Input_Validation_Check;
            ct_bas_mil_sta.Validated += Input_Validation_Check;
            ct_bas_mil_mil.Validated += Input_Validation_Check;
            ct_bas_mil_rnk.Validated += Input_Validation_Check;
            ct_bas_mar.Validated += Input_Validation_Check;
            ct_bas_acc_bank.Validated += Input_Validation_Check;
            ct_bas_acc_name.Validated += Input_Validation_Check;
            ct_bas_acc_no.Validated += Input_Validation_Check;
            ct_bas_cont.Validated += Input_Validation_Check;
            ct_bas_emp_sdate.Validated += Input_Validation_Check;
            ct_bas_emp_edate.Validated += Input_Validation_Check;
            ct_bas_entdate.Validated += Input_Validation_Check;
            ct_bas_resdate.Validated += Input_Validation_Check;
            ct_bas_levdate.Validated += Input_Validation_Check;
            ct_bas_reidate.Validated += Input_Validation_Check;
            ct_bas_dptdate.Validated += Input_Validation_Check;
            ct_bas_jkpdate.Validated += Input_Validation_Check;
            ct_bas_posdate.Validated += Input_Validation_Check;
            ct_bas_wsta.Validated += Input_Validation_Check;
            ct_bas_sts.Validated += Input_Validation_Check;
            ct_bas_pos.Validated += Input_Validation_Check;
            ct_bas_dut.Validated += Input_Validation_Check;
            ct_bas_dept.Validated += Input_Validation_Check;
            ct_bas_rmk.Validated += Input_Validation_Check;
            //*---Validated Event Handler(End)----------------------------
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(q_bas_dept, SQLStatement.SelectSQL_ybgtinsa_dept);
            Utility.SetComboWithCdnm(q_bas_pos, SQLStatement.SelectSQL_ybgtinsa_pos);

            Utility.SetComboWithCdnm(ct_bas_mil_mil, SQLStatement.SelectSQL_ybgtinsa_mil);
            Utility.SetComboWithCdnm(ct_bas_mil_rnk, SQLStatement.SelectSQL_ybgtinsa_rnk);
            Utility.SetComboWithCdnm(ct_bas_acc_bank, SQLStatement.SelectSQL_ybgtinsa_bnk);
            //*---Combox 에 "" 을 추가
            q_bas_dept.Items.Add("");
            q_bas_pos.Items.Add("");
            ct_bas_fix.Items.Add("");
            ct_bas_mil_sta.Items.Add("");
            ct_bas_mil_mil.Items.Add("");
            ct_bas_mil_rnk.Items.Add("");
            ct_bas_mar.Items.Add("");
            ct_bas_acc_bank.Items.Add("");

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
            ct_pictureBox1.Image = null;
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
                    row.Cells["bas_resno"].Value = dr["bas_resno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["bas_cname"].Value = dr["bas_cname"].ToString();
                    row.Cells["bas_ename"].Value = dr["bas_ename"].ToString();
                    row.Cells["bas_fix"].Value = dr["bas_fix"].ToString();
                    row.Cells["bas_zip"].Value = dr["bas_zip"].ToString();
                    row.Cells["bas_addr"].Value = dr["bas_addr"].ToString();
                    row.Cells["bas_addr2"].Value = dr["bas_addr2"].ToString();
                    row.Cells["bas_hdpno"].Value = dr["bas_hdpno"].ToString();
                    row.Cells["bas_telno"].Value = dr["bas_telno"].ToString();
                    row.Cells["bas_email"].Value = dr["bas_email"].ToString();
                    row.Cells["bas_mil_sta"].Value = dr["bas_mil_sta"].ToString();
                    row.Cells["bas_mil_mil"].Value = dr["bas_mil_mil"].ToString();
                    row.Cells["bas_mil_rnk"].Value = dr["bas_mil_rnk"].ToString();
                    row.Cells["bas_mar"].Value = dr["bas_mar"].ToString();
                    row.Cells["bas_acc_bank"].Value = dr["bas_acc_bank"].ToString();
                    row.Cells["bas_acc_name"].Value = dr["bas_acc_name"].ToString();
                    row.Cells["bas_acc_no"].Value = dr["bas_acc_no"].ToString();
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
            ct_bas_empno.Focus();

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
            ct_pictureBox1.Image = null;
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
            DialogResult result = MessageBox.Show(row.Cells["bas_empno"].Value +
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
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                    Info_Count.Text = dataGridView1.RowCount.ToString();
                    cmd.CommandText = SQLStatement.DeleteIMG;
                    cmd.Parameters.Add("key2", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
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
                    }

                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = row.Cells["bas_empno"].Value;
                    cmd.Parameters.Add("bas_resno", OracleDbType.Varchar2).Value = (row.Cells["bas_resno"].Value.ToString().Replace("-", ""));
                    cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = row.Cells["bas_name"].Value;
                    cmd.Parameters.Add("bas_cname", OracleDbType.Varchar2).Value = row.Cells["bas_cname"].Value;
                    cmd.Parameters.Add("bas_ename", OracleDbType.Varchar2).Value = row.Cells["bas_ename"].Value;
                    cmd.Parameters.Add("bas_fix", OracleDbType.Varchar2).Value = row.Cells["bas_fix"].Value;
                    cmd.Parameters.Add("bas_zip", OracleDbType.Varchar2).Value = row.Cells["bas_zip"].Value;
                    cmd.Parameters.Add("bas_addr", OracleDbType.Varchar2).Value = row.Cells["bas_addr"].Value;
                    cmd.Parameters.Add("bas_addr2", OracleDbType.Varchar2).Value = row.Cells["bas_addr2"].Value;
                    cmd.Parameters.Add("bas_hdpno", OracleDbType.Varchar2).Value = row.Cells["bas_hdpno"].Value;
                    cmd.Parameters.Add("bas_telno", OracleDbType.Varchar2).Value = row.Cells["bas_telno"].Value;
                    cmd.Parameters.Add("bas_email", OracleDbType.Varchar2).Value = row.Cells["bas_email"].Value;
                    cmd.Parameters.Add("bas_mil_sta", OracleDbType.Varchar2).Value = row.Cells["bas_mil_sta"].Value;
                    cmd.Parameters.Add("bas_mil_mil", OracleDbType.Varchar2).Value = Utility.GetCodeNM((string)row.Cells["bas_mil_mil"].Value);
                    cmd.Parameters.Add("bas_mil_rnk", OracleDbType.Varchar2).Value = Utility.GetCodeNM((string)row.Cells["bas_mil_rnk"].Value);
                    cmd.Parameters.Add("bas_mar", OracleDbType.Varchar2).Value = row.Cells["bas_mar"].Value;
                    cmd.Parameters.Add("bas_acc_bank", OracleDbType.Varchar2).Value = Utility.GetCodeNM((string)row.Cells["bas_acc_bank"].Value);
                    cmd.Parameters.Add("bas_acc_name", OracleDbType.Varchar2).Value = row.Cells["bas_acc_name"].Value;
                    cmd.Parameters.Add("bas_acc_no", OracleDbType.Varchar2).Value = row.Cells["bas_acc_no"].Value;
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
                row.Cells["key1"].Value = row.Cells["bas_empno"].Value;
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
            img_search(dataGridView1.CurrentRow.Cells["bas_empno"].Value, ct_pictureBox1);

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
            if (ct_bas_empno.Text == "")
            {
                SetError(ct_bas_empno, "사원코드를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_empno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_resno.Text == "")
            {
                SetError(ct_bas_resno, "주민등록번호를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_resno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_name.Text == "")
            {
                SetError(ct_bas_name, "성명(한글)을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_name, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_cname.Text == "")
            {
                SetError(ct_bas_cname, "성명(한자)을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_cname, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_ename.Text == "")
            {
                SetError(ct_bas_ename, "성명(영어)을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_ename, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (ct_bas_fix.Text == "")
            {
                SetError(ct_bas_fix, "성별을 반드시 선택하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_fix, errorProvider1);
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
        #region 사원사진 등록 Click
        private void Photo_add_Click(object sender, EventArgs e)
        {
            //이미지 불러올때
            String image_file = "";
            //이미지를 선택하기 위한 다이얼로그를 생성
            OpenFileDialog dialog = new OpenFileDialog();

            //파일선택창을 띄울때 c드라이브로 Setting -> 아니면 바탕화면으로 선택됨
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //선택된 파일이름 저장
                image_file = dialog.FileName;

                //선택파일을 image로 변환
                img = Bitmap.FromFile(image_file);

                ImageConverter converter = new ImageConverter();
                b = (byte[])converter.ConvertTo(img, typeof(byte[]));

                if (b.Length >= Math.Pow(2, 10) * 30)
                {
                    MessageBox.Show("30kb 이하의 사진을 등록해주세요.");
                    return; //2의 10승*10 = 10kb
                }
                //PictureBox 컨트롤에 선택한 이미지를 넣습니다.
                ct_pictureBox1.Image = Bitmap.FromFile(image_file);
            }
        }
        #endregion
        #region 사원사진 저장 Click
        private void ct_pic_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.DeleteIMG;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //사진 삭제 후 저장

                cmd.CommandText = SQLStatement.InsertIMG;
                cmd.BindByName = true;
                cmd.Parameters.Add("img_code", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                cmd.Parameters.Add("img_img", OracleDbType.Blob, b.Length, b, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("사진 등록 완료 !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 이미지 Search
        private void img_search(object empno, PictureBox picture)
        {
            //--DB Handling(Start)-------------------------------------            
            picture.Image = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectIMG;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["img_i"] != System.DBNull.Value)
                    {
                        picture.Image = new Bitmap(new MemoryStream(((byte[])dr["img_i"])));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
        }
        #endregion
        #region 도로명 주소찾기 Click
        private void add_btn_Click(object sender, EventArgs e)
        {
            UcSub004Zip frm = new UcSub004Zip(this);
            frm.ShowDialog();
        }
        #endregion
    }
}

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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace ybgSub024
{
    public partial class UserControl1: UserControl
    {
        #region 초기 설정
        OracleConnection con = null;
        private String temp;
        private String temp2;
        private String seq;
        private String cycle;

        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public string UserNm { get; set; }              // 사용자 이름
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태

        public string Copies { get; set; } // 프린터 매수

        public UserControl1()
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(dept, SQLStatement.SelectSQL_ybg_insa_dept);
            Utility.SetComboWithCdnm(pos, SQLStatement.SelectSQL_ybg_insa_pos);

            dept.Items.Add("");
            pos.Items.Add("");

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
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            Utility.BusyIndicator(true);
            //--DB Handling(Start)-------------------------------------
            try
            {
                String[] s1 = dept.Text.Split(new char[] { ':' });
                String[] s2 = pos.Text.Split(new char[] { ':' });
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + s1[0] + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + s2[0] + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["bas_empno"].Value = dr["bas_empno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["dept_name"].Value = dr["dept_name"].ToString();
                    row.Cells["pos_name"].Value = dr["pos_name"].ToString();
                    row.Cells["bas_resno"].Value = dr["bas_resno"].ToString();
                    row.Cells["bas_entdate"].Value = dr["bas_entdate"].ToString();
                    row.Cells["bas_addr"].Value = dr["bas_addr"].ToString();
                    row.Cells["bas_hdpno"].Value = dr["bas_hdpno"].ToString();

                }
                dr.Close();
                /*                OracleDataAdapter da = new OracleDataAdapter(cmd);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "TAB");
                                dataGridView1.DataSource = ds.Tables["TAB"];*/
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
        #region 증명서에 Data 뿌리기
        public void BtnSearch2_Click()
        {
            if (MessageBox.Show(temp + " " + temp2 + " 님의 " + "영문증명서를 발급하시겠습니까?", "주의", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cycle = null;
                seq = null;
                //--DB Handling(Start)-------------------------------------
                try
                {
                    con = Utility.SetOracleConnection();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = SQLStatement.SelectSQL0;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = temp;
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string res = dr["bas_resno"].ToString();
                        res = res.Substring(0, 6) + "-" + res.Substring(6);
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_name", dr["bas_ename"].ToString()));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_resno", res));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_entdate", Utility.FormatDate(dr["bas_entdate"].ToString())));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_pos", dr["bas_pos"].ToString()));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dut", dr["bas_dut"].ToString()));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dept", dr["bas_dept"].ToString()));
                        reportViewer1.LocalReport.SetParameters(new ReportParameter("today", DateTime.Now.ToString("yyyy-MM-dd")));
                    }
                    dr.Close();
                    findCN();
                    insertCeri();
                    this.reportViewer1.RefreshReport();
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
            else
            {
                return;
            }
        }
        #endregion
        #region 시퀀스 증가 후 출력
        public void findCN()
        {
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectCeriNo;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cycle = dr["ceri_no"].ToString(); // 초기화 여부확인용 변수                   
                    seq = dr["ceri_no"].ToString(); // 프린트 후 INSERT 바인드변수용
                }
                dr.Close();
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ceri_no", cycle));
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
        #region 증명서 데이터 삽입
        public void insertCeri()
        {
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQLStatement.InsertSQL;
                cmd.Parameters.Add("ceri_no", OracleDbType.Varchar2).Value = seq;
                cmd.Parameters.Add("ceri_empno", OracleDbType.Varchar2).Value = temp;
                cmd.Parameters.Add("ceri_kind", OracleDbType.Varchar2).Value = "영문";
                cmd.Parameters.Add("ceri_date", OracleDbType.Varchar2).Value = DateTime.Now.ToString("yyyyMMdd");
                cmd.Parameters.Add("ceri_lang", OracleDbType.Varchar2).Value = "영문";
                cmd.Parameters.Add("datesys3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();  //*----반드시 포함
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
        #region 프린트 후 발생 Event
        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            string cnt = reportViewer1.PrinterSettings.Copies.ToString();
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQLStatement.UpdateCNT;
                cmd.Parameters.Add("ceri_no", OracleDbType.Varchar2).Value = seq;
                cmd.Parameters.Add("ceri_cnt", OracleDbType.Varchar2).Value = cnt;
                cmd.Parameters.Add("datasys3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();  //*----반드시 포함  
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
            Info_Message.Text = "증명서가 정상적으로 출력 되었습니다.";
        }
        #endregion
        #region 증명서 발급 버튼 Click
        private void ceri_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row == null) return;
            temp = (String)row.Cells["bas_empno"].Value;
            temp2 = (String)row.Cells["bas_name"].Value;

            BtnSearch2_Click();
        }
        #endregion
        #region 시퀀스 초기화
        public void seq_cycle()
        {

        }
        #endregion
    }
}

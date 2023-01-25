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

namespace ybgSub025
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

        public string Copies { get; set; } // 프린터 매수

        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---Combox 채우기-----------------------------------------------------
            Utility.SetComboWithCdnm(dept, SQLStatement.SelectSQL_ybgtinsa_dept);
            Utility.SetComboWithCdnm(pos, SQLStatement.SelectSQL_ybgtinsa_pos);


            last_button_status = Utility.SetFuncBtn(MainBtn, "0");

            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion
        #region 증명서 발급대장 조회
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
                String[] s1 = dept.Text.Split(new char[] { ':' });
                String[] s2 = pos.Text.Split(new char[] { ':' });
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL0;
                cmd.BindByName = true;
                cmd.Parameters.Add("ceri_empno", OracleDbType.Varchar2).Value = empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + name.Text + "%";
                cmd.Parameters.Add("bas_dept", OracleDbType.Varchar2).Value = "%" + s1[0] + "%";
                cmd.Parameters.Add("bas_pos", OracleDbType.Varchar2).Value = "%" + s2[0] + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["ceri_empno"].Value = dr["ceri_empno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["ceri_no"].Value = dr["ceri_no"].ToString();
                    row.Cells["ceri_kind"].Value = dr["ceri_kind"].ToString();
                    row.Cells["ceri_date"].Value = dr["ceri_date"].ToString();
                    row.Cells["ceri_lang"].Value = dr["ceri_lang"].ToString();
                    row.Cells["ceri_cnt"].Value = dr["ceri_cnt"].ToString();
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
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
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
        #region 증명서 재발급 팝업창 Load
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row == null) return;

            string empno = (String)row.Cells["ceri_empno"].Value;
            string kind = (String)row.Cells["ceri_kind"].Value;
            string no = (String)row.Cells["ceri_no"].Value;
            string date = (String)row.Cells["ceri_date"].Value;

            if (Utility.FormatDate(date) != DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("증명서를 발급한 당일에만 재발급이 가능합니다.");
                return;
            }
            else
            {
                reissue form = new reissue(empno, kind, no);
                form.ShowDialog();
            }
        }
        #endregion
    }
}

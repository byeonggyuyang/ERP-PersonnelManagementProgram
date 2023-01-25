using System;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace ybgMain
{
    public partial class Login : Form
    {
        MainFrm mainFrm;
        private bool chk_userid_save;
        private string saved_userid;
        private OracleConnection con = null;

        public Login(MainFrm _mainFrm)
        {
            InitializeComponent();
            this.mainFrm = _mainFrm;
        }
        #region (Event)프로그램 종료 버튼 Click
        //**************************************************************************
        //-- (Event)프로그램 종료 버튼 Click
        //**************************************************************************
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region (Event)로그인 버튼 Click
        //**************************************************************************
        //-- (Event)로그인 버튼 Click
        //**************************************************************************
        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((tb_userid.Text == "") | (tb_pswd.Text == ""))
            {
                MessageBox.Show("사용자 ID와 비밀번호를 입력하세요.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            /*-----사용자ID 저장 여부에 변경이 있을 때------------------------*/

            bool change_check = false;
            if (cbx_useridSave.Checked != chk_userid_save)
            {
                change_check = true;
            }
            else if ((cbx_useridSave.Checked == true) & (tb_userid.Text != saved_userid))
            {
                change_check = true;
            }
            if (change_check == true)
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    settings["userid"].Value = tb_userid.Text;
                    settings["userid_save"].Value = cbx_useridSave.Checked == true ? "1" : "0";
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*----로그인 인증 (추가 적용 포인트)------------------------------*/
            /*    1. 비밀번호는 SHA-256 일방향암호화로 관리
            /*    2. 계정잠김(사용중지) 관리                          
            /*    3. 계정잠김(비밀번호 5회 오류) 관리                          
            /*    4. 계정잠김(장기미접속 사용자) 관리                          
            /*    5. 동일한 아이디로 중복 로그인 불허용 관리                          
            /*    6. 비밀번호 주기적 변경 관리                          
            /*----로그인 인증 -----------------------------------------------*/
            OracleDataReader dr = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("user_id", OracleDbType.Varchar2).Value = tb_userid.Text;
                dr = cmd.ExecuteReader();
                if (!dr.Read())  //사용자 ID 존재 하지 않으면
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                //---비밀번호 Check-----------------------------------------------------------------------------------------------------/
                if (tb_pswd.Text != dr.GetString(1))
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                mainFrm.UserId = tb_userid.Text;
                mainFrm.UserNm = dr.GetString(0);
                mainFrm.Master = dr.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------

            this.Close();
        }
        #endregion
        #region (Event)로그인 화면이 보여질 때
        //**************************************************************************
        //-- (Event)로그인 화면이 보여질 때
        //**************************************************************************
        private void Login_Shown(object sender, EventArgs e)
        {
            /*------------------------------------------------------------------
               사용자ID 저장여부 Check 
             -------------------------------------------------------------------*/
            string userid_save = ConfigurationManager.AppSettings["userid_save"];
            if (userid_save.Equals("1"))
            {
                cbx_useridSave.Checked = true;
                tb_userid.Text = ConfigurationManager.AppSettings["userid"];
                saved_userid = tb_userid.Text;
                chk_userid_save = true;
                tb_pswd.Focus();
            }
            else
            {
                cbx_useridSave.Checked = false;
                chk_userid_save = false;
                tb_userid.Focus();
            }
        }
        #endregion
    }
}

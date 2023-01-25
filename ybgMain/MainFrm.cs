using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ybgMain
{
    public partial class MainFrm : Form
    {
        //**************************************************************************
        // 전역변수 선언
        //**************************************************************************
        public String UserId;
        public String UserNm;
        public String Master;
        //**************************************************************************
        // 지역변수 선언
        //**************************************************************************
        private string dir = null;
        private string subdir = @"\";
        private string FTP = "10.100.10.1";     //외부화 필요
        Button[] button;
        OracleConnection con;

        Point _imageLocation = new Point(20, 8);
        Point _imgHitArea = new Point(20, 8);
        public MainFrm()
        {
            InitializeComponent();
        }
        #region (Event)메인 프로그램 시작 시
        //**************************************************************************
        //-- (Event)메인 프로그램 시작 시 
        //**************************************************************************
        private void MainFrm_Load(object sender, EventArgs e)
        {
            /*-------------------------------------------------------
              1.메인 시작(메뉴) 프로그램 버전 Check 및 버전 업그레이드
            --------------------------------------------------------*/
            /*-------------------------------------------------------
              2. 시스템 라이브러리 변경 Check 및 다운로드
            --------------------------------------------------------*/
            /*-------------------------------------------------------
              3.사용자 인증/로그인/메인메뉴 생성
            --------------------------------------------------------*/
            new Login(this).ShowDialog();
            this.WindowState = FormWindowState.Maximized;

            MainMenu_Creation();

            /*-기타설정 및 초기화-----------------------------------*/
            tabControl.Padding = new Point(20, 4);
            info_user.Text = String.Format("사용자: {0}({1})", UserNm, UserId);
            info_message.Text = "";
            info_count.Text = "0";
            info_pgmid.Text = "";

            //---2021.03.09-----------------------------------------------------
            ButtonFrm bf = new ButtonFrm() { TopLevel = false, TopMost = true };

            btn_panel.Controls.Add(bf);
            bf.Show();

            button = bf.button;
            bf.tabControl = this.tabControl;
            bf.uc_load_style = "1";
            //---2021.03.09-----------------------------------------------------

            dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }
        #endregion
        #region (Event)메뉴 선택 시(Double Click)
        //**************************************************************************
        //-- (Event)메뉴 선택 시(Double Click)
        //**************************************************************************
        private void tv_MainMenu_DoubleClick(object sender, EventArgs e)
        {
            /*----- Tag 정보--------------------------------------------------------
             * 0: Program Id
             * 1: UserControl Width
             * 2: UserControl Height
             * 3: UserControl Maximize             
             * 4: Program Name             
             * 5: Program Version             
             * 6: 접근권한 여부             
             * 7: 개별 접근권한(CRUD)             
            ----------------------------------------------------------------------*/
            String tag = (String)(sender as TreeView).SelectedNode.Tag;
            if (String.IsNullOrEmpty(tag)) return;

            String[] tag_arr = tag.Split(';');
            if (tag_arr.Length != 8)
            {
                MessageBox.Show("선택된 메뉴에 대한 화면정보가 제대로 입력되지 않았습니다.");
                return;
            }

            //*---기능화면을 윈도우로 실행할지 또는 메인폼으로 삽입할 지 선택
            if (cb_new_window.Checked)
            {
                Load_UserControl2(tag_arr);
            }
            else
            {
                Load_UserControl(tag_arr);
            }
        }
        #endregion
        #region (Event)TapPage Close 버튼 Click
        //**************************************************************************
        //-- (Event)TapPage Close 버튼 Click
        //**************************************************************************
        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {

            TabControl tabControl = (TabControl)sender;
            if (tabControl.SelectedIndex == 0) return;

            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;

            if (r.Contains(p))
            {
                TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                tabControl.TabPages.Remove(tabPage);
            }
        }
        #endregion
        #region 메인메뉴 동적 생성
        //**************************************************************************
        //-- 메인메뉴 동적 생성 
        //**************************************************************************
        private void MainMenu_Creation()
        {
            string kind1 = "";
            string kind2 = "";
            TreeNode tvItem = null;
            TreeNode tvItem1 = null;
            TreeNode tvItem2 = null;
            tv_MainMenu.Nodes.Clear();
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                if (con == null) return;
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL3;
                cmd.Parameters.Add("pgm_use", OracleDbType.Varchar2).Value = "Y";
                cmd.Parameters.Add("pgm_name", OracleDbType.Varchar2).Value = "%";
                cmd.Parameters.Add("auth_userid", OracleDbType.Varchar2).Value = UserId;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string pgm_id = dr.GetString(0);
                    string pgm_name = dr.GetString(1);
                    string pgm_kind1 = dr.GetString(2);
                    string pgm_kind2 = dr.GetString(3);
                    string pgm_dllname = dr.GetString(4);
                    string pgm_pi = dr.GetString(5);
                    string pgm_ver = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    int pgm_width = dr.IsDBNull(7) ? 1024 : dr.GetInt32(7);
                    int pgm_height = dr.IsDBNull(8) ? 768 : dr.GetInt32(8);
                    string pgm_maximize = dr.GetString(9);
                    string auth_access = dr.IsDBNull(10) ? "0" : "1";
                    string auth_all = dr.IsDBNull(11) ? "0" : dr.GetString(11);
                    string auth_read = dr.IsDBNull(12) ? "0" : dr.GetString(12);
                    string auth_insert = dr.IsDBNull(13) ? "0" : dr.GetString(13);
                    string auth_update = dr.IsDBNull(14) ? "0" : dr.GetString(14);
                    string auth_delete = dr.IsDBNull(15) ? "0" : dr.GetString(15);
                    string auth_print = dr.IsDBNull(16) ? "0" : dr.GetString(16);
                    string pgm_auth = dr.GetString(17);
                    string wk_auth = auth_read + "*" + auth_insert + "*" + auth_update + "*" + auth_delete + "*" + auth_print;
                    /*--마스터 권한-----------------------------------*/
                    if (Master.Equals("Y"))
                    {
                        auth_access = "1";
                        auth_all = "1";
                    }
                    /*--ALL 권한--------------------------------------*/
                    if (auth_all.Equals("1"))
                    {
                        wk_auth = "1*1*1*1*1";
                    }
                    /*--사용권한 관리대상이 아니면--------------------------------------*/
                    if (pgm_auth.Equals("N"))
                    {
                        auth_access = "1";
                        wk_auth = "1*1*1*1*1";
                    }

                    tvItem = new TreeNode();
                    tvItem.Text = pgm_name;
                    if (pgm_ver != "")
                    {
                        tvItem.Tag = pgm_id + ";" +
                                     pgm_width.ToString() + ";" +
                                     pgm_height.ToString() + ";" +
                                     pgm_maximize + ";" +
                                     pgm_name + ";" +
                                     pgm_ver + ";" +
                                     auth_access + ";" +
                                     wk_auth;
                        if (auth_access.Equals("0"))
                        {
                            tvItem.Tag = "";
                            tvItem.ForeColor = Color.LightGray;
                        }
                    }
                    else
                    {
                        tvItem.Tag = "";
                        tvItem.ForeColor = Color.LightGray;
                    }
                    if (kind1 != pgm_kind1)
                    {
                        tvItem1 = new TreeNode();
                        tvItem1.Text = pgm_kind1;
                        tv_MainMenu.Nodes.Add(tvItem1);
                        kind1 = pgm_kind1;
                    }
                    if (pgm_kind2 == "*")
                    {
                        tvItem1.Nodes.Add(tvItem);
                        continue;
                    }
                    if ((kind2 != pgm_kind2))
                    {
                        tvItem2 = new TreeNode();
                        tvItem2.Text = pgm_kind2;
                        tvItem1.Nodes.Add(tvItem2);
                        kind2 = pgm_kind2;
                    }
                    tvItem2.Nodes.Add(tvItem);
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
        }
        #endregion
        #region 초기설정값 Reflection to Loading UserControl
        //**************************************************************************
        //-- 초기설정값 Reflection to Loading UserControl
        //**************************************************************************
        private void InitialValue_Reflection_to_UserControl(UserControl uc)
        {
            Type type = uc.GetType();

            type.GetProperty("MainBtn")?.SetValue(uc, button);
            type.GetProperty("UserId")?.SetValue(uc, UserId);
            type.GetProperty("UserNm")?.SetValue(uc, UserNm);
            type.GetProperty("Info_Count")?.SetValue(uc, info_count);
            type.GetProperty("Info_Message")?.SetValue(uc, info_message);
        }
        #endregion
        #region 메뉴 선택에 따른 해당 UserControl Load
        //**************************************************************************
        //-- 메뉴 선택에 따른 해당 UserControl Load 
        //**************************************************************************
        //*-------------------------------------------------------------------------
        //* 1. 메인 메뉴에 삽입하는 형태로 UserControl Load 
        //*-------------------------------------------------------------------------
        private void Load_UserControl(String[] tag_arr)
        {
            //*-------------------------------------------------------------------------
            //* 버전변경 Check 및 자동 업그레이드
            //*-------------------------------------------------------------------------
            try
            {
                FileVersionInfo myVersion = FileVersionInfo.GetVersionInfo(dir + subdir + tag_arr[0] + ".dll");
                if (!myVersion.FileVersion.Equals(tag_arr[5]))
                {
                    Utility.VersionAutoUpgrade(FTP, dir + subdir, tag_arr[0] + ".dll",
                                               "해당 단위업무파일의 버전이 변경되었습니다. 다운로드를 진행합니다.");
                    return;
                }
            }
            catch (FileNotFoundException)
            {
                Utility.VersionAutoUpgrade(FTP, dir + subdir, tag_arr[0] + ".dll",
                                           "해당 단위업무 파일이 PC에 존재하지 않습니다. 서버에서 다운로드를 진행합니다.");
                return;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error 발생 : " + exc.ToString());
                return;
            }
            //*-------------------------------------------------------------------------
            //* 단위업무 DLL Check 및 프로그램 로드
            //*-------------------------------------------------------------------------
            UserControl uc = Utility.TryLoad_UserControl_ByName(dir + subdir, tag_arr[0]);
            if (uc == null) return;

            //*-------------------------------------------------------------------------
            //* Loading UserControl에 초기값 전달
            //*-------------------------------------------------------------------------
            InitialValue_Reflection_to_UserControl(uc);

            if (tag_arr[3].Equals("Y"))
            {
                uc.Dock = DockStyle.Fill;
            }

            //---이미 존재하면, TabPage Activate (2020.11.30 Add)
            TabPage tabPage = tabControl.TabPages[tag_arr[4]];
            if (tabPage != null)
            {
                tabControl.SelectTab(tabPage);
                return;
            }

            tabControl.TabPages.Add(tag_arr[4], tag_arr[4]);
            tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(uc);
            tabControl.SelectTab(tabControl.TabPages.Count - 1);

            uc.Tag = tag_arr[0];
            info_pgmid.Text = tag_arr[0];
            info_message.Text = "";
            info_count.Text = "0";

        }
        //*-------------------------------------------------------------------------
        //* 2. 별도의 창으로 띄우는 형태로 UserControl Load
        //*-------------------------------------------------------------------------
        private void Load_UserControl2(String[] tag_arr)
        {
            var launcher = new Launcher();
            launcher.UserId = this.UserId;
            launcher.Dir = dir + subdir;
            launcher.LoadingPgmId = tag_arr[0];
            launcher.LoadingPgmName = tag_arr[4];
            launcher.Version = tag_arr[5];
            launcher.FTP = FTP;
            if (tag_arr[3].Equals("Y"))
            {
                launcher.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            launcher.Width = Convert.ToInt32(tag_arr[1]) + 25;
            launcher.Height = Convert.ToInt32(tag_arr[2]) + 90 + 47;
            launcher.Show();
        }
        #endregion
        #region TapControl-> TabPage Header에 이미지 그리기
        //**************************************************************************
        //-- TapControl-> TabPage Header에 이미지 그리기   
        //**************************************************************************
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle r = e.Bounds;
            r = this.tabControl.GetTabRect(e.Index);
            r.Offset(5, 5);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

            if (e.Index == 0) return;
            if (e.Index != this.tabControl.SelectedIndex) return;  //선택된 Page에서만 Close Image 표시

            Image img = new Bitmap(Properties.Resources.close);
            e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }
        #endregion
        #region TapPage가 선택될 때, 각 페이지에 따라 버튼 제어를 달리한다
        //**************************************************************************
        //-- TapPage가 선택될 때, 각 페이지에 따라 버튼 제어를 달리한다 
        //**************************************************************************
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedIndex == 0) //--Home TabPage 면 
            {
                Utility.SetFuncBtn2(button, "0000000");
                return;
            }

            UserControl uc = (UserControl)tabControl.SelectedTab.Controls[0];
            Type type = uc.GetType();

            PropertyInfo pi = type.GetProperty("last_button_status");
            if (pi != null)
            {
                Utility.SetFuncBtn2(button, pi.GetValue(uc) as String);
            }
        }
        #endregion
    }
}

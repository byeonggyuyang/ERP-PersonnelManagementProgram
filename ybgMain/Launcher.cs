using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ybgMain
{
    public partial class Launcher : Form
    {
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public string LoadingPgmId;     // Loading 프로그램 Id
        public string LoadingPgmName;   // Loading 프로그램 이름
        public string UserId;           // 사용자 ID
        public string UserNm;           // 사용자 이름
        public string Dir;              // DLL 폴더위치
        public string Version;          // 프로그램 버전정보
        public string FTP;              // FTP 서버 정보
        //************************************************************
        // 로컬변수 선언
        //************************************************************
        private UserControl uc;
        Button[] button;

        public Launcher()
        {
            InitializeComponent();
        }
        #region (Event)Form Load 시
        //**************************************************************************
        // (Event)Form(론처) Load 시
        //**************************************************************************
        private void Launcher_Load(object sender, EventArgs e)
        {
            //---2021.03.09-----------------------------------------------------
            ButtonFrm bf = new ButtonFrm() { TopLevel = false, TopMost = true };

            btn_panel.Controls.Add(bf);
            bf.Show();

            bf.uc_panel = pnl_form;
            button = bf.button;
            bf.uc_launcher = this;
            bf.uc_load_style = "2";
            //---2021.03.09-----------------------------------------------------

            //*-------------------------------------------------------------------------
            //* 버전변경 Check 및 자동 업그레이드
            //*-------------------------------------------------------------------------
            try
            {
                FileVersionInfo myVersion = FileVersionInfo.GetVersionInfo(Dir + LoadingPgmId + ".dll");
                if (!myVersion.FileVersion.Equals(Version))
                {
                    this.Hide();
                    Utility.VersionAutoUpgrade(FTP, Dir, LoadingPgmId + ".dll",
                                               "해당 단위업무파일의 버전이 변경되었습니다. 다운로드를 진행합니다.");
                    this.Close();
                    return;
                }
            }
            catch (FileNotFoundException)
            {
                this.Hide();
                Utility.VersionAutoUpgrade(FTP, Dir, LoadingPgmId + ".dll",
                                           "해당 단위업무 파일이 PC에 존재하지 않습니다. 서버에서 다운로드를 진행합니다.");
                this.Close();
                return;
            }
            catch (Exception exc)
            {
                this.Hide();
                MessageBox.Show("Error 발생 : " + exc.ToString());
                this.Close();
                return;
            }
            //*-------------------------------------------------------------------------
            //* 단위업무 DLL Check 및 프로그램 로드
            //*-------------------------------------------------------------------------
            uc = Utility.TryLoad_UserControl_ByName(Dir, LoadingPgmId);
            if (uc == null)
            {
                this.Close();
                return;
            }
            //*-------------------------------------------------------------------------
            //* Loading UserControl에 초기값 전달
            //*-------------------------------------------------------------------------
            InitialValue_Reflection_to_Form(uc);

            pnl_form.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

            this.Text = LoadingPgmName;

            info_pgmid.Text = LoadingPgmId;
            info_message.Text = "";
            info_count.Text = "0";
        }
        #endregion
        #region 초기설정값 Reflection to Loading UserControl
        //**************************************************************************
        //-- 초기설정값 Reflection to Loading USerControl
        //**************************************************************************
        private void InitialValue_Reflection_to_Form(UserControl uc)
        {
            Type type = uc.GetType();

            type.GetProperty("MainBtn")?.SetValue(uc, button);
            type.GetProperty("UserId")?.SetValue(uc, UserId);
            type.GetProperty("UserNm")?.SetValue(uc, UserNm);
            type.GetProperty("Info_Count")?.SetValue(uc, info_count);
            type.GetProperty("Info_Message")?.SetValue(uc, info_message);
        }
        #endregion
    }
}

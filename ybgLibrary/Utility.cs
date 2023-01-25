using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Net;
using System.Net.Sockets;

namespace ybgLibrary
{
    public class Utility
    {
        //****************************************************************************
        // 콘트롤의 Tag를 활용하여, 자동화된 일괄처리에서 예외 처리가 가능하도록 한다.
        //****************************************************************************
        // tag 정보 (1:0:0:1.....)  1 => 예외처리
        // 1. Control ReadOnly or Enabled 예외  
        // 2. Control Text = "" 예외  
        //****************************************************************************
        #region  Oracle Database Connection
        //************************************************************
        //** Oracle Database Connection
        //************************************************************
        static public OracleConnection SetOracleConnection()
        {
            OracleConnection con = null;
            try
            {
                string connectString = "Data Source = 222.237.134.74:1522/ora7; User Id=edu; Password=edu1234";
                con = new OracleConnection(connectString);
                con.Open();
                return con;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return null;
            }
        }
        #endregion
        #region  클라이언트 IP 주소 알아내기
        //************************************************************
        //** 클라이언트 IP 주소 알아내기
        //************************************************************
        static public string MyIpAddress
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string ClientIP = string.Empty;
                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ClientIP = host.AddressList[i].ToString();
                    }
                }
                return ClientIP;
            }
        }
        #endregion
        #region ComboBox 를 코드 값으로 채우기(코드:코드명칭)
        //************************************************************
        //** ComboBox 를 코드 값으로 채우기(코드:코드명칭)
        //************************************************************
        static public void SetComboWithCdnm(ComboBox cb, string sql)
        {
            OracleConnection con = null;
            try
            {
                con = SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                OracleDataReader dr = cmd.ExecuteReader();
                cb.Items.Clear();
                cb.Items.Add("");
                while (dr.Read())
                {
                    cb.Items.Add(dr.GetString(0));
                }
                dr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
        }
        #endregion
        #region 기능버튼 제어하기(활성화/비활성화)
        //************************************************************
        //** 기능버튼 제어하기
        //************************************************************
        static public string SetFuncBtn(Button[] btn, string func)
        {
            if (btn.Length == 0) return "";
            //*****************************************************************
            //* 0: 조회, 1:입력, 2:수정, 3:삭제, 4:저장, 5:취소, 6:인쇄
            //*****************************************************************
            string wk_func = "0000000";

            if (func.Equals("0")) wk_func = "1000000";   //*---조회 Only 버튼 상태            
            if (func.Equals("E")) wk_func = "0000000";   //*---Only 종료 버튼 상태
            if (func.Equals("P")) wk_func = "1000001";   //*---조회 후 인쇄/엑셀 가능 상태
            if (func.Equals("1")) wk_func = "1100000";   //*---기본 상태
            if (func.Equals("2")) wk_func = "1101001";   //*---조회 후
            if (func.Equals("3")) wk_func = "0101110";   //*---수정 및 추가 후
            if (func.Equals("4")) wk_func = "1000110";   //*---조회 후 수정 발생(추가는 없음)
            if (func.Equals("EX1")) wk_func = "0000000";   //*---엑셀 Import 前

            SetFuncBtn2(btn, wk_func);
            return wk_func;
        }
        static public string SetFuncBtn2(Button[] btn, string func)
        {
            if (btn.Length == 0) return "";
            if (string.IsNullOrEmpty(func)) return "";
            if (func.Length != 7) return "";
            //*****************************************************************
            //* 0: 조회, 1:입력, 2:수정, 3:삭제, 4:저장, 5:취소, 6:인쇄
            //*****************************************************************
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(func);
            for (int i = 0; i < bytes.Length; i++)
            {
                btn[i].Enabled = bytes[i] == '1' ? true : false;
            }
            return func;
        }
        #endregion
        #region 이름으로 Form Instance(Object)  생성
        //**************************************************************************
        //-- 이름으로 Form Instance(Object)  생성 
        //**************************************************************************
        static public Form TryGetFormByName(string frmname)
        {
            Type formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name == frmname)
                .FirstOrDefault();

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (Form)Activator.CreateInstance(formType);
        }
        #endregion
        #region 이름으로 UserControl Load from DLL and Instance(Object)  생성
        //**************************************************************************
        //-- 이름으로 UserControl Load from DLL and Instance(Object)  생성 
        //**************************************************************************
        static public UserControl TryLoad_UserControl_ByName(string dir, string ucName)
        {
            Assembly ass;
            try
            {
                ass = Assembly.LoadFile(dir + ucName + ".dll");
            }
            catch
            {
                MessageBox.Show("해당 단위업무 파일이 존재하지 않습니다.");
                return null;
            }
            Type vType = ass.GetType(ucName + ".UserControl1");
            if (vType == null)
            {
                //this.Hide();
                MessageBox.Show("해당업무 화면명이 올바르게 지정되지 않았습니다.");
                //this.Close();
                return null;
            }
            return Activator.CreateInstance(vType) as UserControl;
        }
        #endregion
        #region  작업진행 중(Mouse Cursor = "WAIT")
        //************************************************************
        //**  작업진행 중(Mouse Cursor = "WAIT")
        //************************************************************
        static public void BusyIndicator(bool onoff)
        {
            if (onoff)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.AppStarting;
            }
        }
        #endregion
        #region DataGridView Scrolling 속도 향상 
        //************************************************************
        //** DataGridView Scrolling 속도 향상
        //************************************************************
        static public void DataGridView_Scrolling_SpeedUp(DataGridView dgv)
        {
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgv.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, true, null);
            }
        }
        #endregion
        #region DataGridView Select & Focusing (DataGridView 적용)
        //************************************************************
        //** DataGridView Select & Focusing (DataGrid 적용)
        //************************************************************
        static public void SetFocusingDataGridView(DataGridView dgv, int rowIndex)
        {
            dgv.CurrentCell = dgv.Rows[rowIndex].Cells[0];
        }
        #endregion
        #region Date 유효성 Check( yyyy-mm-dd)
        //************************************************************
        //** Date 유효성 Check( yyyy-mm-dd)
        //************************************************************
        static public bool Check_Date_YYYYMMDD(String ymd)
        {
            if (String.IsNullOrEmpty(ymd)) return true;
            if (ymd.Replace(" ", "").Equals("--")) return true;

            try
            {
                DateTime.ParseExact(ymd, "yyyy-MM-dd", null);
            }
            catch
            {
                return false;
            }

            return true;
        }
        static public bool Check_Date_YYYYMM(String ymd)
        {
            if (String.IsNullOrEmpty(ymd)) return true;
            if (ymd.Replace(" ", "").Equals("-")) return true;

            try
            {
                DateTime.ParseExact(ymd, "yyyy-MM", null);
            }
            catch
            {
                return false;
            }

            return true;
        }
        static public bool Check_Date_IsEmpty(String ymd)
        {
            if (String.IsNullOrEmpty(ymd)) return true;
            if (ymd.Replace(" ", "").Equals("--")) return true;

            return false;
        }
        #endregion
        #region Controls on Panel to set readonly (true/false)   
        //************************************************************
        //** Controls on Panel to set readonly (true/false)
        //************************************************************
        static public void SetReadOnly(Control panel, bool isReadOnly)
        {
            foreach (Control ctl in panel.Controls)
            {
                //*--예외처리-(설정에서 제외)-----------------------------
                if ((ctl is Label)) continue;
                if (!String.IsNullOrEmpty(ctl.Tag as String))
                {
                    String tag = ctl.Tag as String;
                    String[] arr_tag = tag.Split(':');
                    if (arr_tag.Length > 0)
                    {
                        if (arr_tag[0] == "1") continue;
                    }
                }
                if ((ctl is GroupBox) || (ctl is Panel) || (ctl is TableLayoutPanel))
                {
                    //*---Recursive Call----------------------------------
                    SetReadOnly(ctl, isReadOnly);
                    continue;
                }
                //*-------------------------------------------------------
                Type type = ctl.GetType();
                PropertyInfo pi = type.GetProperty("ReadOnly");
                if (pi != null)
                {
                    pi.SetValue(ctl, isReadOnly);
                    continue;
                }
                pi = type.GetProperty("Enabled");
                if (pi != null)
                {
                    pi.SetValue(ctl, !isReadOnly);
                }
            }
        }
        #endregion
        #region Control.Text Property = ""   
        //************************************************************
        //** Control.Text Property = ""
        //************************************************************
        static public void SetTextNull(Control panel)
        {
            Type type;
            PropertyInfo pi;
            foreach (Control ctl in panel.Controls)
            {
                //*--예외처리-(설정에서 제외)-----------------------------
                if (!String.IsNullOrEmpty(ctl.Tag as String))
                {
                    String tag = ctl.Tag as String;
                    String[] arr_tag = tag.Split(':');
                    if (arr_tag.Length > 1)
                    {
                        if (arr_tag[1] == "1") continue;
                    }
                }
                if ((ctl is GroupBox) || (ctl is Panel) || (ctl is TableLayoutPanel))
                {
                    //*---Recursive Call----------------------------------
                    SetTextNull(ctl);
                    continue;
                }
                type = ctl.GetType();
                if ((ctl is TextBox) || (ctl is ComboBox) || (ctl is MaskedTextBox))
                {
                    pi = type.GetProperty("Text");
                    if (pi != null)
                    {
                        pi.SetValue(ctl, String.Empty);
                        continue;
                    }
                }
                else if ((ctl is CheckBox))
                {
                    pi = type.GetProperty("Checked");
                    if (pi != null)
                    {
                        pi.SetValue(ctl, false);
                        continue;
                    }
                }
                //*-------------------------------------------------------
            }
        }
        #endregion
        #region Control.Text set with Selected DataGridViewRow   
        //************************************************************
        //** Control.Text set with Selected DataGridViewRow
        //************************************************************
        static public void SetValueToGridView(DataGridView dgv, Control ctl)
        {
            DataGridViewRow row = dgv.CurrentRow;
            if (row == null) return;

            string col_name = ctl.Name.Substring(3);

            Type type = ctl.GetType();
            PropertyInfo pi = null;
            if (ctl is CheckBox)
            {
                pi = type.GetProperty("Checked");
                if (pi != null)
                {
                    row.Cells[col_name].Value = pi.GetValue(ctl);
                }
                return;
            }
            pi = type.GetProperty("Text");
            if (pi != null)
            {
                //*--숫자 포맷이면, Control Text를 숫자로 변환하여 Assign 해야 Format이 적용된다.
                if (dgv.Columns[col_name].DefaultCellStyle.Format != "")
                {
                    string fm = dgv.Columns[col_name].DefaultCellStyle.Format.Substring(0, 1).ToUpper();
                    if (fm == "N")
                    {
                        try
                        {
                            row.Cells[col_name].Value = (String)pi.GetValue(ctl) == "" ? 0 : Convert.ToDecimal(pi.GetValue(ctl));
                        }
                        catch
                        {
                            row.Cells[col_name].Value = 0;
                        }
                    }
                    return;
                }
                row.Cells[col_name].Value = pi.GetValue(ctl);
                return;
            }
        }
        #endregion
        #region Selected DataGridViewRow set to Control.Text   
        //************************************************************
        //** Selected DataGridViewRow set to Control.Text   
        //************************************************************
        static public void SetValueToControlFromGridView(DataGridView dgv, Control control)
        {
            if (dgv.SelectedRows.Count == 0) return;

            Type type;
            PropertyInfo pi;
            Control ctl;
            for (int col = 0; col < dgv.ColumnCount; col++)
            {
                ctl = GetControlByName(control, dgv.Columns[col].Name);

                if (ctl == null) continue;

                type = ctl.GetType();
                pi = null;
                if (ctl is CheckBox)
                {
                    pi = type.GetProperty("Checked");
                    if (pi != null)
                    {
                        pi.SetValue(ctl, dgv.SelectedRows[0].Cells[col].Value);
                    }
                    continue;
                }
                pi = type.GetProperty("Text");
                if (pi != null)
                {
                    pi.SetValue(ctl, dgv.SelectedRows[0].Cells[col].Value?.ToString()); // Cell이 Number Format일때 Control에 String으로 Assign
                }
            }
        }
        static private Control GetControlByName(Control control, String col_name)
        {
            string ctl_name = "ct_" + col_name;

            Control[] ctl = control.Controls.Find(ctl_name, true);
            return ctl.Length == 0 ? null : ctl[0];
        }
        #endregion
        #region 날짜 텍스트 형식 변경 (yyyymmdd <-> yyyy-mm-dd)
        //************************************************************
        //** 날짜 텍스트 형식 변경 (yyyymmdd <-> yyyy-mm-dd)
        //************************************************************
        static public string FormatDate(string ymd)
        {
            if (string.IsNullOrEmpty(ymd)) return "";
            if (ymd.Length != 8) return "";
            return string.Concat(ymd.Substring(0, 4), "-",
                                 ymd.Substring(4, 2), "-",
                                 ymd.Substring(6, 2));
        }
        static public string FormatDate(string ymd, string format)
        {
            if (string.IsNullOrEmpty(ymd)) return "";
            if (ymd.Length != 8) return "";
            return string.Concat(ymd.Substring(0, 4), format,
                                 ymd.Substring(4, 2), format,
                                 ymd.Substring(6, 2));
        }
        static public string FormatDateR(string ymd)
        {
            if (string.IsNullOrEmpty(ymd)) return "";
            if (ymd.Length != 10) return "";
            return ymd.Replace("-", "").Replace(" ", "");
        }
        static public string FormatDateR(string ymd, string format)
        {
            if (string.IsNullOrEmpty(ymd)) return "";
            if (ymd.Length != 10) return "";
            return ymd.Replace(format, "").Replace(" ", "");
        }
        #endregion
        #region Bool <-> Text ('1','0'/'Y','N')
        //************************************************************
        //** Bool <-> Text ('1','0'/'Y','N')
        //************************************************************
        static public bool ChangeBoolType(string text)
        {
            if (text == null) return false;
            if (text == "") return false;
            if (text == "0") return false;
            if (text == "N") return false;
            return true;
        }
        static public string ChangeBoolType(object val, string type)
        {
            if (type == "YN")
            {
                if (val == null) return "N";
                if ((bool)val) return "Y";
                else return "N";
            }
            else if (type == "10")
            {
                if (val == null) return "0";
                if ((bool)val) return "1";
                else return "0";
            }
            return "";
        }
        #endregion
        #region 입력값 정합성 Check
        //************************************************************
        //** 입력값의 정합성 Check
        //************************************************************
        static public Boolean InputErrorCheck(DataGridView view)
        {
            foreach (DataGridViewRow row in view.Rows)
            {
                if (String.IsNullOrEmpty(row.ErrorText) == false)
                {
                    MessageBox.Show("저장할 자료에 오류가 있습니다.", "오류확인", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region 코드 + ":" + 코드명칭에서 코드 분리
        //************************************************************
        //** 코드 + ":" + 코드명칭에서 코드 분리
        //************************************************************
        static public string GetCode(string codenm)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            string[] cd = codenm.Split(':');
            if (cd.Length == 0) return "";
            return cd[0];
        }
        static public string GetCode(string codenm, char dlm)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            string[] cd = codenm.Split(dlm);
            if (cd.Length == 0) return "";
            return cd[0];
        }
        static public string SetCode(string codenm)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            if (codenm == ":") return "";
            return codenm;
        }
        static public string GetCodeSplit(string codenm, int pos)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            string[] cd = codenm.Split(':');
            if (cd.Length == 0) return "";
            return cd[pos - 1];
        }
        #endregion
        #region 코드 + ":" + 코드명칭에서 명칭 분리
        //************************************************************
        //** 코드 + ":" + 코드명칭에서 명칭 분리
        //************************************************************
        static public string GetCodeNM(string codenm)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            string[] cd = codenm.Split(':');
            if (cd.Length == 0) return "";
            return cd[1];
        }
        static public string GetCodeNM(string codenm, char dlm)
        {
            if (string.IsNullOrEmpty(codenm)) return "";
            string[] cd = codenm.Split(dlm);
            if (cd.Length == 0) return "";
            return cd[1];
        }
        #endregion
        #region TextBox에서 숫자 천단위 Comma 설정 
        //************************************************************
        //** TextBox에서 숫자 천단위 Comma 설정 
        //************************************************************
        static public void Get_1000_Comma(TextBox textBox, string format)
        {
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:" + format + "}", value);
            else
                textBox.Text = String.Empty;
        }
        #endregion
       /* #region  코드검색 윈도우 보여주기
        //************************************************************
        //**  코드검색 윈도우 보여주기
        //************************************************************
        static public bool ShowSearchCDWindow(string sql, string caption, out string result)
        {
            var win = new SearchCDWindow(sql);
            win.Text = caption;
            if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                result = win.GetResult;
                win.Dispose();
                return true;
            }
            else
            {
                result = "";
                win.Dispose();
                return false;
            }
        }
        #endregion*/
        #region  주민등록번호 검증
        //************************************************************
        //**  주민등록번호 검증 
        //************************************************************
        static public bool IsValid_ResNo(string RRN)
        {
            RRN = RRN.Replace(" ", "");
            RRN = RRN.Replace("-", "");
            if (RRN.Length != 13)
            {
                return false;
            }
            if (rrn_Check(RRN) || fgn_Check(RRN))
                return true;
            return false;
        }
        //*--주민등록번호 Check----------------
        static bool rrn_Check(string RRN)
        {
            RRN = RRN.Replace(" ", "");
            RRN = RRN.Replace("-", "");
            if (RRN.Length != 13)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < RRN.Length - 1; i++)
            {
                char c = RRN[i];
                if (!char.IsNumber(c))
                {
                    return false;
                }
                else
                {
                    if (i < RRN.Length)
                    {
                        sum += int.Parse(c.ToString()) * ((i % 8) + 2);
                    }
                }
            }
            if (!((((11 - (sum % 11)) % 10).ToString()) == ((RRN[RRN.Length - 1]).ToString())))
            {
                return false;
            }
            return true;
        }
        //*--외국인 등록번호 Check----------------
        static bool fgn_Check(string s_rrn)
        {
            int sum = 0;
            if (int.Parse(s_rrn.Substring(7, 2)) % 2 != 0)
            {
                return false;
            }
            for (int i = 0; i < 12; i++)
            {
                sum += int.Parse(s_rrn.Substring(i, 1)) * ((i % 8) + 2);
            }
            if ((((11 - (sum % 11)) % 10 + 2) % 10) == int.Parse(s_rrn.Substring(12, 1)))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

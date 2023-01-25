using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ybgLibrary;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Reporting.WinForms;

namespace ybgSub025
{
    public partial class reissue : Form
    {
        #region 초기 설정
        OracleConnection con = null;
        private string empno;
        private string kind;
        private string no;

        public reissue(string empno, string kind, string no)
        {
            InitializeComponent();
            this.empno = empno;
            this.kind = kind;
            this.no = no;
        }
        #endregion
        #region 증명서 종류 구분
        private void reissue_Load(object sender, EventArgs e)
        {
            if (kind == "재직")
            {
                P_report();
            }
            else if (kind == "경력")
            {
                C_report();
            }
            else if (kind == "영문")
            {
                E_report();
            }
            this.reportViewer1.RefreshReport();
        }
        #endregion
        #region 재직 증명서 재발급
        public void P_report()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ybgSub025.Report1.rdlc";
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                cmd.Parameters.Add("ceri_no", OracleDbType.Varchar2).Value = no;
                cmd.Parameters.Add("ceri_kind", OracleDbType.Varchar2).Value = kind;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("ceri_no", no));
                    string res = dr["bas_resno"].ToString();
                    res = res.Substring(0, 6) + "-" + res.Substring(6);
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_name", dr["bas_name"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_addr", dr["bas_addr"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_entdate", Utility.FormatDate(dr["bas_entdate"].ToString())));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_resno", res));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_pos", dr["bas_pos"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dut", dr["bas_dut"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dept", dr["bas_dept"].ToString()));
                    string ymd = DateTime.Now.ToString("yyyy-MM-dd");
                    ymd = ymd.Substring(0, 4) + "-" + ymd.Substring(5, 2) + "-" + ymd.Substring(8, 2) + "-";
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("today", ymd));
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
        }
        #endregion
        #region 경력 증명서 재발급
        public void C_report()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ybgSub025.Report2.rdlc";
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_C;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                cmd.Parameters.Add("ceri_no", OracleDbType.Varchar2).Value = no;
                cmd.Parameters.Add("ceri_kind", OracleDbType.Varchar2).Value = kind;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("ceri_no", no));
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
        #region 영문 증명서 재발급
        public void E_report()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ybgSub025.Report3.rdlc";
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL_E;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
                cmd.Parameters.Add("ceri_no", OracleDbType.Varchar2).Value = no;
                cmd.Parameters.Add("ceri_kind", OracleDbType.Varchar2).Value = kind;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string res = dr["bas_resno"].ToString();
                    res = res.Substring(0, 6) + "-" + res.Substring(6);
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("ceri_no", no));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_name", dr["bas_ename"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_resno", res));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_entdate", Utility.FormatDate(dr["bas_entdate"].ToString())));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_pos", dr["bas_pos"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dut", dr["bas_dut"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("bas_dept", dr["bas_dept"].ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("use", "for submission"));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("today", DateTime.Now.ToString("yyyy-MM-dd")));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("dateymd", DateTime.Now.ToString("yyyy-MM-dd")));
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
        }
        #endregion
    }
}

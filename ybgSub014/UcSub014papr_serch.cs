using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ybgLibrary;

namespace ybgSub014
{
    public partial class UcSub014papr_serch : Form
    {
        UserControl1 user;
        OracleConnection con = null;
        public UcSub014papr_serch(UserControl1 user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            user.ct_papp_appno.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            String sql1 = "SELECT * FROM ybgTINSA_PAPR WHERE PAPR_APPNO LIKE :APPNO AND PAPR_DATE >= :DATE1 AND PAPR_DATE <= :DATE2 ";

            con = Utility.SetOracleConnection();
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText = sql1;

            cmd.Parameters.Add("APPNO", OracleDbType.Varchar2).Value = "%" + appno.Text + "%";
            cmd.Parameters.Add("DATE1", OracleDbType.Varchar2).Value = Utility.FormatDateR(date.Text);
            cmd.Parameters.Add("DATE2", OracleDbType.Varchar2).Value = Utility.FormatDateR(date1.Text);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rowIdx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowIdx];
                row.Cells["papr_appno"].Value = dr["papr_appno"].ToString();
                row.Cells["papr_date"].Value = Utility.FormatDate(dr["papr_date"].ToString());
                row.Cells["papr_content"].Value = dr["papr_content"].ToString();
                row.Cells["papr_num"].Value = dr["papr_num"].ToString();

            }
            dr.Close();
        }
    }
}

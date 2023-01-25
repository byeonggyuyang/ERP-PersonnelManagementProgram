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

namespace ybgSub018
{
    public partial class UcSub018evalm_serch : Form
    {
        TextBox user;
        TextBox txt2;
        TextBox txt3;
        TextBox txt4;
        OracleConnection con = null;
        public UcSub018evalm_serch(TextBox user, TextBox txt2, TextBox txt3)
        {
            InitializeComponent();
            this.user = user;
            this.txt2 = txt2;
            this.txt3 = txt3;
        }

        public UcSub018evalm_serch(TextBox user, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            InitializeComponent();
            this.user = user;
            this.txt2 = txt2;
            this.txt3 = txt3;
            this.txt4 = txt4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            String sql1 = "SELECT POS.CD_CODNMS pos_name, DUT.CD_CODNMS dut_name, STS.CD_CODNMS sts_name, dept.dept_name, BAS.* FROM ybgTINSA_BAS BAS" +
                            ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'POS') POS" +
                            ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'DUT') DUT" +
                            ", (SELECT * FROM ybgTINSA_CD WHERE CD_GRPCD = 'STS') STS" +
                            ", ybgTINSA_DEPT DEPT" +
                            " where BAS.bas_empno like :empno and BAS.bas_name like :name and nvl(dept.dept_name, '*') like :dapt and nvl(pos.cd_codnms, '*') like :pos" +
                            " and POS.cd_code(+) = BAS.bas_pos" +
                            " and DUT.cd_code(+) = BAS.bas_DUT" +
                            " and STS.cd_code(+) = BAS.bas_STS" +
                            " AND dept.dept_code(+) = BAS.bas_dept";

            con = Utility.SetOracleConnection();
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText = sql1;

            cmd.Parameters.Add("empno", OracleDbType.Varchar2).Value = "%" + empno.Text + "%";
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + name.Text + "%";
            cmd.Parameters.Add("dept", OracleDbType.Varchar2).Value = "%" + dept.Text + "%";
            cmd.Parameters.Add("pos", OracleDbType.Varchar2).Value = "%" + pos.Text + "%";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                rowIdx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowIdx];
                row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                row.Cells["bas_empno"].Value = dr["bas_empno"].ToString();
                row.Cells["pos_name"].Value = dr["pos_name"].ToString();
                row.Cells["dut_name"].Value = dr["dut_name"].ToString();
                row.Cells["dept_name"].Value = dr["dept_name"].ToString();
                row.Cells["bas_pos"].Value = dr["bas_pos"].ToString();
                row.Cells["bas_dut"].Value = dr["bas_dut"].ToString();
                row.Cells["bas_dept"].Value = dr["bas_dept"].ToString();
                row.Cells["bas_cont"].Value = dr["bas_cont"].ToString();
            }
            dr.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(user.Name == "ct_evalm_tee")
            {
                user.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + ':' + (String)dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt2.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt3.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

            if (user.Name == "ct_evalm_tor")
            {
                user.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + ':' + (String)dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt2.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt3.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt4.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

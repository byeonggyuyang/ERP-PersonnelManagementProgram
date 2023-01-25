using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace ybgSub004
{
    public partial class UcSub004Zip : Form
    {
        string confmKey = "U01TX0FVVEgyMDIxMDMyOTE1MDYyOTExMDk3OTI="; //api key 
        int currentPage = 1; //보여줄 페이지 번호
        int countPerPage = 50; //보여줄 데이터 개수
        string keyword = string.Empty; //확인용
        string apiurl = string.Empty; //apiurl 입력 변수
        UserControl1 user;
        public UcSub004Zip(UserControl1 user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                keyword = textBox1.Text.Trim();
                apiurl = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage +
                    "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;

                WebClient wc = new WebClient();
                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                DataRow[] rows = ds.Tables[0].Select();

                if (rows[0]["totalCount"].ToString() != "0")
                {
                    foreach (DataRow rowss in ds.Tables[1].Rows)
                    {
                        int rowidx = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowidx].Cells["roadAddr"].Value = rowss["roadAddr"].ToString();
                        dataGridView1.Rows[rowidx].Cells["zipNo"].Value = rowss["zipNo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            user.ct_bas_zip.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            user.ct_bas_addr.Text = (String)dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

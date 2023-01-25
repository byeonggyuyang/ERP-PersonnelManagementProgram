namespace ybgSub017
{
    partial class UserControl1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_panel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_eval_period = new System.Windows.Forms.TextBox();
            this.ct_eval_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_eval_year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_eval_no = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_eval_year = new System.Windows.Forms.TextBox();
            this.ct_eval_sdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_eval_edate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.eval_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.data_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 366F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.data_panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 725);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eval_year,
            this.eval_no,
            this.eval_period,
            this.eval_sdate,
            this.eval_edate,
            this.key1,
            this.Key2,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(726, 673);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_eval_edate);
            this.data_panel.Controls.Add(this.ct_eval_sdate);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_eval_period);
            this.data_panel.Controls.Add(this.ct_eval_no);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_eval_year);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(739, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "평가종료기간";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "평가시작기간";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "평가대상기간";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_eval_period
            // 
            this.ct_eval_period.Location = new System.Drawing.Point(102, 82);
            this.ct_eval_period.Name = "ct_eval_period";
            this.ct_eval_period.Size = new System.Drawing.Size(156, 21);
            this.ct_eval_period.TabIndex = 3;
            this.ct_eval_period.Tag = "";
            // 
            // ct_eval_no
            // 
            this.ct_eval_no.Location = new System.Drawing.Point(102, 55);
            this.ct_eval_no.Name = "ct_eval_no";
            this.ct_eval_no.Size = new System.Drawing.Size(156, 21);
            this.ct_eval_no.TabIndex = 2;
            this.ct_eval_no.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "평가년도";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_eval_year
            // 
            this.ct_eval_year.Location = new System.Drawing.Point(102, 28);
            this.ct_eval_year.Name = "ct_eval_year";
            this.ct_eval_year.Size = new System.Drawing.Size(156, 21);
            this.ct_eval_year.TabIndex = 1;
            this.ct_eval_year.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "평가차수";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_eval_no);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_eval_year);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1094, 34);
            this.search_panel.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "평가차수";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_eval_no
            // 
            this.q_eval_no.Location = new System.Drawing.Point(250, 7);
            this.q_eval_no.Name = "q_eval_no";
            this.q_eval_no.Size = new System.Drawing.Size(89, 21);
            this.q_eval_no.TabIndex = 15;
            this.q_eval_no.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "평가년도";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_eval_year
            // 
            this.q_eval_year.Location = new System.Drawing.Point(96, 7);
            this.q_eval_year.Name = "q_eval_year";
            this.q_eval_year.Size = new System.Drawing.Size(89, 21);
            this.q_eval_year.TabIndex = 13;
            this.q_eval_year.Tag = "";
            // 
            // ct_eval_sdate
            // 
            this.ct_eval_sdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_eval_sdate.Location = new System.Drawing.Point(102, 109);
            this.ct_eval_sdate.Mask = "0000-00-00";
            this.ct_eval_sdate.Name = "ct_eval_sdate";
            this.ct_eval_sdate.Size = new System.Drawing.Size(156, 21);
            this.ct_eval_sdate.TabIndex = 37;
            // 
            // ct_eval_edate
            // 
            this.ct_eval_edate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_eval_edate.Location = new System.Drawing.Point(102, 136);
            this.ct_eval_edate.Mask = "0000-00-00";
            this.ct_eval_edate.Name = "ct_eval_edate";
            this.ct_eval_edate.Size = new System.Drawing.Size(156, 21);
            this.ct_eval_edate.TabIndex = 38;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eval_year
            // 
            this.eval_year.HeaderText = "평가년도";
            this.eval_year.Name = "eval_year";
            this.eval_year.ReadOnly = true;
            // 
            // eval_no
            // 
            this.eval_no.HeaderText = "평가차수";
            this.eval_no.Name = "eval_no";
            this.eval_no.ReadOnly = true;
            // 
            // eval_period
            // 
            this.eval_period.HeaderText = "평가대상기간";
            this.eval_period.Name = "eval_period";
            this.eval_period.ReadOnly = true;
            // 
            // eval_sdate
            // 
            this.eval_sdate.HeaderText = "평가시작기간";
            this.eval_sdate.Name = "eval_sdate";
            this.eval_sdate.ReadOnly = true;
            this.eval_sdate.Width = 150;
            // 
            // eval_edate
            // 
            this.eval_edate.HeaderText = "평가종료기간";
            this.eval_edate.Name = "eval_edate";
            this.eval_edate.ReadOnly = true;
            // 
            // key1
            // 
            this.key1.HeaderText = "Key1";
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Visible = false;
            // 
            // Key2
            // 
            this.Key2.HeaderText = "Key2";
            this.Key2.Name = "Key2";
            this.Key2.ReadOnly = true;
            this.Key2.Visible = false;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1104, 725);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_eval_period;
        private System.Windows.Forms.TextBox ct_eval_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_eval_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_eval_no;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_eval_year;
        private System.Windows.Forms.MaskedTextBox ct_eval_edate;
        private System.Windows.Forms.MaskedTextBox ct_eval_sdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

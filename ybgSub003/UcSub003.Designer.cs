namespace ybgSub003
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
            this.dept_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_upp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dept_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_dept_upp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_dept_use = new System.Windows.Forms.CheckBox();
            this.ct_dept_edate = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_dept_seq = new System.Windows.Forms.TextBox();
            this.ct_dept_names = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_dept_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_dept_code = new System.Windows.Forms.TextBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_dept_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_dept_code = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ct_dept_sdate = new System.Windows.Forms.MaskedTextBox();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 725);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.dept_code,
            this.dept_name,
            this.dept_names,
            this.dept_seq,
            this.dept_upp,
            this.dept_use,
            this.dept_sdate,
            this.dept_edate,
            this.key1,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(880, 673);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // dept_code
            // 
            this.dept_code.HeaderText = "부서코드";
            this.dept_code.Name = "dept_code";
            this.dept_code.ReadOnly = true;
            // 
            // dept_name
            // 
            this.dept_name.HeaderText = "부서명칭(원형)";
            this.dept_name.Name = "dept_name";
            this.dept_name.ReadOnly = true;
            this.dept_name.Width = 120;
            // 
            // dept_names
            // 
            this.dept_names.HeaderText = "부서명칭(축약)";
            this.dept_names.Name = "dept_names";
            this.dept_names.ReadOnly = true;
            this.dept_names.Width = 120;
            // 
            // dept_seq
            // 
            this.dept_seq.HeaderText = "부서SEQ";
            this.dept_seq.Name = "dept_seq";
            this.dept_seq.ReadOnly = true;
            // 
            // dept_upp
            // 
            this.dept_upp.HeaderText = "상위부서코드";
            this.dept_upp.Name = "dept_upp";
            this.dept_upp.ReadOnly = true;
            // 
            // dept_use
            // 
            this.dept_use.HeaderText = "사용여부";
            this.dept_use.Name = "dept_use";
            this.dept_use.ReadOnly = true;
            this.dept_use.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dept_use.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dept_sdate
            // 
            this.dept_sdate.HeaderText = "생성일자";
            this.dept_sdate.Name = "dept_sdate";
            this.dept_sdate.ReadOnly = true;
            // 
            // dept_edate
            // 
            this.dept_edate.HeaderText = "폐기일자";
            this.dept_edate.Name = "dept_edate";
            this.dept_edate.ReadOnly = true;
            // 
            // key1
            // 
            this.key1.HeaderText = "Key1";
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Visible = false;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_dept_sdate);
            this.data_panel.Controls.Add(this.ct_dept_upp);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.ct_dept_use);
            this.data_panel.Controls.Add(this.ct_dept_edate);
            this.data_panel.Controls.Add(this.label10);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_dept_seq);
            this.data_panel.Controls.Add(this.ct_dept_names);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_dept_name);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.ct_dept_code);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(893, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_dept_upp
            // 
            this.ct_dept_upp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_dept_upp.FormattingEnabled = true;
            this.ct_dept_upp.Location = new System.Drawing.Point(114, 135);
            this.ct_dept_upp.Name = "ct_dept_upp";
            this.ct_dept_upp.Size = new System.Drawing.Size(156, 20);
            this.ct_dept_upp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "사용여부";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_dept_use
            // 
            this.ct_dept_use.AutoSize = true;
            this.ct_dept_use.Checked = true;
            this.ct_dept_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_dept_use.Location = new System.Drawing.Point(114, 163);
            this.ct_dept_use.Name = "ct_dept_use";
            this.ct_dept_use.Size = new System.Drawing.Size(15, 14);
            this.ct_dept_use.TabIndex = 5;
            this.ct_dept_use.Tag = "";
            this.ct_dept_use.UseVisualStyleBackColor = true;
            // 
            // ct_dept_edate
            // 
            this.ct_dept_edate.Location = new System.Drawing.Point(114, 214);
            this.ct_dept_edate.Mask = "0000-00-00";
            this.ct_dept_edate.Name = "ct_dept_edate";
            this.ct_dept_edate.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_edate.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "폐기일자";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "생성일자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "상위부서코드";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "부서SEQ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_dept_seq
            // 
            this.ct_dept_seq.Location = new System.Drawing.Point(114, 105);
            this.ct_dept_seq.Name = "ct_dept_seq";
            this.ct_dept_seq.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_seq.TabIndex = 3;
            this.ct_dept_seq.Tag = "";
            // 
            // ct_dept_names
            // 
            this.ct_dept_names.Location = new System.Drawing.Point(114, 78);
            this.ct_dept_names.Name = "ct_dept_names";
            this.ct_dept_names.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_names.TabIndex = 2;
            this.ct_dept_names.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "부서명칭(원형)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_dept_name
            // 
            this.ct_dept_name.Location = new System.Drawing.Point(114, 51);
            this.ct_dept_name.Name = "ct_dept_name";
            this.ct_dept_name.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_name.TabIndex = 1;
            this.ct_dept_name.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "부서명칭(축약)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "부서코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_dept_code
            // 
            this.ct_dept_code.Location = new System.Drawing.Point(114, 24);
            this.ct_dept_code.MaxLength = 5;
            this.ct_dept_code.Name = "ct_dept_code";
            this.ct_dept_code.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_code.TabIndex = 0;
            this.ct_dept_code.Tag = "";
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_dept_name);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_dept_code);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1248, 34);
            this.search_panel.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "부서명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_dept_name
            // 
            this.q_dept_name.Location = new System.Drawing.Point(233, 7);
            this.q_dept_name.Name = "q_dept_name";
            this.q_dept_name.Size = new System.Drawing.Size(89, 21);
            this.q_dept_name.TabIndex = 15;
            this.q_dept_name.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "부서코드";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_dept_code
            // 
            this.q_dept_code.Location = new System.Drawing.Point(85, 7);
            this.q_dept_code.Name = "q_dept_code";
            this.q_dept_code.Size = new System.Drawing.Size(89, 21);
            this.q_dept_code.TabIndex = 13;
            this.q_dept_code.Tag = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ct_dept_sdate
            // 
            this.ct_dept_sdate.Location = new System.Drawing.Point(114, 187);
            this.ct_dept_sdate.Mask = "0000-00-00";
            this.ct_dept_sdate.Name = "ct_dept_sdate";
            this.ct_dept_sdate.Size = new System.Drawing.Size(156, 21);
            this.ct_dept_sdate.TabIndex = 37;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1258, 725);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_upp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dept_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.ComboBox ct_dept_upp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ct_dept_use;
        private System.Windows.Forms.MaskedTextBox ct_dept_edate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_dept_seq;
        private System.Windows.Forms.TextBox ct_dept_names;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_dept_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_dept_code;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_dept_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_dept_code;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox ct_dept_sdate;
    }
}

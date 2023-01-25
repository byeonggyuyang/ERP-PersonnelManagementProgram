namespace ybgSub005
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_emp_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_emp_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_entdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_resdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_levdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_reidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dptdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_jkpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_posdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_wsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_sts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_rmk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_bas_levdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_resdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_reidate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_dptdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_jkpdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_posdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_entdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_emp_edate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_emp_sdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_bas_cont = new System.Windows.Forms.ComboBox();
            this.ct_bas_dept = new System.Windows.Forms.ComboBox();
            this.ct_bas_dut = new System.Windows.Forms.ComboBox();
            this.ct_bas_pos = new System.Windows.Forms.ComboBox();
            this.ct_bas_sts = new System.Windows.Forms.ComboBox();
            this.ct_bas_wsta = new System.Windows.Forms.ComboBox();
            this.ct_bas_empno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_bas_name = new System.Windows.Forms.TextBox();
            this.ct_bas_rmk = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.q_bas_pos = new System.Windows.Forms.ComboBox();
            this.q_bas_dept = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.q_bas_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_bas_empno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.data_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
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
            this.bas_empno,
            this.bas_name,
            this.bas_cont,
            this.bas_emp_sdate,
            this.bas_emp_edate,
            this.bas_entdate,
            this.bas_resdate,
            this.bas_levdate,
            this.bas_reidate,
            this.bas_dptdate,
            this.bas_jkpdate,
            this.bas_posdate,
            this.bas_wsta,
            this.bas_sts,
            this.bas_pos,
            this.bas_dut,
            this.bas_dept,
            this.bas_rmk,
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
            // bas_empno
            // 
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            // 
            // bas_name
            // 
            this.bas_name.HeaderText = "성명(한글)";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            this.bas_name.Width = 120;
            // 
            // bas_cont
            // 
            this.bas_cont.HeaderText = "계약구분";
            this.bas_cont.Name = "bas_cont";
            this.bas_cont.ReadOnly = true;
            // 
            // bas_emp_sdate
            // 
            this.bas_emp_sdate.HeaderText = "계약시작일";
            this.bas_emp_sdate.Name = "bas_emp_sdate";
            this.bas_emp_sdate.ReadOnly = true;
            // 
            // bas_emp_edate
            // 
            this.bas_emp_edate.HeaderText = "계약종료일";
            this.bas_emp_edate.Name = "bas_emp_edate";
            this.bas_emp_edate.ReadOnly = true;
            // 
            // bas_entdate
            // 
            this.bas_entdate.HeaderText = "입사일자";
            this.bas_entdate.Name = "bas_entdate";
            this.bas_entdate.ReadOnly = true;
            // 
            // bas_resdate
            // 
            this.bas_resdate.HeaderText = "퇴사일자";
            this.bas_resdate.Name = "bas_resdate";
            this.bas_resdate.ReadOnly = true;
            // 
            // bas_levdate
            // 
            this.bas_levdate.HeaderText = "휴직일자";
            this.bas_levdate.Name = "bas_levdate";
            this.bas_levdate.ReadOnly = true;
            // 
            // bas_reidate
            // 
            this.bas_reidate.HeaderText = "복직일자";
            this.bas_reidate.Name = "bas_reidate";
            this.bas_reidate.ReadOnly = true;
            // 
            // bas_dptdate
            // 
            this.bas_dptdate.HeaderText = "현부서일자";
            this.bas_dptdate.Name = "bas_dptdate";
            this.bas_dptdate.ReadOnly = true;
            // 
            // bas_jkpdate
            // 
            this.bas_jkpdate.HeaderText = "현직급일자";
            this.bas_jkpdate.Name = "bas_jkpdate";
            this.bas_jkpdate.ReadOnly = true;
            // 
            // bas_posdate
            // 
            this.bas_posdate.HeaderText = "현직책일자";
            this.bas_posdate.Name = "bas_posdate";
            this.bas_posdate.ReadOnly = true;
            // 
            // bas_wsta
            // 
            this.bas_wsta.HeaderText = "재직상태";
            this.bas_wsta.Name = "bas_wsta";
            this.bas_wsta.ReadOnly = true;
            // 
            // bas_sts
            // 
            this.bas_sts.HeaderText = "신분구분";
            this.bas_sts.Name = "bas_sts";
            this.bas_sts.ReadOnly = true;
            // 
            // bas_pos
            // 
            this.bas_pos.HeaderText = "직급(현재)";
            this.bas_pos.Name = "bas_pos";
            this.bas_pos.ReadOnly = true;
            // 
            // bas_dut
            // 
            this.bas_dut.HeaderText = "직책(현재)";
            this.bas_dut.Name = "bas_dut";
            this.bas_dut.ReadOnly = true;
            // 
            // bas_dept
            // 
            this.bas_dept.HeaderText = "부서(현재)";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            // 
            // bas_rmk
            // 
            this.bas_rmk.HeaderText = "참고사항";
            this.bas_rmk.Name = "bas_rmk";
            this.bas_rmk.ReadOnly = true;
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
            this.data_panel.Controls.Add(this.ct_bas_levdate);
            this.data_panel.Controls.Add(this.ct_bas_resdate);
            this.data_panel.Controls.Add(this.ct_bas_reidate);
            this.data_panel.Controls.Add(this.ct_bas_dptdate);
            this.data_panel.Controls.Add(this.ct_bas_jkpdate);
            this.data_panel.Controls.Add(this.ct_bas_posdate);
            this.data_panel.Controls.Add(this.ct_bas_entdate);
            this.data_panel.Controls.Add(this.ct_bas_emp_edate);
            this.data_panel.Controls.Add(this.ct_bas_emp_sdate);
            this.data_panel.Controls.Add(this.ct_bas_cont);
            this.data_panel.Controls.Add(this.ct_bas_dept);
            this.data_panel.Controls.Add(this.ct_bas_dut);
            this.data_panel.Controls.Add(this.ct_bas_pos);
            this.data_panel.Controls.Add(this.ct_bas_sts);
            this.data_panel.Controls.Add(this.ct_bas_wsta);
            this.data_panel.Controls.Add(this.ct_bas_empno);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_bas_name);
            this.data_panel.Controls.Add(this.ct_bas_rmk);
            this.data_panel.Controls.Add(this.label34);
            this.data_panel.Controls.Add(this.label33);
            this.data_panel.Controls.Add(this.label32);
            this.data_panel.Controls.Add(this.label31);
            this.data_panel.Controls.Add(this.label30);
            this.data_panel.Controls.Add(this.label29);
            this.data_panel.Controls.Add(this.label28);
            this.data_panel.Controls.Add(this.label27);
            this.data_panel.Controls.Add(this.label26);
            this.data_panel.Controls.Add(this.label25);
            this.data_panel.Controls.Add(this.label24);
            this.data_panel.Controls.Add(this.label23);
            this.data_panel.Controls.Add(this.label22);
            this.data_panel.Controls.Add(this.label21);
            this.data_panel.Controls.Add(this.label20);
            this.data_panel.Controls.Add(this.label36);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(893, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_bas_levdate
            // 
            this.ct_bas_levdate.Location = new System.Drawing.Point(145, 213);
            this.ct_bas_levdate.Mask = "0000-00-00";
            this.ct_bas_levdate.Name = "ct_bas_levdate";
            this.ct_bas_levdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_levdate.TabIndex = 7;
            this.ct_bas_levdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_resdate
            // 
            this.ct_bas_resdate.Location = new System.Drawing.Point(145, 189);
            this.ct_bas_resdate.Mask = "0000-00-00";
            this.ct_bas_resdate.Name = "ct_bas_resdate";
            this.ct_bas_resdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_resdate.TabIndex = 6;
            this.ct_bas_resdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_reidate
            // 
            this.ct_bas_reidate.Location = new System.Drawing.Point(145, 237);
            this.ct_bas_reidate.Mask = "0000-00-00";
            this.ct_bas_reidate.Name = "ct_bas_reidate";
            this.ct_bas_reidate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_reidate.TabIndex = 8;
            this.ct_bas_reidate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_dptdate
            // 
            this.ct_bas_dptdate.Location = new System.Drawing.Point(145, 261);
            this.ct_bas_dptdate.Mask = "0000-00-00";
            this.ct_bas_dptdate.Name = "ct_bas_dptdate";
            this.ct_bas_dptdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_dptdate.TabIndex = 9;
            this.ct_bas_dptdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_jkpdate
            // 
            this.ct_bas_jkpdate.Location = new System.Drawing.Point(145, 285);
            this.ct_bas_jkpdate.Mask = "0000-00-00";
            this.ct_bas_jkpdate.Name = "ct_bas_jkpdate";
            this.ct_bas_jkpdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_jkpdate.TabIndex = 10;
            this.ct_bas_jkpdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_posdate
            // 
            this.ct_bas_posdate.Location = new System.Drawing.Point(145, 309);
            this.ct_bas_posdate.Mask = "0000-00-00";
            this.ct_bas_posdate.Name = "ct_bas_posdate";
            this.ct_bas_posdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_posdate.TabIndex = 11;
            this.ct_bas_posdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_entdate
            // 
            this.ct_bas_entdate.Location = new System.Drawing.Point(145, 165);
            this.ct_bas_entdate.Mask = "0000-00-00";
            this.ct_bas_entdate.Name = "ct_bas_entdate";
            this.ct_bas_entdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_entdate.TabIndex = 5;
            this.ct_bas_entdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_emp_edate
            // 
            this.ct_bas_emp_edate.Location = new System.Drawing.Point(145, 141);
            this.ct_bas_emp_edate.Mask = "0000-00-00";
            this.ct_bas_emp_edate.Name = "ct_bas_emp_edate";
            this.ct_bas_emp_edate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_emp_edate.TabIndex = 4;
            this.ct_bas_emp_edate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_emp_sdate
            // 
            this.ct_bas_emp_sdate.Location = new System.Drawing.Point(145, 117);
            this.ct_bas_emp_sdate.Mask = "0000-00-00";
            this.ct_bas_emp_sdate.Name = "ct_bas_emp_sdate";
            this.ct_bas_emp_sdate.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_emp_sdate.TabIndex = 3;
            this.ct_bas_emp_sdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_bas_cont
            // 
            this.ct_bas_cont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_cont.FormattingEnabled = true;
            this.ct_bas_cont.Items.AddRange(new object[] {
            "",
            "정규직",
            "계약직"});
            this.ct_bas_cont.Location = new System.Drawing.Point(145, 94);
            this.ct_bas_cont.Name = "ct_bas_cont";
            this.ct_bas_cont.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_cont.TabIndex = 2;
            // 
            // ct_bas_dept
            // 
            this.ct_bas_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_dept.FormattingEnabled = true;
            this.ct_bas_dept.Location = new System.Drawing.Point(145, 425);
            this.ct_bas_dept.Name = "ct_bas_dept";
            this.ct_bas_dept.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_dept.TabIndex = 16;
            // 
            // ct_bas_dut
            // 
            this.ct_bas_dut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_dut.FormattingEnabled = true;
            this.ct_bas_dut.Location = new System.Drawing.Point(145, 402);
            this.ct_bas_dut.Name = "ct_bas_dut";
            this.ct_bas_dut.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_dut.TabIndex = 15;
            // 
            // ct_bas_pos
            // 
            this.ct_bas_pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_pos.FormattingEnabled = true;
            this.ct_bas_pos.Location = new System.Drawing.Point(145, 379);
            this.ct_bas_pos.Name = "ct_bas_pos";
            this.ct_bas_pos.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_pos.TabIndex = 14;
            // 
            // ct_bas_sts
            // 
            this.ct_bas_sts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_sts.FormattingEnabled = true;
            this.ct_bas_sts.Location = new System.Drawing.Point(145, 356);
            this.ct_bas_sts.Name = "ct_bas_sts";
            this.ct_bas_sts.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_sts.TabIndex = 13;
            // 
            // ct_bas_wsta
            // 
            this.ct_bas_wsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bas_wsta.FormattingEnabled = true;
            this.ct_bas_wsta.Items.AddRange(new object[] {
            "",
            "재직",
            "휴직",
            "퇴직"});
            this.ct_bas_wsta.Location = new System.Drawing.Point(145, 333);
            this.ct_bas_wsta.Name = "ct_bas_wsta";
            this.ct_bas_wsta.Size = new System.Drawing.Size(156, 20);
            this.ct_bas_wsta.TabIndex = 12;
            // 
            // ct_bas_empno
            // 
            this.ct_bas_empno.Location = new System.Drawing.Point(145, 46);
            this.ct_bas_empno.Name = "ct_bas_empno";
            this.ct_bas_empno.ReadOnly = true;
            this.ct_bas_empno.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_empno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 246;
            this.label1.Text = "사원번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 247;
            this.label3.Text = "성명(한글)";
            // 
            // ct_bas_name
            // 
            this.ct_bas_name.Location = new System.Drawing.Point(145, 70);
            this.ct_bas_name.Name = "ct_bas_name";
            this.ct_bas_name.ReadOnly = true;
            this.ct_bas_name.Size = new System.Drawing.Size(156, 21);
            this.ct_bas_name.TabIndex = 1;
            // 
            // ct_bas_rmk
            // 
            this.ct_bas_rmk.Location = new System.Drawing.Point(145, 448);
            this.ct_bas_rmk.Multiline = true;
            this.ct_bas_rmk.Name = "ct_bas_rmk";
            this.ct_bas_rmk.Size = new System.Drawing.Size(156, 43);
            this.ct_bas_rmk.TabIndex = 17;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(64, 451);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 12);
            this.label34.TabIndex = 205;
            this.label34.Text = "참고사항";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(64, 428);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 12);
            this.label33.TabIndex = 204;
            this.label33.Text = "부서(현재)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(64, 405);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 12);
            this.label32.TabIndex = 203;
            this.label32.Text = "직책(현재)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(64, 382);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 12);
            this.label31.TabIndex = 202;
            this.label31.Text = "직급(현재)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(64, 359);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 201;
            this.label30.Text = "신분구분";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(64, 336);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 200;
            this.label29.Text = "재직상태";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(64, 312);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 199;
            this.label28.Text = "현직책일자";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(64, 288);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 198;
            this.label27.Text = "현직급일자";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(64, 264);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 190;
            this.label26.Text = "현부서일자";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(64, 240);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 189;
            this.label25.Text = "복직일자";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(64, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 188;
            this.label24.Text = "휴직일자";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(64, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 187;
            this.label23.Text = "퇴사일자";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(64, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 186;
            this.label22.Text = "입사일자";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(64, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 185;
            this.label21.Text = "계약종료일";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(64, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 184;
            this.label20.Text = "계약시작일";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(64, 97);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 12);
            this.label36.TabIndex = 181;
            this.label36.Text = "계약구분";
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.q_bas_pos);
            this.search_panel.Controls.Add(this.q_bas_dept);
            this.search_panel.Controls.Add(this.label38);
            this.search_panel.Controls.Add(this.label37);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_bas_name);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_bas_empno);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1248, 34);
            this.search_panel.TabIndex = 2;
            // 
            // q_bas_pos
            // 
            this.q_bas_pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_bas_pos.FormattingEnabled = true;
            this.q_bas_pos.Location = new System.Drawing.Point(504, 9);
            this.q_bas_pos.Name = "q_bas_pos";
            this.q_bas_pos.Size = new System.Drawing.Size(89, 20);
            this.q_bas_pos.TabIndex = 21;
            // 
            // q_bas_dept
            // 
            this.q_bas_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_bas_dept.FormattingEnabled = true;
            this.q_bas_dept.Location = new System.Drawing.Point(363, 9);
            this.q_bas_dept.Name = "q_bas_dept";
            this.q_bas_dept.Size = new System.Drawing.Size(89, 20);
            this.q_bas_dept.TabIndex = 20;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(469, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 19;
            this.label38.Text = "직급";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(328, 12);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 17;
            this.label37.Text = "부서";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "성명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_name
            // 
            this.q_bas_name.Location = new System.Drawing.Point(220, 9);
            this.q_bas_name.Name = "q_bas_name";
            this.q_bas_name.Size = new System.Drawing.Size(89, 21);
            this.q_bas_name.TabIndex = 1;
            this.q_bas_name.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "사원번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_empno
            // 
            this.q_bas_empno.Location = new System.Drawing.Point(84, 9);
            this.q_bas_empno.Name = "q_bas_empno";
            this.q_bas_empno.Size = new System.Drawing.Size(89, 21);
            this.q_bas_empno.TabIndex = 0;
            this.q_bas_empno.Tag = "";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_emp_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_emp_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_entdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_resdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_levdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_reidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dptdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_jkpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_posdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_wsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_sts;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dut;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_rmk;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.MaskedTextBox ct_bas_levdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_resdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_reidate;
        private System.Windows.Forms.MaskedTextBox ct_bas_dptdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_jkpdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_posdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_entdate;
        private System.Windows.Forms.MaskedTextBox ct_bas_emp_edate;
        private System.Windows.Forms.MaskedTextBox ct_bas_emp_sdate;
        private System.Windows.Forms.ComboBox ct_bas_cont;
        private System.Windows.Forms.ComboBox ct_bas_dept;
        private System.Windows.Forms.ComboBox ct_bas_dut;
        private System.Windows.Forms.ComboBox ct_bas_pos;
        private System.Windows.Forms.ComboBox ct_bas_sts;
        private System.Windows.Forms.ComboBox ct_bas_wsta;
        private System.Windows.Forms.TextBox ct_bas_empno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_bas_name;
        private System.Windows.Forms.TextBox ct_bas_rmk;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.ComboBox q_bas_pos;
        private System.Windows.Forms.ComboBox q_bas_dept;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_bas_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_bas_empno;
    }
}

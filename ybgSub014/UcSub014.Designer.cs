namespace ybgSub014
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_papp_cont = new System.Windows.Forms.ComboBox();
            this.papr_serch = new System.Windows.Forms.Button();
            this.bas_serch = new System.Windows.Forms.Button();
            this.ct_papp_date = new System.Windows.Forms.DateTimePicker();
            this.ct_papp_dept_nm = new System.Windows.Forms.ComboBox();
            this.ct_papp_dut_nm = new System.Windows.Forms.ComboBox();
            this.ct_papp_pos_nm = new System.Windows.Forms.ComboBox();
            this.ct_papp_pap = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ct_papp_dept_cd = new System.Windows.Forms.TextBox();
            this.ct_papp_dut_cd = new System.Windows.Forms.TextBox();
            this.ct_papp_pos_cd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ct_papp_rmk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ct_papp_basis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_papp_auth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_papp_appno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_papp_content = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ct_papp_empno = new System.Windows.Forms.TextBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.q_papp_date2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.q_papp_appno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.q_papp_date1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_papp_empno = new System.Windows.Forms.TextBox();
            this.papp_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_basis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_rmk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pos_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dut_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dept_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pos_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dut_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dept_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pap = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.data_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
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
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.papp_empno,
            this.papp_appno,
            this.papp_date,
            this.papp_pap,
            this.papp_content,
            this.papp_auth,
            this.papp_basis,
            this.papp_rmk,
            this.papp_pos_cd,
            this.papp_dut_cd,
            this.papp_dept_cd,
            this.papp_pos_nm,
            this.papp_dut_nm,
            this.papp_dept_nm,
            this.papp_cont,
            this.key1,
            this.key2,
            this.key3,
            this.key4,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 673);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.ct_papp_cont);
            this.data_panel.Controls.Add(this.papr_serch);
            this.data_panel.Controls.Add(this.bas_serch);
            this.data_panel.Controls.Add(this.ct_papp_date);
            this.data_panel.Controls.Add(this.ct_papp_dept_nm);
            this.data_panel.Controls.Add(this.ct_papp_dut_nm);
            this.data_panel.Controls.Add(this.ct_papp_pos_nm);
            this.data_panel.Controls.Add(this.ct_papp_pap);
            this.data_panel.Controls.Add(this.label17);
            this.data_panel.Controls.Add(this.label16);
            this.data_panel.Controls.Add(this.label15);
            this.data_panel.Controls.Add(this.ct_papp_dept_cd);
            this.data_panel.Controls.Add(this.ct_papp_dut_cd);
            this.data_panel.Controls.Add(this.ct_papp_pos_cd);
            this.data_panel.Controls.Add(this.label10);
            this.data_panel.Controls.Add(this.ct_papp_rmk);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.ct_papp_basis);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.ct_papp_auth);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_papp_appno);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_papp_content);
            this.data_panel.Controls.Add(this.label11);
            this.data_panel.Controls.Add(this.label13);
            this.data_panel.Controls.Add(this.ct_papp_empno);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(875, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(378, 673);
            this.data_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "계약구분";
            // 
            // ct_papp_cont
            // 
            this.ct_papp_cont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_cont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_papp_cont.Enabled = false;
            this.ct_papp_cont.FormattingEnabled = true;
            this.ct_papp_cont.Items.AddRange(new object[] {
            "",
            "정규직",
            "계약직"});
            this.ct_papp_cont.Location = new System.Drawing.Point(137, 201);
            this.ct_papp_cont.Name = "ct_papp_cont";
            this.ct_papp_cont.Size = new System.Drawing.Size(148, 20);
            this.ct_papp_cont.TabIndex = 84;
            // 
            // papr_serch
            // 
            this.papr_serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.papr_serch.Location = new System.Drawing.Point(240, 46);
            this.papr_serch.Name = "papr_serch";
            this.papr_serch.Size = new System.Drawing.Size(45, 23);
            this.papr_serch.TabIndex = 83;
            this.papr_serch.Text = "검색";
            this.papr_serch.UseVisualStyleBackColor = true;
            this.papr_serch.Click += new System.EventHandler(this.papr_serch_Click);
            // 
            // bas_serch
            // 
            this.bas_serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bas_serch.Location = new System.Drawing.Point(240, 21);
            this.bas_serch.Name = "bas_serch";
            this.bas_serch.Size = new System.Drawing.Size(45, 23);
            this.bas_serch.TabIndex = 82;
            this.bas_serch.Text = "검색";
            this.bas_serch.UseVisualStyleBackColor = true;
            this.bas_serch.Click += new System.EventHandler(this.bas_serch_Click);
            // 
            // ct_papp_date
            // 
            this.ct_papp_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ct_papp_date.Location = new System.Drawing.Point(137, 72);
            this.ct_papp_date.Name = "ct_papp_date";
            this.ct_papp_date.Size = new System.Drawing.Size(148, 21);
            this.ct_papp_date.TabIndex = 81;
            // 
            // ct_papp_dept_nm
            // 
            this.ct_papp_dept_nm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_dept_nm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_papp_dept_nm.Enabled = false;
            this.ct_papp_dept_nm.FormattingEnabled = true;
            this.ct_papp_dept_nm.Items.AddRange(new object[] {
            ""});
            this.ct_papp_dept_nm.Location = new System.Drawing.Point(209, 175);
            this.ct_papp_dept_nm.Name = "ct_papp_dept_nm";
            this.ct_papp_dept_nm.Size = new System.Drawing.Size(76, 20);
            this.ct_papp_dept_nm.TabIndex = 59;
            this.ct_papp_dept_nm.SelectedValueChanged += new System.EventHandler(this.ct_papp_dept_nm_SelectedValueChanged);
            // 
            // ct_papp_dut_nm
            // 
            this.ct_papp_dut_nm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_dut_nm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_papp_dut_nm.Enabled = false;
            this.ct_papp_dut_nm.FormattingEnabled = true;
            this.ct_papp_dut_nm.Items.AddRange(new object[] {
            ""});
            this.ct_papp_dut_nm.Location = new System.Drawing.Point(209, 149);
            this.ct_papp_dut_nm.Name = "ct_papp_dut_nm";
            this.ct_papp_dut_nm.Size = new System.Drawing.Size(76, 20);
            this.ct_papp_dut_nm.TabIndex = 58;
            this.ct_papp_dut_nm.SelectedValueChanged += new System.EventHandler(this.ct_papp_dut_nm_SelectedValueChanged);
            // 
            // ct_papp_pos_nm
            // 
            this.ct_papp_pos_nm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_pos_nm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_papp_pos_nm.Enabled = false;
            this.ct_papp_pos_nm.FormattingEnabled = true;
            this.ct_papp_pos_nm.Items.AddRange(new object[] {
            ""});
            this.ct_papp_pos_nm.Location = new System.Drawing.Point(209, 124);
            this.ct_papp_pos_nm.Name = "ct_papp_pos_nm";
            this.ct_papp_pos_nm.Size = new System.Drawing.Size(76, 20);
            this.ct_papp_pos_nm.TabIndex = 57;
            this.ct_papp_pos_nm.SelectedValueChanged += new System.EventHandler(this.ct_papp_pos_nm_SelectedValueChanged);
            // 
            // ct_papp_pap
            // 
            this.ct_papp_pap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_pap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_papp_pap.FormattingEnabled = true;
            this.ct_papp_pap.Items.AddRange(new object[] {
            ""});
            this.ct_papp_pap.Location = new System.Drawing.Point(137, 98);
            this.ct_papp_pap.Name = "ct_papp_pap";
            this.ct_papp_pap.Size = new System.Drawing.Size(148, 20);
            this.ct_papp_pap.TabIndex = 80;
            this.ct_papp_pap.SelectedValueChanged += new System.EventHandler(this.ct_papp_pap_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 12);
            this.label17.TabIndex = 79;
            this.label17.Text = "부서명(당시)";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 12);
            this.label16.TabIndex = 78;
            this.label16.Text = "직책명(당시)";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 12);
            this.label15.TabIndex = 77;
            this.label15.Text = "직급명(당시)";
            // 
            // ct_papp_dept_cd
            // 
            this.ct_papp_dept_cd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_dept_cd.Enabled = false;
            this.ct_papp_dept_cd.Location = new System.Drawing.Point(137, 174);
            this.ct_papp_dept_cd.Name = "ct_papp_dept_cd";
            this.ct_papp_dept_cd.Size = new System.Drawing.Size(66, 21);
            this.ct_papp_dept_cd.TabIndex = 76;
            // 
            // ct_papp_dut_cd
            // 
            this.ct_papp_dut_cd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_dut_cd.Enabled = false;
            this.ct_papp_dut_cd.Location = new System.Drawing.Point(137, 149);
            this.ct_papp_dut_cd.Name = "ct_papp_dut_cd";
            this.ct_papp_dut_cd.Size = new System.Drawing.Size(66, 21);
            this.ct_papp_dut_cd.TabIndex = 75;
            // 
            // ct_papp_pos_cd
            // 
            this.ct_papp_pos_cd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_pos_cd.Enabled = false;
            this.ct_papp_pos_cd.Location = new System.Drawing.Point(137, 124);
            this.ct_papp_pos_cd.Name = "ct_papp_pos_cd";
            this.ct_papp_pos_cd.Size = new System.Drawing.Size(66, 21);
            this.ct_papp_pos_cd.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 73;
            this.label10.Text = "비고";
            // 
            // ct_papp_rmk
            // 
            this.ct_papp_rmk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_rmk.Location = new System.Drawing.Point(137, 323);
            this.ct_papp_rmk.Name = "ct_papp_rmk";
            this.ct_papp_rmk.Size = new System.Drawing.Size(148, 21);
            this.ct_papp_rmk.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 71;
            this.label9.Text = "발령근거";
            // 
            // ct_papp_basis
            // 
            this.ct_papp_basis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_basis.Location = new System.Drawing.Point(137, 298);
            this.ct_papp_basis.Name = "ct_papp_basis";
            this.ct_papp_basis.Size = new System.Drawing.Size(148, 21);
            this.ct_papp_basis.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 69;
            this.label8.Text = "발령권자";
            // 
            // ct_papp_auth
            // 
            this.ct_papp_auth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_auth.Location = new System.Drawing.Point(137, 273);
            this.ct_papp_auth.Name = "ct_papp_auth";
            this.ct_papp_auth.Size = new System.Drawing.Size(148, 21);
            this.ct_papp_auth.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 67;
            this.label7.Text = "사원번호";
            // 
            // ct_papp_appno
            // 
            this.ct_papp_appno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_appno.Enabled = false;
            this.ct_papp_appno.Location = new System.Drawing.Point(137, 47);
            this.ct_papp_appno.Name = "ct_papp_appno";
            this.ct_papp_appno.Size = new System.Drawing.Size(97, 21);
            this.ct_papp_appno.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 65;
            this.label5.Text = "발령종류";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 64;
            this.label6.Text = "발령내용";
            // 
            // ct_papp_content
            // 
            this.ct_papp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_content.Location = new System.Drawing.Point(137, 225);
            this.ct_papp_content.Multiline = true;
            this.ct_papp_content.Name = "ct_papp_content";
            this.ct_papp_content.Size = new System.Drawing.Size(148, 44);
            this.ct_papp_content.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 62;
            this.label11.Text = "시행일자";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 61;
            this.label13.Text = "인사발령번호";
            // 
            // ct_papp_empno
            // 
            this.ct_papp_empno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_papp_empno.Enabled = false;
            this.ct_papp_empno.Location = new System.Drawing.Point(137, 23);
            this.ct_papp_empno.Name = "ct_papp_empno";
            this.ct_papp_empno.Size = new System.Drawing.Size(97, 21);
            this.ct_papp_empno.TabIndex = 60;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.pap);
            this.search_panel.Controls.Add(this.label14);
            this.search_panel.Controls.Add(this.label4);
            this.search_panel.Controls.Add(this.q_papp_date2);
            this.search_panel.Controls.Add(this.label3);
            this.search_panel.Controls.Add(this.q_papp_appno);
            this.search_panel.Controls.Add(this.label2);
            this.search_panel.Controls.Add(this.q_papp_date1);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_papp_empno);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1248, 34);
            this.search_panel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 259;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papp_date2
            // 
            this.q_papp_date2.Location = new System.Drawing.Point(565, 9);
            this.q_papp_date2.Mask = "0000-00-00";
            this.q_papp_date2.Name = "q_papp_date2";
            this.q_papp_date2.Size = new System.Drawing.Size(89, 21);
            this.q_papp_date2.TabIndex = 258;
            this.q_papp_date2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 257;
            this.label3.Text = "인사발령번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papp_appno
            // 
            this.q_papp_appno.Location = new System.Drawing.Point(282, 9);
            this.q_papp_appno.Name = "q_papp_appno";
            this.q_papp_appno.Size = new System.Drawing.Size(89, 21);
            this.q_papp_appno.TabIndex = 256;
            this.q_papp_appno.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 255;
            this.label2.Text = "시행일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papp_date1
            // 
            this.q_papp_date1.Location = new System.Drawing.Point(453, 9);
            this.q_papp_date1.Mask = "0000-00-00";
            this.q_papp_date1.Name = "q_papp_date1";
            this.q_papp_date1.Size = new System.Drawing.Size(89, 21);
            this.q_papp_date1.TabIndex = 253;
            this.q_papp_date1.ValidatingType = typeof(System.DateTime);
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
            // q_papp_empno
            // 
            this.q_papp_empno.Location = new System.Drawing.Point(84, 9);
            this.q_papp_empno.Name = "q_papp_empno";
            this.q_papp_empno.Size = new System.Drawing.Size(89, 21);
            this.q_papp_empno.TabIndex = 0;
            this.q_papp_empno.Tag = "";
            // 
            // papp_empno
            // 
            this.papp_empno.HeaderText = "사원번호";
            this.papp_empno.Name = "papp_empno";
            this.papp_empno.ReadOnly = true;
            this.papp_empno.Width = 70;
            // 
            // papp_appno
            // 
            this.papp_appno.HeaderText = "인사발령번호";
            this.papp_appno.Name = "papp_appno";
            this.papp_appno.ReadOnly = true;
            // 
            // papp_date
            // 
            this.papp_date.HeaderText = "시행일자";
            this.papp_date.Name = "papp_date";
            this.papp_date.ReadOnly = true;
            // 
            // papp_pap
            // 
            this.papp_pap.HeaderText = "발령종류";
            this.papp_pap.Name = "papp_pap";
            this.papp_pap.ReadOnly = true;
            // 
            // papp_content
            // 
            this.papp_content.HeaderText = "발령내용";
            this.papp_content.Name = "papp_content";
            this.papp_content.ReadOnly = true;
            this.papp_content.Width = 140;
            // 
            // papp_auth
            // 
            this.papp_auth.HeaderText = "발령권자";
            this.papp_auth.Name = "papp_auth";
            this.papp_auth.ReadOnly = true;
            // 
            // papp_basis
            // 
            this.papp_basis.HeaderText = "발령근거";
            this.papp_basis.Name = "papp_basis";
            this.papp_basis.ReadOnly = true;
            this.papp_basis.Width = 140;
            // 
            // papp_rmk
            // 
            this.papp_rmk.HeaderText = "비고";
            this.papp_rmk.Name = "papp_rmk";
            this.papp_rmk.ReadOnly = true;
            this.papp_rmk.Width = 140;
            // 
            // papp_pos_cd
            // 
            this.papp_pos_cd.HeaderText = "직급코드(당시)";
            this.papp_pos_cd.Name = "papp_pos_cd";
            this.papp_pos_cd.ReadOnly = true;
            // 
            // papp_dut_cd
            // 
            this.papp_dut_cd.HeaderText = "직책코드(당시)";
            this.papp_dut_cd.Name = "papp_dut_cd";
            this.papp_dut_cd.ReadOnly = true;
            // 
            // papp_dept_cd
            // 
            this.papp_dept_cd.HeaderText = "부서코드(당시)";
            this.papp_dept_cd.Name = "papp_dept_cd";
            this.papp_dept_cd.ReadOnly = true;
            // 
            // papp_pos_nm
            // 
            this.papp_pos_nm.HeaderText = "직급명(당시)";
            this.papp_pos_nm.Name = "papp_pos_nm";
            this.papp_pos_nm.ReadOnly = true;
            // 
            // papp_dut_nm
            // 
            this.papp_dut_nm.HeaderText = "직책명(당시)";
            this.papp_dut_nm.Name = "papp_dut_nm";
            this.papp_dut_nm.ReadOnly = true;
            // 
            // papp_dept_nm
            // 
            this.papp_dept_nm.HeaderText = "부서명(당시)";
            this.papp_dept_nm.Name = "papp_dept_nm";
            this.papp_dept_nm.ReadOnly = true;
            // 
            // papp_cont
            // 
            this.papp_cont.HeaderText = "계약구분";
            this.papp_cont.Name = "papp_cont";
            this.papp_cont.ReadOnly = true;
            // 
            // key1
            // 
            this.key1.HeaderText = "Key1";
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Visible = false;
            // 
            // key2
            // 
            this.key2.HeaderText = "Key2";
            this.key2.Name = "key2";
            this.key2.ReadOnly = true;
            this.key2.Visible = false;
            // 
            // key3
            // 
            this.key3.HeaderText = "Key3";
            this.key3.Name = "key3";
            this.key3.ReadOnly = true;
            this.key3.Visible = false;
            // 
            // key4
            // 
            this.key4.HeaderText = "Key4";
            this.key4.Name = "key4";
            this.key4.ReadOnly = true;
            this.key4.Visible = false;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // pap
            // 
            this.pap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pap.FormattingEnabled = true;
            this.pap.Items.AddRange(new object[] {
            ""});
            this.pap.Location = new System.Drawing.Point(729, 9);
            this.pap.Name = "pap";
            this.pap.Size = new System.Drawing.Size(101, 20);
            this.pap.TabIndex = 261;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(670, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 260;
            this.label14.Text = "발령종류";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1258, 725);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ct_papp_cont;
        private System.Windows.Forms.Button papr_serch;
        private System.Windows.Forms.Button bas_serch;
        private System.Windows.Forms.DateTimePicker ct_papp_date;
        public System.Windows.Forms.ComboBox ct_papp_dept_nm;
        public System.Windows.Forms.ComboBox ct_papp_dut_nm;
        public System.Windows.Forms.ComboBox ct_papp_pos_nm;
        private System.Windows.Forms.ComboBox ct_papp_pap;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox ct_papp_dept_cd;
        public System.Windows.Forms.TextBox ct_papp_dut_cd;
        public System.Windows.Forms.TextBox ct_papp_pos_cd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ct_papp_rmk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ct_papp_basis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ct_papp_auth;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox ct_papp_appno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_papp_content;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox ct_papp_empno;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox q_papp_date2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_papp_appno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox q_papp_date1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_papp_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pap;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_auth;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_basis;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_rmk;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pos_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dut_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dept_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pos_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dut_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dept_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn key3;
        private System.Windows.Forms.DataGridViewTextBoxColumn key4;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ComboBox pap;
        private System.Windows.Forms.Label label14;
    }
}

namespace ybgSub018
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
            this.evalm_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_evalm_pos_tor = new System.Windows.Forms.TextBox();
            this.ct_evalm_dut_tor = new System.Windows.Forms.TextBox();
            this.ct_evalm_pos_tee = new System.Windows.Forms.TextBox();
            this.ct_evalm_dept_tor = new System.Windows.Forms.TextBox();
            this.ct_evalm_dept_tee = new System.Windows.Forms.TextBox();
            this.ct_evalm_period = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ct_evalm_type = new System.Windows.Forms.TextBox();
            this.ct_evalm_year = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_evalm_no = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_evalm_tor = new System.Windows.Forms.TextBox();
            this.ct_evalm_stage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_evalm_tee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q_evalm_stage = new System.Windows.Forms.TextBox();
            this.q_evalm_no = new System.Windows.Forms.MaskedTextBox();
            this.q_evalm_tee = new System.Windows.Forms.TextBox();
            this.q_evalm_year = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.evalm_year,
            this.evalm_no,
            this.evalm_tee,
            this.evalm_stage,
            this.evalm_tor,
            this.evalm_type,
            this.evalm_period,
            this.key1,
            this.Key2,
            this.Key3,
            this.Key4,
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
            // evalm_year
            // 
            this.evalm_year.HeaderText = "평가년도";
            this.evalm_year.Name = "evalm_year";
            this.evalm_year.ReadOnly = true;
            // 
            // evalm_no
            // 
            this.evalm_no.HeaderText = "평가차수";
            this.evalm_no.Name = "evalm_no";
            this.evalm_no.ReadOnly = true;
            // 
            // evalm_tee
            // 
            this.evalm_tee.HeaderText = "피평가";
            this.evalm_tee.Name = "evalm_tee";
            this.evalm_tee.ReadOnly = true;
            this.evalm_tee.Width = 150;
            // 
            // evalm_stage
            // 
            this.evalm_stage.HeaderText = "평가단게";
            this.evalm_stage.Name = "evalm_stage";
            this.evalm_stage.ReadOnly = true;
            // 
            // evalm_tor
            // 
            this.evalm_tor.HeaderText = "평가자";
            this.evalm_tor.Name = "evalm_tor";
            this.evalm_tor.ReadOnly = true;
            // 
            // evalm_type
            // 
            this.evalm_type.HeaderText = "평가표 유형";
            this.evalm_type.Name = "evalm_type";
            this.evalm_type.ReadOnly = true;
            // 
            // evalm_period
            // 
            this.evalm_period.HeaderText = "평가대상기간";
            this.evalm_period.Name = "evalm_period";
            this.evalm_period.ReadOnly = true;
            this.evalm_period.Width = 150;
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
            // Key3
            // 
            this.Key3.HeaderText = "Key3";
            this.Key3.Name = "Key3";
            this.Key3.ReadOnly = true;
            this.Key3.Visible = false;
            // 
            // Key4
            // 
            this.Key4.HeaderText = "Key4";
            this.Key4.Name = "Key4";
            this.Key4.ReadOnly = true;
            this.Key4.Visible = false;
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
            this.data_panel.Controls.Add(this.ct_evalm_pos_tor);
            this.data_panel.Controls.Add(this.ct_evalm_dut_tor);
            this.data_panel.Controls.Add(this.ct_evalm_pos_tee);
            this.data_panel.Controls.Add(this.ct_evalm_dept_tor);
            this.data_panel.Controls.Add(this.ct_evalm_dept_tee);
            this.data_panel.Controls.Add(this.ct_evalm_period);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.button2);
            this.data_panel.Controls.Add(this.button1);
            this.data_panel.Controls.Add(this.ct_evalm_type);
            this.data_panel.Controls.Add(this.ct_evalm_year);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.ct_evalm_no);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_evalm_tor);
            this.data_panel.Controls.Add(this.ct_evalm_stage);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_evalm_tee);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(739, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_evalm_pos_tor
            // 
            this.ct_evalm_pos_tor.Enabled = false;
            this.ct_evalm_pos_tor.Location = new System.Drawing.Point(102, 340);
            this.ct_evalm_pos_tor.Name = "ct_evalm_pos_tor";
            this.ct_evalm_pos_tor.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_pos_tor.TabIndex = 46;
            this.ct_evalm_pos_tor.Tag = "";
            this.ct_evalm_pos_tor.Visible = false;
            // 
            // ct_evalm_dut_tor
            // 
            this.ct_evalm_dut_tor.Enabled = false;
            this.ct_evalm_dut_tor.Location = new System.Drawing.Point(102, 367);
            this.ct_evalm_dut_tor.Name = "ct_evalm_dut_tor";
            this.ct_evalm_dut_tor.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_dut_tor.TabIndex = 45;
            this.ct_evalm_dut_tor.Tag = "";
            this.ct_evalm_dut_tor.Visible = false;
            // 
            // ct_evalm_pos_tee
            // 
            this.ct_evalm_pos_tee.Enabled = false;
            this.ct_evalm_pos_tee.Location = new System.Drawing.Point(102, 286);
            this.ct_evalm_pos_tee.Name = "ct_evalm_pos_tee";
            this.ct_evalm_pos_tee.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_pos_tee.TabIndex = 44;
            this.ct_evalm_pos_tee.Tag = "";
            this.ct_evalm_pos_tee.Visible = false;
            // 
            // ct_evalm_dept_tor
            // 
            this.ct_evalm_dept_tor.Enabled = false;
            this.ct_evalm_dept_tor.Location = new System.Drawing.Point(102, 313);
            this.ct_evalm_dept_tor.Name = "ct_evalm_dept_tor";
            this.ct_evalm_dept_tor.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_dept_tor.TabIndex = 43;
            this.ct_evalm_dept_tor.Tag = "";
            this.ct_evalm_dept_tor.Visible = false;
            // 
            // ct_evalm_dept_tee
            // 
            this.ct_evalm_dept_tee.Enabled = false;
            this.ct_evalm_dept_tee.Location = new System.Drawing.Point(102, 259);
            this.ct_evalm_dept_tee.Name = "ct_evalm_dept_tee";
            this.ct_evalm_dept_tee.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_dept_tee.TabIndex = 42;
            this.ct_evalm_dept_tee.Tag = "";
            this.ct_evalm_dept_tee.Visible = false;
            // 
            // ct_evalm_period
            // 
            this.ct_evalm_period.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_evalm_period.Location = new System.Drawing.Point(102, 189);
            this.ct_evalm_period.Mask = "0000-00-00~0000-00-00";
            this.ct_evalm_period.Name = "ct_evalm_period";
            this.ct_evalm_period.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_period.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "평가대상기간";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ct_evalm_type
            // 
            this.ct_evalm_type.Location = new System.Drawing.Point(102, 162);
            this.ct_evalm_type.Name = "ct_evalm_type";
            this.ct_evalm_type.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_type.TabIndex = 6;
            this.ct_evalm_type.Tag = "";
            // 
            // ct_evalm_year
            // 
            this.ct_evalm_year.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_evalm_year.Location = new System.Drawing.Point(102, 22);
            this.ct_evalm_year.Mask = "0000";
            this.ct_evalm_year.Name = "ct_evalm_year";
            this.ct_evalm_year.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_year.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "평가표 유형";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_evalm_no
            // 
            this.ct_evalm_no.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_evalm_no.Location = new System.Drawing.Point(102, 50);
            this.ct_evalm_no.Mask = "0";
            this.ct_evalm_no.Name = "ct_evalm_no";
            this.ct_evalm_no.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_no.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "평가자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "평가단계";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "피평가자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_evalm_tor
            // 
            this.ct_evalm_tor.Enabled = false;
            this.ct_evalm_tor.Location = new System.Drawing.Point(102, 134);
            this.ct_evalm_tor.Name = "ct_evalm_tor";
            this.ct_evalm_tor.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_tor.TabIndex = 3;
            this.ct_evalm_tor.Tag = "";
            // 
            // ct_evalm_stage
            // 
            this.ct_evalm_stage.Location = new System.Drawing.Point(102, 106);
            this.ct_evalm_stage.Name = "ct_evalm_stage";
            this.ct_evalm_stage.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_stage.TabIndex = 4;
            this.ct_evalm_stage.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "평가년도";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_evalm_tee
            // 
            this.ct_evalm_tee.Enabled = false;
            this.ct_evalm_tee.Location = new System.Drawing.Point(102, 78);
            this.ct_evalm_tee.Name = "ct_evalm_tee";
            this.ct_evalm_tee.Size = new System.Drawing.Size(156, 21);
            this.ct_evalm_tee.TabIndex = 1;
            this.ct_evalm_tee.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "평가차수";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label4);
            this.search_panel.Controls.Add(this.label3);
            this.search_panel.Controls.Add(this.q_evalm_stage);
            this.search_panel.Controls.Add(this.q_evalm_no);
            this.search_panel.Controls.Add(this.q_evalm_tee);
            this.search_panel.Controls.Add(this.q_evalm_year);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1094, 34);
            this.search_panel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "평가단계";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "피평가자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_evalm_stage
            // 
            this.q_evalm_stage.Location = new System.Drawing.Point(499, 7);
            this.q_evalm_stage.Name = "q_evalm_stage";
            this.q_evalm_stage.Size = new System.Drawing.Size(93, 21);
            this.q_evalm_stage.TabIndex = 43;
            this.q_evalm_stage.Tag = "";
            // 
            // q_evalm_no
            // 
            this.q_evalm_no.ForeColor = System.Drawing.SystemColors.WindowText;
            this.q_evalm_no.Location = new System.Drawing.Point(224, 7);
            this.q_evalm_no.Mask = "00";
            this.q_evalm_no.Name = "q_evalm_no";
            this.q_evalm_no.Size = new System.Drawing.Size(33, 21);
            this.q_evalm_no.TabIndex = 43;
            // 
            // q_evalm_tee
            // 
            this.q_evalm_tee.Location = new System.Drawing.Point(332, 7);
            this.q_evalm_tee.Name = "q_evalm_tee";
            this.q_evalm_tee.Size = new System.Drawing.Size(91, 21);
            this.q_evalm_tee.TabIndex = 43;
            this.q_evalm_tee.Tag = "";
            // 
            // q_evalm_year
            // 
            this.q_evalm_year.ForeColor = System.Drawing.SystemColors.WindowText;
            this.q_evalm_year.Location = new System.Drawing.Point(97, 7);
            this.q_evalm_year.Mask = "0000";
            this.q_evalm_year.Name = "q_evalm_year";
            this.q_evalm_year.Size = new System.Drawing.Size(47, 21);
            this.q_evalm_year.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "평가차수";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "평가년도";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
        private System.Windows.Forms.TextBox ct_evalm_type;
        private System.Windows.Forms.MaskedTextBox ct_evalm_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ct_evalm_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_evalm_stage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_evalm_stage;
        private System.Windows.Forms.MaskedTextBox q_evalm_no;
        private System.Windows.Forms.TextBox q_evalm_tee;
        private System.Windows.Forms.MaskedTextBox q_evalm_year;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ct_evalm_tor;
        public System.Windows.Forms.TextBox ct_evalm_tee;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tee;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key4;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.MaskedTextBox ct_evalm_period;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ct_evalm_pos_tor;
        public System.Windows.Forms.TextBox ct_evalm_dut_tor;
        public System.Windows.Forms.TextBox ct_evalm_pos_tee;
        public System.Windows.Forms.TextBox ct_evalm_dept_tor;
        public System.Windows.Forms.TextBox ct_evalm_dept_tee;
    }
}

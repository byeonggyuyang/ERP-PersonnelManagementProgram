namespace ybgSub021
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evalm_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor_dut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tee_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tee_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_findate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q_evalm_tee_name = new System.Windows.Forms.TextBox();
            this.q_evalm_tor_name = new System.Windows.Forms.TextBox();
            this.q_evalm_no = new System.Windows.Forms.ComboBox();
            this.q_evalm_year = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q_evalp_edate = new System.Windows.Forms.TextBox();
            this.q_evalp_sdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.q_evalp_period = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evalm_tor,
            this.evalm_tor_name,
            this.evalm_tor_dept,
            this.evalm_tor_pos,
            this.evalm_tor_dut,
            this.evalm_tee,
            this.evalm_tee_name,
            this.evalm_tee_dept,
            this.evalm_tee_pos,
            this.evalm_findate,
            this.evalm_total,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 679);
            this.dataGridView1.TabIndex = 263;
            // 
            // evalm_tor
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_tor.DefaultCellStyle = dataGridViewCellStyle7;
            this.evalm_tor.HeaderText = "평가자";
            this.evalm_tor.Name = "evalm_tor";
            this.evalm_tor.ReadOnly = true;
            this.evalm_tor.Width = 60;
            // 
            // evalm_tor_name
            // 
            this.evalm_tor_name.HeaderText = "성명";
            this.evalm_tor_name.Name = "evalm_tor_name";
            this.evalm_tor_name.ReadOnly = true;
            this.evalm_tor_name.Width = 60;
            // 
            // evalm_tor_dept
            // 
            this.evalm_tor_dept.HeaderText = "당시소속";
            this.evalm_tor_dept.Name = "evalm_tor_dept";
            this.evalm_tor_dept.ReadOnly = true;
            // 
            // evalm_tor_pos
            // 
            this.evalm_tor_pos.HeaderText = "당시직급";
            this.evalm_tor_pos.Name = "evalm_tor_pos";
            this.evalm_tor_pos.ReadOnly = true;
            this.evalm_tor_pos.Width = 60;
            // 
            // evalm_tor_dut
            // 
            this.evalm_tor_dut.HeaderText = "당시직책";
            this.evalm_tor_dut.Name = "evalm_tor_dut";
            this.evalm_tor_dut.ReadOnly = true;
            this.evalm_tor_dut.Width = 60;
            // 
            // evalm_tee
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_tee.DefaultCellStyle = dataGridViewCellStyle8;
            this.evalm_tee.HeaderText = "피평가자";
            this.evalm_tee.Name = "evalm_tee";
            this.evalm_tee.ReadOnly = true;
            this.evalm_tee.Width = 60;
            // 
            // evalm_tee_name
            // 
            this.evalm_tee_name.HeaderText = "성명";
            this.evalm_tee_name.Name = "evalm_tee_name";
            this.evalm_tee_name.ReadOnly = true;
            this.evalm_tee_name.Width = 60;
            // 
            // evalm_tee_dept
            // 
            this.evalm_tee_dept.HeaderText = "당시소속";
            this.evalm_tee_dept.Name = "evalm_tee_dept";
            this.evalm_tee_dept.ReadOnly = true;
            // 
            // evalm_tee_pos
            // 
            this.evalm_tee_pos.HeaderText = "당시직급";
            this.evalm_tee_pos.Name = "evalm_tee_pos";
            this.evalm_tee_pos.ReadOnly = true;
            this.evalm_tee_pos.Width = 60;
            // 
            // evalm_findate
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_findate.DefaultCellStyle = dataGridViewCellStyle9;
            this.evalm_findate.HeaderText = "평가완료일";
            this.evalm_findate.Name = "evalm_findate";
            this.evalm_findate.ReadOnly = true;
            this.evalm_findate.Width = 80;
            // 
            // evalm_total
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_total.DefaultCellStyle = dataGridViewCellStyle10;
            this.evalm_total.HeaderText = "평가총점";
            this.evalm_total.Name = "evalm_total";
            this.evalm_total.ReadOnly = true;
            this.evalm_total.Width = 60;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "비고";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q_evalm_tee_name);
            this.panel1.Controls.Add(this.q_evalm_tor_name);
            this.panel1.Controls.Add(this.q_evalm_no);
            this.panel1.Controls.Add(this.q_evalm_year);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.q_evalp_edate);
            this.panel1.Controls.Add(this.q_evalp_sdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.q_evalp_period);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 34);
            this.panel1.TabIndex = 4;
            // 
            // q_evalm_tee_name
            // 
            this.q_evalm_tee_name.Location = new System.Drawing.Point(899, 9);
            this.q_evalm_tee_name.Name = "q_evalm_tee_name";
            this.q_evalm_tee_name.Size = new System.Drawing.Size(72, 21);
            this.q_evalm_tee_name.TabIndex = 280;
            // 
            // q_evalm_tor_name
            // 
            this.q_evalm_tor_name.Location = new System.Drawing.Point(762, 9);
            this.q_evalm_tor_name.Name = "q_evalm_tor_name";
            this.q_evalm_tor_name.Size = new System.Drawing.Size(72, 21);
            this.q_evalm_tor_name.TabIndex = 279;
            // 
            // q_evalm_no
            // 
            this.q_evalm_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_evalm_no.FormattingEnabled = true;
            this.q_evalm_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.q_evalm_no.Location = new System.Drawing.Point(197, 9);
            this.q_evalm_no.Name = "q_evalm_no";
            this.q_evalm_no.Size = new System.Drawing.Size(48, 20);
            this.q_evalm_no.TabIndex = 1;
            // 
            // q_evalm_year
            // 
            this.q_evalm_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_evalm_year.FormattingEnabled = true;
            this.q_evalm_year.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.q_evalm_year.Location = new System.Drawing.Point(84, 9);
            this.q_evalm_year.Name = "q_evalm_year";
            this.q_evalm_year.Size = new System.Drawing.Size(48, 20);
            this.q_evalm_year.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 276;
            this.label6.Text = "피평가자";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 274;
            this.label5.Text = "평가자";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 272;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 271;
            this.label3.Text = "평가가능기간";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_evalp_edate
            // 
            this.q_evalp_edate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.q_evalp_edate.Location = new System.Drawing.Point(638, 9);
            this.q_evalp_edate.Margin = new System.Windows.Forms.Padding(2);
            this.q_evalp_edate.Name = "q_evalp_edate";
            this.q_evalp_edate.ReadOnly = true;
            this.q_evalp_edate.Size = new System.Drawing.Size(72, 21);
            this.q_evalp_edate.TabIndex = 268;
            this.q_evalp_edate.Tag = "";
            // 
            // q_evalp_sdate
            // 
            this.q_evalp_sdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.q_evalp_sdate.Location = new System.Drawing.Point(549, 9);
            this.q_evalp_sdate.Margin = new System.Windows.Forms.Padding(2);
            this.q_evalp_sdate.Name = "q_evalp_sdate";
            this.q_evalp_sdate.ReadOnly = true;
            this.q_evalp_sdate.Size = new System.Drawing.Size(72, 21);
            this.q_evalp_sdate.TabIndex = 267;
            this.q_evalp_sdate.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 266;
            this.label2.Text = "평가차수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 265;
            this.label1.Text = "평가년도";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_evalp_period
            // 
            this.q_evalp_period.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.q_evalp_period.Location = new System.Drawing.Point(333, 8);
            this.q_evalp_period.Margin = new System.Windows.Forms.Padding(2);
            this.q_evalp_period.Name = "q_evalp_period";
            this.q_evalp_period.ReadOnly = true;
            this.q_evalp_period.Size = new System.Drawing.Size(129, 21);
            this.q_evalp_period.TabIndex = 2;
            this.q_evalp_period.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 263;
            this.label14.Text = "평가대상기간";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor_dut;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tee;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tee_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tee_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_findate;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox q_evalm_tee_name;
        private System.Windows.Forms.TextBox q_evalm_tor_name;
        private System.Windows.Forms.ComboBox q_evalm_no;
        private System.Windows.Forms.ComboBox q_evalm_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_evalp_edate;
        private System.Windows.Forms.TextBox q_evalp_sdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q_evalp_period;
        private System.Windows.Forms.Label label14;
    }
}

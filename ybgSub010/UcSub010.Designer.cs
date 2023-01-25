namespace ybgSub010
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lic_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_acqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_organ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_panel = new System.Windows.Forms.Panel();
            this.q_bas_pos = new System.Windows.Forms.ComboBox();
            this.q_bas_dept = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.q_bas_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_bas_empno = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_lic_grade = new System.Windows.Forms.TextBox();
            this.ct_lic_organ = new System.Windows.Forms.TextBox();
            this.ct_lic_acqdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_lic_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ct_bas_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_bas_empno = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.data_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 725);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lic_name,
            this.lic_grade,
            this.lic_acqdate,
            this.lic_organ,
            this.lic_empno,
            this.key1,
            this.key2,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(407, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 443);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // lic_name
            // 
            this.lic_name.HeaderText = "자격증명";
            this.lic_name.Name = "lic_name";
            this.lic_name.ReadOnly = true;
            // 
            // lic_grade
            // 
            this.lic_grade.HeaderText = "급수";
            this.lic_grade.Name = "lic_grade";
            this.lic_grade.ReadOnly = true;
            // 
            // lic_acqdate
            // 
            this.lic_acqdate.HeaderText = "취득일";
            this.lic_acqdate.Name = "lic_acqdate";
            this.lic_acqdate.ReadOnly = true;
            // 
            // lic_organ
            // 
            this.lic_organ.HeaderText = "발급기관";
            this.lic_organ.Name = "lic_organ";
            this.lic_organ.ReadOnly = true;
            // 
            // lic_empno
            // 
            this.lic_empno.HeaderText = "사원번호";
            this.lic_empno.Name = "lic_empno";
            this.lic_empno.ReadOnly = true;
            this.lic_empno.Visible = false;
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
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
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
            this.search_panel.TabIndex = 3;
            // 
            // q_bas_pos
            // 
            this.q_bas_pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_bas_pos.FormattingEnabled = true;
            this.q_bas_pos.Location = new System.Drawing.Point(502, 7);
            this.q_bas_pos.Name = "q_bas_pos";
            this.q_bas_pos.Size = new System.Drawing.Size(89, 20);
            this.q_bas_pos.TabIndex = 25;
            // 
            // q_bas_dept
            // 
            this.q_bas_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q_bas_dept.FormattingEnabled = true;
            this.q_bas_dept.Location = new System.Drawing.Point(361, 7);
            this.q_bas_dept.Name = "q_bas_dept";
            this.q_bas_dept.Size = new System.Drawing.Size(89, 20);
            this.q_bas_dept.TabIndex = 24;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(467, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 23;
            this.label38.Text = "직급";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(326, 12);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 22;
            this.label37.Text = "부서";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "성명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_bas_name
            // 
            this.q_bas_name.Location = new System.Drawing.Point(220, 7);
            this.q_bas_name.Name = "q_bas_name";
            this.q_bas_name.Size = new System.Drawing.Size(89, 21);
            this.q_bas_name.TabIndex = 15;
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
            this.q_bas_empno.Location = new System.Drawing.Point(85, 7);
            this.q_bas_empno.Name = "q_bas_empno";
            this.q_bas_empno.Size = new System.Drawing.Size(89, 21);
            this.q_bas_empno.TabIndex = 13;
            this.q_bas_empno.Tag = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept,
            this.Column1});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 47);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 20;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView, 2);
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(394, 673);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // bas_empno
            // 
            this.bas_empno.DataPropertyName = "bas_empno";
            this.bas_empno.FillWeight = 80F;
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            this.bas_empno.Width = 80;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "dept_name";
            this.bas_dept.HeaderText = "부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pos_name";
            this.Column1.HeaderText = "직급";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.data_panel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(407, 498);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(846, 222);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_lic_grade);
            this.data_panel.Controls.Add(this.ct_lic_organ);
            this.data_panel.Controls.Add(this.ct_lic_acqdate);
            this.data_panel.Controls.Add(this.ct_lic_name);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(4, 35);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(838, 183);
            this.data_panel.TabIndex = 7;
            // 
            // ct_lic_grade
            // 
            this.ct_lic_grade.Location = new System.Drawing.Point(96, 46);
            this.ct_lic_grade.Name = "ct_lic_grade";
            this.ct_lic_grade.Size = new System.Drawing.Size(156, 21);
            this.ct_lic_grade.TabIndex = 1;
            this.ct_lic_grade.Tag = "";
            // 
            // ct_lic_organ
            // 
            this.ct_lic_organ.Location = new System.Drawing.Point(350, 19);
            this.ct_lic_organ.Name = "ct_lic_organ";
            this.ct_lic_organ.Size = new System.Drawing.Size(156, 21);
            this.ct_lic_organ.TabIndex = 2;
            this.ct_lic_organ.Tag = "";
            // 
            // ct_lic_acqdate
            // 
            this.ct_lic_acqdate.Location = new System.Drawing.Point(350, 46);
            this.ct_lic_acqdate.Mask = "0000-00-00";
            this.ct_lic_acqdate.Name = "ct_lic_acqdate";
            this.ct_lic_acqdate.Size = new System.Drawing.Size(156, 21);
            this.ct_lic_acqdate.TabIndex = 3;
            this.ct_lic_acqdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_lic_name
            // 
            this.ct_lic_name.Location = new System.Drawing.Point(96, 19);
            this.ct_lic_name.Name = "ct_lic_name";
            this.ct_lic_name.Size = new System.Drawing.Size(156, 21);
            this.ct_lic_name.TabIndex = 0;
            this.ct_lic_name.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "취득일";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "급수";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "발급기관";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "자격증명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ct_bas_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ct_bas_empno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 24);
            this.panel1.TabIndex = 8;
            // 
            // ct_bas_name
            // 
            this.ct_bas_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_name.Location = new System.Drawing.Point(167, 2);
            this.ct_bas_name.MaxLength = 5;
            this.ct_bas_name.Name = "ct_bas_name";
            this.ct_bas_name.ReadOnly = true;
            this.ct_bas_name.Size = new System.Drawing.Size(80, 21);
            this.ct_bas_name.TabIndex = 22;
            this.ct_bas_name.TabStop = false;
            this.ct_bas_name.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "사원정보";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_bas_empno
            // 
            this.ct_bas_empno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ct_bas_empno.Location = new System.Drawing.Point(91, 2);
            this.ct_bas_empno.MaxLength = 5;
            this.ct_bas_empno.Name = "ct_bas_empno";
            this.ct_bas_empno.ReadOnly = true;
            this.ct_bas_empno.Size = new System.Drawing.Size(74, 21);
            this.ct_bas_empno.TabIndex = 20;
            this.ct_bas_empno.TabStop = false;
            this.ct_bas_empno.Tag = "";
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
            this.Size = new System.Drawing.Size(1258, 725);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_acqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_organ;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.ComboBox q_bas_pos;
        private System.Windows.Forms.ComboBox q_bas_dept;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_bas_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_bas_empno;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox ct_lic_grade;
        private System.Windows.Forms.TextBox ct_lic_organ;
        private System.Windows.Forms.MaskedTextBox ct_lic_acqdate;
        private System.Windows.Forms.TextBox ct_lic_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ct_bas_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_bas_empno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

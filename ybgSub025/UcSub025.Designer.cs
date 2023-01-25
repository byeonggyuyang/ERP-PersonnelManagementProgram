namespace ybgSub025
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pos = new System.Windows.Forms.ComboBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 725);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.panel1);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1094, 34);
            this.search_panel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empno);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 33);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 333;
            this.label5.Text = "이름";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 332;
            this.button1.Text = "증명서 재발급";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pos
            // 
            this.pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pos.FormattingEnabled = true;
            this.pos.Items.AddRange(new object[] {
            ""});
            this.pos.Location = new System.Drawing.Point(388, 8);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(73, 20);
            this.pos.TabIndex = 331;
            // 
            // dept
            // 
            this.dept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            ""});
            this.dept.Location = new System.Drawing.Point(279, 8);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(68, 20);
            this.dept.TabIndex = 330;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 329;
            this.label1.Text = "직급";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 328;
            this.label2.Text = "부서";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 327;
            this.label3.Text = "사번";
            // 
            // empno
            // 
            this.empno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empno.Location = new System.Drawing.Point(164, 7);
            this.empno.Name = "empno";
            this.empno.Size = new System.Drawing.Size(74, 21);
            this.empno.TabIndex = 326;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(50, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 21);
            this.name.TabIndex = 324;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_name,
            this.ceri_empno,
            this.ceri_no,
            this.ceri_kind,
            this.ceri_date,
            this.ceri_lang,
            this.ceri_cnt});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 673);
            this.dataGridView1.TabIndex = 3;
            // 
            // bas_name
            // 
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            // 
            // ceri_empno
            // 
            this.ceri_empno.HeaderText = "사원번호";
            this.ceri_empno.Name = "ceri_empno";
            this.ceri_empno.ReadOnly = true;
            // 
            // ceri_no
            // 
            this.ceri_no.HeaderText = "증명서번호";
            this.ceri_no.Name = "ceri_no";
            this.ceri_no.ReadOnly = true;
            // 
            // ceri_kind
            // 
            this.ceri_kind.HeaderText = "증명서종류";
            this.ceri_kind.Name = "ceri_kind";
            this.ceri_kind.ReadOnly = true;
            // 
            // ceri_date
            // 
            this.ceri_date.HeaderText = "발급일자";
            this.ceri_date.Name = "ceri_date";
            this.ceri_date.ReadOnly = true;
            // 
            // ceri_lang
            // 
            this.ceri_lang.HeaderText = "발급언어";
            this.ceri_lang.Name = "ceri_lang";
            this.ceri_lang.ReadOnly = true;
            // 
            // ceri_cnt
            // 
            this.ceri_cnt.HeaderText = "발급부수";
            this.ceri_cnt.Name = "ceri_cnt";
            this.ceri_cnt.ReadOnly = true;
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
            this.search_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_cnt;
    }
}

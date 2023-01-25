namespace ybgSub015
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.q_papr_date2 = new System.Windows.Forms.MaskedTextBox();
            this.q_papr_date1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_papr_appno = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.papr_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 725);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label4);
            this.search_panel.Controls.Add(this.label2);
            this.search_panel.Controls.Add(this.q_papr_date2);
            this.search_panel.Controls.Add(this.q_papr_date1);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_papr_appno);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(5, 5);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1094, 34);
            this.search_panel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 258;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 257;
            this.label2.Text = "시행일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papr_date2
            // 
            this.q_papr_date2.Location = new System.Drawing.Point(411, 8);
            this.q_papr_date2.Mask = "0000-00-00";
            this.q_papr_date2.Name = "q_papr_date2";
            this.q_papr_date2.Size = new System.Drawing.Size(120, 21);
            this.q_papr_date2.TabIndex = 256;
            // 
            // q_papr_date1
            // 
            this.q_papr_date1.Location = new System.Drawing.Point(268, 8);
            this.q_papr_date1.Mask = "0000-00-00";
            this.q_papr_date1.Name = "q_papr_date1";
            this.q_papr_date1.Size = new System.Drawing.Size(120, 21);
            this.q_papr_date1.TabIndex = 255;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 254;
            this.label12.Text = "인사발령번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papr_appno
            // 
            this.q_papr_appno.Location = new System.Drawing.Point(97, 10);
            this.q_papr_appno.Name = "q_papr_appno";
            this.q_papr_appno.Size = new System.Drawing.Size(89, 21);
            this.q_papr_appno.TabIndex = 253;
            this.q_papr_appno.Tag = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papr_appno,
            this.papr_date,
            this.papr_content,
            this.papr_num});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView, 2);
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(534, 673);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // papr_appno
            // 
            this.papr_appno.DataPropertyName = "papr_appno";
            this.papr_appno.HeaderText = "인사발령번호";
            this.papr_appno.Name = "papr_appno";
            this.papr_appno.ReadOnly = true;
            this.papr_appno.Width = 110;
            // 
            // papr_date
            // 
            this.papr_date.DataPropertyName = "papr_date";
            this.papr_date.HeaderText = "시행일자";
            this.papr_date.Name = "papr_date";
            this.papr_date.ReadOnly = true;
            this.papr_date.Width = 80;
            // 
            // papr_content
            // 
            this.papr_content.DataPropertyName = "papr_content";
            this.papr_content.HeaderText = "발령내용";
            this.papr_content.Name = "papr_content";
            this.papr_content.ReadOnly = true;
            this.papr_content.Width = 180;
            // 
            // papr_num
            // 
            this.papr_num.DataPropertyName = "papr_num";
            this.papr_num.HeaderText = "발령인원수";
            this.papr_num.Name = "papr_num";
            this.papr_num.ReadOnly = true;
            this.papr_num.Width = 120;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Location = new System.Drawing.Point(547, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 673);
            this.dataGridView1.TabIndex = 4;
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1104, 725);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox q_papr_date2;
        private System.Windows.Forms.MaskedTextBox q_papr_date1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_num;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

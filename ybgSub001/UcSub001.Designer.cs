namespace ybgSub001
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
            this.cdg_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cdg_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_cdg_length = new System.Windows.Forms.TextBox();
            this.ct_cdg_digit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_cdg_kind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_cdg_grpnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_cdg_use = new System.Windows.Forms.CheckBox();
            this.ct_cdg_grpcd = new System.Windows.Forms.TextBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_cdg_grpnm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_cdg_grpcd = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 725);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.cdg_grpcd,
            this.cdg_grpnm,
            this.cdg_digit,
            this.cdg_length,
            this.cdg_use,
            this.cdg_kind,
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
            // cdg_grpcd
            // 
            this.cdg_grpcd.HeaderText = "그룹코드";
            this.cdg_grpcd.Name = "cdg_grpcd";
            this.cdg_grpcd.ReadOnly = true;
            // 
            // cdg_grpnm
            // 
            this.cdg_grpnm.HeaderText = "그룹코드명";
            this.cdg_grpnm.Name = "cdg_grpnm";
            this.cdg_grpnm.ReadOnly = true;
            // 
            // cdg_digit
            // 
            this.cdg_digit.HeaderText = "단위코드 자리수";
            this.cdg_digit.Name = "cdg_digit";
            this.cdg_digit.ReadOnly = true;
            this.cdg_digit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cdg_length
            // 
            this.cdg_length.HeaderText = "단위코드명(원형) 길이";
            this.cdg_length.Name = "cdg_length";
            this.cdg_length.ReadOnly = true;
            this.cdg_length.Width = 140;
            // 
            // cdg_use
            // 
            this.cdg_use.HeaderText = "사용여부";
            this.cdg_use.Name = "cdg_use";
            this.cdg_use.ReadOnly = true;
            // 
            // cdg_kind
            // 
            this.cdg_kind.HeaderText = "분류";
            this.cdg_kind.Name = "cdg_kind";
            this.cdg_kind.ReadOnly = true;
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
            this.data_panel.Controls.Add(this.ct_cdg_length);
            this.data_panel.Controls.Add(this.ct_cdg_digit);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.ct_cdg_kind);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_cdg_grpnm);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.ct_cdg_use);
            this.data_panel.Controls.Add(this.ct_cdg_grpcd);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(893, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_cdg_length
            // 
            this.ct_cdg_length.Location = new System.Drawing.Point(169, 102);
            this.ct_cdg_length.Name = "ct_cdg_length";
            this.ct_cdg_length.Size = new System.Drawing.Size(156, 21);
            this.ct_cdg_length.TabIndex = 3;
            this.ct_cdg_length.Tag = "";
            // 
            // ct_cdg_digit
            // 
            this.ct_cdg_digit.Location = new System.Drawing.Point(169, 76);
            this.ct_cdg_digit.Name = "ct_cdg_digit";
            this.ct_cdg_digit.Size = new System.Drawing.Size(156, 21);
            this.ct_cdg_digit.TabIndex = 2;
            this.ct_cdg_digit.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "분류";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "사용여부";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cdg_kind
            // 
            this.ct_cdg_kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_cdg_kind.FormattingEnabled = true;
            this.ct_cdg_kind.Items.AddRange(new object[] {
            "학사행정",
            "일반행정"});
            this.ct_cdg_kind.Location = new System.Drawing.Point(169, 153);
            this.ct_cdg_kind.Name = "ct_cdg_kind";
            this.ct_cdg_kind.Size = new System.Drawing.Size(156, 20);
            this.ct_cdg_kind.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "단위코드명(원형) 길이";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "단위코드 자리수";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "그룹코드명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cdg_grpnm
            // 
            this.ct_cdg_grpnm.Location = new System.Drawing.Point(169, 49);
            this.ct_cdg_grpnm.Name = "ct_cdg_grpnm";
            this.ct_cdg_grpnm.Size = new System.Drawing.Size(156, 21);
            this.ct_cdg_grpnm.TabIndex = 1;
            this.ct_cdg_grpnm.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "그룹코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cdg_use
            // 
            this.ct_cdg_use.AutoSize = true;
            this.ct_cdg_use.Checked = true;
            this.ct_cdg_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_cdg_use.Location = new System.Drawing.Point(169, 132);
            this.ct_cdg_use.Name = "ct_cdg_use";
            this.ct_cdg_use.Size = new System.Drawing.Size(15, 14);
            this.ct_cdg_use.TabIndex = 4;
            this.ct_cdg_use.Tag = "";
            this.ct_cdg_use.UseVisualStyleBackColor = true;
            // 
            // ct_cdg_grpcd
            // 
            this.ct_cdg_grpcd.Location = new System.Drawing.Point(169, 22);
            this.ct_cdg_grpcd.MaxLength = 5;
            this.ct_cdg_grpcd.Name = "ct_cdg_grpcd";
            this.ct_cdg_grpcd.Size = new System.Drawing.Size(156, 21);
            this.ct_cdg_grpcd.TabIndex = 0;
            this.ct_cdg_grpcd.Tag = "";
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_cdg_grpnm);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_cdg_grpcd);
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
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "그룹코드명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_cdg_grpnm
            // 
            this.q_cdg_grpnm.Location = new System.Drawing.Point(257, 7);
            this.q_cdg_grpnm.Name = "q_cdg_grpnm";
            this.q_cdg_grpnm.Size = new System.Drawing.Size(89, 21);
            this.q_cdg_grpnm.TabIndex = 15;
            this.q_cdg_grpnm.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "그룹코드";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_cdg_grpcd
            // 
            this.q_cdg_grpcd.Location = new System.Drawing.Point(85, 7);
            this.q_cdg_grpcd.Name = "q_cdg_grpcd";
            this.q_cdg_grpcd.Size = new System.Drawing.Size(89, 21);
            this.q_cdg_grpcd.TabIndex = 13;
            this.q_cdg_grpcd.Tag = "";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_length;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdg_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.TextBox ct_cdg_length;
        private System.Windows.Forms.TextBox ct_cdg_digit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ct_cdg_kind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_cdg_grpnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ct_cdg_use;
        private System.Windows.Forms.TextBox ct_cdg_grpcd;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_cdg_grpnm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_cdg_grpcd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

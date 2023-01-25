namespace ybgSub016
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_evali_points = new System.Windows.Forms.MaskedTextBox();
            this.ct_evali_gap = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_evali_item_l = new System.Windows.Forms.TextBox();
            this.ct_evali_itmeno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_evali_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_evali_itmeno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_evali_type = new System.Windows.Forms.TextBox();
            this.ct_evali_item_s = new System.Windows.Forms.TextBox();
            this.evali_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_itmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_gap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.evali_type,
            this.evali_itmeno,
            this.evali_item_l,
            this.evali_item_s,
            this.evali_points,
            this.evali_gap,
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
            this.data_panel.Controls.Add(this.ct_evali_item_s);
            this.data_panel.Controls.Add(this.ct_evali_points);
            this.data_panel.Controls.Add(this.ct_evali_gap);
            this.data_panel.Controls.Add(this.label10);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_evali_item_l);
            this.data_panel.Controls.Add(this.ct_evali_itmeno);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_evali_type);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(739, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_evali_points
            // 
            this.ct_evali_points.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_evali_points.Location = new System.Drawing.Point(102, 158);
            this.ct_evali_points.Mask = "00";
            this.ct_evali_points.Name = "ct_evali_points";
            this.ct_evali_points.Size = new System.Drawing.Size(156, 21);
            this.ct_evali_points.TabIndex = 37;
            this.ct_evali_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ct_evali_gap
            // 
            this.ct_evali_gap.Location = new System.Drawing.Point(102, 185);
            this.ct_evali_gap.Mask = "0";
            this.ct_evali_gap.Name = "ct_evali_gap";
            this.ct_evali_gap.Size = new System.Drawing.Size(156, 21);
            this.ct_evali_gap.TabIndex = 7;
            this.ct_evali_gap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "평점간격";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "배점";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "소항목";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "대항목";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_evali_item_l
            // 
            this.ct_evali_item_l.Location = new System.Drawing.Point(102, 82);
            this.ct_evali_item_l.Name = "ct_evali_item_l";
            this.ct_evali_item_l.Size = new System.Drawing.Size(156, 21);
            this.ct_evali_item_l.TabIndex = 3;
            this.ct_evali_item_l.Tag = "";
            // 
            // ct_evali_itmeno
            // 
            this.ct_evali_itmeno.Location = new System.Drawing.Point(102, 55);
            this.ct_evali_itmeno.Name = "ct_evali_itmeno";
            this.ct_evali_itmeno.Size = new System.Drawing.Size(156, 21);
            this.ct_evali_itmeno.TabIndex = 2;
            this.ct_evali_itmeno.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "평가표 유형";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_evali_type
            // 
            this.ct_evali_type.Location = new System.Drawing.Point(102, 28);
            this.ct_evali_type.Name = "ct_evali_type";
            this.ct_evali_type.Size = new System.Drawing.Size(156, 21);
            this.ct_evali_type.TabIndex = 1;
            this.ct_evali_type.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "항목번호";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_evali_itmeno);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_evali_type);
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
            this.label13.Text = "항목번호";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_evali_itmeno
            // 
            this.q_evali_itmeno.Location = new System.Drawing.Point(250, 7);
            this.q_evali_itmeno.Name = "q_evali_itmeno";
            this.q_evali_itmeno.Size = new System.Drawing.Size(89, 21);
            this.q_evali_itmeno.TabIndex = 15;
            this.q_evali_itmeno.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "평가표 유형";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_evali_type
            // 
            this.q_evali_type.Location = new System.Drawing.Point(96, 7);
            this.q_evali_type.Name = "q_evali_type";
            this.q_evali_type.Size = new System.Drawing.Size(89, 21);
            this.q_evali_type.TabIndex = 13;
            this.q_evali_type.Tag = "";
            // 
            // ct_evali_item_s
            // 
            this.ct_evali_item_s.Location = new System.Drawing.Point(102, 109);
            this.ct_evali_item_s.Multiline = true;
            this.ct_evali_item_s.Name = "ct_evali_item_s";
            this.ct_evali_item_s.Size = new System.Drawing.Size(156, 43);
            this.ct_evali_item_s.TabIndex = 38;
            this.ct_evali_item_s.Tag = "";
            // 
            // evali_type
            // 
            this.evali_type.HeaderText = "평가표 유형";
            this.evali_type.Name = "evali_type";
            this.evali_type.ReadOnly = true;
            // 
            // evali_itmeno
            // 
            this.evali_itmeno.HeaderText = "항목번호";
            this.evali_itmeno.Name = "evali_itmeno";
            this.evali_itmeno.ReadOnly = true;
            // 
            // evali_item_l
            // 
            this.evali_item_l.HeaderText = "대항목";
            this.evali_item_l.Name = "evali_item_l";
            this.evali_item_l.ReadOnly = true;
            // 
            // evali_item_s
            // 
            this.evali_item_s.HeaderText = "소항목";
            this.evali_item_s.Name = "evali_item_s";
            this.evali_item_s.ReadOnly = true;
            this.evali_item_s.Width = 150;
            // 
            // evali_points
            // 
            this.evali_points.HeaderText = "배점";
            this.evali_points.Name = "evali_points";
            this.evali_points.ReadOnly = true;
            // 
            // evali_gap
            // 
            this.evali_gap.HeaderText = "평점간격";
            this.evali_gap.Name = "evali_gap";
            this.evali_gap.ReadOnly = true;
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
        private System.Windows.Forms.MaskedTextBox ct_evali_points;
        private System.Windows.Forms.MaskedTextBox ct_evali_gap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_evali_item_l;
        private System.Windows.Forms.TextBox ct_evali_itmeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_evali_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_evali_itmeno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_evali_type;
        private System.Windows.Forms.TextBox ct_evali_item_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_itmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_gap;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

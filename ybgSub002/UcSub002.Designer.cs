namespace ybgSub002
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
            this.cd_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_codnms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_codnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_addinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cd_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_cd_edate = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_cd_upper = new System.Windows.Forms.TextBox();
            this.ct_cd_addinfo = new System.Windows.Forms.TextBox();
            this.ct_cd_codnm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_cd_codnms = new System.Windows.Forms.TextBox();
            this.ct_cd_seq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_cd_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_cd_use = new System.Windows.Forms.CheckBox();
            this.ct_cd_grpcd = new System.Windows.Forms.TextBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.q_cd_codnms = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_cd_grpcd = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ct_cd_sdate = new System.Windows.Forms.MaskedTextBox();
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
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.cd_grpcd,
            this.cd_code,
            this.cd_seq,
            this.cd_codnms,
            this.cd_codnm,
            this.cd_addinfo,
            this.cd_upper,
            this.cd_use,
            this.cd_sdate,
            this.cd_edate,
            this.datasys1,
            this.datasys2,
            this.datasys3,
            this.key1,
            this.key2,
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
            // cd_grpcd
            // 
            this.cd_grpcd.HeaderText = "그룹코드";
            this.cd_grpcd.Name = "cd_grpcd";
            this.cd_grpcd.ReadOnly = true;
            // 
            // cd_code
            // 
            this.cd_code.HeaderText = "코드";
            this.cd_code.Name = "cd_code";
            this.cd_code.ReadOnly = true;
            // 
            // cd_seq
            // 
            this.cd_seq.HeaderText = "코드 Seq";
            this.cd_seq.Name = "cd_seq";
            this.cd_seq.ReadOnly = true;
            this.cd_seq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cd_codnms
            // 
            this.cd_codnms.HeaderText = "코드명(축약)";
            this.cd_codnms.Name = "cd_codnms";
            this.cd_codnms.ReadOnly = true;
            this.cd_codnms.Width = 120;
            // 
            // cd_codnm
            // 
            this.cd_codnm.HeaderText = "코드명(원형)";
            this.cd_codnm.Name = "cd_codnm";
            this.cd_codnm.ReadOnly = true;
            this.cd_codnm.Width = 120;
            // 
            // cd_addinfo
            // 
            this.cd_addinfo.HeaderText = "추가정보";
            this.cd_addinfo.Name = "cd_addinfo";
            this.cd_addinfo.ReadOnly = true;
            // 
            // cd_upper
            // 
            this.cd_upper.HeaderText = "상위분류";
            this.cd_upper.Name = "cd_upper";
            this.cd_upper.ReadOnly = true;
            // 
            // cd_use
            // 
            this.cd_use.HeaderText = "사용여부";
            this.cd_use.Name = "cd_use";
            this.cd_use.ReadOnly = true;
            // 
            // cd_sdate
            // 
            this.cd_sdate.HeaderText = "생성일자";
            this.cd_sdate.Name = "cd_sdate";
            this.cd_sdate.ReadOnly = true;
            this.cd_sdate.Width = 120;
            // 
            // cd_edate
            // 
            this.cd_edate.HeaderText = "폐기일자";
            this.cd_edate.Name = "cd_edate";
            this.cd_edate.ReadOnly = true;
            this.cd_edate.Width = 120;
            // 
            // datasys1
            // 
            this.datasys1.HeaderText = "자료처리일시";
            this.datasys1.Name = "datasys1";
            this.datasys1.ReadOnly = true;
            this.datasys1.Visible = false;
            // 
            // datasys2
            // 
            this.datasys2.HeaderText = "자료처리구분";
            this.datasys2.Name = "datasys2";
            this.datasys2.ReadOnly = true;
            this.datasys2.Visible = false;
            // 
            // datasys3
            // 
            this.datasys3.HeaderText = "자료처리자";
            this.datasys3.Name = "datasys3";
            this.datasys3.ReadOnly = true;
            this.datasys3.Visible = false;
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
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_cd_sdate);
            this.data_panel.Controls.Add(this.ct_cd_edate);
            this.data_panel.Controls.Add(this.label10);
            this.data_panel.Controls.Add(this.label9);
            this.data_panel.Controls.Add(this.label8);
            this.data_panel.Controls.Add(this.label7);
            this.data_panel.Controls.Add(this.ct_cd_upper);
            this.data_panel.Controls.Add(this.ct_cd_addinfo);
            this.data_panel.Controls.Add(this.ct_cd_codnm);
            this.data_panel.Controls.Add(this.label6);
            this.data_panel.Controls.Add(this.ct_cd_codnms);
            this.data_panel.Controls.Add(this.ct_cd_seq);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.label5);
            this.data_panel.Controls.Add(this.label4);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.ct_cd_code);
            this.data_panel.Controls.Add(this.label2);
            this.data_panel.Controls.Add(this.ct_cd_use);
            this.data_panel.Controls.Add(this.ct_cd_grpcd);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(893, 47);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(360, 673);
            this.data_panel.TabIndex = 1;
            // 
            // ct_cd_edate
            // 
            this.ct_cd_edate.Location = new System.Drawing.Point(99, 263);
            this.ct_cd_edate.Mask = "0000-00-00";
            this.ct_cd_edate.Name = "ct_cd_edate";
            this.ct_cd_edate.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_edate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "폐기일자";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "생성일자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "상위분류";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "추가정보";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cd_upper
            // 
            this.ct_cd_upper.Location = new System.Drawing.Point(99, 182);
            this.ct_cd_upper.Name = "ct_cd_upper";
            this.ct_cd_upper.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_upper.TabIndex = 6;
            this.ct_cd_upper.Tag = "";
            // 
            // ct_cd_addinfo
            // 
            this.ct_cd_addinfo.Location = new System.Drawing.Point(99, 155);
            this.ct_cd_addinfo.Name = "ct_cd_addinfo";
            this.ct_cd_addinfo.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_addinfo.TabIndex = 5;
            this.ct_cd_addinfo.Tag = "";
            // 
            // ct_cd_codnm
            // 
            this.ct_cd_codnm.Location = new System.Drawing.Point(99, 128);
            this.ct_cd_codnm.Name = "ct_cd_codnm";
            this.ct_cd_codnm.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_codnm.TabIndex = 4;
            this.ct_cd_codnm.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "코드명(원형)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cd_codnms
            // 
            this.ct_cd_codnms.Location = new System.Drawing.Point(99, 101);
            this.ct_cd_codnms.Name = "ct_cd_codnms";
            this.ct_cd_codnms.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_codnms.TabIndex = 3;
            this.ct_cd_codnms.Tag = "";
            // 
            // ct_cd_seq
            // 
            this.ct_cd_seq.Location = new System.Drawing.Point(99, 75);
            this.ct_cd_seq.Name = "ct_cd_seq";
            this.ct_cd_seq.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_seq.TabIndex = 2;
            this.ct_cd_seq.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "사용여부";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "코드명(축약)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "코드 Seq";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cd_code
            // 
            this.ct_cd_code.Location = new System.Drawing.Point(99, 48);
            this.ct_cd_code.Name = "ct_cd_code";
            this.ct_cd_code.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_code.TabIndex = 1;
            this.ct_cd_code.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "그룹코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ct_cd_use
            // 
            this.ct_cd_use.AutoSize = true;
            this.ct_cd_use.Checked = true;
            this.ct_cd_use.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ct_cd_use.Location = new System.Drawing.Point(99, 212);
            this.ct_cd_use.Name = "ct_cd_use";
            this.ct_cd_use.Size = new System.Drawing.Size(15, 14);
            this.ct_cd_use.TabIndex = 7;
            this.ct_cd_use.Tag = "";
            this.ct_cd_use.UseVisualStyleBackColor = true;
            // 
            // ct_cd_grpcd
            // 
            this.ct_cd_grpcd.Location = new System.Drawing.Point(99, 21);
            this.ct_cd_grpcd.MaxLength = 5;
            this.ct_cd_grpcd.Name = "ct_cd_grpcd";
            this.ct_cd_grpcd.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_grpcd.TabIndex = 0;
            this.ct_cd_grpcd.Tag = "";
            // 
            // search_panel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.q_cd_codnms);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.q_cd_grpcd);
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
            this.label13.Text = "코드명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_cd_codnms
            // 
            this.q_cd_codnms.Location = new System.Drawing.Point(233, 7);
            this.q_cd_codnms.Name = "q_cd_codnms";
            this.q_cd_codnms.Size = new System.Drawing.Size(89, 21);
            this.q_cd_codnms.TabIndex = 15;
            this.q_cd_codnms.Tag = "";
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
            // q_cd_grpcd
            // 
            this.q_cd_grpcd.Location = new System.Drawing.Point(85, 7);
            this.q_cd_grpcd.Name = "q_cd_grpcd";
            this.q_cd_grpcd.Size = new System.Drawing.Size(89, 21);
            this.q_cd_grpcd.TabIndex = 13;
            this.q_cd_grpcd.Tag = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ct_cd_sdate
            // 
            this.ct_cd_sdate.Location = new System.Drawing.Point(99, 234);
            this.ct_cd_sdate.Mask = "0000-00-00";
            this.ct_cd_sdate.Name = "ct_cd_sdate";
            this.ct_cd_sdate.Size = new System.Drawing.Size(156, 21);
            this.ct_cd_sdate.TabIndex = 32;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_codnms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_codnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_addinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_upper;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cd_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys3;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.MaskedTextBox ct_cd_edate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_cd_upper;
        private System.Windows.Forms.TextBox ct_cd_addinfo;
        private System.Windows.Forms.TextBox ct_cd_codnm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_cd_codnms;
        private System.Windows.Forms.TextBox ct_cd_seq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_cd_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ct_cd_use;
        private System.Windows.Forms.TextBox ct_cd_grpcd;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox q_cd_codnms;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_cd_grpcd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox ct_cd_sdate;
    }
}

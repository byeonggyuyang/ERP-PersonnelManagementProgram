namespace ybgSub013
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
            this.papr_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_panel = new System.Windows.Forms.Panel();
            this.ct_papr_num = new System.Windows.Forms.NumericUpDown();
            this.ct_papr_content = new System.Windows.Forms.TextBox();
            this.ct_papr_appno = new System.Windows.Forms.TextBox();
            this.ct_papr_date = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.q_papr_date2 = new System.Windows.Forms.MaskedTextBox();
            this.q_papr_date1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.q_papr_appno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_papr_num)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.data_panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 906);
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
            this.papr_appno,
            this.papr_date,
            this.papr_num,
            this.papr_content,
            this.key1,
            this.key2,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 842);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataList_SelectionChanged);
            // 
            // papr_appno
            // 
            this.papr_appno.HeaderText = "인사발령번호";
            this.papr_appno.MinimumWidth = 6;
            this.papr_appno.Name = "papr_appno";
            this.papr_appno.ReadOnly = true;
            this.papr_appno.Width = 125;
            // 
            // papr_date
            // 
            this.papr_date.HeaderText = "시행일자";
            this.papr_date.MinimumWidth = 6;
            this.papr_date.Name = "papr_date";
            this.papr_date.ReadOnly = true;
            this.papr_date.Width = 120;
            // 
            // papr_num
            // 
            this.papr_num.HeaderText = "발령인원수";
            this.papr_num.MinimumWidth = 6;
            this.papr_num.Name = "papr_num";
            this.papr_num.ReadOnly = true;
            this.papr_num.Width = 125;
            // 
            // papr_content
            // 
            this.papr_content.HeaderText = "발령내용";
            this.papr_content.MinimumWidth = 6;
            this.papr_content.Name = "papr_content";
            this.papr_content.ReadOnly = true;
            this.papr_content.Width = 150;
            // 
            // key1
            // 
            this.key1.HeaderText = "Key1";
            this.key1.MinimumWidth = 6;
            this.key1.Name = "key1";
            this.key1.ReadOnly = true;
            this.key1.Visible = false;
            this.key1.Width = 125;
            // 
            // key2
            // 
            this.key2.HeaderText = "Key2";
            this.key2.MinimumWidth = 6;
            this.key2.Name = "key2";
            this.key2.ReadOnly = true;
            this.key2.Visible = false;
            this.key2.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            this.status.Width = 125;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.ct_papr_num);
            this.data_panel.Controls.Add(this.ct_papr_content);
            this.data_panel.Controls.Add(this.ct_papr_appno);
            this.data_panel.Controls.Add(this.ct_papr_date);
            this.data_panel.Controls.Add(this.label1);
            this.data_panel.Controls.Add(this.label3);
            this.data_panel.Controls.Add(this.label34);
            this.data_panel.Controls.Add(this.label36);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(602, 58);
            this.data_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(412, 842);
            this.data_panel.TabIndex = 1;
            // 
            // ct_papr_num
            // 
            this.ct_papr_num.Location = new System.Drawing.Point(159, 99);
            this.ct_papr_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_papr_num.Name = "ct_papr_num";
            this.ct_papr_num.Size = new System.Drawing.Size(137, 25);
            this.ct_papr_num.TabIndex = 2;
            // 
            // ct_papr_content
            // 
            this.ct_papr_content.Location = new System.Drawing.Point(159, 129);
            this.ct_papr_content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_papr_content.Multiline = true;
            this.ct_papr_content.Name = "ct_papr_content";
            this.ct_papr_content.Size = new System.Drawing.Size(137, 54);
            this.ct_papr_content.TabIndex = 3;
            // 
            // ct_papr_appno
            // 
            this.ct_papr_appno.Location = new System.Drawing.Point(159, 39);
            this.ct_papr_appno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_papr_appno.Name = "ct_papr_appno";
            this.ct_papr_appno.Size = new System.Drawing.Size(137, 25);
            this.ct_papr_appno.TabIndex = 0;
            // 
            // ct_papr_date
            // 
            this.ct_papr_date.Location = new System.Drawing.Point(159, 69);
            this.ct_papr_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_papr_date.Mask = "0000-00-00";
            this.ct_papr_date.Name = "ct_papr_date";
            this.ct_papr_date.Size = new System.Drawing.Size(137, 25);
            this.ct_papr_date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 246;
            this.label1.Text = "인사발령번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 247;
            this.label3.Text = "시행일자";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(51, 101);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(82, 15);
            this.label34.TabIndex = 205;
            this.label34.Text = "발령인원수";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(51, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 15);
            this.label36.TabIndex = 181;
            this.label36.Text = "발령내용";
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
            this.search_panel.Location = new System.Drawing.Point(5, 6);
            this.search_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1009, 42);
            this.search_panel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 252;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 251;
            this.label2.Text = "시행일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papr_date2
            // 
            this.q_papr_date2.Location = new System.Drawing.Point(482, 9);
            this.q_papr_date2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.q_papr_date2.Mask = "0000-00-00";
            this.q_papr_date2.Name = "q_papr_date2";
            this.q_papr_date2.Size = new System.Drawing.Size(137, 25);
            this.q_papr_date2.TabIndex = 250;
            // 
            // q_papr_date1
            // 
            this.q_papr_date1.Location = new System.Drawing.Point(319, 9);
            this.q_papr_date1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.q_papr_date1.Mask = "0000-00-00";
            this.q_papr_date1.Name = "q_papr_date1";
            this.q_papr_date1.Size = new System.Drawing.Size(137, 25);
            this.q_papr_date1.TabIndex = 249;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "인사발령번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q_papr_appno
            // 
            this.q_papr_appno.Location = new System.Drawing.Point(123, 11);
            this.q_papr_appno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.q_papr_appno.Name = "q_papr_appno";
            this.q_papr_appno.Size = new System.Drawing.Size(101, 25);
            this.q_papr_appno.TabIndex = 0;
            this.q_papr_appno.Tag = "";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1019, 906);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_papr_num)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.NumericUpDown ct_papr_num;
        private System.Windows.Forms.TextBox ct_papr_content;
        private System.Windows.Forms.TextBox ct_papr_appno;
        private System.Windows.Forms.MaskedTextBox ct_papr_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox q_papr_date2;
        private System.Windows.Forms.MaskedTextBox q_papr_date1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox q_papr_appno;
    }
}

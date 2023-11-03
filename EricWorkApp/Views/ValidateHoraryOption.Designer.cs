namespace EricWorkApp.Views
{
    partial class ValidateHoraryOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateHoraryOption));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_search_code = new System.Windows.Forms.Label();
            this.dgv_WorksHorary = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Total_Saturday = new System.Windows.Forms.Label();
            this.lbl_Total_Tuesday = new System.Windows.Forms.Label();
            this.lbl_Total_Wednesday = new System.Windows.Forms.Label();
            this.lbl_Total_Sunday = new System.Windows.Forms.Label();
            this.lbl_Total_Thursday = new System.Windows.Forms.Label();
            this.lbl_Total_Friday = new System.Windows.Forms.Label();
            this.lbl__total_Monday = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Thursday = new System.Windows.Forms.Label();
            this.lbl_Wednesday = new System.Windows.Forms.Label();
            this.lbl_Tuesday = new System.Windows.Forms.Label();
            this.lbl_Monday = new System.Windows.Forms.Label();
            this.flp_Friday = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Wednesday = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Sunday = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Saturday = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Thursday = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Tuesday = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.flp_Monday = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorksHorary)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flp_Monday.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel1.Controls.Add(this.lbl_search_code);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_WorksHorary);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Search);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Thursday);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Wednesday);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Tuesday);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Monday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Friday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Wednesday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Sunday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Saturday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Thursday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Tuesday);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Monday);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 621);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_search_code
            // 
            this.lbl_search_code.AutoSize = true;
            this.lbl_search_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_code.Location = new System.Drawing.Point(3, 9);
            this.lbl_search_code.Name = "lbl_search_code";
            this.lbl_search_code.Size = new System.Drawing.Size(97, 15);
            this.lbl_search_code.TabIndex = 3;
            this.lbl_search_code.Text = "Search Code: ";
            // 
            // dgv_WorksHorary
            // 
            this.dgv_WorksHorary.AllowUserToAddRows = false;
            this.dgv_WorksHorary.AllowUserToDeleteRows = false;
            this.dgv_WorksHorary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WorksHorary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCode,
            this.ColumnStartTime,
            this.ColumnEndTime});
            this.dgv_WorksHorary.Location = new System.Drawing.Point(3, 38);
            this.dgv_WorksHorary.Name = "dgv_WorksHorary";
            this.dgv_WorksHorary.ReadOnly = true;
            this.dgv_WorksHorary.Size = new System.Drawing.Size(355, 510);
            this.dgv_WorksHorary.TabIndex = 2;
            this.dgv_WorksHorary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WorksHorary_CellContentClick);
            this.dgv_WorksHorary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_WorksHorary_MouseDown);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 43;
            // 
            // ColumnCode
            // 
            this.ColumnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnCode.HeaderText = "CODE";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 62;
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "START TIME";
            this.ColumnStartTime.Name = "ColumnStartTime";
            this.ColumnStartTime.ReadOnly = true;
            // 
            // ColumnEndTime
            // 
            this.ColumnEndTime.HeaderText = "END TIME";
            this.ColumnEndTime.Name = "ColumnEndTime";
            this.ColumnEndTime.ReadOnly = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(106, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(150, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(615, 558);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(94, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "Analyze";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Saturday, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Tuesday, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Wednesday, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Sunday, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Thursday, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Friday, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl__total_Monday, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 518);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 34);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // lbl_Total_Saturday
            // 
            this.lbl_Total_Saturday.AutoSize = true;
            this.lbl_Total_Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Saturday.Location = new System.Drawing.Point(501, 3);
            this.lbl_Total_Saturday.Name = "lbl_Total_Saturday";
            this.lbl_Total_Saturday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Saturday.TabIndex = 12;
            this.lbl_Total_Saturday.Text = "0";
            // 
            // lbl_Total_Tuesday
            // 
            this.lbl_Total_Tuesday.AutoSize = true;
            this.lbl_Total_Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Tuesday.Location = new System.Drawing.Point(105, 3);
            this.lbl_Total_Tuesday.Name = "lbl_Total_Tuesday";
            this.lbl_Total_Tuesday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Tuesday.TabIndex = 8;
            this.lbl_Total_Tuesday.Text = "0";
            // 
            // lbl_Total_Wednesday
            // 
            this.lbl_Total_Wednesday.AutoSize = true;
            this.lbl_Total_Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Wednesday.Location = new System.Drawing.Point(204, 3);
            this.lbl_Total_Wednesday.Name = "lbl_Total_Wednesday";
            this.lbl_Total_Wednesday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Wednesday.TabIndex = 9;
            this.lbl_Total_Wednesday.Text = "0";
            this.lbl_Total_Wednesday.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Total_Sunday
            // 
            this.lbl_Total_Sunday.AutoSize = true;
            this.lbl_Total_Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Sunday.Location = new System.Drawing.Point(303, 3);
            this.lbl_Total_Sunday.Name = "lbl_Total_Sunday";
            this.lbl_Total_Sunday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Sunday.TabIndex = 13;
            this.lbl_Total_Sunday.Text = "0";
            // 
            // lbl_Total_Thursday
            // 
            this.lbl_Total_Thursday.AutoSize = true;
            this.lbl_Total_Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Thursday.Location = new System.Drawing.Point(402, 3);
            this.lbl_Total_Thursday.Name = "lbl_Total_Thursday";
            this.lbl_Total_Thursday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Thursday.TabIndex = 14;
            this.lbl_Total_Thursday.Text = "0";
            // 
            // lbl_Total_Friday
            // 
            this.lbl_Total_Friday.AutoSize = true;
            this.lbl_Total_Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Friday.Location = new System.Drawing.Point(6, 3);
            this.lbl_Total_Friday.Name = "lbl_Total_Friday";
            this.lbl_Total_Friday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Friday.TabIndex = 11;
            this.lbl_Total_Friday.Text = "0";
            // 
            // lbl__total_Monday
            // 
            this.lbl__total_Monday.AutoSize = true;
            this.lbl__total_Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__total_Monday.Location = new System.Drawing.Point(600, 3);
            this.lbl__total_Monday.Name = "lbl__total_Monday";
            this.lbl__total_Monday.Size = new System.Drawing.Size(26, 28);
            this.lbl__total_Monday.TabIndex = 7;
            this.lbl__total_Monday.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(631, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "Sun";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(535, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Sat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fri";
            // 
            // lbl_Thursday
            // 
            this.lbl_Thursday.AutoSize = true;
            this.lbl_Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thursday.Location = new System.Drawing.Point(333, 6);
            this.lbl_Thursday.Name = "lbl_Thursday";
            this.lbl_Thursday.Size = new System.Drawing.Size(55, 29);
            this.lbl_Thursday.TabIndex = 17;
            this.lbl_Thursday.Text = "Thu";
            // 
            // lbl_Wednesday
            // 
            this.lbl_Wednesday.AutoSize = true;
            this.lbl_Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wednesday.Location = new System.Drawing.Point(228, 6);
            this.lbl_Wednesday.Name = "lbl_Wednesday";
            this.lbl_Wednesday.Size = new System.Drawing.Size(63, 29);
            this.lbl_Wednesday.TabIndex = 16;
            this.lbl_Wednesday.Text = "Wed";
            // 
            // lbl_Tuesday
            // 
            this.lbl_Tuesday.AutoSize = true;
            this.lbl_Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tuesday.Location = new System.Drawing.Point(127, 6);
            this.lbl_Tuesday.Name = "lbl_Tuesday";
            this.lbl_Tuesday.Size = new System.Drawing.Size(56, 29);
            this.lbl_Tuesday.TabIndex = 15;
            this.lbl_Tuesday.Text = "Tue";
            // 
            // lbl_Monday
            // 
            this.lbl_Monday.AutoSize = true;
            this.lbl_Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monday.Location = new System.Drawing.Point(39, 6);
            this.lbl_Monday.Name = "lbl_Monday";
            this.lbl_Monday.Size = new System.Drawing.Size(33, 29);
            this.lbl_Monday.TabIndex = 14;
            this.lbl_Monday.Text = "M";
            // 
            // flp_Friday
            // 
            this.flp_Friday.AutoScroll = true;
            this.flp_Friday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Friday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Friday.Location = new System.Drawing.Point(412, 38);
            this.flp_Friday.Name = "flp_Friday";
            this.flp_Friday.Size = new System.Drawing.Size(95, 474);
            this.flp_Friday.TabIndex = 4;
            this.flp_Friday.Click += new System.EventHandler(this.flp_Friday_Click);
            // 
            // flp_Wednesday
            // 
            this.flp_Wednesday.AutoScroll = true;
            this.flp_Wednesday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Wednesday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Wednesday.Location = new System.Drawing.Point(210, 38);
            this.flp_Wednesday.Name = "flp_Wednesday";
            this.flp_Wednesday.Size = new System.Drawing.Size(95, 474);
            this.flp_Wednesday.TabIndex = 2;
            this.flp_Wednesday.Click += new System.EventHandler(this.flp_Wednesday_Click);
            // 
            // flp_Sunday
            // 
            this.flp_Sunday.AutoScroll = true;
            this.flp_Sunday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Sunday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Sunday.Location = new System.Drawing.Point(614, 38);
            this.flp_Sunday.Name = "flp_Sunday";
            this.flp_Sunday.Size = new System.Drawing.Size(95, 474);
            this.flp_Sunday.TabIndex = 6;
            this.flp_Sunday.Click += new System.EventHandler(this.flp_Sunday_Click);
            // 
            // flp_Saturday
            // 
            this.flp_Saturday.AutoScroll = true;
            this.flp_Saturday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Saturday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Saturday.Location = new System.Drawing.Point(513, 38);
            this.flp_Saturday.Name = "flp_Saturday";
            this.flp_Saturday.Size = new System.Drawing.Size(95, 474);
            this.flp_Saturday.TabIndex = 5;
            this.flp_Saturday.Click += new System.EventHandler(this.flp_Saturday_Click);
            // 
            // flp_Thursday
            // 
            this.flp_Thursday.AutoScroll = true;
            this.flp_Thursday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Thursday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Thursday.Location = new System.Drawing.Point(311, 38);
            this.flp_Thursday.Name = "flp_Thursday";
            this.flp_Thursday.Size = new System.Drawing.Size(95, 474);
            this.flp_Thursday.TabIndex = 3;
            this.flp_Thursday.Click += new System.EventHandler(this.flp_Thursday_Click);
            // 
            // flp_Tuesday
            // 
            this.flp_Tuesday.AutoScroll = true;
            this.flp_Tuesday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Tuesday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Tuesday.Location = new System.Drawing.Point(109, 38);
            this.flp_Tuesday.Name = "flp_Tuesday";
            this.flp_Tuesday.Size = new System.Drawing.Size(95, 474);
            this.flp_Tuesday.TabIndex = 1;
            this.flp_Tuesday.Click += new System.EventHandler(this.flp_Tuesday_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // flp_Monday
            // 
            this.flp_Monday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_Monday.AutoScroll = true;
            this.flp_Monday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Monday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Monday.Controls.Add(this.button2);
            this.flp_Monday.Location = new System.Drawing.Point(8, 38);
            this.flp_Monday.Name = "flp_Monday";
            this.flp_Monday.Size = new System.Drawing.Size(95, 474);
            this.flp_Monday.TabIndex = 0;
            this.flp_Monday.Click += new System.EventHandler(this.flp_Monday_Click);
            // 
            // ValidateHoraryOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 660);
            this.MinimumSize = new System.Drawing.Size(1100, 660);
            this.Name = "ValidateHoraryOption";
            this.Text = "ValidateHoraryOption";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorksHorary)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flp_Monday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.FlowLayoutPanel flp_Tuesday;
        private System.Windows.Forms.FlowLayoutPanel flp_Sunday;
        private System.Windows.Forms.FlowLayoutPanel flp_Saturday;
        private System.Windows.Forms.FlowLayoutPanel flp_Friday;
        private System.Windows.Forms.FlowLayoutPanel flp_Thursday;
        private System.Windows.Forms.FlowLayoutPanel flp_Wednesday;
        private System.Windows.Forms.Label lbl__total_Monday;
        private System.Windows.Forms.Label lbl_Total_Saturday;
        private System.Windows.Forms.Label lbl_Total_Friday;
        private System.Windows.Forms.Label lbl_Total_Wednesday;
        private System.Windows.Forms.Label lbl_Total_Tuesday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Thursday;
        private System.Windows.Forms.Label lbl_Wednesday;
        private System.Windows.Forms.Label lbl_Tuesday;
        private System.Windows.Forms.Label lbl_Monday;
        private System.Windows.Forms.Label lbl_Total_Sunday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Total_Thursday;
        private System.Windows.Forms.DataGridView dgv_WorksHorary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_search_code;
        private System.Windows.Forms.FlowLayoutPanel flp_Monday;
        private System.Windows.Forms.Button button2;
    }
}
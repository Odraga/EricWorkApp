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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_search_code = new System.Windows.Forms.Label();
            this.dgv_WorksHorary = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Total_Hours = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Total_Saturday = new System.Windows.Forms.Label();
            this.lbl_Total_Tuesday = new System.Windows.Forms.Label();
            this.lbl_Total_Wednesday = new System.Windows.Forms.Label();
            this.lbl_Total_Thursday = new System.Windows.Forms.Label();
            this.lbl_Total_Friday = new System.Windows.Forms.Label();
            this.lbl_Total_Monday = new System.Windows.Forms.Label();
            this.lbl_total_Sunday = new System.Windows.Forms.Label();
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
            this.flp_Monday = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_min_days = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorksHorary)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_min_days);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
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
            this.splitContainer1.Size = new System.Drawing.Size(1184, 621);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_search_code
            // 
            this.lbl_search_code.AutoSize = true;
            this.lbl_search_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_code.Location = new System.Drawing.Point(3, 17);
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
            this.dgv_WorksHorary.Location = new System.Drawing.Point(6, 82);
            this.dgv_WorksHorary.Name = "dgv_WorksHorary";
            this.dgv_WorksHorary.ReadOnly = true;
            this.dgv_WorksHorary.Size = new System.Drawing.Size(321, 474);
            this.dgv_WorksHorary.TabIndex = 2;
            this.dgv_WorksHorary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WorksHorary_CellClick);
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
            this.txt_Search.Location = new System.Drawing.Point(106, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(221, 20);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Total_Hours);
            this.panel1.Location = new System.Drawing.Point(618, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 59);
            this.panel1.TabIndex = 22;
            // 
            // lbl_Total_Hours
            // 
            this.lbl_Total_Hours.AutoSize = true;
            this.lbl_Total_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Hours.Location = new System.Drawing.Point(0, 7);
            this.lbl_Total_Hours.Name = "lbl_Total_Hours";
            this.lbl_Total_Hours.Size = new System.Drawing.Size(35, 37);
            this.lbl_Total_Hours.TabIndex = 23;
            this.lbl_Total_Hours.Text = "0";
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
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Thursday, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Friday, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Monday, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_total_Sunday, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 34);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // lbl_Total_Saturday
            // 
            this.lbl_Total_Saturday.AutoSize = true;
            this.lbl_Total_Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Saturday.Location = new System.Drawing.Point(596, 3);
            this.lbl_Total_Saturday.Name = "lbl_Total_Saturday";
            this.lbl_Total_Saturday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Saturday.TabIndex = 12;
            this.lbl_Total_Saturday.Text = "0";
            // 
            // lbl_Total_Tuesday
            // 
            this.lbl_Total_Tuesday.AutoSize = true;
            this.lbl_Total_Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Tuesday.Location = new System.Drawing.Point(124, 3);
            this.lbl_Total_Tuesday.Name = "lbl_Total_Tuesday";
            this.lbl_Total_Tuesday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Tuesday.TabIndex = 8;
            this.lbl_Total_Tuesday.Text = "0";
            // 
            // lbl_Total_Wednesday
            // 
            this.lbl_Total_Wednesday.AutoSize = true;
            this.lbl_Total_Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Wednesday.Location = new System.Drawing.Point(242, 3);
            this.lbl_Total_Wednesday.Name = "lbl_Total_Wednesday";
            this.lbl_Total_Wednesday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Wednesday.TabIndex = 9;
            this.lbl_Total_Wednesday.Text = "0";
            this.lbl_Total_Wednesday.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Total_Thursday
            // 
            this.lbl_Total_Thursday.AutoSize = true;
            this.lbl_Total_Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Thursday.Location = new System.Drawing.Point(360, 3);
            this.lbl_Total_Thursday.Name = "lbl_Total_Thursday";
            this.lbl_Total_Thursday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Thursday.TabIndex = 13;
            this.lbl_Total_Thursday.Text = "0";
            // 
            // lbl_Total_Friday
            // 
            this.lbl_Total_Friday.AutoSize = true;
            this.lbl_Total_Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Friday.Location = new System.Drawing.Point(478, 3);
            this.lbl_Total_Friday.Name = "lbl_Total_Friday";
            this.lbl_Total_Friday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Friday.TabIndex = 14;
            this.lbl_Total_Friday.Text = "0";
            // 
            // lbl_Total_Monday
            // 
            this.lbl_Total_Monday.AutoSize = true;
            this.lbl_Total_Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Total_Monday.Location = new System.Drawing.Point(6, 3);
            this.lbl_Total_Monday.Name = "lbl_Total_Monday";
            this.lbl_Total_Monday.Size = new System.Drawing.Size(26, 28);
            this.lbl_Total_Monday.TabIndex = 11;
            this.lbl_Total_Monday.Text = "0";
            // 
            // lbl_total_Sunday
            // 
            this.lbl_total_Sunday.AutoSize = true;
            this.lbl_total_Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_Sunday.Location = new System.Drawing.Point(714, 3);
            this.lbl_total_Sunday.Name = "lbl_total_Sunday";
            this.lbl_total_Sunday.Size = new System.Drawing.Size(26, 28);
            this.lbl_total_Sunday.TabIndex = 7;
            this.lbl_total_Sunday.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(719, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "Sun";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Sat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(479, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fri";
            // 
            // lbl_Thursday
            // 
            this.lbl_Thursday.AutoSize = true;
            this.lbl_Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thursday.Location = new System.Drawing.Point(359, 7);
            this.lbl_Thursday.Name = "lbl_Thursday";
            this.lbl_Thursday.Size = new System.Drawing.Size(55, 29);
            this.lbl_Thursday.TabIndex = 17;
            this.lbl_Thursday.Text = "Thu";
            // 
            // lbl_Wednesday
            // 
            this.lbl_Wednesday.AutoSize = true;
            this.lbl_Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wednesday.Location = new System.Drawing.Point(240, 7);
            this.lbl_Wednesday.Name = "lbl_Wednesday";
            this.lbl_Wednesday.Size = new System.Drawing.Size(63, 29);
            this.lbl_Wednesday.TabIndex = 16;
            this.lbl_Wednesday.Text = "Wed";
            // 
            // lbl_Tuesday
            // 
            this.lbl_Tuesday.AutoSize = true;
            this.lbl_Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tuesday.Location = new System.Drawing.Point(120, 7);
            this.lbl_Tuesday.Name = "lbl_Tuesday";
            this.lbl_Tuesday.Size = new System.Drawing.Size(56, 29);
            this.lbl_Tuesday.TabIndex = 15;
            this.lbl_Tuesday.Text = "Tue";
            // 
            // lbl_Monday
            // 
            this.lbl_Monday.AutoSize = true;
            this.lbl_Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monday.Location = new System.Drawing.Point(4, 7);
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
            this.flp_Friday.Location = new System.Drawing.Point(484, 79);
            this.flp_Friday.Name = "flp_Friday";
            this.flp_Friday.Size = new System.Drawing.Size(114, 474);
            this.flp_Friday.TabIndex = 4;
            this.flp_Friday.Click += new System.EventHandler(this.flp_Friday_Click);
            // 
            // flp_Wednesday
            // 
            this.flp_Wednesday.AutoScroll = true;
            this.flp_Wednesday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Wednesday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Wednesday.Location = new System.Drawing.Point(245, 79);
            this.flp_Wednesday.Name = "flp_Wednesday";
            this.flp_Wednesday.Size = new System.Drawing.Size(114, 474);
            this.flp_Wednesday.TabIndex = 2;
            this.flp_Wednesday.Click += new System.EventHandler(this.flp_Wednesday_Click);
            // 
            // flp_Sunday
            // 
            this.flp_Sunday.AutoScroll = true;
            this.flp_Sunday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Sunday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Sunday.Location = new System.Drawing.Point(724, 79);
            this.flp_Sunday.Name = "flp_Sunday";
            this.flp_Sunday.Size = new System.Drawing.Size(114, 474);
            this.flp_Sunday.TabIndex = 6;
            this.flp_Sunday.Click += new System.EventHandler(this.flp_Sunday_Click);
            // 
            // flp_Saturday
            // 
            this.flp_Saturday.AutoScroll = true;
            this.flp_Saturday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Saturday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Saturday.Location = new System.Drawing.Point(604, 79);
            this.flp_Saturday.Name = "flp_Saturday";
            this.flp_Saturday.Size = new System.Drawing.Size(114, 474);
            this.flp_Saturday.TabIndex = 5;
            this.flp_Saturday.Click += new System.EventHandler(this.flp_Saturday_Click);
            // 
            // flp_Thursday
            // 
            this.flp_Thursday.AutoScroll = true;
            this.flp_Thursday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Thursday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Thursday.Location = new System.Drawing.Point(364, 79);
            this.flp_Thursday.Name = "flp_Thursday";
            this.flp_Thursday.Size = new System.Drawing.Size(114, 474);
            this.flp_Thursday.TabIndex = 3;
            this.flp_Thursday.Click += new System.EventHandler(this.flp_Thursday_Click);
            // 
            // flp_Tuesday
            // 
            this.flp_Tuesday.AutoScroll = true;
            this.flp_Tuesday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Tuesday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Tuesday.Location = new System.Drawing.Point(125, 79);
            this.flp_Tuesday.Name = "flp_Tuesday";
            this.flp_Tuesday.Size = new System.Drawing.Size(114, 474);
            this.flp_Tuesday.TabIndex = 1;
            this.flp_Tuesday.Click += new System.EventHandler(this.flp_Tuesday_Click);
            // 
            // flp_Monday
            // 
            this.flp_Monday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Monday.AutoScroll = true;
            this.flp_Monday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flp_Monday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Monday.Location = new System.Drawing.Point(5, 79);
            this.flp_Monday.Name = "flp_Monday";
            this.flp_Monday.Size = new System.Drawing.Size(114, 474);
            this.flp_Monday.TabIndex = 0;
            this.flp_Monday.Click += new System.EventHandler(this.flp_Monday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Minimum days work:";
            // 
            // lbl_min_days
            // 
            this.lbl_min_days.AutoSize = true;
            this.lbl_min_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min_days.Location = new System.Drawing.Point(177, 569);
            this.lbl_min_days.Name = "lbl_min_days";
            this.lbl_min_days.Size = new System.Drawing.Size(17, 18);
            this.lbl_min_days.TabIndex = 25;
            this.lbl_min_days.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "/ 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "/ 12 Min";
            // 
            // ValidateHoraryOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 660);
            this.MinimumSize = new System.Drawing.Size(1200, 660);
            this.Name = "ValidateHoraryOption";
            this.Text = "ValidateHoraryOption";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorksHorary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_total_Sunday;
        private System.Windows.Forms.Label lbl_Total_Saturday;
        private System.Windows.Forms.Label lbl_Total_Monday;
        private System.Windows.Forms.Label lbl_Total_Wednesday;
        private System.Windows.Forms.Label lbl_Total_Tuesday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Thursday;
        private System.Windows.Forms.Label lbl_Wednesday;
        private System.Windows.Forms.Label lbl_Tuesday;
        private System.Windows.Forms.Label lbl_Monday;
        private System.Windows.Forms.Label lbl_Total_Thursday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Total_Friday;
        private System.Windows.Forms.DataGridView dgv_WorksHorary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndTime;
        private System.Windows.Forms.Label lbl_search_code;
        private System.Windows.Forms.FlowLayoutPanel flp_Monday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Total_Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_min_days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
namespace EricWorkApp.Views
{
    partial class ConfigurationOption
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
            this.dgv_WorkHours = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_total_hours = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.btn_delete_work_horary = new System.Windows.Forms.Button();
            this.btn_add_work_hourary = new System.Windows.Forms.Button();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkHours)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_WorkHours
            // 
            this.dgv_WorkHours.AllowUserToAddRows = false;
            this.dgv_WorkHours.AllowUserToDeleteRows = false;
            this.dgv_WorkHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WorkHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnStartTime,
            this.ColumnEndTime});
            this.dgv_WorkHours.Location = new System.Drawing.Point(12, 173);
            this.dgv_WorkHours.Name = "dgv_WorkHours";
            this.dgv_WorkHours.ReadOnly = true;
            this.dgv_WorkHours.Size = new System.Drawing.Size(560, 175);
            this.dgv_WorkHours.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btn_delete_work_horary);
            this.panel1.Controls.Add(this.btn_add_work_hourary);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 165);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl_total_hours);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(236, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 53);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // lbl_total_hours
            // 
            this.lbl_total_hours.AutoSize = true;
            this.lbl_total_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_hours.Location = new System.Drawing.Point(3, 0);
            this.lbl_total_hours.Name = "lbl_total_hours";
            this.lbl_total_hours.Size = new System.Drawing.Size(51, 55);
            this.lbl_total_hours.TabIndex = 4;
            this.lbl_total_hours.Text = "0";
            this.lbl_total_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txt_code);
            this.flowLayoutPanel1.Controls.Add(this.lbl_start_date);
            this.flowLayoutPanel1.Controls.Add(this.dtp_start_date);
            this.flowLayoutPanel1.Controls.Add(this.lbl_end_date);
            this.flowLayoutPanel1.Controls.Add(this.dtp_end_date);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 84);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(44, 3);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(312, 20);
            this.txt_code.TabIndex = 1;
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Location = new System.Drawing.Point(3, 26);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(58, 13);
            this.lbl_start_date.TabIndex = 2;
            this.lbl_start_date.Text = "Start Date:";
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.CustomFormat = "HH:mm";
            this.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_date.Location = new System.Drawing.Point(67, 29);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.ShowUpDown = true;
            this.dtp_start_date.Size = new System.Drawing.Size(289, 20);
            this.dtp_start_date.TabIndex = 5;
            this.dtp_start_date.ValueChanged += new System.EventHandler(this.dtp_start_date_ValueChanged);
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Location = new System.Drawing.Point(3, 52);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(55, 13);
            this.lbl_end_date.TabIndex = 4;
            this.lbl_end_date.Text = "End Date:";
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.CustomFormat = "HH:mm";
            this.dtp_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end_date.Location = new System.Drawing.Point(64, 55);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.ShowUpDown = true;
            this.dtp_end_date.Size = new System.Drawing.Size(292, 20);
            this.dtp_end_date.TabIndex = 6;
            this.dtp_end_date.ValueChanged += new System.EventHandler(this.dtp_end_date_ValueChanged);
            // 
            // btn_delete_work_horary
            // 
            this.btn_delete_work_horary.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_work_horary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete_work_horary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_work_horary.FlatAppearance.BorderSize = 0;
            this.btn_delete_work_horary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_work_horary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete_work_horary.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_delete_work_horary.Image = global::EricWorkApp.Properties.Resources.delete;
            this.btn_delete_work_horary.Location = new System.Drawing.Point(3, 0);
            this.btn_delete_work_horary.Name = "btn_delete_work_horary";
            this.btn_delete_work_horary.Size = new System.Drawing.Size(86, 165);
            this.btn_delete_work_horary.TabIndex = 2;
            this.btn_delete_work_horary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete_work_horary.UseVisualStyleBackColor = false;
            this.btn_delete_work_horary.Click += new System.EventHandler(this.btn_delete_work_horary_Click);
            // 
            // btn_add_work_hourary
            // 
            this.btn_add_work_hourary.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_work_hourary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add_work_hourary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_work_hourary.FlatAppearance.BorderSize = 0;
            this.btn_add_work_hourary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_work_hourary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_work_hourary.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add_work_hourary.Image = global::EricWorkApp.Properties.Resources.boton_agregar;
            this.btn_add_work_hourary.Location = new System.Drawing.Point(471, 3);
            this.btn_add_work_hourary.Name = "btn_add_work_hourary";
            this.btn_add_work_hourary.Size = new System.Drawing.Size(86, 159);
            this.btn_add_work_hourary.TabIndex = 1;
            this.btn_add_work_hourary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_work_hourary.UseVisualStyleBackColor = false;
            this.btn_add_work_hourary.Click += new System.EventHandler(this.btn_add_work_hourary_Click);
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "CODE";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
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
            // ConfigurationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_WorkHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ConfigurationOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkHours)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_WorkHours;
        private System.Windows.Forms.Button btn_add_work_hourary;
        private System.Windows.Forms.Button btn_delete_work_horary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_start_date;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.DateTimePicker dtp_end_date;
        private System.Windows.Forms.Label lbl_total_hours;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndTime;
    }
}
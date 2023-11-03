namespace EricWorkApp
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_validate_horary = new System.Windows.Forms.Button();
            this.btn_configuration = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 457);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_validate_horary);
            this.flowLayoutPanel1.Controls.Add(this.btn_configuration);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 139);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(532, 268);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 87);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Made by gabrielvr.dev@gmail.com";
            // 
            // btn_validate_horary
            // 
            this.btn_validate_horary.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_validate_horary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_validate_horary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validate_horary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate_horary.Image = global::EricWorkApp.Properties.Resources.reloj_de_pared;
            this.btn_validate_horary.Location = new System.Drawing.Point(3, 3);
            this.btn_validate_horary.Name = "btn_validate_horary";
            this.btn_validate_horary.Size = new System.Drawing.Size(125, 125);
            this.btn_validate_horary.TabIndex = 0;
            this.btn_validate_horary.Text = "Validate Horary";
            this.btn_validate_horary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_validate_horary.UseVisualStyleBackColor = false;
            this.btn_validate_horary.Click += new System.EventHandler(this.btn_validate_horary_Click);
            // 
            // btn_configuration
            // 
            this.btn_configuration.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_configuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_configuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_configuration.Image = global::EricWorkApp.Properties.Resources.configuraciones;
            this.btn_configuration.Location = new System.Drawing.Point(134, 3);
            this.btn_configuration.Name = "btn_configuration";
            this.btn_configuration.Size = new System.Drawing.Size(125, 125);
            this.btn_configuration.TabIndex = 1;
            this.btn_configuration.Text = "Configuration";
            this.btn_configuration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_configuration.UseVisualStyleBackColor = false;
            this.btn_configuration.Click += new System.EventHandler(this.btn_configuration_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(654, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 520);
            this.MinimumSize = new System.Drawing.Size(670, 520);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_validate_horary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_configuration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}


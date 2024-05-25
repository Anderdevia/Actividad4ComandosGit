
namespace CapaPresentacion
{
    partial class FormTPROCESO
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
            this.button15 = new System.Windows.Forms.Button();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel31.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Franklin Gothic Book", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button15.Location = new System.Drawing.Point(231, 28);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(62, 21);
            this.button15.TabIndex = 170;
            this.button15.Text = "&Generar";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(125, 31);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(100, 18);
            this.dateTimePicker5.TabIndex = 168;
            this.dateTimePicker5.UseWaitCursor = true;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.Transparent;
            this.panel31.Controls.Add(this.panel32);
            this.panel31.Controls.Add(this.label12);
            this.panel31.Location = new System.Drawing.Point(12, 36);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(119, 13);
            this.panel31.TabIndex = 169;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel32.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel32.Location = new System.Drawing.Point(0, 12);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(119, 1);
            this.panel32.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 11);
            this.label12.TabIndex = 7;
            this.label12.Text = "Hasta";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(125, 7);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(100, 18);
            this.dateTimePicker4.TabIndex = 166;
            this.dateTimePicker4.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panel30);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(119, 13);
            this.panel7.TabIndex = 167;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel30.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel30.Location = new System.Drawing.Point(0, 12);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(119, 1);
            this.panel30.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 11);
            this.label11.TabIndex = 7;
            this.label11.Text = "Desde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 517);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(689, 498);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormTPROCESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 570);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTPROCESO";
            this.Text = "Reporte";
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button15;
        public System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
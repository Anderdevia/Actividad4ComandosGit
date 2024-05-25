
namespace CapaPresentacion
{
    partial class Formreporte1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.panel70 = new System.Windows.Forms.Panel();
            this.panel71 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel70.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 517);
            this.groupBox1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            this.button15.Location = new System.Drawing.Point(204, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(62, 21);
            this.button15.TabIndex = 163;
            this.button15.Text = "&Generar";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel70
            // 
            this.panel70.BackColor = System.Drawing.Color.Transparent;
            this.panel70.Controls.Add(this.panel71);
            this.panel70.Controls.Add(this.label24);
            this.panel70.Location = new System.Drawing.Point(15, 12);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(82, 13);
            this.panel70.TabIndex = 164;
            // 
            // panel71
            // 
            this.panel71.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel71.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel71.Location = new System.Drawing.Point(0, 12);
            this.panel71.Name = "panel71";
            this.panel71.Size = new System.Drawing.Size(82, 1);
            this.panel71.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(-3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 11);
            this.label24.TabIndex = 7;
            this.label24.Text = " Codigo";
            // 
            // Formreporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 555);
            this.Controls.Add(this.panel70);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Formreporte1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Empleados";
            this.Load += new System.EventHandler(this.Formreporte1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel70.ResumeLayout(false);
            this.panel70.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button15;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel70;
        private System.Windows.Forms.Panel panel71;
        private System.Windows.Forms.Label label24;
    }
}
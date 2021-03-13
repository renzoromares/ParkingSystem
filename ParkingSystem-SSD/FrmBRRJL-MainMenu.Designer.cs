
namespace ParkingSystem_SSD
{
    partial class FrmMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 63);
            this.panel1.TabIndex = 49;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(708, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "USJR -";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(117, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(321, 25);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Parking Vehicle Management System\r\n";
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.Silver;
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.Black;
            this.btnGuest.Location = new System.Drawing.Point(528, 103);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(173, 126);
            this.btnGuest.TabIndex = 48;
            this.btnGuest.TabStop = false;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            this.btnGuest.MouseEnter += new System.EventHandler(this.btnGuest_MouseEnter);
            this.btnGuest.MouseLeave += new System.EventHandler(this.btnGuest_MouseLeave);
            // 
            // btnSSD
            // 
            this.btnSSD.BackColor = System.Drawing.Color.Silver;
            this.btnSSD.FlatAppearance.BorderSize = 0;
            this.btnSSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSD.ForeColor = System.Drawing.Color.Black;
            this.btnSSD.Location = new System.Drawing.Point(282, 103);
            this.btnSSD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(173, 126);
            this.btnSSD.TabIndex = 47;
            this.btnSSD.TabStop = false;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = false;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            this.btnSSD.MouseEnter += new System.EventHandler(this.btnSSD_MouseEnter);
            this.btnSSD.MouseLeave += new System.EventHandler(this.btnSSD_MouseLeave);
            // 
            // btnGuard
            // 
            this.btnGuard.BackColor = System.Drawing.Color.Silver;
            this.btnGuard.FlatAppearance.BorderSize = 0;
            this.btnGuard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuard.ForeColor = System.Drawing.Color.Black;
            this.btnGuard.Location = new System.Drawing.Point(38, 103);
            this.btnGuard.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(173, 126);
            this.btnGuard.TabIndex = 46;
            this.btnGuard.TabStop = false;
            this.btnGuard.Text = "Guard";
            this.btnGuard.UseVisualStyleBackColor = false;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            this.btnGuard.MouseEnter += new System.EventHandler(this.btnGuard_MouseEnter);
            this.btnGuard.MouseLeave += new System.EventHandler(this.btnGuard_MouseLeave);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(734, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnGuard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnGuard;
    }
}
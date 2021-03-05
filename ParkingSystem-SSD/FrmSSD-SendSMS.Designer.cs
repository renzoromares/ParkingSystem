namespace ParkingSystem_SSD
{
    partial class FrmSendSMS
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
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.btnProceed = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblheader1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelheader2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(66, 81);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(264, 231);
            this.rtxtMessage.TabIndex = 27;
            this.rtxtMessage.Text = "";
            this.rtxtMessage.TextChanged += new System.EventHandler(this.rtxtMessage_TextChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProceed.BorderRadius = 0;
            this.btnProceed.ButtonText = "Proceed";
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.DisabledColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProceed.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProceed.Iconimage = null;
            this.btnProceed.Iconimage_right = null;
            this.btnProceed.Iconimage_right_Selected = null;
            this.btnProceed.Iconimage_Selected = null;
            this.btnProceed.IconMarginLeft = 0;
            this.btnProceed.IconMarginRight = 0;
            this.btnProceed.IconRightVisible = true;
            this.btnProceed.IconRightZoom = 0D;
            this.btnProceed.IconVisible = true;
            this.btnProceed.IconZoom = 90D;
            this.btnProceed.IsTab = false;
            this.btnProceed.Location = new System.Drawing.Point(120, 327);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnProceed.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnProceed.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProceed.selected = false;
            this.btnProceed.Size = new System.Drawing.Size(161, 34);
            this.btnProceed.TabIndex = 62;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProceed.Textcolor = System.Drawing.Color.White;
            this.btnProceed.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(74, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 17);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Create Message";
            // 
            // lblheader1
            // 
            this.lblheader1.AutoSize = true;
            this.lblheader1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader1.Location = new System.Drawing.Point(287, 51);
            this.lblheader1.Name = "lblheader1";
            this.lblheader1.Size = new System.Drawing.Size(222, 28);
            this.lblheader1.TabIndex = 27;
            this.lblheader1.Text = "SEND EMERGENCY";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelContainer.Controls.Add(this.lbl1);
            this.panelContainer.Controls.Add(this.rtxtMessage);
            this.panelContainer.Controls.Add(this.btnProceed);
            this.panelContainer.Location = new System.Drawing.Point(202, 104);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(382, 386);
            this.panelContainer.TabIndex = 63;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelheader2
            // 
            this.labelheader2.AutoSize = true;
            this.labelheader2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheader2.ForeColor = System.Drawing.Color.Black;
            this.labelheader2.Location = new System.Drawing.Point(505, 51);
            this.labelheader2.Name = "labelheader2";
            this.labelheader2.Size = new System.Drawing.Size(58, 28);
            this.labelheader2.TabIndex = 64;
            this.labelheader2.Text = "SMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(206, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 65;
            this.label1.Text = "USJ-R";
            // 
            // FrmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelheader2);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblheader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSendSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSendSMS";
            this.Load += new System.EventHandler(this.FrmSendSMS_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnProceed;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Label lblheader1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelheader2;
        private System.Windows.Forms.Label label1;
    }
}
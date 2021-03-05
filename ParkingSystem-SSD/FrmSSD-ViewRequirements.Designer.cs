namespace ParkingSystem_SSD
{
    partial class FrmViewRequirements
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
            this.components = new System.ComponentModel.Container();
            this.picBoxOR = new System.Windows.Forms.PictureBox();
            this.picBoxCR = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblVehicleColor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVehicleModel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVehicleType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPlatenumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnActivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeactivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCarmake = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCR)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxOR
            // 
            this.picBoxOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxOR.Location = new System.Drawing.Point(12, 69);
            this.picBoxOR.Name = "picBoxOR";
            this.picBoxOR.Size = new System.Drawing.Size(301, 318);
            this.picBoxOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOR.TabIndex = 0;
            this.picBoxOR.TabStop = false;
            this.picBoxOR.Click += new System.EventHandler(this.picBoxOR_Click);
            // 
            // picBoxCR
            // 
            this.picBoxCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCR.Location = new System.Drawing.Point(328, 69);
            this.picBoxCR.Name = "picBoxCR";
            this.picBoxCR.Size = new System.Drawing.Size(301, 318);
            this.picBoxCR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCR.TabIndex = 1;
            this.picBoxCR.TabStop = false;
            this.picBoxCR.Click += new System.EventHandler(this.picBoxCR_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.panelHeader.Controls.Add(this.lblCarmake);
            this.panelHeader.Controls.Add(this.lbl5);
            this.panelHeader.Controls.Add(this.lblVehicleColor);
            this.panelHeader.Controls.Add(this.lbl4);
            this.panelHeader.Controls.Add(this.lblVehicleModel);
            this.panelHeader.Controls.Add(this.lbl3);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.lblVehicleType);
            this.panelHeader.Controls.Add(this.lbl1);
            this.panelHeader.Controls.Add(this.lbl2);
            this.panelHeader.Controls.Add(this.lblPlatenumber);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(642, 63);
            this.panelHeader.TabIndex = 2;
            // 
            // lblVehicleColor
            // 
            this.lblVehicleColor.AutoSize = true;
            this.lblVehicleColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleColor.ForeColor = System.Drawing.Color.Yellow;
            this.lblVehicleColor.Location = new System.Drawing.Point(499, 13);
            this.lblVehicleColor.Name = "lblVehicleColor";
            this.lblVehicleColor.Size = new System.Drawing.Size(33, 16);
            this.lblVehicleColor.TabIndex = 35;
            this.lblVehicleColor.Text = "Red";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl4.Location = new System.Drawing.Point(445, 12);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 17);
            this.lbl4.TabIndex = 34;
            this.lbl4.Text = "Color:";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleModel.ForeColor = System.Drawing.Color.Yellow;
            this.lblVehicleModel.Location = new System.Drawing.Point(342, 30);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(28, 16);
            this.lblVehicleModel.TabIndex = 33;
            this.lblVehicleModel.Text = "Rio";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl3.Location = new System.Drawing.Point(284, 29);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 17);
            this.lbl3.TabIndex = 32;
            this.lbl3.Text = "Model:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(615, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVehicleType.Location = new System.Drawing.Point(145, 12);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(32, 17);
            this.lblVehicleType.TabIndex = 30;
            this.lblVehicleType.Text = "Car";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(9, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(176, 17);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "Registered Plate Number: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(9, 12);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(130, 17);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "Registered Vehicle:";
            // 
            // lblPlatenumber
            // 
            this.lblPlatenumber.AutoSize = true;
            this.lblPlatenumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatenumber.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlatenumber.Location = new System.Drawing.Point(191, 31);
            this.lblPlatenumber.Name = "lblPlatenumber";
            this.lblPlatenumber.Size = new System.Drawing.Size(55, 16);
            this.lblPlatenumber.TabIndex = 28;
            this.lblPlatenumber.Text = "MNO11";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivate.BorderRadius = 0;
            this.btnActivate.ButtonText = "Activate";
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.DisabledColor = System.Drawing.Color.Gray;
            this.btnActivate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActivate.Iconimage = null;
            this.btnActivate.Iconimage_right = null;
            this.btnActivate.Iconimage_right_Selected = null;
            this.btnActivate.Iconimage_Selected = null;
            this.btnActivate.IconMarginLeft = 0;
            this.btnActivate.IconMarginRight = 0;
            this.btnActivate.IconRightVisible = true;
            this.btnActivate.IconRightZoom = 0D;
            this.btnActivate.IconVisible = true;
            this.btnActivate.IconZoom = 90D;
            this.btnActivate.IsTab = false;
            this.btnActivate.Location = new System.Drawing.Point(342, 400);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnActivate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnActivate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActivate.selected = false;
            this.btnActivate.Size = new System.Drawing.Size(136, 38);
            this.btnActivate.TabIndex = 31;
            this.btnActivate.Text = "Activate";
            this.btnActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActivate.Textcolor = System.Drawing.Color.White;
            this.btnActivate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeactivate.BorderRadius = 0;
            this.btnDeactivate.ButtonText = "Deactivate";
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeactivate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeactivate.Iconimage = null;
            this.btnDeactivate.Iconimage_right = null;
            this.btnDeactivate.Iconimage_right_Selected = null;
            this.btnDeactivate.Iconimage_Selected = null;
            this.btnDeactivate.IconMarginLeft = 0;
            this.btnDeactivate.IconMarginRight = 0;
            this.btnDeactivate.IconRightVisible = true;
            this.btnDeactivate.IconRightZoom = 0D;
            this.btnDeactivate.IconVisible = true;
            this.btnDeactivate.IconZoom = 90D;
            this.btnDeactivate.IsTab = false;
            this.btnDeactivate.Location = new System.Drawing.Point(200, 400);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeactivate.OnHovercolor = System.Drawing.Color.Red;
            this.btnDeactivate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeactivate.selected = false;
            this.btnDeactivate.Size = new System.Drawing.Size(136, 38);
            this.btnDeactivate.TabIndex = 32;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeactivate.Textcolor = System.Drawing.Color.White;
            this.btnDeactivate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl5.Location = new System.Drawing.Point(284, 11);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(77, 17);
            this.lbl5.TabIndex = 36;
            this.lbl5.Text = "Car make:";
            // 
            // lblCarmake
            // 
            this.lblCarmake.AutoSize = true;
            this.lblCarmake.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarmake.ForeColor = System.Drawing.Color.Yellow;
            this.lblCarmake.Location = new System.Drawing.Point(364, 12);
            this.lblCarmake.Name = "lblCarmake";
            this.lblCarmake.Size = new System.Drawing.Size(51, 16);
            this.lblCarmake.TabIndex = 37;
            this.lblCarmake.Text = "Toyota";
            // 
            // FrmViewRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.picBoxCR);
            this.Controls.Add(this.picBoxOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmViewRequirements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewRequirements";
            this.Load += new System.EventHandler(this.FrmViewRequirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCR)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxOR;
        private System.Windows.Forms.PictureBox picBoxCR;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlatenumber;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleType;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnActivate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeactivate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleColor;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleModel;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCarmake;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl5;
    }
}
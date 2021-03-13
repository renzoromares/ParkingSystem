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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewRequirements));
            this.picBoxOR = new System.Windows.Forms.PictureBox();
            this.picBoxCR = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExpireDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCarmake = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPlatenumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVehicleColor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVehicleType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVehicleModel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxOR
            // 
            this.picBoxOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxOR.Location = new System.Drawing.Point(27, 132);
            this.picBoxOR.Name = "picBoxOR";
            this.picBoxOR.Size = new System.Drawing.Size(324, 318);
            this.picBoxOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOR.TabIndex = 0;
            this.picBoxOR.TabStop = false;
            this.picBoxOR.Click += new System.EventHandler(this.picBoxOR_Click);
            // 
            // picBoxCR
            // 
            this.picBoxCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxCR.Location = new System.Drawing.Point(370, 132);
            this.picBoxCR.Name = "picBoxCR";
            this.picBoxCR.Size = new System.Drawing.Size(324, 318);
            this.picBoxCR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCR.TabIndex = 1;
            this.picBoxCR.TabStop = false;
            this.picBoxCR.Click += new System.EventHandler(this.picBoxCR_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblExpireDate);
            this.groupBox1.Controls.Add(this.lblCarmake);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lblPlatenumber);
            this.groupBox1.Controls.Add(this.lblVehicleColor);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lblVehicleType);
            this.groupBox1.Controls.Add(this.lblVehicleModel);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VEHICLE";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpireDate.Location = new System.Drawing.Point(363, 61);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(85, 17);
            this.lblExpireDate.TabIndex = 50;
            this.lblExpireDate.Text = "Expire Date:";
            // 
            // lblCarmake
            // 
            this.lblCarmake.AutoSize = true;
            this.lblCarmake.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarmake.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarmake.Location = new System.Drawing.Point(442, 20);
            this.lblCarmake.Name = "lblCarmake";
            this.lblCarmake.Size = new System.Drawing.Size(51, 16);
            this.lblCarmake.TabIndex = 49;
            this.lblCarmake.Text = "Toyota";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl2.Location = new System.Drawing.Point(14, 37);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(130, 17);
            this.lbl2.TabIndex = 42;
            this.lbl2.Text = "Registered Vehicle:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl5.Location = new System.Drawing.Point(359, 21);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(77, 17);
            this.lbl5.TabIndex = 48;
            this.lbl5.Text = "Car make:";
            // 
            // lblPlatenumber
            // 
            this.lblPlatenumber.AutoSize = true;
            this.lblPlatenumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatenumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlatenumber.Location = new System.Drawing.Point(196, 22);
            this.lblPlatenumber.Name = "lblPlatenumber";
            this.lblPlatenumber.Size = new System.Drawing.Size(55, 16);
            this.lblPlatenumber.TabIndex = 41;
            this.lblPlatenumber.Text = "MNO11";
            // 
            // lblVehicleColor
            // 
            this.lblVehicleColor.AutoSize = true;
            this.lblVehicleColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVehicleColor.Location = new System.Drawing.Point(415, 40);
            this.lblVehicleColor.Name = "lblVehicleColor";
            this.lblVehicleColor.Size = new System.Drawing.Size(33, 16);
            this.lblVehicleColor.TabIndex = 47;
            this.lblVehicleColor.Text = "Red";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(14, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(176, 17);
            this.lbl1.TabIndex = 40;
            this.lbl1.Text = "Registered Plate Number: ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl4.Location = new System.Drawing.Point(363, 40);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 17);
            this.lbl4.TabIndex = 46;
            this.lbl4.Text = "Color:";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVehicleType.Location = new System.Drawing.Point(150, 39);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(32, 16);
            this.lblVehicleType.TabIndex = 43;
            this.lblVehicleType.Text = "Car";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVehicleModel.Location = new System.Drawing.Point(72, 55);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(28, 16);
            this.lblVehicleModel.TabIndex = 45;
            this.lblVehicleModel.Text = "Rio";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl3.Location = new System.Drawing.Point(14, 54);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 17);
            this.lbl3.TabIndex = 44;
            this.lbl3.Text = "Model:";
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecline.Location = new System.Drawing.Point(228, 467);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(136, 38);
            this.btnDecline.TabIndex = 35;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApprove.Location = new System.Drawing.Point(370, 467);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(136, 38);
            this.btnApprove.TabIndex = 34;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // FrmViewRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxCR);
            this.Controls.Add(this.picBoxOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewRequirements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VEHICLE REQUIREMENTS";
            this.Load += new System.EventHandler(this.FrmViewRequirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxOR;
        private System.Windows.Forms.PictureBox picBoxCR;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblExpireDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCarmake;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlatenumber;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleColor;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleModel;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
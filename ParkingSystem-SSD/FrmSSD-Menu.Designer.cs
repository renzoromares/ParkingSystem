namespace ParkingSystem_SSD
{
    partial class FrmSSD_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSSD_Menu));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddGuard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelApplication = new System.Windows.Forms.Panel();
            this.btnActivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdateVehiclePass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateAccounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSendSMS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSide.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelApplication.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.pnlSide.Controls.Add(this.flowLayoutPanel1);
            this.pnlSide.Controls.Add(this.lblStatus);
            this.pnlSide.Controls.Add(this.pictureBox1);
            this.pnlSide.Location = new System.Drawing.Point(-1, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(173, 607);
            this.pnlSide.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddGuard);
            this.flowLayoutPanel1.Controls.Add(this.panelApplication);
            this.flowLayoutPanel1.Controls.Add(this.panelUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnSendSMS);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(173, 434);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnAddGuard
            // 
            this.btnAddGuard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnAddGuard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnAddGuard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGuard.BorderRadius = 0;
            this.btnAddGuard.ButtonText = "Add Guard";
            this.btnAddGuard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGuard.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddGuard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddGuard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddGuard.Iconimage")));
            this.btnAddGuard.Iconimage_right = null;
            this.btnAddGuard.Iconimage_right_Selected = null;
            this.btnAddGuard.Iconimage_Selected = null;
            this.btnAddGuard.IconMarginLeft = 0;
            this.btnAddGuard.IconMarginRight = 0;
            this.btnAddGuard.IconRightVisible = true;
            this.btnAddGuard.IconRightZoom = 0D;
            this.btnAddGuard.IconVisible = true;
            this.btnAddGuard.IconZoom = 50D;
            this.btnAddGuard.IsTab = false;
            this.btnAddGuard.Location = new System.Drawing.Point(3, 3);
            this.btnAddGuard.Name = "btnAddGuard";
            this.btnAddGuard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnAddGuard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnAddGuard.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnAddGuard.selected = false;
            this.btnAddGuard.Size = new System.Drawing.Size(170, 54);
            this.btnAddGuard.TabIndex = 11;
            this.btnAddGuard.Text = "Add Guard";
            this.btnAddGuard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGuard.Textcolor = System.Drawing.SystemColors.Window;
            this.btnAddGuard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuard.Click += new System.EventHandler(this.btnAddGuard_Click);
            // 
            // panelApplication
            // 
            this.panelApplication.Controls.Add(this.btnActivate);
            this.panelApplication.Controls.Add(this.btnApplication);
            this.panelApplication.Controls.Add(this.btnAccounts);
            this.panelApplication.Location = new System.Drawing.Point(0, 60);
            this.panelApplication.Margin = new System.Windows.Forms.Padding(0);
            this.panelApplication.Name = "panelApplication";
            this.panelApplication.Size = new System.Drawing.Size(182, 126);
            this.panelApplication.TabIndex = 12;
            // 
            // btnActivate
            // 
            this.btnActivate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnActivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivate.BorderRadius = 0;
            this.btnActivate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnActivate.ButtonText = "Vehicle Entry Pass";
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.DisabledColor = System.Drawing.Color.Gray;
            this.btnActivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.btnActivate.IconZoom = 60D;
            this.btnActivate.IsTab = false;
            this.btnActivate.Location = new System.Drawing.Point(0, 89);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnActivate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnActivate.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnActivate.selected = false;
            this.btnActivate.Size = new System.Drawing.Size(173, 32);
            this.btnActivate.TabIndex = 7;
            this.btnActivate.Text = "Vehicle Entry Pass";
            this.btnActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActivate.Textcolor = System.Drawing.Color.Beige;
            this.btnActivate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplication.BorderRadius = 0;
            this.btnApplication.ButtonText = "Applications";
            this.btnApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplication.DisabledColor = System.Drawing.Color.Gray;
            this.btnApplication.Iconcolor = System.Drawing.Color.Transparent;
            this.btnApplication.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnApplication.Iconimage")));
            this.btnApplication.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnApplication.Iconimage_right")));
            this.btnApplication.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("btnApplication.Iconimage_right_Selected")));
            this.btnApplication.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnApplication.Iconimage_Selected")));
            this.btnApplication.IconMarginLeft = 15;
            this.btnApplication.IconMarginRight = 0;
            this.btnApplication.IconRightVisible = true;
            this.btnApplication.IconRightZoom = 20D;
            this.btnApplication.IconVisible = true;
            this.btnApplication.IconZoom = 35D;
            this.btnApplication.IsTab = false;
            this.btnApplication.Location = new System.Drawing.Point(3, 3);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnApplication.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnApplication.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnApplication.selected = false;
            this.btnApplication.Size = new System.Drawing.Size(173, 54);
            this.btnApplication.TabIndex = 6;
            this.btnApplication.Text = "Applications";
            this.btnApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplication.Textcolor = System.Drawing.SystemColors.Window;
            this.btnApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnAccounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccounts.BorderRadius = 0;
            this.btnAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAccounts.ButtonText = "Vehicle Entry Accounts";
            this.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccounts.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccounts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccounts.Iconimage = null;
            this.btnAccounts.Iconimage_right = null;
            this.btnAccounts.Iconimage_right_Selected = null;
            this.btnAccounts.Iconimage_Selected = null;
            this.btnAccounts.IconMarginLeft = 0;
            this.btnAccounts.IconMarginRight = 0;
            this.btnAccounts.IconRightVisible = true;
            this.btnAccounts.IconRightZoom = 0D;
            this.btnAccounts.IconVisible = true;
            this.btnAccounts.IconZoom = 60D;
            this.btnAccounts.IsTab = false;
            this.btnAccounts.Location = new System.Drawing.Point(0, 58);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnAccounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnAccounts.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnAccounts.selected = false;
            this.btnAccounts.Size = new System.Drawing.Size(173, 32);
            this.btnAccounts.TabIndex = 12;
            this.btnAccounts.Text = "Vehicle Entry Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccounts.Textcolor = System.Drawing.Color.Beige;
            this.btnAccounts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdateVehiclePass);
            this.panelUpdate.Controls.Add(this.btnUpdateAccounts);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Location = new System.Drawing.Point(0, 186);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(182, 126);
            this.panelUpdate.TabIndex = 13;
            // 
            // btnUpdateVehiclePass
            // 
            this.btnUpdateVehiclePass.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateVehiclePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateVehiclePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateVehiclePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateVehiclePass.BorderRadius = 0;
            this.btnUpdateVehiclePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUpdateVehiclePass.ButtonText = "Vehicle Entry Pass";
            this.btnUpdateVehiclePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateVehiclePass.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateVehiclePass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateVehiclePass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateVehiclePass.Iconimage = null;
            this.btnUpdateVehiclePass.Iconimage_right = null;
            this.btnUpdateVehiclePass.Iconimage_right_Selected = null;
            this.btnUpdateVehiclePass.Iconimage_Selected = null;
            this.btnUpdateVehiclePass.IconMarginLeft = 0;
            this.btnUpdateVehiclePass.IconMarginRight = 0;
            this.btnUpdateVehiclePass.IconRightVisible = true;
            this.btnUpdateVehiclePass.IconRightZoom = 0D;
            this.btnUpdateVehiclePass.IconVisible = true;
            this.btnUpdateVehiclePass.IconZoom = 60D;
            this.btnUpdateVehiclePass.IsTab = false;
            this.btnUpdateVehiclePass.Location = new System.Drawing.Point(0, 89);
            this.btnUpdateVehiclePass.Name = "btnUpdateVehiclePass";
            this.btnUpdateVehiclePass.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateVehiclePass.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnUpdateVehiclePass.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnUpdateVehiclePass.selected = false;
            this.btnUpdateVehiclePass.Size = new System.Drawing.Size(173, 32);
            this.btnUpdateVehiclePass.TabIndex = 7;
            this.btnUpdateVehiclePass.Text = "Vehicle Entry Pass";
            this.btnUpdateVehiclePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateVehiclePass.Textcolor = System.Drawing.Color.Beige;
            this.btnUpdateVehiclePass.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehiclePass.Click += new System.EventHandler(this.btnUpdateVehiclePass_Click);
            // 
            // btnUpdateAccounts
            // 
            this.btnUpdateAccounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateAccounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAccounts.BorderRadius = 0;
            this.btnUpdateAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUpdateAccounts.ButtonText = "Vehicle Entry Accounts";
            this.btnUpdateAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccounts.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateAccounts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateAccounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateAccounts.Iconimage = null;
            this.btnUpdateAccounts.Iconimage_right = null;
            this.btnUpdateAccounts.Iconimage_right_Selected = null;
            this.btnUpdateAccounts.Iconimage_Selected = null;
            this.btnUpdateAccounts.IconMarginLeft = 0;
            this.btnUpdateAccounts.IconMarginRight = 0;
            this.btnUpdateAccounts.IconRightVisible = true;
            this.btnUpdateAccounts.IconRightZoom = 0D;
            this.btnUpdateAccounts.IconVisible = true;
            this.btnUpdateAccounts.IconZoom = 60D;
            this.btnUpdateAccounts.IsTab = false;
            this.btnUpdateAccounts.Location = new System.Drawing.Point(0, 58);
            this.btnUpdateAccounts.Name = "btnUpdateAccounts";
            this.btnUpdateAccounts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(4)))));
            this.btnUpdateAccounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnUpdateAccounts.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnUpdateAccounts.selected = false;
            this.btnUpdateAccounts.Size = new System.Drawing.Size(173, 32);
            this.btnUpdateAccounts.TabIndex = 12;
            this.btnUpdateAccounts.Text = "Vehicle Entry Accounts";
            this.btnUpdateAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateAccounts.Textcolor = System.Drawing.Color.Beige;
            this.btnUpdateAccounts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccounts.Click += new System.EventHandler(this.btnUpdateAccounts_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage_right")));
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 30D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 35D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(0, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(173, 54);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.SystemColors.Window;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnSendSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSendSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendSMS.BorderRadius = 0;
            this.btnSendSMS.ButtonText = "Send SMS";
            this.btnSendSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendSMS.DisabledColor = System.Drawing.Color.Gray;
            this.btnSendSMS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSendSMS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSendSMS.Iconimage")));
            this.btnSendSMS.Iconimage_right = null;
            this.btnSendSMS.Iconimage_right_Selected = null;
            this.btnSendSMS.Iconimage_Selected = null;
            this.btnSendSMS.IconMarginLeft = 0;
            this.btnSendSMS.IconMarginRight = 0;
            this.btnSendSMS.IconRightVisible = true;
            this.btnSendSMS.IconRightZoom = 0D;
            this.btnSendSMS.IconVisible = true;
            this.btnSendSMS.IconZoom = 50D;
            this.btnSendSMS.IsTab = false;
            this.btnSendSMS.Location = new System.Drawing.Point(3, 315);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSendSMS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnSendSMS.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnSendSMS.selected = false;
            this.btnSendSMS.Size = new System.Drawing.Size(170, 54);
            this.btnSendSMS.TabIndex = 9;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendSMS.Textcolor = System.Drawing.SystemColors.Window;
            this.btnSendSMS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 50D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(3, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(170, 54);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.SystemColors.Window;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(13, 125);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Safety and Security Dep\'t";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(178, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(865, 583);
            this.mainPanel.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mainPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmSSD_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 607);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSSD_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelApplication.ResumeLayout(false);
            this.panelUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnSendSMS;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnApplication;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddGuard;
        private Bunifu.Framework.UI.BunifuFlatButton btnActivate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccounts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelApplication;
        private System.Windows.Forms.Panel panelUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateVehiclePass;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateAccounts;
    }
}



namespace ParkingSystem_SSD
{
    partial class FrmGuest_AddVehicle
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
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbVehicleType = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtCarmake = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtVehicleModel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtVehicleColor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddFace = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFaceImage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddFileCR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddFileOR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPlateNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOfficialReceipt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = null;
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = true;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 90D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Location = new System.Drawing.Point(586, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(132, 38);
            this.btnRegister.TabIndex = 62;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.White;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.cmbVehicleType.BorderRadius = 3;
            this.cmbVehicleType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicleType.ForeColor = System.Drawing.Color.Black;
            this.cmbVehicleType.Items = new string[] {
        "Car",
        "Motorcycle "};
            this.cmbVehicleType.Location = new System.Drawing.Point(350, 43);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.NomalColor = System.Drawing.Color.DarkGray;
            this.cmbVehicleType.onHoverColor = System.Drawing.Color.DarkGray;
            this.cmbVehicleType.selectedIndex = -1;
            this.cmbVehicleType.Size = new System.Drawing.Size(255, 27);
            this.cmbVehicleType.TabIndex = 61;
            // 
            // txtCarmake
            // 
            this.txtCarmake.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarmake.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCarmake.ForeColor = System.Drawing.Color.Black;
            this.txtCarmake.HintForeColor = System.Drawing.Color.Empty;
            this.txtCarmake.HintText = "Car make";
            this.txtCarmake.isPassword = false;
            this.txtCarmake.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtCarmake.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCarmake.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtCarmake.LineThickness = 3;
            this.txtCarmake.Location = new System.Drawing.Point(25, 130);
            this.txtCarmake.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarmake.Name = "txtCarmake";
            this.txtCarmake.Size = new System.Drawing.Size(255, 44);
            this.txtCarmake.TabIndex = 60;
            this.txtCarmake.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleModel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVehicleModel.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleModel.HintForeColor = System.Drawing.Color.Empty;
            this.txtVehicleModel.HintText = "Vehicle Model";
            this.txtVehicleModel.isPassword = false;
            this.txtVehicleModel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtVehicleModel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVehicleModel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtVehicleModel.LineThickness = 3;
            this.txtVehicleModel.Location = new System.Drawing.Point(25, 78);
            this.txtVehicleModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(255, 44);
            this.txtVehicleModel.TabIndex = 52;
            this.txtVehicleModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleColor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVehicleColor.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleColor.HintForeColor = System.Drawing.Color.Empty;
            this.txtVehicleColor.HintText = "Color";
            this.txtVehicleColor.isPassword = false;
            this.txtVehicleColor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtVehicleColor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVehicleColor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtVehicleColor.LineThickness = 3;
            this.txtVehicleColor.Location = new System.Drawing.Point(25, 182);
            this.txtVehicleColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(255, 44);
            this.txtVehicleColor.TabIndex = 54;
            this.txtVehicleColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddFace
            // 
            this.btnAddFace.Activecolor = System.Drawing.Color.Silver;
            this.btnAddFace.BackColor = System.Drawing.Color.Gray;
            this.btnAddFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFace.BorderRadius = 2;
            this.btnAddFace.ButtonText = "Add File";
            this.btnAddFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFace.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFace.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddFace.Iconimage = null;
            this.btnAddFace.Iconimage_right = null;
            this.btnAddFace.Iconimage_right_Selected = null;
            this.btnAddFace.Iconimage_Selected = null;
            this.btnAddFace.IconMarginLeft = 0;
            this.btnAddFace.IconMarginRight = 0;
            this.btnAddFace.IconRightVisible = true;
            this.btnAddFace.IconRightZoom = 0D;
            this.btnAddFace.IconVisible = true;
            this.btnAddFace.IconZoom = 90D;
            this.btnAddFace.IsTab = false;
            this.btnAddFace.Location = new System.Drawing.Point(626, 93);
            this.btnAddFace.Name = "btnAddFace";
            this.btnAddFace.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddFace.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddFace.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddFace.selected = false;
            this.btnAddFace.Size = new System.Drawing.Size(92, 29);
            this.btnAddFace.TabIndex = 59;
            this.btnAddFace.Text = "Add File";
            this.btnAddFace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFace.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFace.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFace.Click += new System.EventHandler(this.btnAddFace_Click);
            // 
            // txtFaceImage
            // 
            this.txtFaceImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaceImage.Enabled = false;
            this.txtFaceImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFaceImage.ForeColor = System.Drawing.Color.Black;
            this.txtFaceImage.HintForeColor = System.Drawing.Color.Empty;
            this.txtFaceImage.HintText = "Face Image";
            this.txtFaceImage.isPassword = false;
            this.txtFaceImage.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtFaceImage.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFaceImage.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtFaceImage.LineThickness = 3;
            this.txtFaceImage.Location = new System.Drawing.Point(350, 78);
            this.txtFaceImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaceImage.Name = "txtFaceImage";
            this.txtFaceImage.Size = new System.Drawing.Size(255, 44);
            this.txtFaceImage.TabIndex = 58;
            this.txtFaceImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddFileCR
            // 
            this.btnAddFileCR.Activecolor = System.Drawing.Color.Silver;
            this.btnAddFileCR.BackColor = System.Drawing.Color.Gray;
            this.btnAddFileCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFileCR.BorderRadius = 2;
            this.btnAddFileCR.ButtonText = "Add File";
            this.btnAddFileCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFileCR.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddFileCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFileCR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddFileCR.Iconimage = null;
            this.btnAddFileCR.Iconimage_right = null;
            this.btnAddFileCR.Iconimage_right_Selected = null;
            this.btnAddFileCR.Iconimage_Selected = null;
            this.btnAddFileCR.IconMarginLeft = 0;
            this.btnAddFileCR.IconMarginRight = 0;
            this.btnAddFileCR.IconRightVisible = true;
            this.btnAddFileCR.IconRightZoom = 0D;
            this.btnAddFileCR.IconVisible = true;
            this.btnAddFileCR.IconZoom = 90D;
            this.btnAddFileCR.IsTab = false;
            this.btnAddFileCR.Location = new System.Drawing.Point(626, 197);
            this.btnAddFileCR.Name = "btnAddFileCR";
            this.btnAddFileCR.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddFileCR.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddFileCR.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddFileCR.selected = false;
            this.btnAddFileCR.Size = new System.Drawing.Size(92, 29);
            this.btnAddFileCR.TabIndex = 57;
            this.btnAddFileCR.Text = "Add File";
            this.btnAddFileCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFileCR.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFileCR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFileCR.Click += new System.EventHandler(this.btnAddFileCR_Click);
            // 
            // btnAddFileOR
            // 
            this.btnAddFileOR.Activecolor = System.Drawing.Color.Silver;
            this.btnAddFileOR.BackColor = System.Drawing.Color.Gray;
            this.btnAddFileOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFileOR.BorderRadius = 2;
            this.btnAddFileOR.ButtonText = "Add File";
            this.btnAddFileOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFileOR.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddFileOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFileOR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddFileOR.Iconimage = null;
            this.btnAddFileOR.Iconimage_right = null;
            this.btnAddFileOR.Iconimage_right_Selected = null;
            this.btnAddFileOR.Iconimage_Selected = null;
            this.btnAddFileOR.IconMarginLeft = 0;
            this.btnAddFileOR.IconMarginRight = 0;
            this.btnAddFileOR.IconRightVisible = true;
            this.btnAddFileOR.IconRightZoom = 0D;
            this.btnAddFileOR.IconVisible = true;
            this.btnAddFileOR.IconZoom = 90D;
            this.btnAddFileOR.IsTab = false;
            this.btnAddFileOR.Location = new System.Drawing.Point(626, 145);
            this.btnAddFileOR.Name = "btnAddFileOR";
            this.btnAddFileOR.Normalcolor = System.Drawing.Color.Gray;
            this.btnAddFileOR.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddFileOR.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddFileOR.selected = false;
            this.btnAddFileOR.Size = new System.Drawing.Size(92, 29);
            this.btnAddFileOR.TabIndex = 56;
            this.btnAddFileOR.Text = "Add File";
            this.btnAddFileOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFileOR.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAddFileOR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFileOR.Click += new System.EventHandler(this.btnAddFileOR_Click);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPlateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlateNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtPlateNumber.HintText = "Plate Number";
            this.txtPlateNumber.isPassword = false;
            this.txtPlateNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtPlateNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPlateNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtPlateNumber.LineThickness = 3;
            this.txtPlateNumber.Location = new System.Drawing.Point(25, 26);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(255, 44);
            this.txtPlateNumber.TabIndex = 51;
            this.txtPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOfficialReceipt
            // 
            this.txtOfficialReceipt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOfficialReceipt.Enabled = false;
            this.txtOfficialReceipt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOfficialReceipt.ForeColor = System.Drawing.Color.Black;
            this.txtOfficialReceipt.HintForeColor = System.Drawing.Color.Empty;
            this.txtOfficialReceipt.HintText = "Official Receipt";
            this.txtOfficialReceipt.isPassword = false;
            this.txtOfficialReceipt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtOfficialReceipt.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOfficialReceipt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtOfficialReceipt.LineThickness = 3;
            this.txtOfficialReceipt.Location = new System.Drawing.Point(350, 130);
            this.txtOfficialReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.txtOfficialReceipt.Name = "txtOfficialReceipt";
            this.txtOfficialReceipt.Size = new System.Drawing.Size(255, 44);
            this.txtOfficialReceipt.TabIndex = 53;
            this.txtOfficialReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCR
            // 
            this.txtCR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCR.Enabled = false;
            this.txtCR.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCR.ForeColor = System.Drawing.Color.Black;
            this.txtCR.HintForeColor = System.Drawing.Color.Empty;
            this.txtCR.HintText = "Certificate of Registration";
            this.txtCR.isPassword = false;
            this.txtCR.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtCR.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCR.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtCR.LineThickness = 3;
            this.txtCR.Location = new System.Drawing.Point(350, 182);
            this.txtCR.Margin = new System.Windows.Forms.Padding(4);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(255, 44);
            this.txtCR.TabIndex = 55;
            this.txtCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmGuest_AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 498);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.txtCarmake);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.btnAddFace);
            this.Controls.Add(this.txtFaceImage);
            this.Controls.Add(this.btnAddFileCR);
            this.Controls.Add(this.btnAddFileOR);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtOfficialReceipt);
            this.Controls.Add(this.txtCR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuest_AddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGuest_AddVehicle";
            this.Load += new System.EventHandler(this.FrmGuest_AddVehicle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
        private Bunifu.Framework.UI.BunifuDropdown cmbVehicleType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCarmake;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVehicleModel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVehicleColor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddFace;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFaceImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddFileCR;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddFileOR;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPlateNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOfficialReceipt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCR;
    }
}
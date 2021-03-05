
namespace ParkingSystem_SSD
{
    partial class FrmSSD_DeliverSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSSD_DeliverSMS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPlateNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnADD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Id,
            this.theName,
            this.Department,
            this.Contacts,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 375);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "Send";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = null;
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 90D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(329, 480);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(161, 34);
            this.btnSend.TabIndex = 63;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtPlateNumber.HintText = "Search Plate Number";
            this.txtPlateNumber.isPassword = false;
            this.txtPlateNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtPlateNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPlateNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtPlateNumber.LineThickness = 3;
            this.txtPlateNumber.Location = new System.Drawing.Point(442, 60);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(255, 32);
            this.txtPlateNumber.TabIndex = 67;
            this.txtPlateNumber.TabStop = false;
            this.txtPlateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnADD
            // 
            this.btnADD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnADD.BorderRadius = 0;
            this.btnADD.ButtonText = "Add";
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.DisabledColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnADD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnADD.Iconimage = null;
            this.btnADD.Iconimage_right = null;
            this.btnADD.Iconimage_right_Selected = null;
            this.btnADD.Iconimage_Selected = null;
            this.btnADD.IconMarginLeft = 0;
            this.btnADD.IconMarginRight = 0;
            this.btnADD.IconRightVisible = true;
            this.btnADD.IconRightZoom = 0D;
            this.btnADD.IconVisible = true;
            this.btnADD.IconZoom = 90D;
            this.btnADD.IsTab = false;
            this.btnADD.Location = new System.Drawing.Point(704, 65);
            this.btnADD.Name = "btnADD";
            this.btnADD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnADD.OnHovercolor = System.Drawing.Color.Gray;
            this.btnADD.OnHoverTextColor = System.Drawing.Color.White;
            this.btnADD.selected = false;
            this.btnADD.Size = new System.Drawing.Size(91, 28);
            this.btnADD.TabIndex = 68;
            this.btnADD.Text = "Add";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnADD.Textcolor = System.Drawing.Color.White;
            this.btnADD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Reference
            // 
            this.Reference.FillWeight = 49.48958F;
            this.Reference.HeaderText = "#";
            this.Reference.Name = "Reference";
            // 
            // Id
            // 
            this.Id.FillWeight = 140.3912F;
            this.Id.HeaderText = "PLATE NUMBER";
            this.Id.Name = "Id";
            // 
            // theName
            // 
            this.theName.FillWeight = 151.6887F;
            this.theName.HeaderText = "NAME";
            this.theName.Name = "theName";
            // 
            // Department
            // 
            this.Department.FillWeight = 209.3786F;
            this.Department.HeaderText = "DEPARTMENT";
            this.Department.Name = "Department";
            // 
            // Contacts
            // 
            this.Contacts.FillWeight = 140.5124F;
            this.Contacts.HeaderText = "CONTACTS";
            this.Contacts.Name = "Contacts";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 36.9765F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            // 
            // FrmSSD_DeliverSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(807, 551);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSSD_DeliverSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USJR SEND SMS - ADD RECIPIENTS";
            this.Load += new System.EventHandler(this.FrmSSD_DeliverSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPlateNumber;
        private Bunifu.Framework.UI.BunifuFlatButton btnADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn theName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
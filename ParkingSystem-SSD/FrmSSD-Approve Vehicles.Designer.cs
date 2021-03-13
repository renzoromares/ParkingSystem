namespace ParkingSystem_SSD
{
    partial class FrmActivate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Submitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Verified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Id,
            this.theName,
            this.Position,
            this.Column2,
            this.Date_Submitted,
            this.Date_Verified,
            this.Date_Expired,
            this.Status,
            this.Checkbox});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Pending",
            "Allowed Entry",
            "Not Allowed Entry",
            "Expired"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(658, 71);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbFilterStatus.TabIndex = 6;
            this.cmbFilterStatus.SelectedValueChanged += new System.EventHandler(this.cmbFilterStatus_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "USJ-R";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(180, 19);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(417, 28);
            this.lblRecords.TabIndex = 7;
            this.lblRecords.Text = "VEHICLE PASS ENTRY APPLICATIONS\r\n";
            // 
            // Reference
            // 
            this.Reference.FillWeight = 32.85573F;
            this.Reference.HeaderText = "#";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.FillWeight = 117.9398F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // theName
            // 
            this.theName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theName.FillWeight = 136.9728F;
            this.theName.HeaderText = "Name";
            this.theName.Name = "theName";
            this.theName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.FillWeight = 93.13408F;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 82.13935F;
            this.Column2.HeaderText = "Plate#";
            this.Column2.Name = "Column2";
            // 
            // Date_Submitted
            // 
            this.Date_Submitted.FillWeight = 126.6069F;
            this.Date_Submitted.HeaderText = "Date Submitted";
            this.Date_Submitted.Name = "Date_Submitted";
            // 
            // Date_Verified
            // 
            this.Date_Verified.FillWeight = 118.5539F;
            this.Date_Verified.HeaderText = "Date Verified";
            this.Date_Verified.Name = "Date_Verified";
            // 
            // Date_Expired
            // 
            this.Date_Expired.FillWeight = 84.31299F;
            this.Date_Expired.HeaderText = "Expiration";
            this.Date_Expired.Name = "Date_Expired";
            // 
            // Status
            // 
            this.Status.FillWeight = 100.7167F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // Checkbox
            // 
            this.Checkbox.FillWeight = 30.52904F;
            this.Checkbox.HeaderText = "";
            this.Checkbox.Image = ((System.Drawing.Image)(resources.GetObject("Checkbox.Image")));
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmActivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActivate";
            this.Text = "FrmActivate";
            this.Load += new System.EventHandler(this.FrmActivate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn theName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Submitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Verified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Checkbox;
    }
}
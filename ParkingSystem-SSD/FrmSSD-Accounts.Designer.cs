namespace ParkingSystem_SSD
{
    partial class FrmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccounts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptORDecline = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Department,
            this.Position,
            this.Status,
            this.AcceptORDecline});
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 413);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(267, 21);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(314, 28);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "VEHICLE PASS APPLICANTS";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Pending",
            "ALLOWED ENTRY",
            "NOT ALLOWED ENTRY"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(564, 71);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbFilterStatus.TabIndex = 5;
            this.cmbFilterStatus.SelectedValueChanged += new System.EventHandler(this.cmbFilterStatus_SelectedValueChanged);
            // 
            // Reference
            // 
            this.Reference.FillWeight = 35.22078F;
            this.Reference.HeaderText = "#";
            this.Reference.Name = "Reference";
            // 
            // Id
            // 
            this.Id.FillWeight = 99.91376F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // theName
            // 
            this.theName.FillWeight = 107.9539F;
            this.theName.HeaderText = "NAME";
            this.theName.Name = "theName";
            // 
            // Department
            // 
            this.Department.FillWeight = 149.0107F;
            this.Department.HeaderText = "DEPARTMENT";
            this.Department.Name = "Department";
            // 
            // Position
            // 
            this.Position.FillWeight = 81.30334F;
            this.Position.HeaderText = "POSITION";
            this.Position.Name = "Position";
            // 
            // Status
            // 
            this.Status.FillWeight = 133.8063F;
            this.Status.HeaderText = "STATUS";
            this.Status.Name = "Status";
            // 
            // AcceptORDecline
            // 
            this.AcceptORDecline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcceptORDecline.FillWeight = 14.73629F;
            this.AcceptORDecline.HeaderText = "";
            this.AcceptORDecline.Image = ((System.Drawing.Image)(resources.GetObject("AcceptORDecline.Image")));
            this.AcceptORDecline.Name = "AcceptORDecline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(186, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "USJ-R";
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccounts";
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn theName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn AcceptORDecline;
        private System.Windows.Forms.Label label1;
    }
}
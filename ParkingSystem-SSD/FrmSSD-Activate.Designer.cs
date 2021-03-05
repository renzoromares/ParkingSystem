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
            this.lblActivate = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column1,
            this.Column2,
            this.Status,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 413);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblActivate
            // 
            this.lblActivate.AutoSize = true;
            this.lblActivate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate.Location = new System.Drawing.Point(127, 25);
            this.lblActivate.Name = "lblActivate";
            this.lblActivate.Size = new System.Drawing.Size(488, 28);
            this.lblActivate.TabIndex = 5;
            this.lblActivate.Text = "Activate\\Deactivate Vehicle Application\r\n";
            this.lblActivate.Click += new System.EventHandler(this.lblActivate_Click);
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
            this.cmbFilterStatus.TabIndex = 6;
            this.cmbFilterStatus.SelectedValueChanged += new System.EventHandler(this.cmbFilterStatus_SelectedValueChanged);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 24.2206F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            // 
            // Status
            // 
            this.Status.FillWeight = 108.2018F;
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 88.24377F;
            this.Column2.HeaderText = "PLATE NO.";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 88.24377F;
            this.Column1.HeaderText = "TYPE";
            this.Column1.Name = "Column1";
            // 
            // Position
            // 
            this.Position.FillWeight = 100.0556F;
            this.Position.HeaderText = "POSITION";
            this.Position.Name = "Position";
            // 
            // theName
            // 
            this.theName.FillWeight = 112.372F;
            this.theName.HeaderText = "NAME";
            this.theName.Name = "theName";
            this.theName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.FillWeight = 80.90625F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Reference
            // 
            this.Reference.FillWeight = 35.2975F;
            this.Reference.HeaderText = "#";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // FrmActivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.lblActivate);
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
        private System.Windows.Forms.Label lblActivate;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn theName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
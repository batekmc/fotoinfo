namespace PhotoInfo.Modules.Ciselniky.PDM_Status
{
    partial class PDM_StatusGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region 
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPDM_Status = new SmartISLib.Controls.FastDataGridView();
            this.colPDMStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPDM_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPDMStatus
            // 
            this.gridPDM_Status.AlternatingRowStyle = true;
            this.gridPDM_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPDM_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPDM_Status.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPDMStatus});
            this.gridPDM_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPDM_Status.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gridPDM_Status.HighlightSelectedCross = false;
            this.gridPDM_Status.Location = new System.Drawing.Point(0, 0);
            this.gridPDM_Status.Name = "gridPDMStatus";
            this.gridPDM_Status.RowHeadersWidth = 20;
            this.gridPDM_Status.RowTemplate.Height = 18;
            this.gridPDM_Status.Size = new System.Drawing.Size(319, 315);
            this.gridPDM_Status.TabIndex = 2;
            // 
            // colPDMStatus
            // 
            this.colPDMStatus.DataPropertyName = "PDMStatus";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPDMStatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPDMStatus.HeaderText = "PDMStatus";
            this.colPDMStatus.MaxInputLength = 18;
            this.colPDMStatus.Name = "colPDMStatus";
            this.colPDMStatus.Width = 150;
            // 
            // PDMStatusGrid
            // 
            this.PrimaryKeyAttribute = "PDMStatusID";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPDM_Status);
            this.DataGridView = this.gridPDM_Status;
            this.Name = "PDM Status";
            this.SqlSelect = "Select * from TPDMStatus";
            ((System.ComponentModel.ISupportInitialize)(this.gridPDM_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView gridPDM_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPDMStatus;
    }
}
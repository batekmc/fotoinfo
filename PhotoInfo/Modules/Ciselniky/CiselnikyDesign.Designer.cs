namespace PhotoInfo.Modules.Ciselniky
{
    partial class CiselnikyDesign
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
        ///Default design for all modules in ciselniky
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.gridView.AlternatingRowStyle = true;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrid});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gridView.HighlightSelectedCross = false;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = this.dataPropName + "gridView";
            this.gridView.RowHeadersWidth = 20;
            this.gridView.RowTemplate.Height = 18;
            this.gridView.Size = new System.Drawing.Size(319, 315);
            this.gridView.TabIndex = 2;
            this.gridView.ReadOnly = false;
            this.gridView.AllowUserToAddRows = true;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.AllowUserToResizeRows = true;
            this.HorizontalScroll.Visible = true;
            // 
            // col
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGrid.MaxInputLength = 18;
            this.colGrid.Name = this.dataPropName;
            if (!this.setWidth)
                this.colGrid.Width = 150;
            // 
            //Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridView);
            this.DataGridView = this.gridView;
            this.Name = this.dataPropName;
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid;
    }
}
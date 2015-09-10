namespace PhotoInfo.Modules.Ciselniky.KdoFoti
{
    partial class KdoFotiGrid
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

            this.gridView = new SmartISLib.Controls.FastDataGridView();
            this.colGrid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();


            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.gridView.AlternatingRowStyle = true;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrid1, this.colGrid2, this.colGrid3});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gridView.HighlightSelectedCross = false;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "KdoFotigridView";
            this.gridView.RowHeadersWidth = 20;
            this.gridView.RowTemplate.Height = 18;
            this.gridView.Size = new System.Drawing.Size(319, 315);
            this.gridView.TabIndex = 4;
            // 
            // col1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGrid1.DataPropertyName = "ResponsiblePhotoSurname";
            this.colGrid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGrid1.HeaderText = "Příjmení";
            this.colGrid1.MaxInputLength = 18;
            this.colGrid1.Name = "KdoFoti";
            this.colGrid1.Width = 150;
            // 
            // col2
            // 
            this.colGrid2.DataPropertyName = "ResponsiblePhotoName";
            this.colGrid2.HeaderText = "Jméno";
            this.colGrid2.Name = "KdoFoti";
            this.colGrid2.Width = 150;
            // 
            // col3
            // 
            this.colGrid3.DataPropertyName = "ResponsiblePhotoCode";
            this.colGrid3.HeaderText = "Zkratka";
            this.colGrid3.Name = "Zkratka";
            this.colGrid3.Width = 150;
            // 
            //Grid
            // 
            this.SqlSelect = "SELECT * FROM TPersonResponsiblePhoto";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridView);
            this.DataGridView = this.gridView;
            this.Name = "KdoFoti";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid3;
    }
}
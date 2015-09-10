using System.Windows.Forms;
namespace PhotoInfo.Modules.Ciselniky.ZemePoznamky
{
    partial class ZemeGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ZemePoynamky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZemePoznamky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridView = new SmartISLib.Controls.FastDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ZemePoynamky
            // 
            this.ZemePoynamky.DataPropertyName = "Zeme";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ZemePoynamky.DefaultCellStyle = dataGridViewCellStyle1;
            this.ZemePoynamky.HeaderText = "Země";
            this.ZemePoynamky.MaxInputLength = 18;
            this.ZemePoynamky.Name = "ZemePoynamky";
            this.ZemePoynamky.Width = 150;
            // 
            // ZemePoznamky
            // 
            this.ZemePoznamky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZemePoznamky.DataPropertyName = "Text";
            this.ZemePoznamky.DefaultCellStyle = dataGridViewCellStyle1;
            this.ZemePoznamky.HeaderText = "Poznámky";
            this.ZemePoznamky.MaxInputLength = 18;
            this.ZemePoznamky.Name = "ZemePoznamky";
            // 
            // gridView
            // 
            this.gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.AlternatingRowStyle = true;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZemePoynamky,
            this.ZemePoznamky});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gridView.HighlightSelectedCross = false;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 20;
            this.gridView.RowTemplate.Height = 18;
            this.gridView.Size = new System.Drawing.Size(319, 315);
            this.gridView.TabIndex = 2;
            // 
            // ZemeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridView);
            this.DataGridView = this.gridView;
            this.Name = "ZemeGrid";
            this.SqlSelect = "SELECT * FROM TZEME";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid1; 
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrid2;
        private DataGridViewTextBoxColumn ZemePoynamky;
        private DataGridViewTextBoxColumn ZemePoznamky;
    }
}
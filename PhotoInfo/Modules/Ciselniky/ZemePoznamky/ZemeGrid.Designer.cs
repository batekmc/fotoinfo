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
            this.ZemePoznamky1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZemePoznamky2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridView = new SmartISLib.Controls.FastDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ZemePoznamky1
            // 
            this.ZemePoznamky1.DataPropertyName = "Zeme";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ZemePoznamky1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ZemePoznamky1.HeaderText = "Země";
            this.ZemePoznamky1.MaxInputLength = 18;
            this.ZemePoznamky1.Name = "Zeme";
            this.ZemePoznamky1.Width = 150;
            // 
            // ZemePoznamky2
            // 
            this.ZemePoznamky2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZemePoznamky2.DataPropertyName = "Text";
            this.ZemePoznamky2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ZemePoznamky2.HeaderText = "Poznámky";
            this.ZemePoznamky2.MaxInputLength = 18;
            this.ZemePoznamky2.Name = "ZemeText";
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
            this.ZemePoznamky1,
            this.ZemePoznamky2});
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
            this.SqlSelect = "SELECT * FROM TZEME where @where";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView gridView;
        private DataGridViewTextBoxColumn ZemePoznamky1;
        private DataGridViewTextBoxColumn ZemePoznamky2;
    }
}
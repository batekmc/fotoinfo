namespace PhotoInfo.Modules.Ciselniky.ZemePoznamky
{
    partial class ZemeFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlFilterHeader1 = new SmartISLib.Filters.SqlFilterHeader();
            this.stringFilterItem1 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.SuspendLayout();
            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Země";
            this.sqlFilterHeader1.Location = new System.Drawing.Point(0, 0);
            this.sqlFilterHeader1.Name = "sqlFilterHeader1";
            this.sqlFilterHeader1.Owner = this;
            this.sqlFilterHeader1.Size = new System.Drawing.Size(150, 26);
            this.sqlFilterHeader1.TabIndex = 0;
            // 
            // stringFilterItem1
            // 
            this.stringFilterItem1.Active = false;
            this.stringFilterItem1.Attribute = "Zeme";
            this.stringFilterItem1.AttributeTitle = "Země";
            this.stringFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem1.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem1.Name = "stringFilterItem1";
            this.stringFilterItem1.Owner = this;
            this.stringFilterItem1.Size = new System.Drawing.Size(150, 25);
            this.stringFilterItem1.TabIndex = 1;
            this.stringFilterItem1.Value = "";
            // 
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl1.Active = false;
            this.strForeignKeyFilterControl1.Attribute = "Zeme";
            this.strForeignKeyFilterControl1.AttributeTitle = "Vyberte zemi";
            this.strForeignKeyFilterControl1.DisplayAttribute = "Zeme";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 51);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(150, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "Select Zeme from TZeme ORDER BY ZEME";
            this.strForeignKeyFilterControl1.TabIndex = 2;
            this.strForeignKeyFilterControl1.ValueAttribute = "Zeme";
            // 
            // ZemeFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.Name = "ZemeFilter";
            this.ResumeLayout(false);

        }

        #endregion
        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl1;
    }
}
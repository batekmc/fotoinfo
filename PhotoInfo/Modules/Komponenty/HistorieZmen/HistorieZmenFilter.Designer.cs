namespace PhotoInfo.Modules.Komponenty.HistorieZmen
{
    partial class HistorieZmenFilter
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

            this.sqlFilterHeader1 = new SmartISLib.Filters.SqlFilterHeader();
            this.stringFilterItem1 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.dateFilterItem1 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();
            this.SuspendLayout();
            // 
            // HistorieZmenFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "HistorieZmenFilter";
            this.ResumeLayout(false);

            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Historie změn.";
            this.sqlFilterHeader1.Location = new System.Drawing.Point(0, 0);
            this.sqlFilterHeader1.Name = "sqlFilterHeader1";
            this.sqlFilterHeader1.Owner = this;
            this.sqlFilterHeader1.Size = new System.Drawing.Size(150, 26);
            this.sqlFilterHeader1.TabIndex = 0;
            // 
            // stringFilterItem1
            // 
            this.stringFilterItem1.Active = false;
            this.stringFilterItem1.Attribute = "ComponentNo";
            this.stringFilterItem1.AttributeTitle = "Číslo komp.";
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
            this.strForeignKeyFilterControl1.Attribute = "TableField";
            this.strForeignKeyFilterControl1.AttributeTitle = "Změněné pole";
            this.strForeignKeyFilterControl1.DisplayAttribute = "TableField";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 51);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(150, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "Select distinct TableField from QHISTORIE";
            this.strForeignKeyFilterControl1.TabIndex = 2;
            // 
            // dateFilterItem1
            // 
            this.dateFilterItem1.Active = false;
            this.dateFilterItem1.Attribute = "UpdateDate";
            this.dateFilterItem1.AttributeTitle = "Datum změny";
            this.dateFilterItem1.AutoDate = false;
            this.dateFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFilterItem1.Location = new System.Drawing.Point(0, 76);
            this.dateFilterItem1.Name = "dateFilterItem1";
            this.dateFilterItem1.Owner = this;
            this.dateFilterItem1.RangeFiltering = true;
            this.dateFilterItem1.Size = new System.Drawing.Size(180, 25);
            this.dateFilterItem1.TabIndex = 3;
            this.dateFilterItem1.Value = new System.DateTime(2015, 7, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueFrom = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueTill = new System.DateTime(2015, 7, 12, 0, 0, 0, 0);



            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.FilterElements.Add(this.dateFilterItem1);
            this.strForeignKeyFilterControl1.ValueAttribute = "TableField";

        }

        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl1;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem1;

        #endregion
    }
}
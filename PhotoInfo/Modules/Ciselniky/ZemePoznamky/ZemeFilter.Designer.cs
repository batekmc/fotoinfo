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
            this.stringFilterItem2 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.SuspendLayout();
            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Zeme";
            this.sqlFilterHeader1.Location = new System.Drawing.Point(0, 0);
            this.sqlFilterHeader1.Name = "Zeme";
            this.sqlFilterHeader1.Owner = this;
            this.sqlFilterHeader1.Size = new System.Drawing.Size(150, 26);
            this.sqlFilterHeader1.TabIndex = 0;
            // 
            // stringFilterItem1
            // 
            this.stringFilterItem1.Active = false;
            this.stringFilterItem1.Attribute = "Zeme";
            this.stringFilterItem1.AttributeTitle = "Zeme";
            this.stringFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem1.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem1.Name = "Zeme";
            this.stringFilterItem1.Owner = this;
            this.stringFilterItem1.Size = new System.Drawing.Size(150, 25);
            this.stringFilterItem1.TabIndex = 1;
            this.stringFilterItem1.Value = "";
            // 
            // stringFilterItem2
            // 
            this.stringFilterItem2.Active = false;
            this.stringFilterItem2.Attribute = "Zeme";
            this.stringFilterItem2.AttributeTitle = "Zeme";
            this.stringFilterItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem2.Location = new System.Drawing.Point(0, 51);
            this.stringFilterItem2.Name = "Zeme";
            this.stringFilterItem2.Owner = this;
            this.stringFilterItem2.Size = new System.Drawing.Size(150, 25);
            this.stringFilterItem2.TabIndex = 2;
            this.stringFilterItem2.Value = "";
            // 
            // CustomersFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.stringFilterItem2);
            this.Name = "CustomersFilter";
            this.ResumeLayout(false);

        }

        #endregion
        // TODO - fuckin not working...ORM to Tables.&& we will see...
        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem2;
    }
}
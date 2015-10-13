namespace PhotoInfo.Modules.Komponenty.PrikazyKVyskladneni
{
    partial class PrikazyKVyskladneniFilter
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "PrikazyKVyskladneniFilter";

            this.sqlFilterHeader1 = new SmartISLib.Filters.SqlFilterHeader();
            this.stringFilterItem1 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.intFilter1 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.dateFilterItem1 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl2 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.SuspendLayout();
            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Seznam příkazů k vyskladnění.";
            this.sqlFilterHeader1.Location = new System.Drawing.Point(0, 0);
            this.sqlFilterHeader1.Name = "sqlFilterHeader1";
            this.sqlFilterHeader1.Owner = this;
            this.sqlFilterHeader1.Size = new System.Drawing.Size(133, 26);
            this.sqlFilterHeader1.TabIndex = 0;
            // 
            // stringFilterItem1
            // 
            this.stringFilterItem1.Active = false;
            this.stringFilterItem1.Attribute = "CisloSetu";
            this.stringFilterItem1.AttributeTitle = "Číslo setu";
            this.stringFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem1.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem1.Name = "stringFilterItem1";
            this.stringFilterItem1.Owner = this;
            this.stringFilterItem1.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem1.TabIndex = 1;
            this.stringFilterItem1.Value = "";
            // 
            // intFilter1
            // 
            this.intFilter1.Active = false;
            this.intFilter1.Attribute = "SumTotalWeight";
            this.intFilter1.AttributeTitle = "Celková hmotnost [g]";
            this.intFilter1.Location = new System.Drawing.Point(0, 200);
            this.intFilter1.Maximum = 100;
            this.intFilter1.Minimum = 0;
            this.intFilter1.Name = "intFilter1";
            this.intFilter1.Owner = this;
            this.intFilter1.RangeFiltering = true;
            this.intFilter1.Size = new System.Drawing.Size(150, 25);
            this.intFilter1.TabIndex = 8;
            this.intFilter1.Value = 0;
            this.intFilter1.ValueFrom = 0;
            this.intFilter1.ValueTill = 0;
            // 
            // dateFilterItem1
            // 
            this.dateFilterItem1.Active = true;
            this.dateFilterItem1.Attribute = "Created";
            this.dateFilterItem1.AttributeTitle = "Vytvořeno";
            this.dateFilterItem1.AutoDate = false;
            this.dateFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFilterItem1.Location = new System.Drawing.Point(0, 76);
            this.dateFilterItem1.Name = "dateFilterItem1";
            this.dateFilterItem1.Owner = this;
            this.dateFilterItem1.RangeFiltering = true;
            this.dateFilterItem1.Size = new System.Drawing.Size(180, 25);
            this.dateFilterItem1.TabIndex = 3;
            //this.dateFilterItem1.Value = new System.DateTime(2015, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueFrom = new System.DateTime(2015, 6, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueTill =  System.DateTime.Now;
            // 
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl1.Active = false;
            this.strForeignKeyFilterControl1.Attribute = "CreatedByStr";
            this.strForeignKeyFilterControl1.AttributeTitle = "Vytvořil kdo";
            this.strForeignKeyFilterControl1.DisplayAttribute = "CreatedByStr";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "Select distinct CreatedByStr from QFPrikazVyskladneniSeznam where CreatedByStr is not null order by CreatedByStr";
            this.strForeignKeyFilterControl1.TabIndex = 6;
            this.strForeignKeyFilterControl1.ValueAttribute = "CreatedByStr";
            // 
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl2.Active = false;
            this.strForeignKeyFilterControl2.Attribute = "ZemeStr";
            this.strForeignKeyFilterControl2.AttributeTitle = "Země";
            this.strForeignKeyFilterControl2.DisplayAttribute = "ZemeStr";
            this.strForeignKeyFilterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl2.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl2.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl2.Owner = this;
            this.strForeignKeyFilterControl2.ParentFilter = null;
            this.strForeignKeyFilterControl2.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl2.SqlSelect = "Select distinct ZemeStr from QFPrikazVyskladneniSeznam where ZemeStr is not null order by ZemeStr";
            this.strForeignKeyFilterControl2.TabIndex = 6;
            this.strForeignKeyFilterControl2.ValueAttribute = "ZemeStr";
            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.intFilter1);
            this.FilterElements.Add(this.dateFilterItem1);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.FilterElements.Add(this.strForeignKeyFilterControl2);
            this.ResumeLayout(false);
        }

        #endregion

        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter1;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl2;
    }
}
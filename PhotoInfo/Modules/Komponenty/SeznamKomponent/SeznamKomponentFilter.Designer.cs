namespace PhotoInfo.Modules.Komponenty.SeznamKomponent
{
    partial class SeznamKomponentFilter
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
            this.stringFilterItem2 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.stringFilterItem3 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.stringFilterItem4 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.stringFilterItem5 = new SmartISLib.Filters.SqlFilterItems.StringFilterItem();
            this.boolFilter1 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter2 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter3 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter4 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter5 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter6 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl2 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.intFilter1 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.SuspendLayout();
            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Seznam komponent.";
            this.sqlFilterHeader1.Location = new System.Drawing.Point(0, 0);
            this.sqlFilterHeader1.Name = "sqlFilterHeader1";
            this.sqlFilterHeader1.Owner = this;
            this.sqlFilterHeader1.Size = new System.Drawing.Size(133, 26);
            this.sqlFilterHeader1.TabIndex = 0;
            // 
            // stringFilterItem1
            // 
            this.stringFilterItem1.Active = false;
            this.stringFilterItem1.Attribute = "Code";
            this.stringFilterItem1.AttributeTitle = "Číslo komp.";
            this.stringFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem1.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem1.Name = "stringFilterItem1";
            this.stringFilterItem1.Owner = this;
            this.stringFilterItem1.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem1.TabIndex = 1;
            this.stringFilterItem1.Value = "";
            // 
            // stringFilterItem2
            // 
            this.stringFilterItem2.Active = false;
            this.stringFilterItem2.Attribute = "VendorPhoto";
            this.stringFilterItem2.AttributeTitle = "Vendor kód";
            this.stringFilterItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem2.Location = new System.Drawing.Point(0, 51);
            this.stringFilterItem2.Name = "stringFilterItem2";
            this.stringFilterItem2.Owner = this;
            this.stringFilterItem2.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem2.TabIndex = 2;
            this.stringFilterItem2.Value = "";
            // 
            // stringFilterItem3
            // 
            this.stringFilterItem3.Active = false;
            this.stringFilterItem3.Attribute = "PDMComent";
            this.stringFilterItem3.AttributeTitle = "Interní komentář";
            this.stringFilterItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem3.Location = new System.Drawing.Point(0, 76);
            this.stringFilterItem3.Name = "stringFilterItem3";
            this.stringFilterItem3.Owner = this;
            this.stringFilterItem3.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem3.TabIndex = 3;
            this.stringFilterItem3.Value = "";
            // 
            // stringFilterItem4
            // 
            this.stringFilterItem4.Active = false;
            this.stringFilterItem4.Attribute = "BIN";
            this.stringFilterItem4.AttributeTitle = "BIN";
            this.stringFilterItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem4.Location = new System.Drawing.Point(0, 101);
            this.stringFilterItem4.Name = "stringFilterItem4";
            this.stringFilterItem4.Owner = this;
            this.stringFilterItem4.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem4.TabIndex = 4;
            this.stringFilterItem4.Value = "";
            // 
            // stringFilterItem5
            // 
            this.stringFilterItem5.Active = false;
            this.stringFilterItem5.Attribute = "Description";
            this.stringFilterItem5.AttributeTitle = "Název komp.";
            this.stringFilterItem5.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem5.Location = new System.Drawing.Point(0, 126);
            this.stringFilterItem5.Name = "stringFilterItem5";
            this.stringFilterItem5.Owner = this;
            this.stringFilterItem5.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem5.TabIndex = 5;
            this.stringFilterItem5.Value = "";
            // 
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl1.Active = false;
            this.strForeignKeyFilterControl1.Attribute = "PDMStatusPhoto";
            this.strForeignKeyFilterControl1.AttributeTitle = "Status komponentu";
            this.strForeignKeyFilterControl1.DisplayAttribute = "PDMStatusPhoto";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "Select distinct PDMStatusPhoto from QFComponentsPhoto";
            this.strForeignKeyFilterControl1.TabIndex = 6;
            this.strForeignKeyFilterControl1.ValueAttribute = "PDMStatusPhoto";
            // 
            // strForeignKeyFilterControl2
            // 
            this.strForeignKeyFilterControl2.Active = false;
            this.strForeignKeyFilterControl2.Attribute = "KomponentKategorieName";
            this.strForeignKeyFilterControl2.AttributeTitle = "Druh komponentu";
            this.strForeignKeyFilterControl2.DisplayAttribute = "KomponentKategorieName";
            this.strForeignKeyFilterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl2.Location = new System.Drawing.Point(0, 176);
            this.strForeignKeyFilterControl2.Name = "strForeignKeyFilterControl2";
            this.strForeignKeyFilterControl2.Owner = this;
            this.strForeignKeyFilterControl2.ParentFilter = null;
            this.strForeignKeyFilterControl2.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl2.SqlSelect = "Select distinct KomponentKategorieName from QFComponentsPhoto";
            this.strForeignKeyFilterControl2.TabIndex = 7;
            this.strForeignKeyFilterControl2.ValueAttribute = "KomponentKategorieName";
            // 
            // intFilter1
            // 
            this.intFilter1.Active = false;
            this.intFilter1.Attribute = "vaha";
            this.intFilter1.AttributeTitle = "Hmotnost";
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
            //boolFilter3
            //
            this.boolFilter3.Active = false;
            this.boolFilter3.Attribute = "vaha";
            this.boolFilter3.AttributeTitle = "Chybějící hmotnoist";
            this.boolFilter3.Name = "vaha";
            this.boolFilter3.Owner = this;
            this.boolFilter3.Location = new System.Drawing.Point(0, 225);
            this.boolFilter3.TabIndex = 9;
            //
            //boolFilter1
            //
            this.boolFilter1.Active = false;
            this.boolFilter1.Attribute = "Scrap";
            this.boolFilter1.AttributeTitle = "Scrap";
            this.boolFilter1.Name = "Scrap";
            this.boolFilter1.Owner = this;
            this.boolFilter1.Location = new System.Drawing.Point(0, 275);
            this.boolFilter1.TabIndex = 11;
            //
            //boolFilter2
            //
            // TODO - upravit... ConditionFormat. „CASE WHEN [{0}] IS NOT NULL THEN ELSE 0 END = {1}“
            this.boolFilter2.ConditionFormat = "";
            this.boolFilter2.Active = false;
            this.boolFilter2.Attribute = "EOD";
            this.boolFilter2.AttributeTitle = "EOD";
            this.boolFilter2.Name = "EOD";
            this.boolFilter2.Owner = this;
            this.boolFilter2.Location = new System.Drawing.Point(0, 250);
            this.boolFilter2.TabIndex = 10;
            //
            //boolFilter4
            //
            this.boolFilter4.Active = false;
            this.boolFilter4.Attribute = "new";
            this.boolFilter4.AttributeTitle = "Nový";
            this.boolFilter4.Name = "new";
            this.boolFilter4.Owner = this;
            this.boolFilter4.Location = new System.Drawing.Point(0, 300);
            this.boolFilter4.TabIndex = 12;
            //
            //boolFilter5
            //
            this.boolFilter5.Active = false;
            this.boolFilter5.Attribute = "ZmenaDesignu";
            this.boolFilter5.AttributeTitle = "Změna designu";
            this.boolFilter5.Name = "ZmenaDesignu";
            this.boolFilter5.Owner = this;
            this.boolFilter5.Location = new System.Drawing.Point(0, 325);
            this.boolFilter5.TabIndex = 13;
            //
            //boolFilter6
            //
            this.boolFilter6.Active = false;
            this.boolFilter6.Attribute = "TimeRevision";
            this.boolFilter6.AttributeTitle = "Změna designu";
            this.boolFilter6.Name = "TimeRevision";
            this.boolFilter6.Owner = this;
            this.boolFilter6.Location = new System.Drawing.Point(0, 350);
            this.boolFilter6.TabIndex = 14;
            // 
            // SeznamKomponentFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.stringFilterItem2);
            this.FilterElements.Add(this.stringFilterItem3);
            this.FilterElements.Add(this.stringFilterItem4);
            this.FilterElements.Add(this.stringFilterItem5);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.FilterElements.Add(this.strForeignKeyFilterControl2);
            this.FilterElements.Add(this.intFilter1);
            this.FilterElements.Add(this.boolFilter1);
            this.FilterElements.Add(this.boolFilter2);
            this.FilterElements.Add(this.boolFilter3);
            this.FilterElements.Add(this.boolFilter4);
            this.FilterElements.Add(this.boolFilter5);
            this.FilterElements.Add(this.boolFilter6);
            this.Name = "SeznamKomponentFilter";
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem2;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem3;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem4;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem5;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl2;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter1;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter1;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter2;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter3;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter4;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter5;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter6;

    }
}
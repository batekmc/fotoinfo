using System;
namespace PhotoInfo.Modules.Komponenty.SampleList
{
    partial class SampleListFilter
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

        #region MYFILTER code

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
            this.boolFilter1 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl2 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl3 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl4 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl5 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl6 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl7 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.dateFilterItem1 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();
            this.dateFilterItem2 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();
            this.dateFilterItem3 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();
            this.intFilter1 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.intFilter2 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.intFilter3 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.intFilter4 = new SmartISLib.Filters.SqlFilterItems.IntegerFilterItem();
            this.SuspendLayout();
            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Sample List Filtr";
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
            // stringFilterItem2
            // 
            this.stringFilterItem2.Active = false;
            this.stringFilterItem2.Attribute = "MethodOfPackagingMain";
            this.stringFilterItem2.AttributeTitle = "Metoda balení hlavní";
            this.stringFilterItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem2.Location = new System.Drawing.Point(0, 51);
            this.stringFilterItem2.Name = "stringFilterItem2";
            this.stringFilterItem2.Owner = this;
            this.stringFilterItem2.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem2.TabIndex = 1;
            this.stringFilterItem2.Value = "";
            // 
            // stringFilterItem3
            // 
            this.stringFilterItem3.Active = false;
            this.stringFilterItem3.Attribute = "MethodOfPackagingSecondary";
            this.stringFilterItem3.AttributeTitle = "Metoda balení vedlejší";
            this.stringFilterItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem3.Location = new System.Drawing.Point(0, 76);
            this.stringFilterItem3.Name = "stringFilterItem3";
            this.stringFilterItem3.Owner = this;
            this.stringFilterItem3.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem3.TabIndex = 1;
            this.stringFilterItem3.Value = "";
            // 
            // stringFilterItem4
            // 
            this.stringFilterItem4.Active = false;
            this.stringFilterItem4.Attribute = "NoteSet";
            this.stringFilterItem4.AttributeTitle = "Poznámka k uložení setu";
            this.stringFilterItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem4.Location = new System.Drawing.Point(0, 101);
            this.stringFilterItem4.Name = "stringFilterItem4";
            this.stringFilterItem4.Owner = this;
            this.stringFilterItem4.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem4.TabIndex = 1;
            this.stringFilterItem4.Value = "";
            // 
            // boolFilter1
            // 
            this.boolFilter1.Active = false;
            this.boolFilter1.Attribute = "PostedWi";
            this.boolFilter1.AttributeTitle = "Posláno WI";
            this.boolFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.boolFilter1.Location = new System.Drawing.Point(0, 301);
            this.boolFilter1.Name = "boolFilter1";
            this.boolFilter1.Owner = this;
            this.boolFilter1.Size = new System.Drawing.Size(133, 30);
            this.boolFilter1.TabIndex = 7;
            this.boolFilter1.ThreeState = true;
            this.boolFilter1.Value = false;
            // 
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl1.Active = false;
            this.strForeignKeyFilterControl1.Attribute = "ZemeStr";
            this.strForeignKeyFilterControl1.AttributeTitle = "Země";
            this.strForeignKeyFilterControl1.DisplayAttribute = "Zeme";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 126);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "SELECT * FROM TZeme ORDER BY Zeme";
            this.strForeignKeyFilterControl1.TabIndex = 6;
            this.strForeignKeyFilterControl1.ValueAttribute = "Zeme";
            // 
            // strForeignKeyFilterControl2
            // 
            this.strForeignKeyFilterControl2.Active = false;
            this.strForeignKeyFilterControl2.Attribute = "StatusSetStr";
            this.strForeignKeyFilterControl2.AttributeTitle = "Status setu";
            this.strForeignKeyFilterControl2.DisplayAttribute = "Name";
            this.strForeignKeyFilterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl2.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl2.Name = "strForeignKeyFilterControl2";
            this.strForeignKeyFilterControl2.Owner = this;
            this.strForeignKeyFilterControl2.ParentFilter = null;
            this.strForeignKeyFilterControl2.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl2.SqlSelect = "Select  ID,Name From TSampleListCis where SCategory= \'status\' order by Name";
            this.strForeignKeyFilterControl2.TabIndex = 6;
            this.strForeignKeyFilterControl2.ValueAttribute = "Name";
            // 
            // strForeignKeyFilterControl3
            // 
            this.strForeignKeyFilterControl3.Active = false;
            this.strForeignKeyFilterControl3.Attribute = "WhoWorkedStr";
            this.strForeignKeyFilterControl3.AttributeTitle = "Zpracoval WI";
            this.strForeignKeyFilterControl3.DisplayAttribute = "ResponsiblePhotoCode";
            this.strForeignKeyFilterControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl3.Location = new System.Drawing.Point(0, 176);
            this.strForeignKeyFilterControl3.Name = "strForeignKeyFilterControl3";
            this.strForeignKeyFilterControl3.Owner = this;
            this.strForeignKeyFilterControl3.ParentFilter = null;
            this.strForeignKeyFilterControl3.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl3.SqlSelect = "SELECT IDResponsiblePhoto,ResponsiblePhotoCode FROM TPersonResponsiblePhoto WHERE" +
    " ResponsiblePhotoCode IS NOT NULL ORDER BY ResponsiblePhotoCode";
            this.strForeignKeyFilterControl3.TabIndex = 6;
            this.strForeignKeyFilterControl3.ValueAttribute = "ResponsiblePhotoCode";
            // 
            // strForeignKeyFilterControl4
            // 
            this.strForeignKeyFilterControl4.Active = false;
            this.strForeignKeyFilterControl4.Attribute = "BreatherBagStr";
            this.strForeignKeyFilterControl4.AttributeTitle = "Breather bag";
            this.strForeignKeyFilterControl4.DisplayAttribute = "Name";
            this.strForeignKeyFilterControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl4.Location = new System.Drawing.Point(0, 201);
            this.strForeignKeyFilterControl4.Name = "strForeignKeyFilterControl4";
            this.strForeignKeyFilterControl4.Owner = this;
            this.strForeignKeyFilterControl4.ParentFilter = null;
            this.strForeignKeyFilterControl4.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl4.SqlSelect = "Select  ID,Name From TSampleListCis where SCategory= \'BreatherBag \' order by Name" +
    "";
            this.strForeignKeyFilterControl4.TabIndex = 6;
            this.strForeignKeyFilterControl4.ValueAttribute = "Name";
            // 
            // strForeignKeyFilterControl5
            // 
            this.strForeignKeyFilterControl5.Active = false;
            this.strForeignKeyFilterControl5.Attribute = "TypeOfPackagingStr";
            this.strForeignKeyFilterControl5.AttributeTitle = "Druh balení";
            this.strForeignKeyFilterControl5.DisplayAttribute = "Name";
            this.strForeignKeyFilterControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl5.Location = new System.Drawing.Point(0, 226);
            this.strForeignKeyFilterControl5.Name = "strForeignKeyFilterControl5";
            this.strForeignKeyFilterControl5.Owner = this;
            this.strForeignKeyFilterControl5.ParentFilter = null;
            this.strForeignKeyFilterControl5.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl5.SqlSelect = "Select  ID,Name From TSampleListCis where SCategory= \'DruhBaleni\' order by Name";
            this.strForeignKeyFilterControl5.TabIndex = 6;
            this.strForeignKeyFilterControl5.ValueAttribute = "Name";
            // 
            // strForeignKeyFilterControl6
            // 
            this.strForeignKeyFilterControl6.Active = false;
            this.strForeignKeyFilterControl6.Attribute = "SizeOfBoxStr";
            this.strForeignKeyFilterControl6.AttributeTitle = "Velikost krabice";
            this.strForeignKeyFilterControl6.DisplayAttribute = "Name";
            this.strForeignKeyFilterControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl6.Location = new System.Drawing.Point(0, 251);
            this.strForeignKeyFilterControl6.Name = "strForeignKeyFilterControl6";
            this.strForeignKeyFilterControl6.Owner = this;
            this.strForeignKeyFilterControl6.ParentFilter = null;
            this.strForeignKeyFilterControl6.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl6.SqlSelect = "Select  ID,Name From TSampleListCis where SCategory= \'VelikostKrabice \' order by " +
    "Name";
            this.strForeignKeyFilterControl6.TabIndex = 6;
            this.strForeignKeyFilterControl6.ValueAttribute = "Name";
            // 
            // strForeignKeyFilterControl7
            // 
            this.strForeignKeyFilterControl7.Active = false;
            this.strForeignKeyFilterControl7.Attribute = "WhoApprovedStr";
            this.strForeignKeyFilterControl7.AttributeTitle = "Schválil WI";
            this.strForeignKeyFilterControl7.DisplayAttribute = "ResponsiblePhotoCode";
            this.strForeignKeyFilterControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl7.Location = new System.Drawing.Point(0, 276);
            this.strForeignKeyFilterControl7.Name = "strForeignKeyFilterControl7";
            this.strForeignKeyFilterControl7.Owner = this;
            this.strForeignKeyFilterControl7.ParentFilter = null;
            this.strForeignKeyFilterControl7.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl7.SqlSelect = "SELECT IDResponsiblePhoto,ResponsiblePhotoCode FROM TPersonResponsiblePhoto WHERE" +
    " ResponsiblePhotoCode IS NOT NULL ORDER BY ResponsiblePhotoCode";
            this.strForeignKeyFilterControl7.TabIndex = 6;
            this.strForeignKeyFilterControl7.ValueAttribute = "ResponsiblePhotoCode";
            // 
            // dateFilterItem1
            // 
            this.dateFilterItem1.Active = false;
            this.dateFilterItem1.Attribute = "Created";
            this.dateFilterItem1.AttributeTitle = "Vytvořen od";
            this.dateFilterItem1.AutoDate = false;
            this.dateFilterItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFilterItem1.Location = new System.Drawing.Point(0, 331);
            this.dateFilterItem1.Name = "dateFilterItem1";
            this.dateFilterItem1.Owner = this;
            this.dateFilterItem1.RangeFiltering = true;
            this.dateFilterItem1.Size = new System.Drawing.Size(133, 25);
            this.dateFilterItem1.TabIndex = 3;
            this.dateFilterItem1.Value = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueFrom = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem1.ValueTill = new System.DateTime(2015, 10, 7, 12, 3, 25, 894);
            // 
            // dateFilterItem2
            // 
            this.dateFilterItem2.Active = false;
            this.dateFilterItem2.Attribute = "DateOfProcessing";
            this.dateFilterItem2.AttributeTitle = "Datum zpracování";
            this.dateFilterItem2.AutoDate = false;
            this.dateFilterItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFilterItem2.Location = new System.Drawing.Point(0, 356);
            this.dateFilterItem2.Name = "dateFilterItem2";
            this.dateFilterItem2.Owner = this;
            this.dateFilterItem2.RangeFiltering = true;
            this.dateFilterItem2.Size = new System.Drawing.Size(133, 25);
            this.dateFilterItem2.TabIndex = 3;
            this.dateFilterItem2.Value = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem2.ValueFrom = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem2.ValueTill = new System.DateTime(2015, 10, 7, 12, 3, 25, 934);
            // 
            // dateFilterItem3
            // 
            this.dateFilterItem3.Active = false;
            this.dateFilterItem3.Attribute = "DateOfApproval";
            this.dateFilterItem3.AttributeTitle = "Datum schválení";
            this.dateFilterItem3.AutoDate = false;
            this.dateFilterItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFilterItem3.Location = new System.Drawing.Point(0, 381);
            this.dateFilterItem3.Name = "dateFilterItem3";
            this.dateFilterItem3.Owner = this;
            this.dateFilterItem3.RangeFiltering = true;
            this.dateFilterItem3.Size = new System.Drawing.Size(133, 25);
            this.dateFilterItem3.TabIndex = 3;
            this.dateFilterItem3.Value = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem3.ValueFrom = new System.DateTime(2008, 8, 12, 0, 0, 0, 0);
            this.dateFilterItem3.ValueTill = new System.DateTime(2015, 10, 7, 12, 3, 25, 974);
            // 
            // intFilter1
            // 
            this.intFilter1.Active = false;
            this.intFilter1.Attribute = "NumberInBox";
            this.intFilter1.AttributeTitle = "Počet ks OD-DO";
            this.intFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.intFilter1.Location = new System.Drawing.Point(0, 406);
            this.intFilter1.Maximum = 100;
            this.intFilter1.Minimum = 0;
            this.intFilter1.Name = "intFilter1";
            this.intFilter1.Owner = this;
            this.intFilter1.RangeFiltering = true;
            this.intFilter1.Size = new System.Drawing.Size(133, 25);
            this.intFilter1.TabIndex = 8;
            this.intFilter1.Value = 0;
            this.intFilter1.ValueFrom = 0;
            this.intFilter1.ValueTill = 0;
            // 
            // intFilter2
            // 
            this.intFilter2.Active = false;
            this.intFilter2.Attribute = "WidthSet";
            this.intFilter2.AttributeTitle = "Šířka setu OD-DO";
            this.intFilter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.intFilter2.Location = new System.Drawing.Point(0, 431);
            this.intFilter2.Maximum = 100;
            this.intFilter2.Minimum = 0;
            this.intFilter2.Name = "intFilter2";
            this.intFilter2.Owner = this;
            this.intFilter2.RangeFiltering = true;
            this.intFilter2.Size = new System.Drawing.Size(133, 25);
            this.intFilter2.TabIndex = 8;
            this.intFilter2.Value = 0;
            this.intFilter2.ValueFrom = 0;
            this.intFilter2.ValueTill = 0;
            // 
            // intFilter3
            // 
            this.intFilter3.Active = false;
            this.intFilter3.Attribute = "HeightSet";
            this.intFilter3.AttributeTitle = "Výška setu OD-DO";
            this.intFilter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.intFilter3.Location = new System.Drawing.Point(0, 456);
            this.intFilter3.Maximum = 100;
            this.intFilter3.Minimum = 0;
            this.intFilter3.Name = "intFilter3";
            this.intFilter3.Owner = this;
            this.intFilter3.RangeFiltering = true;
            this.intFilter3.Size = new System.Drawing.Size(133, 25);
            this.intFilter3.TabIndex = 8;
            this.intFilter3.Value = 0;
            this.intFilter3.ValueFrom = 0;
            this.intFilter3.ValueTill = 0;
            // 
            // intFilter4
            // 
            this.intFilter4.Active = false;
            this.intFilter4.Attribute = "LengthSet";
            this.intFilter4.AttributeTitle = "Délka setu OD-DO";
            this.intFilter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.intFilter4.Location = new System.Drawing.Point(0, 481);
            this.intFilter4.Maximum = 100;
            this.intFilter4.Minimum = 0;
            this.intFilter4.Name = "intFilter4";
            this.intFilter4.Owner = this;
            this.intFilter4.RangeFiltering = true;
            this.intFilter4.Size = new System.Drawing.Size(133, 25);
            this.intFilter4.TabIndex = 8;
            this.intFilter4.Value = 0;
            this.intFilter4.ValueFrom = 0;
            this.intFilter4.ValueTill = 0;
            // 
            // SampleListFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.stringFilterItem2);
            this.FilterElements.Add(this.stringFilterItem3);
            this.FilterElements.Add(this.stringFilterItem4);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.FilterElements.Add(this.strForeignKeyFilterControl2);
            this.FilterElements.Add(this.strForeignKeyFilterControl3);
            this.FilterElements.Add(this.strForeignKeyFilterControl4);
            this.FilterElements.Add(this.strForeignKeyFilterControl5);
            this.FilterElements.Add(this.strForeignKeyFilterControl6);
            this.FilterElements.Add(this.strForeignKeyFilterControl7);
            this.FilterElements.Add(this.boolFilter1);
            this.FilterElements.Add(this.dateFilterItem1);
            this.FilterElements.Add(this.dateFilterItem2);
            this.FilterElements.Add(this.dateFilterItem3);
            this.FilterElements.Add(this.intFilter1);
            this.FilterElements.Add(this.intFilter2);
            this.FilterElements.Add(this.intFilter3);
            this.FilterElements.Add(this.intFilter4);
            this.Name = "SampleListFilter";
            this.ResumeLayout(false);

        }

        private SmartISLib.Filters.SqlFilterHeader sqlFilterHeader1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem2;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem3;
        private SmartISLib.Filters.SqlFilterItems.StringFilterItem stringFilterItem4;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl1;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl2;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl3;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl4;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl5;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl6;
        private SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl strForeignKeyFilterControl7;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter1;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter2;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter3;
        private SmartISLib.Filters.SqlFilterItems.IntegerFilterItem intFilter4;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter1;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem1;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem2;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem3;

        #endregion
    }
}
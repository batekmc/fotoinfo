using System;
namespace PhotoInfo.Modules.Komponenty.RevizeCasu
{
    partial class RevizeCasuFilter
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

        #region muj filter

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
            this.boolFilter2 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter3 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter4 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter5 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter6 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter7 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.boolFilter8 = new SmartISLib.Filters.SqlFilterItems.BoolFilterItem();
            this.strForeignKeyFilterControl1 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl2 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl3 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl4 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.strForeignKeyFilterControl5 = new SmartISLib.Filters.SqlFilterItems.StrForeignKeyFilterControl();
            this.dateFilterItem1 = new SmartISLib.Filters.SqlFilterItems.DateFilterItem();

            this.SuspendLayout();

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "RevizeCasuFilter";

            // 
            // sqlFilterHeader1
            // 
            this.sqlFilterHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlFilterHeader1.HeaderText = "Revize časů.";
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
            // strForeignKeyFilterControl1
            // 
            this.strForeignKeyFilterControl1.Active = false;
            this.strForeignKeyFilterControl1.Attribute = "KomponentKategorieName";
            this.strForeignKeyFilterControl1.AttributeTitle = "Druh komp.";
            this.strForeignKeyFilterControl1.DisplayAttribute = "KomponentKategorieName";
            this.strForeignKeyFilterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl1.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl1.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl1.Owner = this;
            this.strForeignKeyFilterControl1.ParentFilter = null;
            this.strForeignKeyFilterControl1.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl1.SqlSelect = "Select distinct KomponentKategorieName from QFTimesRevisions";
            this.strForeignKeyFilterControl1.TabIndex = 6;
            this.strForeignKeyFilterControl1.ValueAttribute = "KomponentKategorieName";
            // 
            // stringFilterItem2
            // 
            this.stringFilterItem2.Active = false;
            this.stringFilterItem2.Attribute = "DescriptionComp";
            this.stringFilterItem2.AttributeTitle = "Název komp.";
            this.stringFilterItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem2.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem2.Name = "stringFilterItem1";
            this.stringFilterItem2.Owner = this;
            this.stringFilterItem2.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem2.TabIndex = 1;
            this.stringFilterItem2.Value = "";
            // 
            // strForeignKeyFilterControl2
            // 
            this.strForeignKeyFilterControl2.Active = false;
            this.strForeignKeyFilterControl2.Attribute = "PDMStatusPhoto";
            this.strForeignKeyFilterControl2.AttributeTitle = "Status komp.";
            this.strForeignKeyFilterControl2.DisplayAttribute = "PDMStatusPhoto";
            this.strForeignKeyFilterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl2.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl2.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl2.Owner = this;
            this.strForeignKeyFilterControl2.ParentFilter = null;
            this.strForeignKeyFilterControl2.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl2.SqlSelect = "Select distinct PDMStatusPhoto from QFTimesRevisions";
            this.strForeignKeyFilterControl2.TabIndex = 6;
            this.strForeignKeyFilterControl2.ValueAttribute = "PDMStatusPhoto";
            // 
            // stringFilterItem3
            // 
            this.stringFilterItem3.Active = false;
            this.stringFilterItem3.Attribute = "PDMComent";
            this.stringFilterItem3.AttributeTitle = "Interní koment.";
            this.stringFilterItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem3.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem3.Name = "stringFilterItem1";
            this.stringFilterItem3.Owner = this;
            this.stringFilterItem3.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem3.TabIndex = 1;
            this.stringFilterItem3.Value = "";
            // 
            // strForeignKeyFilterControl3
            // 
            this.strForeignKeyFilterControl3.Active = false;
            this.strForeignKeyFilterControl3.Attribute = "CorrectionName";
            this.strForeignKeyFilterControl3.AttributeTitle = "Oprava";
            this.strForeignKeyFilterControl3.DisplayAttribute = "CorrectionName";
            this.strForeignKeyFilterControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl3.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl3.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl3.Owner = this;
            this.strForeignKeyFilterControl3.ParentFilter = null;
            this.strForeignKeyFilterControl3.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl3.SqlSelect = "Select distinct CorrectionName from QFTimesRevisions";
            this.strForeignKeyFilterControl3.TabIndex = 6;
            this.strForeignKeyFilterControl3.ValueAttribute = "CorrectionName";
            // 
            // strForeignKeyFilterControl4
            // 
            this.strForeignKeyFilterControl4.Active = false;
            this.strForeignKeyFilterControl4.Attribute = "ImageName";
            this.strForeignKeyFilterControl4.AttributeTitle = "Fotka";
            this.strForeignKeyFilterControl4.DisplayAttribute = "ImageName";
            this.strForeignKeyFilterControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl4.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl4.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl4.Owner = this;
            this.strForeignKeyFilterControl4.ParentFilter = null;
            this.strForeignKeyFilterControl4.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl4.SqlSelect = "Select distinct ImageName from QFTimesRevisions";
            this.strForeignKeyFilterControl4.TabIndex = 6;
            this.strForeignKeyFilterControl4.ValueAttribute = "ImageName";
            // 
            // strForeignKeyFilterControl5
            // 
            this.strForeignKeyFilterControl5.Active = false;
            this.strForeignKeyFilterControl5.Attribute = "RevisionTypeName";
            this.strForeignKeyFilterControl5.AttributeTitle = "Typ revize";
            this.strForeignKeyFilterControl5.DisplayAttribute = "RevisionTypeName";
            this.strForeignKeyFilterControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.strForeignKeyFilterControl5.Location = new System.Drawing.Point(0, 151);
            this.strForeignKeyFilterControl5.Name = "strForeignKeyFilterControl1";
            this.strForeignKeyFilterControl5.Owner = this;
            this.strForeignKeyFilterControl5.ParentFilter = null;
            this.strForeignKeyFilterControl5.Size = new System.Drawing.Size(133, 25);
            this.strForeignKeyFilterControl5.SqlSelect = "Select distinct RevisionTypeName from QFTimesRevisions";
            this.strForeignKeyFilterControl5.TabIndex = 6;
            this.strForeignKeyFilterControl5.ValueAttribute = "RevisionTypeName";
            // 
            // stringFilterItem4
            // 
            this.stringFilterItem4.Active = false;
            this.stringFilterItem4.Attribute = "MainComponentCode";
            this.stringFilterItem4.AttributeTitle = "Hlavní komp";
            this.stringFilterItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stringFilterItem4.Location = new System.Drawing.Point(0, 26);
            this.stringFilterItem4.Name = "stringFilterItem1";
            this.stringFilterItem4.Owner = this;
            this.stringFilterItem4.Size = new System.Drawing.Size(133, 25);
            this.stringFilterItem4.TabIndex = 1;
            this.stringFilterItem4.Value = "";
            //
            //boolFilter1
            //
            this.boolFilter1.Active = false;
            this.boolFilter1.Attribute = "IFU";
            this.boolFilter1.AttributeTitle = "IFU";
            this.boolFilter1.Name = "IFU";
            this.boolFilter1.Owner = this;
            //
            //boolFilter2
            //
            this.boolFilter2.Active = false;
            this.boolFilter2.Attribute = "RevisionDone";
            this.boolFilter2.AttributeTitle = "Rvize zkontrolována";
            this.boolFilter2.Name = "RevisionDone";
            this.boolFilter2.Owner = this;
            //
            //boolFilter3
            //
            this.boolFilter3.Active = false;
            this.boolFilter3.Attribute = "NewImage";
            this.boolFilter3.AttributeTitle = "Nově nafocené";
            this.boolFilter3.Name = "NewImage";
            this.boolFilter3.Owner = this;
            //
            //boolFilter4
            //
            this.boolFilter4.Active = false;
            this.boolFilter4.Attribute = "TimeRevision";
            this.boolFilter4.AttributeTitle = "Rvidovat časy";
            this.boolFilter4.Name = "TimeRevision";
            this.boolFilter4.Owner = this;
            //
            //boolFilter5
            //
            this.boolFilter5.Active = false;
            this.boolFilter5.Attribute = "CheckPackage";
            this.boolFilter5.AttributeTitle = "Překontrolovat balení";
            this.boolFilter5.Name = "CheckPackage";
            this.boolFilter5.Owner = this;
            //
            //boolFilter6
            //
            // TODO - zmenit podminku asi - zjistit jestli uz jsou vyexportovane
            //tj export date = null
            this.boolFilter6.Active = false;
            this.boolFilter6.Attribute = "ExportDate";
            this.boolFilter6.AttributeTitle = "Již vyexportované";
            this.boolFilter6.Name = "ExportDate";
            this.boolFilter6.Owner = this;
            //
            //boolFilter7
            //
            this.boolFilter7.Active = false;
            this.boolFilter7.Attribute = "CancelImage";
            this.boolFilter7.AttributeTitle = "Zrusené fotky";
            this.boolFilter7.Name = "CancelImage";
            this.boolFilter7.Owner = this;
            //
            //boolFilter8
            //
            this.boolFilter8.Active = false;
            this.boolFilter8.Attribute = "Actual";
            this.boolFilter8.AttributeTitle = "Aktuální revize";
            this.boolFilter8.Name = "Actual";
            this.boolFilter8.Owner = this;
            // 
            // dateFilterItem1
            // 
            this.dateFilterItem1.Active = false;
            this.dateFilterItem1.Attribute = "ExportDate";
            this.dateFilterItem1.AttributeTitle = "Exportováno";
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
            this.dateFilterItem1.ValueTill = DateTime.Now;

            this.FilterElements.Add(this.sqlFilterHeader1);
            this.FilterElements.Add(this.stringFilterItem1);
            this.FilterElements.Add(this.strForeignKeyFilterControl1);
            this.FilterElements.Add(this.stringFilterItem2);
            this.FilterElements.Add(this.strForeignKeyFilterControl2);
            this.FilterElements.Add(this.stringFilterItem3);
            this.FilterElements.Add(this.strForeignKeyFilterControl3);
            this.FilterElements.Add(this.strForeignKeyFilterControl4);
            this.FilterElements.Add(this.strForeignKeyFilterControl5);
            this.FilterElements.Add(this.stringFilterItem4);
            this.FilterElements.Add(this.boolFilter1);
            this.FilterElements.Add(this.boolFilter2);
            this.FilterElements.Add(this.boolFilter3);
            this.FilterElements.Add(this.boolFilter4);
            this.FilterElements.Add(this.boolFilter5);
            this.FilterElements.Add(this.boolFilter6);
            this.FilterElements.Add(this.boolFilter7);
            this.FilterElements.Add(this.boolFilter8);
            this.FilterElements.Add(this.dateFilterItem1);

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
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter1;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter2;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter3;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter4;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter5;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter6;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter7;
        private SmartISLib.Filters.SqlFilterItems.BoolFilterItem boolFilter8;
        private SmartISLib.Filters.SqlFilterItems.DateFilterItem dateFilterItem1;



        #endregion
    }
}
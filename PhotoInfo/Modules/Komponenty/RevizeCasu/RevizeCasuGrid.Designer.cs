using System.Drawing;
namespace PhotoInfo.Modules.Komponenty.RevizeCasu
{
    partial class RevizeCasuGrid
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
            this.fastDataGridView1 = new SmartISLib.Controls.FastDataGridView();
            this.komponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktualniRevize = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.revidovatCasy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.revizeZkontrolovana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.druhKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interniákoment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oprava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opravaPoznamka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revizePoznamka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prekontrolovatBaleni = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zpusobVyskladneni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typRevize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFU = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hlavniKomponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Px = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdrojCasu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportovan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noveNafocene = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zruseno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vytvoreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vytvoril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastDataGridView1
            // 
            this.fastDataGridView1.AllowUserToAddRows = false;
            this.fastDataGridView1.AlternatingRowStyle = true;
            this.fastDataGridView1.AutoGenerateColumns = false;
            this.fastDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fastDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.komponent,
            this.nazevKomponentu,
            this.revize,
            this.aktualniRevize,
            this.revidovatCasy,
            this.revizeZkontrolovana,
            this.statusKomponentu,
            this.druhKomponentu,
            this.interniákoment,
            this.oprava,
            this.opravaPoznamka,
            this.revizePoznamka,
            this.prekontrolovatBaleni,
            this.zpusobVyskladneni,
            this.typRevize,
            this.IFU,
            this.hlavniKomponent,
            this.fotka,
            this.VS,
            this.VV,
            this.VM,
            this.VP,
            this.Vx,
            this.PP,
            this.PM,
            this.Px,
            this.K,
            this.routing,
            this.timeSAP,
            this.zdrojCasu,
            this.exportovan,
            this.counterNo,
            this.noveNafocene,
            this.zruseno,
            this.vytvoreno,
            this.vytvoril});
            this.fastDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fastDataGridView1.HighlightSelectedCross = false;
            this.fastDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.fastDataGridView1.Name = "fastDataGridView1";
            this.fastDataGridView1.ReadOnly = true;
            this.fastDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fastDataGridView1.Size = new System.Drawing.Size(570, 343);
            this.fastDataGridView1.TabIndex = 2;
            // 
            // komponent
            // 
            this.komponent.DataPropertyName = "Code";
            this.komponent.HeaderText = "Komponent";
            this.komponent.Name = "komponent";
            this.komponent.ReadOnly = true;
            // 
            // nazevKomponentu
            // 
            this.nazevKomponentu.DataPropertyName = "DescriptionComp";
            this.nazevKomponentu.HeaderText = "Název komponentu";
            this.nazevKomponentu.Name = "nazevKomponentu";
            this.nazevKomponentu.ReadOnly = true;
            // 
            // revize
            // 
            this.revize.DataPropertyName = "Revision";
            this.revize.HeaderText = "Revize";
            this.revize.Name = "revize";
            this.revize.ReadOnly = true;
            fastDataGridView1.Columns["revize"].DefaultCellStyle.BackColor = Color.LightCoral;
            // 
            // aktualniRevize
            // 
            this.aktualniRevize.DataPropertyName = "Actual";
            this.aktualniRevize.HeaderText = "Aktuální revize";
            this.aktualniRevize.Name = "aktualniRevize";
            this.aktualniRevize.ReadOnly = true;
            // 
            // revidovatCasy
            // 
            this.revidovatCasy.DataPropertyName = "TimeRevision";
            this.revidovatCasy.HeaderText = "Revidovat časy";
            this.revidovatCasy.Name = "revidovatCasy";
            this.revidovatCasy.ReadOnly = true;
            // 
            // revizeZkontrolovana
            // 
            this.revizeZkontrolovana.DataPropertyName = "RevisionDone";
            this.revizeZkontrolovana.HeaderText = "Revize zkontrolována";
            this.revizeZkontrolovana.Name = "revizeZkontrolovana";
            this.revizeZkontrolovana.ReadOnly = true;
            this.revizeZkontrolovana.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.revizeZkontrolovana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // statusKomponentu
            // 
            this.statusKomponentu.DataPropertyName = "PDMStatusPhoto";
            this.statusKomponentu.HeaderText = "Status komponentu";
            this.statusKomponentu.Name = "statusKomponentu";
            this.statusKomponentu.ReadOnly = true;
            // 
            // druhKomponentu
            // 
            this.druhKomponentu.DataPropertyName = "KomponentKategorieName";
            this.druhKomponentu.HeaderText = "Druh komponentu";
            this.druhKomponentu.Name = "druhKomponentu";
            this.druhKomponentu.ReadOnly = true;
            // 
            // interniákoment
            // 
            this.interniákoment.DataPropertyName = "PDMComent";
            this.interniákoment.HeaderText = "Interní koment";
            this.interniákoment.Name = "interniákoment";
            this.interniákoment.ReadOnly = true;
            // 
            // oprava
            // 
            this.oprava.DataPropertyName = "CorrectionName";
            this.oprava.HeaderText = "Oprava";
            this.oprava.Name = "oprava";
            this.oprava.ReadOnly = true;
            // 
            // opravaPoznamka
            // 
            this.opravaPoznamka.DataPropertyName = "CorrectionNote";
            this.opravaPoznamka.HeaderText = "Oprava - poznámka";
            this.opravaPoznamka.Name = "opravaPoznamka";
            this.opravaPoznamka.ReadOnly = true;
            // 
            // revizePoznamka
            // 
            this.revizePoznamka.DataPropertyName = "Note";
            this.revizePoznamka.HeaderText = "Revize - poznámka";
            this.revizePoznamka.Name = "revizePoznamka";
            this.revizePoznamka.ReadOnly = true;
            // 
            // prekontrolovatBaleni
            // 
            this.prekontrolovatBaleni.DataPropertyName = "CheckPackage";
            this.prekontrolovatBaleni.HeaderText = "Překontrolovat balení";
            this.prekontrolovatBaleni.Name = "prekontrolovatBaleni";
            this.prekontrolovatBaleni.ReadOnly = true;
            // 
            // zpusobVyskladneni
            // 
            this.zpusobVyskladneni.DataPropertyName = "PickTypeName";
            this.zpusobVyskladneni.HeaderText = "Způsob vyskladnění";
            this.zpusobVyskladneni.Name = "zpusobVyskladneni";
            this.zpusobVyskladneni.ReadOnly = true;
            // 
            // typRevize
            // 
            this.typRevize.DataPropertyName = "RevisionTypeName";
            this.typRevize.HeaderText = "Typ revize";
            this.typRevize.Name = "typRevize";
            this.typRevize.ReadOnly = true;
            // 
            // IFU
            // 
            this.IFU.DataPropertyName = "IFU";
            this.IFU.HeaderText = "IFU";
            this.IFU.Name = "IFU";
            this.IFU.ReadOnly = true;
            this.IFU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // hlavniKomponent
            // 
            this.hlavniKomponent.DataPropertyName = "MainComponentCode";
            this.hlavniKomponent.HeaderText = "Hlavní komp.";
            this.hlavniKomponent.Name = "hlavniKomponent";
            this.hlavniKomponent.ReadOnly = true;
            this.hlavniKomponent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hlavniKomponent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fotka
            // 
            this.fotka.DataPropertyName = "ImageName";
            this.fotka.HeaderText = "Fotka";
            this.fotka.Name = "fotka";
            this.fotka.ReadOnly = true;
            this.fotka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fotka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            fastDataGridView1.Columns["fotka"].DefaultCellStyle.Font = new Font("Tahoma", 7.75F, FontStyle.Bold);
            fastDataGridView1.Columns["fotka"].DefaultCellStyle.BackColor = Color.LightGreen;
            // 
            // VS
            // 
            this.VS.DataPropertyName = "VS";
            this.VS.HeaderText = "VS";
            this.VS.Name = "VS";
            this.VS.ReadOnly = true;
            this.VS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VV
            // 
            this.VV.DataPropertyName = "VV";
            this.VV.HeaderText = "VV";
            this.VV.Name = "VV";
            this.VV.ReadOnly = true;
            this.VV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VM
            // 
            this.VM.DataPropertyName = "VM";
            this.VM.HeaderText = "VM";
            this.VM.Name = "VM";
            this.VM.ReadOnly = true;
            this.VM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VP
            // 
            this.VP.DataPropertyName = "VP";
            this.VP.HeaderText = "VP";
            this.VP.Name = "VP";
            this.VP.ReadOnly = true;
            this.VP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vx
            // 
            this.Vx.DataPropertyName = "Vx";
            this.Vx.HeaderText = "Vx";
            this.Vx.Name = "Vx";
            this.Vx.ReadOnly = true;
            this.Vx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PP
            // 
            this.PP.DataPropertyName = "PP";
            this.PP.HeaderText = "PP";
            this.PP.Name = "PP";
            this.PP.ReadOnly = true;
            // 
            // PM
            // 
            this.PM.DataPropertyName = "PM";
            this.PM.HeaderText = "PM";
            this.PM.Name = "PM";
            this.PM.ReadOnly = true;
            // 
            // Px
            // 
            this.Px.DataPropertyName = "Px";
            this.Px.HeaderText = "Px";
            this.Px.Name = "Px";
            this.Px.ReadOnly = true;
            // 
            // K
            // 
            this.K.DataPropertyName = "K";
            this.K.HeaderText = "K";
            this.K.Name = "K";
            this.K.ReadOnly = true;
            // 
            // routing
            // 
            this.routing.DataPropertyName = "Routing";
            this.routing.HeaderText = "Routing";
            this.routing.Name = "routing";
            this.routing.ReadOnly = true;
            fastDataGridView1.Columns["routing"].DefaultCellStyle.BackColor = Color.LightCoral;
            fastDataGridView1.Columns["routing"].DefaultCellStyle.Font = new Font("Tahoma", 7.75F, FontStyle.Bold);

            // 
            // timeSAP
            // 
            this.timeSAP.DataPropertyName = "TimeSAP";
            this.timeSAP.HeaderText = "Time SAP";
            this.timeSAP.Name = "timeSAP";
            this.timeSAP.ReadOnly = true;
            fastDataGridView1.Columns["timeSAP"].DefaultCellStyle.BackColor = Color.LightCoral;
            fastDataGridView1.Columns["timeSAP"].DefaultCellStyle.Font = new Font("Tahoma", 7.75F, FontStyle.Bold);
            // 
            // zdrojCasu
            // 
            this.zdrojCasu.DataPropertyName = "Description";
            this.zdrojCasu.HeaderText = "Zdroj časů";
            this.zdrojCasu.Name = "zdrojCasu";
            this.zdrojCasu.ReadOnly = true;
            // 
            // exportovan
            // 
            this.exportovan.DataPropertyName = "ExportDate";
            this.exportovan.HeaderText = "Exportován";
            this.exportovan.Name = "exportovan";
            this.exportovan.ReadOnly = true;
            // 
            // counterNo
            // 
            this.counterNo.DataPropertyName = "CounterNo";
            this.counterNo.HeaderText = "Counter No.";
            this.counterNo.Name = "counterNo";
            this.counterNo.ReadOnly = true;
            // 
            // noveNafocene
            // 
            this.noveNafocene.DataPropertyName = "NewImage";
            this.noveNafocene.HeaderText = "Nově nafocené";
            this.noveNafocene.Name = "noveNafocene";
            this.noveNafocene.ReadOnly = true;
            // 
            // zruseno
            // 
            this.zruseno.DataPropertyName = "CancelImage";
            this.zruseno.HeaderText = "Zrušeno";
            this.zruseno.Name = "zruseno";
            this.zruseno.ReadOnly = true;
            // 
            // vytvoreno
            // 
            this.vytvoreno.DataPropertyName = "Created";
            this.vytvoreno.HeaderText = "Vytvořeno";
            this.vytvoreno.Name = "vytvoreno";
            this.vytvoreno.ReadOnly = true;
            // 
            // vytvoril
            // 
            this.vytvoril.DataPropertyName = "CreatedBy";
            this.vytvoril.HeaderText = "Vytvořil";
            this.vytvoril.Name = "vytvoril";
            this.vytvoril.ReadOnly = true;
            // 
            // RevizeCasuGrid
            // 
            this.PrimaryKeyAttribute = "TimesRevisionID";
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Visible = false;;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastDataGridView1);
            this.DataGridView = this.fastDataGridView1;
            this.Name = "RevizeCasuGrid";
            this.SqlSelect = "SELECT * FROM QFTimesRevisions where @where";
            this.Controls.SetChildIndex(this.fastDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView fastDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn komponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn revize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktualniRevize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn revidovatCasy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn revizeZkontrolovana;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn druhKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn interniákoment;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprava;
        private System.Windows.Forms.DataGridViewTextBoxColumn opravaPoznamka;
        private System.Windows.Forms.DataGridViewTextBoxColumn revizePoznamka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prekontrolovatBaleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn zpusobVyskladneni;
        private System.Windows.Forms.DataGridViewTextBoxColumn typRevize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IFU;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlavniKomponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotka;
        private System.Windows.Forms.DataGridViewTextBoxColumn VS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vx;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Px;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn routing;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdrojCasu;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportovan;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noveNafocene;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zruseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vytvoreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vytvoril;
    }
}
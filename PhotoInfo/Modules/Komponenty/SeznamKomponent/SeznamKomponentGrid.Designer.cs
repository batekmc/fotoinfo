namespace PhotoInfo.Modules.Komponenty.SeznamKomponent
{
    partial class SeznamKomponentGrid
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
            this.StatusKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterniKomentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CisloKomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksNAbin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DostupnostProFoceni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuvodPDMsubstituce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazevKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DruhKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorieKomponentu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NafocenoKdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NafotilKdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetCasti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialniPoznamky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Poznamka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZmenaDesignu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumZmeny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoznamkaKeZmene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hmotnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoznámkaKhmotnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevidovatCasy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastDataGridView1
            // 
            this.fastDataGridView1.AlternatingRowStyle = true;
            this.fastDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fastDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusKomponentu,
            this.InterniKomentar,
            this.CisloKomp,
            this.BIN,
            this.ksNAbin,
            this.DostupnostProFoceni,
            this.EOD,
            this.DuvodPDMsubstituce,
            this.NazevKomponentu,
            this.DruhKomponentu,
            this.VendorKod,
            this.KategorieKomponentu,
            this.NafocenoKdy,
            this.NafotilKdo,
            this.PocetCasti,
            this.SpecialniPoznamky,
            this.Scrap,
            this.ScrapDatum,
            this.Novy,
            this.Poznamka,
            this.ZmenaDesignu,
            this.DatumZmeny,
            this.PoznamkaKeZmene,
            this.Hmotnost,
            this.PoznámkaKhmotnosti,
            this.RevidovatCasy});
            this.fastDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fastDataGridView1.HighlightSelectedCross = false;
            this.fastDataGridView1.Location = new System.Drawing.Point(5, 5);
            this.fastDataGridView1.Name = "fastDataGridView1";
            this.fastDataGridView1.Size = new System.Drawing.Size(674, 28);
            this.fastDataGridView1.TabIndex = 2;
            // 
            // StatusKomponentu
            // 
            this.StatusKomponentu.DataPropertyName = "PDMStatusPhoto";
            this.StatusKomponentu.HeaderText = "Status Komponentu";
            this.StatusKomponentu.Name = "StatusKomponentu";
            // 
            // InterniKomentar
            // 
            this.InterniKomentar.DataPropertyName = "PDMComent";
            this.InterniKomentar.HeaderText = "Interní komentář";
            this.InterniKomentar.Name = "InterniKomentar";
            // 
            // CisloKomp
            // 
            this.CisloKomp.DataPropertyName = "Code";
            this.CisloKomp.HeaderText = "Číslo komp.";
            this.CisloKomp.Name = "CisloKomp";
            // 
            // BIN
            // 
            this.BIN.DataPropertyName = "BIN";
            this.BIN.HeaderText = "BIN";
            this.BIN.Name = "BIN";
            // 
            // ksNAbin
            // 
            this.ksNAbin.DataPropertyName = "PcsBIN";
            this.ksNAbin.HeaderText = "ks na BIN";
            this.ksNAbin.Name = "ksNAbin";
            // 
            // DostupnostProFoceni
            // 
            this.DostupnostProFoceni.DataPropertyName = "AvailabilityName";
            this.DostupnostProFoceni.HeaderText = "Dostupnost pro focení";
            this.DostupnostProFoceni.Name = "DostupnostProFoceni";
            // 
            // EOD
            // 
            this.EOD.DataPropertyName = "EOD";
            this.EOD.HeaderText = "EOD";
            this.EOD.Name = "EOD";
            // 
            // DuvodPDMsubstituce
            // 
            this.DuvodPDMsubstituce.DataPropertyName = "ReasonSubst";
            this.DuvodPDMsubstituce.HeaderText = "Důvod PDM substituce";
            this.DuvodPDMsubstituce.Name = "DuvodPDMsubstituce";
            // 
            // NazevKomponentu
            // 
            this.NazevKomponentu.DataPropertyName = "Description";
            this.NazevKomponentu.HeaderText = "Název komponentu";
            this.NazevKomponentu.Name = "NazevKomponentu";
            // 
            // DruhKomponentu
            // 
            this.DruhKomponentu.DataPropertyName = "KomponentKategorieName";
            this.DruhKomponentu.HeaderText = "Druh Komponentu";
            this.DruhKomponentu.Name = "DruhKomponentu";
            // 
            // VendorKod
            // 
            this.VendorKod.DataPropertyName = "VendorPhoto";
            this.VendorKod.HeaderText = "Vendor kód";
            this.VendorKod.Name = "VendorKod";
            // 
            // KategorieKomponentu
            // 
            this.KategorieKomponentu.DataPropertyName = "KategorieKomponentu";
            this.KategorieKomponentu.HeaderText = "Kategorie komponentu";
            this.KategorieKomponentu.Name = "KategorieKomponentu";
            // 
            // NafocenoKdy
            // 
            this.NafocenoKdy.DataPropertyName = "NafocenoKdy";
            this.NafocenoKdy.HeaderText = "Nafoceno kdy";
            this.NafocenoKdy.Name = "NafocenoKdy";
            // 
            // NafotilKdo
            // 
            this.NafotilKdo.DataPropertyName = "NafotilKdoStr";
            this.NafotilKdo.HeaderText = "Nafotil kdo";
            this.NafotilKdo.Name = "NafotilKdo";
            // 
            // PocetCasti
            // 
            this.PocetCasti.DataPropertyName = "Pcs";
            this.PocetCasti.HeaderText = "Počet částí";
            this.PocetCasti.Name = "PocetCasti";
            // 
            // SpecialniPoznamky
            // 
            this.SpecialniPoznamky.DataPropertyName = "SpecialNote";
            this.SpecialniPoznamky.HeaderText = "Speciální poznámky";
            this.SpecialniPoznamky.Name = "SpecialniPoznamky";
            // 
            // Scrap
            // 
            this.Scrap.DataPropertyName = "SCRAP";
            this.Scrap.HeaderText = "Scrap";
            this.Scrap.Name = "Scrap";
            // 
            // ScrapDatum
            // 
            this.ScrapDatum.DataPropertyName = "SCRAPdate";
            this.ScrapDatum.HeaderText = "Scrap datum";
            this.ScrapDatum.Name = "ScrapDatum";
            // 
            // Novy
            // 
            this.Novy.DataPropertyName = "New";
            this.Novy.HeaderText = "Nový";
            this.Novy.Name = "Novy";
            // 
            // Poznamka
            // 
            this.Poznamka.DataPropertyName = "Note";
            this.Poznamka.HeaderText = "Poznámka";
            this.Poznamka.Name = "Poznamka";
            // 
            // ZmenaDesignu
            // 
            this.ZmenaDesignu.DataPropertyName = "ZmenaDesignu";
            this.ZmenaDesignu.HeaderText = "Změna designu";
            this.ZmenaDesignu.Name = "ZmenaDesignu";
            // 
            // DatumZmeny
            // 
            this.DatumZmeny.DataPropertyName = "ZmenaDatum";
            this.DatumZmeny.HeaderText = "Datum změny";
            this.DatumZmeny.Name = "DatumZmeny";
            // 
            // PoznamkaKeZmene
            // 
            this.PoznamkaKeZmene.DataPropertyName = "ZmenaPozn";
            this.PoznamkaKeZmene.HeaderText = "Poznámka ke změně";
            this.PoznamkaKeZmene.Name = "PoznamkaKeZmene";
            // 
            // Hmotnost
            // 
            this.Hmotnost.DataPropertyName = "Vaha";
            this.Hmotnost.HeaderText = "Hmotnost [g]";
            this.Hmotnost.Name = "Hmotnost";
            // 
            // PoznámkaKhmotnosti
            // 
            this.PoznámkaKhmotnosti.DataPropertyName = "VahaPoznamka";
            this.PoznámkaKhmotnosti.HeaderText = "Poznámka k hmotnosti";
            this.PoznámkaKhmotnosti.Name = "PoznámkaKhmotnosti";
            // 
            // RevidovatCasy
            // 
            this.RevidovatCasy.DataPropertyName = "TimeRevision";
            this.RevidovatCasy.HeaderText = "Revidovat časy";
            this.RevidovatCasy.Name = "RevidovatCasy";
            // 
            // SeznamKomponentGrid
            // 
            this.PrimaryKeyAttribute = "ComponentID";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastDataGridView1);
            this.Name = "SeznamKomponentGrid";
            this.Size = new System.Drawing.Size(682, 361);
            this.Controls.SetChildIndex(this.fastDataGridView1, 0);
            this.DataGridView = this.fastDataGridView1;
            this.HorizontalScroll.Visible = true;
            this.SqlSelect = "SELECT * FROM QFComponentsPhoto where @where";
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView fastDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterniKomentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CisloKomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksNAbin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DostupnostProFoceni;
        private System.Windows.Forms.DataGridViewTextBoxColumn EOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuvodPDMsubstituce;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazevKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DruhKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorieKomponentu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NafocenoKdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NafotilKdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetCasti;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialniPoznamky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapDatum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Novy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poznamka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ZmenaDesignu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZmeny;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoznamkaKeZmene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hmotnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoznámkaKhmotnosti;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RevidovatCasy;
    }
}
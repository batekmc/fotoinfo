using System.Windows.Forms;
namespace PhotoInfo.Modules.Komponenty.SampleList
{
    partial class SampleListGrid
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
            this.dataGridView1 = new SmartISLib.Controls.FastDataGridView();
            this.ColumnCislosetu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDruhBaleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBreatherBag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMetodaBaleniHlavni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1MetodaBaleniVedlejsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVelikostKrabic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPocetVKrabici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSirka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVyska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVahaPoslPKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoznamkaKUlozeniSetu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoslanoWI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnZpracoval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumZpracov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSchvalil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumSchvaleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuleziteInformaceKSetu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVytvorenoKdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVytvorilKdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDSampleList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVyskladnilAst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AlternatingRowStyle = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCislosetu,
            this.ColumnZeme,
            this.ColumnStatusSet,
            this.ColumnDruhBaleni,
            this.ColumnBreatherBag,
            this.ColumnMetodaBaleniHlavni,
            this.Column1MetodaBaleniVedlejsi,
            this.ColumnVelikostKrabic,
            this.ColumnPocetVKrabici,
            this.ColumnSirka,
            this.ColumnDelka,
            this.ColumnVyska,
            this.ColumnVahaPoslPKV,
            this.ColumnPoznamkaKUlozeniSetu,
            this.ColumnPoslanoWI,
            this.columnZpracoval,
            this.ColumnDatumZpracov,
            this.ColumnSchvalil,
            this.ColumnDatumSchvaleni,
            this.ColumnDuleziteInformaceKSetu,
            this.ColumnVytvorenoKdy,
            this.ColumnVytvorilKdo,
            this.ColumnIDSampleList,
            this.ColumnVyskladnilAst});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridView1.HighlightSelectedCross = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnCislosetu
            // 
            this.ColumnCislosetu.DataPropertyName = "CisloSetu";
            this.ColumnCislosetu.HeaderText = "Číslo setu";
            this.ColumnCislosetu.Name = "ColumnCislosetu";
            // 
            // ColumnZeme
            // 
            this.ColumnZeme.DataPropertyName = "ZemeStr";
            this.ColumnZeme.HeaderText = "Země";
            this.ColumnZeme.Name = "ColumnZeme";
            // 
            // ColumnStatusSet
            // 
            this.ColumnStatusSet.DataPropertyName = "StatusSetStr";
            this.ColumnStatusSet.HeaderText = "Status set";
            this.ColumnStatusSet.Name = "ColumnStatusSet";
            // 
            // ColumnDruhBaleni
            // 
            this.ColumnDruhBaleni.DataPropertyName = "TypeOfPackagingStr";
            this.ColumnDruhBaleni.HeaderText = "Druh balení";
            this.ColumnDruhBaleni.Name = "ColumnDruhBaleni";
            // 
            // ColumnBreatherBag
            // 
            this.ColumnBreatherBag.DataPropertyName = "BreatherBagStr";
            this.ColumnBreatherBag.HeaderText = "Breather Bag";
            this.ColumnBreatherBag.Name = "ColumnBreatherBag";
            // 
            // ColumnMetodaBaleniHlavni
            // 
            this.ColumnMetodaBaleniHlavni.DataPropertyName = "MethodOfPackagingMain";
            this.ColumnMetodaBaleniHlavni.HeaderText = "Metoda balení hlavní";
            this.ColumnMetodaBaleniHlavni.Name = "ColumnMetodaBaleniHlavni";
            // 
            // Column1MetodaBaleniVedlejsi
            // 
            this.Column1MetodaBaleniVedlejsi.DataPropertyName = "MethodOfPackagingSecondary";
            this.Column1MetodaBaleniVedlejsi.HeaderText = "Metoda balení vedlejší";
            this.Column1MetodaBaleniVedlejsi.Name = "Column1MetodaBaleniVedlejsi";
            // 
            // ColumnVelikostKrabic
            // 
            this.ColumnVelikostKrabic.DataPropertyName = "SizeOfBoxStr";
            this.ColumnVelikostKrabic.HeaderText = "Velikost krabic";
            this.ColumnVelikostKrabic.Name = "ColumnVelikostKrabic";
            // 
            // ColumnPocetVKrabici
            // 
            this.ColumnPocetVKrabici.DataPropertyName = "NumberInBox";
            this.ColumnPocetVKrabici.HeaderText = "Počet v krabici";
            this.ColumnPocetVKrabici.Name = "ColumnPocetVKrabici";
            // 
            // ColumnSirka
            // 
            this.ColumnSirka.DataPropertyName = "WidthSet";
            this.ColumnSirka.HeaderText = "Šířka";
            this.ColumnSirka.Name = "ColumnSirka";
            // 
            // ColumnDelka
            // 
            this.ColumnDelka.DataPropertyName = "LengthSet";
            this.ColumnDelka.HeaderText = "Délka";
            this.ColumnDelka.Name = "ColumnDelka";
            // 
            // ColumnVyska
            // 
            this.ColumnVyska.DataPropertyName = "HeightSet";
            this.ColumnVyska.HeaderText = "Výška";
            this.ColumnVyska.Name = "ColumnVyska";
            // 
            // ColumnVahaPoslPKV
            // 
            this.ColumnVahaPoslPKV.DataPropertyName = "IDSampleList";
            this.ColumnVahaPoslPKV.HeaderText = "Váha posl.PKV [g]";
            this.ColumnVahaPoslPKV.Name = "ColumnVahaPoslPKV";
            // 
            // ColumnPoznamkaKUlozeniSetu
            // 
            this.ColumnPoznamkaKUlozeniSetu.DataPropertyName = "NoteSet";
            this.ColumnPoznamkaKUlozeniSetu.HeaderText = "Poznámka k uložení setu";
            this.ColumnPoznamkaKUlozeniSetu.Name = "ColumnPoznamkaKUlozeniSetu";
            // 
            // ColumnPoslanoWI
            // 
            this.ColumnPoslanoWI.DataPropertyName = "PostedWi";
            this.ColumnPoslanoWI.HeaderText = "Posláno WI";
            this.ColumnPoslanoWI.Name = "ColumnPoslanoWI";
            this.ColumnPoslanoWI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPoslanoWI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnZpracoval
            // 
            this.columnZpracoval.DataPropertyName = "WhoWorkedStr";
            this.columnZpracoval.HeaderText = "Zpracoval";
            this.columnZpracoval.Name = "columnZpracoval";
            // 
            // ColumnDatumZpracov
            // 
            this.ColumnDatumZpracov.DataPropertyName = "DateOfProcessing";
            this.ColumnDatumZpracov.HeaderText = "Datum zpracování";
            this.ColumnDatumZpracov.Name = "ColumnDatumZpracov";
            // 
            // ColumnSchvalil
            // 
            this.ColumnSchvalil.DataPropertyName = "WhoApprovedStr";
            this.ColumnSchvalil.HeaderText = "Schválil";
            this.ColumnSchvalil.Name = "ColumnSchvalil";
            // 
            // ColumnDatumSchvaleni
            // 
            this.ColumnDatumSchvaleni.DataPropertyName = "DateOfApproval";
            this.ColumnDatumSchvaleni.HeaderText = "Datum schválení";
            this.ColumnDatumSchvaleni.Name = "ColumnDatumSchvaleni";
            // 
            // ColumnDuleziteInformaceKSetu
            // 
            this.ColumnDuleziteInformaceKSetu.DataPropertyName = "NoteForApproval";
            this.ColumnDuleziteInformaceKSetu.HeaderText = "Důležité informace k setu";
            this.ColumnDuleziteInformaceKSetu.Name = "ColumnDuleziteInformaceKSetu";
            // 
            // ColumnVytvorenoKdy
            // 
            this.ColumnVytvorenoKdy.DataPropertyName = "Created";
            this.ColumnVytvorenoKdy.HeaderText = "Vytvořeno kdy";
            this.ColumnVytvorenoKdy.Name = "ColumnVytvorenoKdy";
            // 
            // ColumnVytvorilKdo
            // 
            this.ColumnVytvorilKdo.DataPropertyName = "CreatedByStr";
            this.ColumnVytvorilKdo.HeaderText = "Vytvořil kdo";
            this.ColumnVytvorilKdo.Name = "ColumnVytvorilKdo";
            // 
            // ColumnIDSampleList
            // 
            this.ColumnIDSampleList.DataPropertyName = "IDSampleList";
            this.ColumnIDSampleList.HeaderText = "IDSampleList";
            this.ColumnIDSampleList.Name = "ColumnIDSampleList";
            // 
            // ColumnVyskladnilAst
            // 
            this.ColumnVyskladnilAst.DataPropertyName = "VyskladneniLast";
            this.ColumnVyskladnilAst.HeaderText = "Vyskladnil ast";
            this.ColumnVyskladnilAst.Name = "ColumnVyskladnilAst";
            // 
            // SampleListGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.HorizontalScroll.Visible = true;
            this.Controls.Add(this.dataGridView1);
            this.DataGridView = this.dataGridView1;
            this.Name = "SampleListGrid";
            this.PrimaryKeyAttribute = "IDSampleList";
            this.SqlSelect = "SELECT * FROM QFSampleListsTest where @where";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCislosetu;
        private DataGridViewTextBoxColumn ColumnZeme;
        private DataGridViewTextBoxColumn ColumnStatusSet;
        private DataGridViewTextBoxColumn ColumnDruhBaleni;
        private DataGridViewTextBoxColumn ColumnBreatherBag;
        private DataGridViewTextBoxColumn ColumnMetodaBaleniHlavni;
        private DataGridViewTextBoxColumn Column1MetodaBaleniVedlejsi;
        private DataGridViewTextBoxColumn ColumnVelikostKrabic;
        private DataGridViewTextBoxColumn ColumnPocetVKrabici;
        private DataGridViewTextBoxColumn ColumnSirka;
        private DataGridViewTextBoxColumn ColumnDelka;
        private DataGridViewTextBoxColumn ColumnVyska;
        private DataGridViewTextBoxColumn ColumnVahaPoslPKV;
        private DataGridViewTextBoxColumn ColumnPoznamkaKUlozeniSetu;
        private DataGridViewCheckBoxColumn ColumnPoslanoWI;
        private DataGridViewTextBoxColumn columnZpracoval;
        private DataGridViewTextBoxColumn ColumnDatumZpracov;
        private DataGridViewTextBoxColumn ColumnSchvalil;
        private DataGridViewTextBoxColumn ColumnDatumSchvaleni;
        private DataGridViewTextBoxColumn ColumnDuleziteInformaceKSetu;
        private DataGridViewTextBoxColumn ColumnVytvorenoKdy;
        private DataGridViewTextBoxColumn ColumnVytvorilKdo;
        private DataGridViewTextBoxColumn ColumnIDSampleList;
        private DataGridViewTextBoxColumn ColumnVyskladnilAst;
    }
}
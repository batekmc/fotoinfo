namespace PhotoInfo.Modules.Komponenty.PrikazyKVyskladneni
{
    partial class PrikazyKVyskladneniDetail
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
            this.labelCelkovaHmotnost = new System.Windows.Forms.Label();
            this.labelKoef = new System.Windows.Forms.Label();
            this.labelNadpis = new System.Windows.Forms.Label();
            this.textBoxCelkovaHmotnost = new System.Windows.Forms.TextBox();
            this.textBoxKoef = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelVytvorilKdo = new System.Windows.Forms.Label();
            this.labelZeme = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelCisloSetu = new System.Windows.Forms.Label();
            this.buttonTisk = new System.Windows.Forms.Button();
            this.textBoxCisloSetu = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVytvorilKdo = new System.Windows.Forms.ComboBox();
            this.comboBoxZeme = new System.Windows.Forms.ComboBox();
            this.dataGridViewPrikazyKVyskladneni = new SmartISLib.Controls.FastDataGridView();
            this.ColumnComponent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPcsBIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescInDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPDMSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikazyKVyskladneni)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCelkovaHmotnost
            // 
            this.labelCelkovaHmotnost.AutoSize = true;
            this.labelCelkovaHmotnost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCelkovaHmotnost.Location = new System.Drawing.Point(3, 0);
            this.labelCelkovaHmotnost.Name = "labelCelkovaHmotnost";
            this.labelCelkovaHmotnost.Size = new System.Drawing.Size(110, 13);
            this.labelCelkovaHmotnost.TabIndex = 0;
            this.labelCelkovaHmotnost.Text = "Celková hmotnost";
            // 
            // labelKoef
            // 
            this.labelKoef.AutoSize = true;
            this.labelKoef.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoef.Location = new System.Drawing.Point(288, 0);
            this.labelKoef.Name = "labelKoef";
            this.labelKoef.Size = new System.Drawing.Size(32, 13);
            this.labelKoef.TabIndex = 1;
            this.labelKoef.Text = "Koef";
            // 
            // labelNadpis
            // 
            this.labelNadpis.AutoSize = true;
            this.labelNadpis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNadpis.Location = new System.Drawing.Point(69, 0);
            this.labelNadpis.Name = "labelNadpis";
            this.labelNadpis.Size = new System.Drawing.Size(177, 19);
            this.labelNadpis.TabIndex = 2;
            this.labelNadpis.Text = "Příkaz k vyskladnění";
            // 
            // textBoxCelkovaHmotnost
            // 
            this.textBoxCelkovaHmotnost.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCelkovaHmotnost.Location = new System.Drawing.Point(124, 3);
            this.textBoxCelkovaHmotnost.Name = "textBoxCelkovaHmotnost";
            this.textBoxCelkovaHmotnost.ReadOnly = true;
            this.textBoxCelkovaHmotnost.Size = new System.Drawing.Size(100, 21);
            this.textBoxCelkovaHmotnost.TabIndex = 3;
            // 
            // textBoxKoef
            // 
            this.textBoxKoef.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxKoef.Location = new System.Drawing.Point(393, 3);
            this.textBoxKoef.Name = "textBoxKoef";
            this.textBoxKoef.ReadOnly = true;
            this.textBoxKoef.Size = new System.Drawing.Size(100, 21);
            this.textBoxKoef.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.56055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.43945F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxKoef, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCelkovaHmotnost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelKoef, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCelkovaHmotnost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelVytvorilKdo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelZeme, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDatum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCisloSetu, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonTisk, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCisloSetu, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDatum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxVytvorilKdo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxZeme, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 109);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // labelVytvorilKdo
            // 
            this.labelVytvorilKdo.AutoSize = true;
            this.labelVytvorilKdo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVytvorilKdo.Location = new System.Drawing.Point(3, 26);
            this.labelVytvorilKdo.Name = "labelVytvorilKdo";
            this.labelVytvorilKdo.Size = new System.Drawing.Size(75, 13);
            this.labelVytvorilKdo.TabIndex = 5;
            this.labelVytvorilKdo.Text = "Vytvořil kdo";
            // 
            // labelZeme
            // 
            this.labelZeme.AutoSize = true;
            this.labelZeme.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZeme.Location = new System.Drawing.Point(288, 26);
            this.labelZeme.Name = "labelZeme";
            this.labelZeme.Size = new System.Drawing.Size(39, 13);
            this.labelZeme.TabIndex = 6;
            this.labelZeme.Text = "Země";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.Location = new System.Drawing.Point(3, 54);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(45, 13);
            this.labelDatum.TabIndex = 7;
            this.labelDatum.Text = "Datum";
            // 
            // labelCisloSetu
            // 
            this.labelCisloSetu.AutoSize = true;
            this.labelCisloSetu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCisloSetu.Location = new System.Drawing.Point(288, 54);
            this.labelCisloSetu.Name = "labelCisloSetu";
            this.labelCisloSetu.Size = new System.Drawing.Size(61, 13);
            this.labelCisloSetu.TabIndex = 8;
            this.labelCisloSetu.Text = "Číslo setu";
            // 
            // buttonTisk
            // 
            this.buttonTisk.Location = new System.Drawing.Point(393, 84);
            this.buttonTisk.Name = "buttonTisk";
            this.buttonTisk.Size = new System.Drawing.Size(75, 22);
            this.buttonTisk.TabIndex = 9;
            this.buttonTisk.Text = "Tisk";
            this.buttonTisk.UseVisualStyleBackColor = true;
            // 
            // textBoxCisloSetu
            // 
            this.textBoxCisloSetu.Location = new System.Drawing.Point(393, 57);
            this.textBoxCisloSetu.Name = "textBoxCisloSetu";
            this.textBoxCisloSetu.Size = new System.Drawing.Size(100, 21);
            this.textBoxCisloSetu.TabIndex = 13;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(124, 57);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(158, 21);
            this.dateTimePickerDatum.TabIndex = 14;
            // 
            // comboBoxVytvorilKdo
            // 
            this.comboBoxVytvorilKdo.FormattingEnabled = true;
            this.comboBoxVytvorilKdo.Location = new System.Drawing.Point(124, 29);
            this.comboBoxVytvorilKdo.Name = "comboBoxVytvorilKdo";
            this.comboBoxVytvorilKdo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVytvorilKdo.TabIndex = 15;
            // 
            // comboBoxZeme
            // 
            this.comboBoxZeme.FormattingEnabled = true;
            this.comboBoxZeme.Location = new System.Drawing.Point(393, 29);
            this.comboBoxZeme.Name = "comboBoxZeme";
            this.comboBoxZeme.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZeme.TabIndex = 16;
            // 
            // dataGridViewPrikazyKVyskladneni
            // 
            this.dataGridViewPrikazyKVyskladneni.AlternatingRowStyle = true;
            this.dataGridViewPrikazyKVyskladneni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrikazyKVyskladneni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrikazyKVyskladneni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikazyKVyskladneni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnComponent,
            this.ColumnDescription,
            this.ColumnQT,
            this.ColumnBIN,
            this.ColumnPcsBIN,
            this.ColumnEOD,
            this.ColumnDescInDb,
            this.ColumnPDMSub,
            this.ColumnUnitWeight,
            this.ColumnTotalWeight});
            this.dataGridViewPrikazyKVyskladneni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridViewPrikazyKVyskladneni.HighlightSelectedCross = false;
            this.dataGridViewPrikazyKVyskladneni.Location = new System.Drawing.Point(7, 139);
            this.dataGridViewPrikazyKVyskladneni.Name = "dataGridViewPrikazyKVyskladneni";
            this.dataGridViewPrikazyKVyskladneni.Size = new System.Drawing.Size(568, 255);
            this.dataGridViewPrikazyKVyskladneni.TabIndex = 6;
            // 
            // ColumnComponent
            // 
            this.ColumnComponent.DataPropertyName = "Code";
            this.ColumnComponent.HeaderText = "Component";
            this.ColumnComponent.Name = "ColumnComponent";
            this.ColumnComponent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnComponent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.DataPropertyName = "DescriptionPDM";
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnQT
            // 
            this.ColumnQT.DataPropertyName = "Qty";
            this.ColumnQT.HeaderText = "Qt";
            this.ColumnQT.Name = "ColumnQT";
            this.ColumnQT.Width = 20;
            // 
            // ColumnBIN
            // 
            this.ColumnBIN.DataPropertyName = "BIN";
            this.ColumnBIN.HeaderText = "BIN";
            this.ColumnBIN.Name = "ColumnBIN";
            this.ColumnBIN.Width = 40;
            // 
            // ColumnPcsBIN
            // 
            this.ColumnPcsBIN.DataPropertyName = "PcsBIN";
            this.ColumnPcsBIN.HeaderText = "PcsBIN";
            this.ColumnPcsBIN.Name = "ColumnPcsBIN";
            this.ColumnPcsBIN.Width = 30;
            // 
            // ColumnEOD
            // 
            this.ColumnEOD.DataPropertyName = "EOD";
            this.ColumnEOD.HeaderText = "EOD";
            this.ColumnEOD.Name = "ColumnEOD";
            this.ColumnEOD.Width = 40;
            // 
            // ColumnDescInDb
            // 
            this.ColumnDescInDb.DataPropertyName = "DescriptionComp";
            this.ColumnDescInDb.HeaderText = "Description in DB";
            this.ColumnDescInDb.Name = "ColumnDescInDb";
            // 
            // ColumnPDMSub
            // 
            this.ColumnPDMSub.DataPropertyName = "ReasonSubst";
            this.ColumnPDMSub.HeaderText = "Reasons of PDM subst";
            this.ColumnPDMSub.Name = "ColumnPDMSub";
            // 
            // ColumnUnitWeight
            // 
            this.ColumnUnitWeight.DataPropertyName = "UnitWeight";
            this.ColumnUnitWeight.HeaderText = "Unit weight [g]";
            this.ColumnUnitWeight.Name = "ColumnUnitWeight";
            // 
            // ColumnTotalWeight
            // 
            this.ColumnTotalWeight.DataPropertyName = "TotalWeight";
            this.ColumnTotalWeight.HeaderText = "Total weight [g]";
            this.ColumnTotalWeight.Name = "ColumnTotalWeight";
            // 
            // PrikazyKVyskladneniDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPrikazyKVyskladneni);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNadpis);
            this.Name = "PrikazyKVyskladneniDetail";
            this.Size = new System.Drawing.Size(579, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikazyKVyskladneni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCelkovaHmotnost;
        private System.Windows.Forms.Label labelKoef;
        private System.Windows.Forms.Label labelNadpis;
        private System.Windows.Forms.TextBox textBoxCelkovaHmotnost;
        private System.Windows.Forms.TextBox textBoxKoef;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelVytvorilKdo;
        private System.Windows.Forms.Label labelZeme;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelCisloSetu;
        private System.Windows.Forms.Button buttonTisk;
        private System.Windows.Forms.TextBox textBoxCisloSetu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.ComboBox comboBoxVytvorilKdo;
        private System.Windows.Forms.ComboBox comboBoxZeme;
        private SmartISLib.Controls.FastDataGridView dataGridViewPrikazyKVyskladneni;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPcsBIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescInDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPDMSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalWeight;

    }
}
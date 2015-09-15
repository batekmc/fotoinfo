namespace PhotoInfo.Modules.Komponenty.PrikazyKVyskladneni
{
    partial class PrikazyKVyskladneniGrid
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
            this.CsiloSetu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VytvorenoKdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VytvorilKdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hmotnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChybiVaha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLExistuje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastDataGridView1
            // 
            this.fastDataGridView1.AlternatingRowStyle = true;
            this.fastDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fastDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CsiloSetu,
            this.VytvorenoKdy,
            this.VytvorilKdo,
            this.Zeme,
            this.Hmotnost,
            this.ChybiVaha,
            this.SLExistuje,
            this.ID});
            this.fastDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fastDataGridView1.HighlightSelectedCross = false;
            this.fastDataGridView1.Location = new System.Drawing.Point(4, 4);
            this.fastDataGridView1.Name = "fastDataGridView1";
            this.fastDataGridView1.Size = new System.Drawing.Size(530, 39);
            this.fastDataGridView1.TabIndex = 2;
            // 
            // CsiloSetu
            // 
            this.CsiloSetu.DataPropertyName = "CisloSetu";
            this.CsiloSetu.HeaderText = "Číslo setu";
            this.CsiloSetu.Name = "CsiloSetu";
            // 
            // VytvorenoKdy
            // 
            this.VytvorenoKdy.DataPropertyName = "Created";
            this.VytvorenoKdy.HeaderText = "Vytvořeno kdy";
            this.VytvorenoKdy.Name = "VytvorenoKdy";
            // 
            // VytvorilKdo
            // 
            this.VytvorilKdo.DataPropertyName = "CreatedByStr";
            this.VytvorilKdo.HeaderText = "Vytvořil kdo";
            this.VytvorilKdo.Name = "VytvorilKdo";
            // 
            // Zeme
            // 
            this.Zeme.DataPropertyName = "ZemeStr";
            this.Zeme.HeaderText = "Země";
            this.Zeme.Name = "Zeme";
            // 
            // Hmotnost
            // 
            this.Hmotnost.DataPropertyName = "SumTotalWeight";
            this.Hmotnost.HeaderText = "Celková hmotnost [g]";
            this.Hmotnost.Name = "Hmotnost";
            // 
            // ChybiVaha
            // 
            this.ChybiVaha.DataPropertyName = "CountMissingWeight";
            this.ChybiVaha.HeaderText = "Počet komp. kde chybí váha";
            this.ChybiVaha.Name = "ChybiVaha";
            // 
            // SLExistuje
            // 
            this.SLExistuje.DataPropertyName = "ExistSL";
            this.SLExistuje.HeaderText = "SL existuje";
            this.SLExistuje.Name = "SLExistuje";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDPrikazVyskladneni";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PrikazyKVyskladneniGrid
            // 
            this.HorizontalScroll.Visible = true;
            this.DataGridView = this.fastDataGridView1;
            this.Controls.Add(this.fastDataGridView1);
            this.SqlSelect = "SELECT * FROM QFPrikazVyskladneniSeznam where @where";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastDataGridView1);
            this.Name = "PrikazyKVyskladneniGrid";
            this.Controls.SetChildIndex(this.fastDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView fastDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CsiloSetu;
        private System.Windows.Forms.DataGridViewTextBoxColumn VytvorenoKdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn VytvorilKdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hmotnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChybiVaha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SLExistuje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
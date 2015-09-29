namespace PhotoInfo.Modules.Komponenty.SeznamKomponent
{
    partial class SeznamKomponentDetail
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new SmartISLib.Controls.FastDataGridView();
            this.coSeZmenilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puvodniStav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novaHodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Základní údaje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Revize časů";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(601, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hlavní komponent pro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(601, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Příkazy k vyskladnění";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(601, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historie změn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AlternatingRowStyle = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coSeZmenilo,
            this.kdy,
            this.kdo,
            this.puvodniStav,
            this.novaHodnota});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridView1.HighlightSelectedCross = false;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // coSeZmenilo
            // 
            this.coSeZmenilo.DataPropertyName = "TableField";
            this.coSeZmenilo.HeaderText = "Co se změnilo";
            this.coSeZmenilo.Name = "coSeZmenilo";
            // 
            // kdy
            // 
            this.kdy.DataPropertyName = "UpdatedDate";
            this.kdy.HeaderText = "Kdy";
            this.kdy.Name = "kdy";
            // 
            // kdo
            // 
            this.kdo.DataPropertyName = "UpdatedBy";
            this.kdo.HeaderText = "Kdo";
            this.kdo.Name = "kdo";
            // 
            // puvodniStav
            // 
            this.puvodniStav.DataPropertyName = "OldValue";
            this.puvodniStav.HeaderText = "Původní stav";
            this.puvodniStav.Name = "puvodniStav";
            // 
            // novaHodnota
            // 
            this.novaHodnota.DataPropertyName = "NewValue";
            this.novaHodnota.HeaderText = "Nová hodnota";
            this.novaHodnota.Name = "novaHodnota";
            // 
            // SeznamKomponentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SeznamKomponentDetail";
            this.Size = new System.Drawing.Size(615, 404);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private SmartISLib.Controls.FastDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSeZmenilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn puvodniStav;
        private System.Windows.Forms.DataGridViewTextBoxColumn novaHodnota;
    }
}
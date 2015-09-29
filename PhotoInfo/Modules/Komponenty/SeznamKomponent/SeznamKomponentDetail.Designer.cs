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
            this.dataGridView3 = new SmartISLib.Controls.FastDataGridView();
            this.component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new SmartISLib.Controls.FastDataGridView();
            this.cisloSetu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vytvoreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vytvoril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new SmartISLib.Controls.FastDataGridView();
            this.coSeZmenilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puvodniStav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novaHodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabPage1.Size = new System.Drawing.Size(601, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Základní údaje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Revize časů";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(601, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hlavní komponent pro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AlternatingRowStyle = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.component,
            this.revize,
            this.ID});
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridView3.HighlightSelectedCross = false;
            this.dataGridView3.Location = new System.Drawing.Point(4, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(596, 362);
            this.dataGridView3.TabIndex = 0;
            // 
            // component
            // 
            this.component.DataPropertyName = "Code";
            this.component.HeaderText = "Component";
            this.component.Name = "component";
            this.component.ReadOnly = true;
            // 
            // revize
            // 
            this.revize.DataPropertyName = "Revision";
            this.revize.HeaderText = "Revize";
            this.revize.Name = "revize";
            this.revize.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "TimesRevisionID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(601, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Příkazy k vyskladnění";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AlternatingRowStyle = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cisloSetu,
            this.vytvoreno,
            this.vytvoril,
            this.zeme,
            this.description,
            this.qty});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridView2.HighlightSelectedCross = false;
            this.dataGridView2.Location = new System.Drawing.Point(5, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(586, 360);
            this.dataGridView2.TabIndex = 0;
            // 
            // cisloSetu
            // 
            this.cisloSetu.DataPropertyName = "CisloSetu";
            this.cisloSetu.HeaderText = "Číslo setu";
            this.cisloSetu.Name = "cisloSetu";
            this.cisloSetu.ReadOnly = true;
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
            // zeme
            // 
            this.zeme.DataPropertyName = "Zeme";
            this.zeme.HeaderText = "Země";
            this.zeme.Name = "zeme";
            this.zeme.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Qty";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 50;
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // coSeZmenilo
            // 
            this.coSeZmenilo.DataPropertyName = "TableField";
            this.coSeZmenilo.HeaderText = "Co se změnilo";
            this.coSeZmenilo.Name = "coSeZmenilo";
            this.coSeZmenilo.ReadOnly = true;
            // 
            // kdy
            // 
            this.kdy.DataPropertyName = "UpdateDate";
            this.kdy.HeaderText = "Kdy";
            this.kdy.Name = "kdy";
            this.kdy.ReadOnly = true;
            // 
            // kdo
            // 
            this.kdo.DataPropertyName = "UpdateBy";
            this.kdo.HeaderText = "Kdo";
            this.kdo.Name = "kdo";
            this.kdo.ReadOnly = true;
            // 
            // puvodniStav
            // 
            this.puvodniStav.DataPropertyName = "OldValue";
            this.puvodniStav.HeaderText = "Původní stav";
            this.puvodniStav.Name = "puvodniStav";
            this.puvodniStav.ReadOnly = true;
            // 
            // novaHodnota
            // 
            this.novaHodnota.DataPropertyName = "NewValue";
            this.novaHodnota.HeaderText = "Nová hodnota";
            this.novaHodnota.Name = "novaHodnota";
            this.novaHodnota.ReadOnly = true;
            // 
            // SeznamKomponentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SeznamKomponentDetail";
            this.Size = new System.Drawing.Size(615, 404);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private SmartISLib.Controls.FastDataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisloSetu;
        private System.Windows.Forms.DataGridViewTextBoxColumn vytvoreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vytvoril;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private SmartISLib.Controls.FastDataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn component;
        private System.Windows.Forms.DataGridViewTextBoxColumn revize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
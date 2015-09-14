using System;
namespace PhotoInfo.Modules.Komponenty.HistorieZmen
{
    partial class HistorieZmenGrid
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
            this.CisloKomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZmenenePole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuvodniHodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NovaHodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastDataGridView1
            // 
            this.fastDataGridView1.AllowUserToAddRows = false;
            this.fastDataGridView1.AllowUserToDeleteRows = false;
            this.fastDataGridView1.AlternatingRowStyle = true;
            this.fastDataGridView1.AutoGenerateColumns = false;
            this.fastDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastDataGridView1.ColumnHeadersHeight = 29;
            this.fastDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CisloKomp,
            this.ZmenenePole,
            this.Kdo,
            this.Kdy,
            this.PuvodniHodnota,
            this.NovaHodnota});
            this.fastDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fastDataGridView1.HighlightSelectedCross = false;
            this.fastDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.fastDataGridView1.Name = "fastDataGridView1";
            this.fastDataGridView1.ReadOnly = true;
            this.fastDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fastDataGridView1.Size = new System.Drawing.Size(664, 343);
            this.fastDataGridView1.TabIndex = 2;
            this.HorizontalScroll.Visible = true;
            // 
            // CisloKomp
            // 
            this.CisloKomp.DataPropertyName = "ComponentNo";
            this.CisloKomp.HeaderText = "Číslo komp.";
            this.CisloKomp.Name = "CisloKomp";
            this.CisloKomp.ReadOnly = true;
            // 
            // ZmenenePole
            // 
            this.ZmenenePole.DataPropertyName = "TableField";
            this.ZmenenePole.HeaderText = "Změněné pole";
            this.ZmenenePole.Name = "ZmenenePole";
            this.ZmenenePole.ReadOnly = true;
            // 
            // Kdo
            // 
            this.Kdo.DataPropertyName = "UpdateBy";
            this.Kdo.HeaderText = "Kdo";
            this.Kdo.Name = "Kdo";
            this.Kdo.ReadOnly = true;
            // 
            // Kdy
            // 
            this.Kdy.DataPropertyName = "UpdateDate";
            this.Kdy.HeaderText = "Kdy";
            this.Kdy.Name = "Kdy";
            this.Kdy.ReadOnly = true;
            // 
            // PuvodniHodnota
            // 
            this.PuvodniHodnota.DataPropertyName = "OldValue";
            this.PuvodniHodnota.HeaderText = "Původní hodnota";
            this.PuvodniHodnota.Name = "PuvodniHodnota";
            this.PuvodniHodnota.ReadOnly = true;
            // 
            // NovaHodnota
            // 
            this.NovaHodnota.DataPropertyName = "NewValue";
            this.NovaHodnota.HeaderText = "Nová hodnota";
            this.NovaHodnota.Name = "NovaHodnota";
            this.NovaHodnota.ReadOnly = true;
            // 
            // HistorieZmenGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastDataGridView1);
            this.DataGridView = this.fastDataGridView1;
            this.Name = "HistorieZmenGrid";
            this.Size = new System.Drawing.Size(664, 361);
            this.SqlSelect = "SELECT * from QHISTORIE where @where";
            this.Controls.SetChildIndex(this.fastDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fastDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartISLib.Controls.FastDataGridView fastDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CisloKomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZmenenePole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuvodniHodnota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NovaHodnota;
    }
}
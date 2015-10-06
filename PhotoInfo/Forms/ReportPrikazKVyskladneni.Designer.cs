namespace PhotoInfo.Forms
{
    partial class ReportPrikazKVyskladneni
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new PhotoInfo.Forms.DataSet1();
            this.QRPrikazVyskladneniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QRPrikazVyskladneniTableAdapter = new PhotoInfo.Forms.DataSet1TableAdapters.QRPrikazVyskladneniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRPrikazVyskladneniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QRPrikazVyskladneniBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhotoInfo.Forms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(707, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QRPrikazVyskladneniBindingSource
            // 
            this.QRPrikazVyskladneniBindingSource.DataMember = "QRPrikazVyskladneni";
            this.QRPrikazVyskladneniBindingSource.DataSource = this.DataSet1;
            // 
            // QRPrikazVyskladneniTableAdapter
            // 
            this.QRPrikazVyskladneniTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPrikazKVyskladneni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPrikazKVyskladneni";
            this.Text = "ReportPrikazKVyskladneni";
            this.Load += new System.EventHandler(this.ReportPrikazKVyskladneni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRPrikazVyskladneniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QRPrikazVyskladneniBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.QRPrikazVyskladneniTableAdapter QRPrikazVyskladneniTableAdapter;
    }
}
﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo.Forms
{
    public partial class ReportPrikazKVyskladneni : Form
    {
        private int PK = -1;
        private string person = "";

        public ReportPrikazKVyskladneni(int PKey, string personCR)
        {
            this.person = personCR;
            this.PK = PKey;
            InitializeComponent();
        }

        private void ReportPrikazKVyskladneni_Load(object sender, EventArgs e)
        {
            SmartISLib.Data.GetDataAdapter("Select * from QRPrikazVyskladneni where PrikazVyskladID = " + this.PK).Fill(this.DataSet1.QRPrikazVyskladneni); 
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("person", person));
            //DataTable dtBarcode = new DataTable();
            DataRow row = this.DataSet2.BarCode.NewRow();
            row["ImageBytes"] = Other.BarCode128.PaintBarCodeA(60, 120, "11111111");// Image.FromStream(new MemoryStream(Other.BarCode128.PaintBarCodeA(60, 120, "11111111")));
            row["Person"] = person;
            this.DataSet2.BarCode.Rows.Add(row);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter(person));

            this.reportViewer1.RefreshReport();
        }
    }
}

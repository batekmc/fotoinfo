using Microsoft.Reporting.WinForms;
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
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            SmartISLib.Data.GetDataAdapter("Select * from QRPrikazVyskladneni where PrikazVyskladID = " + this.PK).Fill(this.DataSet1.QRPrikazVyskladneni);
            DataRow row = this.DataSet2.BarCode.NewRow();
            row["ImageBytes"] = Other.BarCode128.PaintBarCodeA(240, 50, this.DataSet1.Tables[0].Rows[0]["CisloSetu"].ToString());
            row["Person"] = person;
            double f = 0;
            try
            {
                foreach (DataRow r in this.DataSet1.Tables[0].Rows)
                {
                    f += Convert.ToDouble(r["TotalWeight"]);
                }
                f += (double)Data.TParameters.LoadAll()[0].HmotnostKoef.Value;
                row["Hmotnost"] = f.ToString();
            }
            catch (Exception ex)
            {
                row["Hmotnost"] = "Nelze stanovit - nutno zvážit";
            }
            this.DataSet2.BarCode.Rows.Add(row);

            this.reportViewer1.RefreshReport();
        }
    }
}

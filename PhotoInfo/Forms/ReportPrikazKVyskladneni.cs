using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'DataSet1.QRPrikazVyskladneni' table. You can move, or remove it, as needed.
            //this.QRPrikazVyskladneniTableAdapter.Fill(this.DataSet1.QRPrikazVyskladneni);
            SmartISLib.Data.GetDataAdapter("Select * from QRPrikazVyskladneni where PrikazVyskladID = " + this.PK).Fill(this.DataSet1.QRPrikazVyskladneni); 
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("person", person));
            this.reportViewer1.RefreshReport();
        }
    }
}

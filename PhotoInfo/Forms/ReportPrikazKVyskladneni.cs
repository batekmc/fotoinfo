using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public ReportPrikazKVyskladneni(int PK)
        {
            //sets primary key of detail
            this.PK = PK;
            InitializeComponent();
        }

        private void ReportPrikazKVyskladneni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.QRPrikazVyskladneni' table. You can move, or remove it, as needed.
            this.QRPrikazVyskladneniTableAdapter.Fill(this.DataSet1.QRPrikazVyskladneni);
            //SqlDataAdapter sqlAdapter = SmartISLib.Data.GetDataAdapter("SELECT BIN, Code, DescriptionPDM, Qty, EOD, BIN_EOD, TotalWeight, ReasonSubst FROM QRPrikazVyskladneni where PrikazVyskladID =@PK");
            //sqlAdapter.SelectCommand.Parameters.AddWithValue("PK", this.PK);
            //DataTable bTab = new DataTable();
            //sqlAdapter.Fill(bTab);
            //Console.WriteLine("111111111111111111111111__" + bTab.Rows.Count);
            //this.DataSet1.EnforceConstraints = true;
            //sqlAdapter.Fill(this.DataSet1.QFPrikazVyskladneniSeznam);

            this.reportViewer1.RefreshReport();
        }
    }
}

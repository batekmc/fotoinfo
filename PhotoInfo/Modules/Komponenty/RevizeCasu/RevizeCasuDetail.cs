using SmartISLib.ORM;
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

namespace PhotoInfo.Modules.Komponenty.RevizeCasu
{
    public partial class RevizeCasuDetail : SmartISLib.Modules.GridDetail.DetailControl
    {

        private DataTable revisionsTable;
        private Data.QFTimesRevisionDialog ormTimeRev;
        
        public RevizeCasuDetail()
        {
            InitializeComponent();
        }

        protected override bool LoadRecordCore()
        {
            try
            {
                //Load data for fields - ORM created by me
                this.ormTimeRev = Data.QFTimesRevisionDialog.Load((int)this.PrimaryKey);
                //load data for grid
                SqlDataAdapter adapter = SmartISLib.Data.GetDataAdapter("SELECT * FROM QFTimesRevisionDialog where TimesRevisionID = " + this.PrimaryKey);
                revisionsTable = new DataTable();
                adapter.Fill(revisionsTable);
                Console.WriteLine("________Pocet radku: " + revisionsTable.Rows.Count);
            }
            catch (Exception e)
            {
                SmartISLib.Messages.Error("Nepodařilo se načíst data z QFTimesRevisionDialog");   
                SmartISLib.Messages.Error(e.Message);
                return false;
            }

            return true;
        }

        protected override void BindData()
        {
            // bind grid data to grid
            this.dataGridView1.DataSource = this.revisionsTable;

            BindTextBox(this.textBox2, ormTimeRev, "CompStatus");
        }

    }
}

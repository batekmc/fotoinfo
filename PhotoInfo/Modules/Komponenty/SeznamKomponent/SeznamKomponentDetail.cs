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

namespace PhotoInfo.Modules.Komponenty.SeznamKomponent
{
    public partial class SeznamKomponentDetail : SmartISLib.Modules.GridDetail.DetailControl
    {

        private Data.QFComponentsPhoto ormCompPhoto;
        private DataTable hZmenDTAB;
        private DataTable kVyskladneniDTAB;
        private DataTable kompDTAB;

        public SeznamKomponentDetail()
        {
            InitializeComponent();
        }

        #region overrided methods

        protected override void BindData()
        {
            //historie Zmen
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = hZmenDTAB;

            //Prikazy k vyskladneni
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = kVyskladneniDTAB;

            //Hlavni komponent pro
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.DataSource = kompDTAB;
        }

        protected override bool LoadRecordCore()
        {
            //ORM
            this.ormCompPhoto = Data.QFComponentsPhoto.Load( (int)this.PrimaryKey);
            //historie zmen
            SqlDataAdapter hZmen = SmartISLib.Data.GetDataAdapter("select * from QHistorie where componentID =@compID ORDER BY UpdateDate");
            hZmen.SelectCommand.Parameters.AddWithValue("compID", (int)this.PrimaryKey);
            hZmenDTAB = new DataTable();
            hZmen.Fill(hZmenDTAB);
            //prikazy k vyskladneni
            SqlDataAdapter pKvyskladneni = SmartISLib.Data.GetDataAdapter("select * from QFComponentDetailVyskladneni where ComponentID =@ID");
            pKvyskladneni.SelectCommand.Parameters.AddWithValue("ID", (int)this.PrimaryKey);
            kVyskladneniDTAB = new DataTable();
            pKvyskladneni.Fill(kVyskladneniDTAB);
            //Hlavni komponent pro
            SqlDataAdapter komp = SmartISLib.Data.GetDataAdapter("select * from QFComponentDetailMainComp where component =@ID");
            komp.SelectCommand.Parameters.AddWithValue("ID", (int)this.PrimaryKey);
            kompDTAB = new DataTable();
            komp.Fill(kompDTAB);


            return true;
        }
        #endregion

    }
}

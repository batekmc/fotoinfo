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

        //private Data.QFComponentsPhoto ormCompPhoto;
        private DataTable hZmenDTAB;

        public SeznamKomponentDetail()
        {
            InitializeComponent();
        }

        #region overrided methods

        protected override void BindData()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = hZmenDTAB;

        }

        protected override bool LoadRecordCore()
        {

            //this.ormCompPhoto = Data.QFComponentsPhoto.LoadBy("ComponentID =@param0", (int)this.PrimaryKey)[0];
            SqlDataAdapter hZmen = SmartISLib.Data.GetDataAdapter("select * from QHistorie where componentID =@compID oreder by UpdateDate");
            hZmen.SelectCommand.Parameters.AddWithValue("compID", (int)this.PrimaryKey);
            hZmenDTAB = new DataTable();
            hZmen.Fill(hZmenDTAB);

            return true;
        }
        #endregion

    }
}

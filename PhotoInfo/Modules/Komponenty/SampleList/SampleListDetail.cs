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

namespace PhotoInfo.Modules.Komponenty.SampleList
{
    public partial class SampleListDetail : SmartISLib.Modules.GridDetail.DetailControl
    {
        public SampleListDetail()
        {
            InitializeComponent();
        }


        private DataTable prikazyKVyskladneniDTAB;
        private DataTable historieZmenDTAB;
        private DataTable parentDTAB;

        private SmartISLib.ORM.DbTable<Data.TZeme> zemeComboData;
        private SmartISLib.ORM.DbTable<Data.TSampleListCis> statusSetuComboData;
        private SmartISLib.ORM.DbTable<Data.TSampleListCis> breatherBagComboData;


        #region overriden methods

        protected override bool LoadRecordCore()
        {

            zemeComboData = Data.TZeme.LoadAll();
            zemeComboData.Sort("Zeme");

            statusSetuComboData = Data.TSampleListCis.LoadBy("SCategory =@param0  and Name !=@param1", "status", "null");
            statusSetuComboData.Sort("Name");

            breatherBagComboData = Data.TSampleListCis.LoadBy("SCategory =@param0 and name !=@param1", "BreatherBag", "null");
            breatherBagComboData.Sort("Name");


            parentDTAB = SmartISLib.Data.GetDataTable("SELECT * FROM QFSampleListsTest WHERE IDSampleList = " + (int)this.PrimaryKey);

            prikazyKVyskladneniDTAB = SmartISLib.Data.GetDataTable("select * from QFPrikazVyskladneniSeznam where CisloSetu = '" + Convert.ToString(parentDTAB.Rows[0]["CisloSetu"]) + "'");

            historieZmenDTAB = SmartISLib.Data.GetDataTable("SELECT * FROM THistoryUpdates WHERE TableID = " + (int)this.PrimaryKey);
            return true;
        }

        protected override void BindData()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = prikazyKVyskladneniDTAB;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = historieZmenDTAB;

            this.comboBoxZeme.DataSource = zemeComboData;
            this.comboBoxZeme.DisplayMember = "Zeme";
            string zem = Convert.ToString(this.parentDTAB.Rows[0]["Zeme"]);
            if (zemeComboData != null)
                //this.comboBoxZeme.Value = zem;

            this.comboBoxStatusSetu.DataSource = statusSetuComboData;
            this.comboBoxStatusSetu.DisplayMember = "Name";

            this.comboBoxBreatherBag.DataSource = breatherBagComboData;
            this.comboBoxBreatherBag.DisplayMember = "Name";

        }



        #endregion

    }
}

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

namespace PhotoInfo.Modules.Komponenty.PrikazyKVyskladneni
{
    public partial class PrikazyKVyskladneniDetail : SmartISLib.Modules.GridDetail.DetailControl
    {
        private SmartISLib.ORM.DbTable<Data.QFPrikazVyskladDetail> ormPrikazVysklad;
        private SmartISLib.ORM.DbTable<Data.TPersonResponsiblePhoto> ormTPersonResponsiblePhoto;
        private SmartISLib.ORM.DbTable<Data.TZeme> ormTZeme;
        private SmartISLib.ORM.DbTable<Data.TParameters> ormTParameters;
        // thousands of records => ORM is slow...
        private DataTable componentDTAB;
        //private SmartISLib.ORM.DbTable<Data.TComponents> ormTComponents;

        //datatable for fields - date, cislo setu... => view not in orm...
        private DataTable myDtab;

        public PrikazyKVyskladneniDetail()
        {
            InitializeComponent();
        }

        #region overriden methods
        
        protected override bool LoadRecordCore()
        {
            SqlDataAdapter myAdapter = SmartISLib.Data.GetDataAdapter("SELECT * FROM QFPrikazVyskladneniSeznam where IDPrikazVyskladneni =@PK");
            myAdapter.SelectCommand.Parameters.AddWithValue("PK", (int)this.PrimaryKey);
            myDtab = new DataTable();
            myAdapter.Fill(myDtab);


            this.ormPrikazVysklad = Data.QFPrikazVyskladDetail.LoadByPrikazVyskladID((int)this.PrimaryKey);

            SqlDataAdapter adapterComponent = SmartISLib.Data.GetDataAdapter("SELECT ComponentID, Code FROM TComponents WHERE Code IS NOT NULL ORDER BY Code");
            this.componentDTAB = new DataTable();
            adapterComponent.Fill(componentDTAB);

            // if surname is null, the exception occured in sort...
            this.ormTPersonResponsiblePhoto = Data.TPersonResponsiblePhoto.LoadBy("ResponsiblePhotoSurname !=@param0", "NULL");
            this.ormTPersonResponsiblePhoto.Sort("ResponsiblePhotoSurname");
            this.ormTZeme = Data.TZeme.LoadAll();
            this.ormTZeme.Sort("Zeme");

            Console.WriteLine("________radku combobox: " + componentDTAB.Rows.Count);
            // TODO console,.write...
            Console.WriteLine("___________PK: " + this.PrimaryKey + "  ,  lines: " + ormPrikazVysklad.Count);

            return true;
        }

        protected override void BindData()
        {

            int zemeIndex = -1, personIndex = -1;
            //  Zeme/////////////////////////////
            this.comboBoxZeme.DataSource = this.ormTZeme;
            this.comboBoxZeme.DisplayMember = "Zeme";
            string zem = Convert.ToString(myDtab.Rows[0]["ZemeStr"]);
            for (int i = 0; i < ormTZeme.Count; i++)
            {
                if (ormTZeme[i].Zeme == zem)
                {
                    zemeIndex = i;
                    break;
                }
            }
            if(zemeIndex > 0)
                this.comboBoxZeme.SelectedIndex = zemeIndex;
            
            // person/////////////////////////////
            this.comboBoxVytvorilKdo.DataSource = this.ormTPersonResponsiblePhoto;
            this.comboBoxVytvorilKdo.DisplayMember = "ResponsiblePhotoSurname";
            string personS = Convert.ToString(myDtab.Rows[0]["CreatedByStr"]);
            for (int i = 0; i < ormTPersonResponsiblePhoto.Count; i++)
            {
                if (ormTPersonResponsiblePhoto[i].ResponsiblePhotoSurname == personS)
                {
                    personIndex = i;
                    break;
                }
            }
            if (personIndex > 0)
                this.comboBoxVytvorilKdo.SelectedIndex = personIndex;

            this.ColumnComponent.DataSource = this.componentDTAB;
            this.ColumnComponent.ValueMember = "ComponentID";
            this.ColumnComponent.DisplayMember = "Code"; // Displayed value
            this.ColumnComponent.DataPropertyName = this.ColumnComponent.ValueMember; // has to bbe set this way.. Even thought it worked in in other modules other way...

            // GRID
            this.dataGridViewPrikazyKVyskladneni.DataSource = this.ormPrikazVysklad;

            // TExtboxes//////////////////////////////
            this.textBoxCisloSetu.Text = Convert.ToString(myDtab.Rows[0]["cisloSetu"]);
            this.dateTimePickerDatum.Value = Convert.ToDateTime(myDtab.Rows[0]["Created"]);
            this.textBoxCelkovaHmotnost.Text = Convert.ToString(myDtab.Rows[0]["SumTotalWeight"]);
            this.ormTParameters = Data.TParameters.LoadAll();
            this.textBoxKoef.Text = this.ormTParameters[0].HmotnostKoef.ToString();
            
            Console.WriteLine("_____P: " + personIndex + ", Z: " + zemeIndex);



        }

        protected override bool DeleteRecordCore()
        {
            SmartISLib.Data.Execute("UPDATE TSampleList SET VyskladneniLast = NULL where VyskladneniLast = " + (int)this.PrimaryKey);
            SmartISLib.Data.Execute("delete from TPrikazVyskladDetail where PrikazVyskladID =  " + (int)this.PrimaryKey);
            SmartISLib.Data.Execute("delete from TPrikazVyskladneni where IDPrikazVyskladneni = " + (int)this.PrimaryKey);

            SmartISLib.Messages.Information("Záznam smazán.");


            return true;
        }
        
        #endregion
    }



}

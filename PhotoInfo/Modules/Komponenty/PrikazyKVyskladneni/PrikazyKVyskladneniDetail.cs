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

            //BindComboBox(this.comboBoxVytvorilKdo, "SELECT IDPDMStatusPhoto, PDMStatusPhoto FROM TPDMStatusPhoto", "IDPDMStatusPhoto", "PDMStatusPhoto", ormTPersonResponsiblePhoto, "PDMStatusPhotoID");



            this.ColumnComponent.DataSource = this.componentDTAB;
            this.ColumnComponent.ValueMember = "ComponentID";
            this.ColumnComponent.DisplayMember = "Code"; // Displayed value
            this.ColumnComponent.DataPropertyName = this.ColumnComponent.ValueMember; // has to be set this way.. Even thought it worked in in other modules other way...

            // GRID
            this.dataGridViewPrikazyKVyskladneni.DataSource = this.ormPrikazVysklad;

            // TExtboxes//////////////////////////////
            this.textBoxCisloSetu.Text = Convert.ToString(myDtab.Rows[0]["cisloSetu"]);
            this.dateTimePickerDatum.Value = Convert.ToDateTime(myDtab.Rows[0]["Created"]);
            this.textBoxCelkovaHmotnost.Text = Convert.ToString(myDtab.Rows[0]["SumTotalWeight"]);
            this.ormTParameters = Data.TParameters.LoadAll();
            this.textBoxKoef.Text = this.ormTParameters[0].HmotnostKoef.ToString();
            
            Console.WriteLine("_____P: " + personIndex + ", Z: " + zemeIndex);

            this.vytvorilKdoChanged = false;
            this.zemeChanged = false;
            this.dateChanged = false;

        }

        protected override bool DeleteRecordCore()
        {
            SmartISLib.Data.Execute("UPDATE TSampleList SET VyskladneniLast = NULL where VyskladneniLast = " + (int)this.PrimaryKey);
            SmartISLib.Data.Execute("delete from TPrikazVyskladDetail where PrikazVyskladID =  " + (int)this.PrimaryKey);
            SmartISLib.Data.Execute("delete from TPrikazVyskladneni where IDPrikazVyskladneni = " + (int)this.PrimaryKey);

            SmartISLib.Messages.Information("Záznam smazán.");


            return true;
        }



        bool gridChanged = false, cisloSetuChanged = false, celkovaHmotnostChanged = false, dateChanged = false, vytvorilKdoChanged = false, zemeChanged = false;
        protected override bool UpdateRecordCore()
        {
            // save the grid
            if (gridChanged)
            {
                this.ormPrikazVysklad.SetAttribute("PrikazVyskladID", (int)this.PrimaryKey);
                this.ormPrikazVysklad.Save();
                gridChanged = false;
            }

            // update cisloSetu
            if (cisloSetuChanged)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE QFPrikazVyskladneniSeznam SET cisloSetu = '{0}' where IDPrikazVyskladneni = {1}", textBoxCisloSetu.Text, (int)this.PrimaryKey));
                cisloSetuChanged = false;
            }
            //update weigth
            if (celkovaHmotnostChanged)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE QFPrikazVyskladneniSeznam SET SumTotalWeight = {0} where IDPrikazVyskladneni = {1}", textBoxCelkovaHmotnost.Text, (int)this.PrimaryKey));
                celkovaHmotnostChanged = false;
            }
            //update date
            if (dateChanged)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE QFPrikazVyskladneniSeznam SET Created = '{0}' where IDPrikazVyskladneni = {1}", dateTimePickerDatum.Value.Date.ToString("yyyy-MM-dd"), (int)this.PrimaryKey));
                dateChanged = false;
            }
            //update created by
            if (vytvorilKdoChanged)
            {
                int kdoFK = -1;
                foreach (Data.TPersonResponsiblePhoto kdo in ormTPersonResponsiblePhoto) 
                {
                    if (kdo.ResponsiblePhotoSurname == comboBoxVytvorilKdo.Text)
                    {
                        kdoFK = kdo.IDResponsiblePhoto;
                        break;
                    }
                }
                // has to be set this way because of using view where should not be...
                SmartISLib.Data.Execute(string.Format("UPDATE TPrikazVyskladneni SET CreatedBy = {0} where IDPrikazVyskladneni = {1}", kdoFK, (int)this.PrimaryKey));
                vytvorilKdoChanged = false;
            }
            //update zeme
            if (zemeChanged)
            {
                int zemCode = -1;
                foreach (Data.TZeme tmp in ormTZeme)
                {
                    if (tmp.Zeme == comboBoxZeme.Text)
                    {
                        zemCode = tmp.IDZeme;
                        break;
                    }
                }
                // has to be set this way because of using view where should not be...
                SmartISLib.Data.Execute(string.Format("update TPrikazVyskladneni SET Zeme = {0} where IDPrikazVyskladneni = {1}", zemCode, (int)this.PrimaryKey));
                zemeChanged = false;
            }

            SmartISLib.Messages.Information("Záznam uložen.");

            return true;
        }
        
        #endregion      

        #region  click events

        private void textBoxCisloSetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            cisloSetuChanged = true;
        }

        private void dateTimePickerDatum_SelectedDateChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            dateChanged = true;
        }

        private void comboBoxVytvorilKdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            vytvorilKdoChanged = true;
        }

        private void comboBoxZeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            zemeChanged = true;
        }

        private void dataGridViewPrikazyKVyskladneni_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.NotifyChanged();
            gridChanged = true;
        }

        private void buttonTisk_Click(object sender, EventArgs e)
        {
            Form printForm = new Forms.ReportPrikazKVyskladneni((int)this.PrimaryKey, comboBoxVytvorilKdo.Text);
            printForm.Show();
        }

        #endregion





    }



}

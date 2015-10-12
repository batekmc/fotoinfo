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

        private Data.QFComponentDetailPhoto ormCompPhoto;
        
        // using table to which view refers instead of the particular view
        private SmartISLib.ORM.DbTable<Data.TComponentMovement> ormMovementsNA;
        private SmartISLib.ORM.DbTable<Data.TComponentMovement> ormMovementsVY; 
        
        private DataTable hZmenDTAB;
        private DataTable kVyskladneniDTAB;
        private DataTable kompDTAB;
        //private DataTable dalsiNaskladneniDTAB;
        //private DataTable dalsiOdepsaniDTAB;
        private DataTable zpusobNaskladneniDrDownDTAB;
        private DataTable zpusobOdepsaniDrDownDTAB;
        private DataTable revizeCasuDTAB;
        private DataTable typFotkyDTAB;

        public SeznamKomponentDetail()
        {
            InitializeComponent();
        }

        #region overrided methods

        protected override bool PrepareNew() {

            //Just clean all fields and update UI for user to see the change:)
            this.ormCompPhoto.LoadDefaultValues();
            return true;
        }

        protected override bool UpdateRecordCore()
        {
            //If the user has made a new record, then will be inserted new row to the db. Otherwise will be updated current record.
            try
            {

                this.ormCompPhoto.Update();
                                SmartISLib.Messages.Information("Záznam aktualizován.");

            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
                return false;
            }
            return true;
        }

        protected override bool InsertRecordCore()
        {
            try
            {
                this.ormCompPhoto.Insert();
                PrimaryKey = this.ormCompPhoto.ComponentID;
                SmartISLib.Messages.Information("Záznam uložen.");

            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
                return false;
            }

            return true;
        }

        protected override void BindData()
        {
            //historie Zmen
            this.dataGridViewHistorieZmen.AutoGenerateColumns = false;
            this.dataGridViewHistorieZmen.DataSource = hZmenDTAB;

            //Prikazy k vyskladneni
            this.dataGridViewPrikazyKVyskladneni.AutoGenerateColumns = false;
            this.dataGridViewPrikazyKVyskladneni.DataSource = kVyskladneniDTAB;

            //Hlavni komponent pro
            this.dataGridViewHlavniompPro.AutoGenerateColumns = false;
            this.dataGridViewHlavniompPro.DataSource = kompDTAB;

            //dalsi naskladneni col zpusob naskladneni
            this.zpusobNaskladneni.DataSource = zpusobNaskladneniDrDownDTAB;
            this.zpusobNaskladneni.DisplayMember = "MovementTypeName";

            //dalsi odepsani - zpusob odepsani 
            this.zpusobOdepsani.DataSource = zpusobOdepsaniDrDownDTAB;
            this.zpusobOdepsani.DisplayMember = "MovementTypeName";

            //dalsi naskladneni grid
            this.dataGridViewDalsiNaskladeni.DataSource = ormMovementsNA; // dalsiNaskladneniDTAB;

            //zpusobOdeslani grid
            this.dataGridViewDalsiOdepsani.DataSource = ormMovementsVY; // dalsiOdepsaniDTAB;

            //revize casu
            this.dataGridViewrevizeCasu.AutoGenerateColumns = false;
            this.dataGridViewrevizeCasu.DataSource = revizeCasuDTAB;

            //typ fotky drop down
            this.imageCol.DataSource = this.typFotkyDTAB;
            this.imageCol.DisplayMember = "Image";


            BindTextBox( this.textBoxCisloKomponentu, ormCompPhoto, "Code");
            BindTextBox(this.textBoxNazevKom, ormCompPhoto, "Description");
            BindTextBox(this.textBoxInterniKoment, ormCompPhoto, "PDMComent");
            BindTextBox(this.textBoxVendorKod, ormCompPhoto, "VendorPhoto");
            BindTextBox(this.textBoxPocetCasti, ormCompPhoto, "Pcs");
            BindTextBox(this.textBoxEOD, ormCompPhoto, "EOD");
            BindTextBox(this.textBoxDuvodEOD, ormCompPhoto, "ReasonSubst");
            BindTextBox(this.textBoxHmotnost, ormCompPhoto, "Vaha");
            BindTextBox(this.textBoxPoznamky, ormCompPhoto, "Note");
            BindTextBox(this.textBoxPoznamkaKHmotnosti, ormCompPhoto, "VahaPoznamka");
            BindTextBox(this.textBoxBIN, ormCompPhoto, "BIN");
            BindTextBox(this.textBoxVychoziNaskladneni, ormCompPhoto, "PcsBIN2");
            BindTextBox(this.textBoxVychoziOdepsani, ormCompPhoto, "SCRAP2");

            // TODO =[PcsBIN2]+[TotalNA]-[TotalVY] -> textBoxPOcetKSBIN --> FAIL!
            BindTextBox(this.textBoxPOcetKSBIN, ormCompPhoto, "PcsBIN2");

            BindTextBox(this.textBoxKomentKeZmene, ormCompPhoto, "ZmenaPozn");
            BindTextBox(this.textBoxPoznamkySpecialni, ormCompPhoto, "SpecialNote");

            BindCheckBox(this.checkBoxNovy, ormCompPhoto, "New");
            BindCheckBox(this.checkBoxRevidovatCasy, ormCompPhoto, "TimeRevision");
            BindCheckBox(this.checkBoxZmenaDesingu, ormCompPhoto, "ZmenaDesignu");

            BindComboBox(this.comboBoxStatusKomp, "SELECT IDPDMStatusPhoto, PDMStatusPhoto FROM TPDMStatusPhoto", "IDPDMStatusPhoto", "PDMStatusPhoto", ormCompPhoto, "PDMStatusPhotoID");
            BindComboBox(this.comboBoxDruhKomponentu, "SELECT IDKomponentKategorie, KomponentKategorieName FROM TKomponentKategorie ORDER BY KomponentKategorieName","IDKomponentKategorie", "KomponentKategorieName", ormCompPhoto, "KomponentKategorieID");
            BindComboBox(this.comboBoxDostupnostProFoceni, "SELECT IDAvailability, AvailabilityName FROM TAvailability ORDER BY AvailabilityName", "IDAvailability", "AvailabilityName", ormCompPhoto, "DostupnostID");
            BindComboBox(this.comboBoxNafotilKdo, "SELECT IDResponsiblePhoto, ResponsiblePhotoSurname FROM TPersonResponsiblePhoto ORDER BY ResponsiblePhotoSurname", "IDResponsiblePhoto", "ResponsiblePhotoSurname", ormCompPhoto, "NafotilKdoID");

            BindDateTimePicker(this.dateTimePickerNafocenoDne, ormCompPhoto, "NafocenoKdy");
            BindDateTimePicker(this.dateTimePickerDatumZmeny, ormCompPhoto, "ZmenaDatum");
            
            //must be set .... again....
            this.dateTimePickerDatumZmeny.Checked = false;
            this.dateTimePickerNafocenoDne.Checked = false;
        }

        protected override bool LoadRecordCore()
        {
            //ORM
            this.ormCompPhoto = Data.QFComponentDetailPhoto.Load((int)this.PrimaryKey);

            // Load by table instead of view. Using views for editing sucks...
            this.ormMovementsNA = Data.TComponentMovement.LoadBy("Component =@param0 and MovementCode =@param1", (int)this.PrimaryKey, "NA");
            // Load by table instead of view. Using views for editing sucks...
            this.ormMovementsVY = Data.TComponentMovement.LoadBy("Component =@param0 and MovementCode =@param1", (int)this.PrimaryKey, "VY");

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

            // Revize casu 
            SqlDataAdapter revizeC = SmartISLib.Data.GetDataAdapter("SELECT * FROM QFComponentDetailRevision WHERE Component =@PK");
            revizeC.SelectCommand.Parameters.AddWithValue("PK", ormCompPhoto.ComponentID);
            revizeCasuDTAB = new DataTable();
            revizeC.Fill(revizeCasuDTAB);

            // drop down zpusob naskladneni
            SqlDataAdapter zpusobDrdown = SmartISLib.Data.GetDataAdapter("SELECT MovementTypeName FROM TMovementTypes WHERE MovementCode = 'NA'");
            zpusobNaskladneniDrDownDTAB = new DataTable();
            zpusobDrdown.Fill(zpusobNaskladneniDrDownDTAB);

            // drop down zpusob odepsani
            SqlDataAdapter dalsiDRDownAdapter = SmartISLib.Data.GetDataAdapter("SELECT MovementTypeName FROM TMovementTypes WHERE MovementCode = 'VY'");
            zpusobOdepsaniDrDownDTAB = new DataTable();
            dalsiDRDownAdapter.Fill(zpusobOdepsaniDrDownDTAB);

            // drop down typ fotky
            SqlDataAdapter fotoAdapt = SmartISLib.Data.GetDataAdapter("select distinct Image from QFComponentDetailRevisionDetail");
            this.typFotkyDTAB = new DataTable();
            fotoAdapt.Fill(typFotkyDTAB);

            return true;
        }
        #endregion

        #region onClick methods

        private void buttonVY_Click(object sender, EventArgs e)
        {
            // foregin key
            ormMovementsVY.SetAttribute("Component", ormCompPhoto.ComponentID);
            // for the view
            ormMovementsVY.SetAttribute("MovementCode", "VY");
            ormMovementsVY.Save();
            SmartISLib.Messages.Information("Uloženo.");
        }

        private void buttonNA_Click(object sender, EventArgs e)
        {
            // foregin key
            ormMovementsNA.SetAttribute("Component", ormCompPhoto.ComponentID);
            // for the view
            ormMovementsNA.SetAttribute("MovementCode", "NA");
            ormMovementsNA.Save();
            SmartISLib.Messages.Information("Uloženo.");
        }

        private void dataGridViewRevizeCasu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                SqlDataAdapter tmpAdapter = SmartISLib.Data.GetDataAdapter("Select image,CancelImage from QFComponentDetailRevisionDetail where TimesRevision =@TimeRevisionID");
                tmpAdapter.SelectCommand.Parameters.AddWithValue("TimeRevisionID",
                    this.revizeCasuDTAB.Rows[e.RowIndex]["TimesRevisionID"]);
                DataTable dt = new DataTable();
                tmpAdapter.Fill(dt);
                // TODO console.write
                this.dataGridViewDetailRevize.DataSource = dt;
                this.dataGridViewDetailRevize.Update(); ;
            }
        }

        #endregion
    }
}

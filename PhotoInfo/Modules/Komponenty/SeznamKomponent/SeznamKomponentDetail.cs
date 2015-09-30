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
        private DataTable hZmenDTAB;
        private DataTable kVyskladneniDTAB;
        private DataTable kompDTAB;
        private DataTable dalsiNaskladneniDTAB;
        private DataTable dalsiOdepsaniDTAB;
        private DataTable zpusobNaskladneniDrDownDTAB;
        private DataTable zpusobOdepsaniDrDownDTAB;

        public SeznamKomponentDetail()
        {
            InitializeComponent();
        }

        #region overrided methods

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
            this.dataGridViewDalsiNaskladeni.DataSource = dalsiNaskladneniDTAB;

            //zpusobOdeslani grid
            this.dataGridViewDalsiOdepsani.DataSource = dalsiOdepsaniDTAB;

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
            // TODO =[PcsBIN2]+[TotalNA]-[TotalVY] -> textBoxPOcetKSBIN
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
            // ------------------------------
            // TODO revize casu rozklik
            // ------------------------------

            // Dalsi naskladneni ///////////////////

            // drop down zpusob naskladneni
            SqlDataAdapter zpusobDrdown = SmartISLib.Data.GetDataAdapter("SELECT MovementTypeName FROM TMovementTypes WHERE MovementCode = 'NA'");
            zpusobNaskladneniDrDownDTAB = new DataTable();
            zpusobDrdown.Fill(zpusobNaskladneniDrDownDTAB);

            // Grid
            SqlDataAdapter zpusobGridAdapter = SmartISLib.Data.GetDataAdapter("Select * from QFComponentDetailMovementVY where Component = " + this.ormCompPhoto.ComponentID);
            dalsiNaskladneniDTAB = new DataTable();
            zpusobGridAdapter.Fill(dalsiNaskladneniDTAB);


            // Dalsi odepsani //////////////////////

            // drop down zpusob odepsani
            SqlDataAdapter dalsiDRDownAdapter = SmartISLib.Data.GetDataAdapter("SELECT MovementTypeName FROM TMovementTypes WHERE MovementCode = 'VY'");
            zpusobOdepsaniDrDownDTAB = new DataTable();
            dalsiDRDownAdapter.Fill(zpusobOdepsaniDrDownDTAB);

            //odepsani grid
            SqlDataAdapter dalsiGridAdapter = SmartISLib.Data.GetDataAdapter("Select * from QFComponentDetailMovementNA where Component = " + this.ormCompPhoto.ComponentID);
            dalsiNaskladneniDTAB = new DataTable();
            dalsiGridAdapter.Fill(dalsiNaskladneniDTAB);

            return true;
        }
        #endregion

    }
}

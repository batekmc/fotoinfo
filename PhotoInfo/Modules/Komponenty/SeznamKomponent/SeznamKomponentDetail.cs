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

            //Revize casu 
            // ------------------------------
            // TODO revize casu rozklik
            // ------------------------------


            return true;
        }
        #endregion

    }
}

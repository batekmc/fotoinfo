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

        private DataTable metodaBalenHlavniiDTAB;
        private DataTable metodaBaleniVedlejsiDTAB;

        private SmartISLib.ORM.DbTable<Data.TSampleListCis> druhBaleniComboData;

        private SmartISLib.ORM.DbTable<Data.TSampleListCis> velikostKrabicComboData;
        private SmartISLib.ORM.DbTable<Data.TPersonResponsiblePhoto> zpracovalWIComboData;
        private SmartISLib.ORM.DbTable<Data.TPersonResponsiblePhoto> kdoSchvalilWIComboData;
        private string[] poznamkaKUlozeniSetu = { "podélně","ve dvou řadách","podélně ve dvou řadách","podélně ve třech řadách","podélně ve čtyřech řadách" };

        private bool cisloSetuC, zemeC, statusSetuC, pocetKsDoKrabC, vyskaC, sirkaC, delkaC, poznamkaKulozC, zpracovalC, kdoSchvalilC, duleziteinfoC, breatherBagC, metodBalHlavniC, metodaBalVedlejsiC, druhBaleniC, velikostKrabC, datumZpracC, datumSchvaleniC, poslanoC, gridC;

        private SmartISLib.ORM.DbTable<Data.TAttachments> tAttachment;
        private SmartISLib.ORM.DbTable<Data.TAttachmentSL> tAttSL;


        // TODO - poznamka - yobrazit data, ulozit prilohy, carovy kod, import z masterListu
        #region overriden methods

        protected override bool LoadRecordCore()
        {
            //vazebni tabulka
            tAttSL = Data.TAttachmentSL.LoadBy("SampleList =@param0", (int)this.PrimaryKey);
            //vlastni data -> nacti vsechny radky
            tAttachment = new SmartISLib.ORM.DbTable<Data.TAttachments>();
            foreach (Data.TAttachmentSL t in tAttSL)
            {
                tAttachment.Add(Data.TAttachments.Load(t.Attachment));
            }
            
            velikostKrabicComboData = Data.TSampleListCis.LoadBy("SCategory =@param0", "VelikostKrabice");
            velikostKrabicComboData.Sort("Name");

            zpracovalWIComboData = Data.TPersonResponsiblePhoto.LoadBy("ResponsiblePhotoCode !=@param0", "null");
            zpracovalWIComboData.Sort("ResponsiblePhotoCode");

            kdoSchvalilWIComboData = Data.TPersonResponsiblePhoto.LoadBy("ResponsiblePhotoCode !=@param0", "null");
            zpracovalWIComboData.Sort("ResponsiblePhotoCode");

            druhBaleniComboData = Data.TSampleListCis.LoadBy("SCategory =@param0 and Name !=@param1", "DruhBaleni", "null");
            druhBaleniComboData.Sort("Name");

            zemeComboData = Data.TZeme.LoadAll();
            zemeComboData.Sort("Zeme");

            statusSetuComboData = Data.TSampleListCis.LoadBy("SCategory =@param0  and Name !=@param1", "status", "null");
            statusSetuComboData.Sort("Name");

            breatherBagComboData = Data.TSampleListCis.LoadBy("SCategory =@param0 and name !=@param1", "BreatherBag", "null");
            breatherBagComboData.Sort("Name");


            parentDTAB = SmartISLib.Data.GetDataTable("SELECT * FROM QFSampleListsTest WHERE IDSampleList = " + (int)this.PrimaryKey);

            prikazyKVyskladneniDTAB = SmartISLib.Data.GetDataTable("select * from QFPrikazVyskladneniSeznam where CisloSetu = '" + Convert.ToString(parentDTAB.Rows[0]["CisloSetu"]) + "'");

            historieZmenDTAB = SmartISLib.Data.GetDataTable("SELECT * FROM THistoryUpdates WHERE TableID = " + (int)this.PrimaryKey);


            metodaBalenHlavniiDTAB = SmartISLib.Data.GetDataTable("select * from QSLMetodaBaleniHlavni");

            metodaBaleniVedlejsiDTAB = SmartISLib.Data.GetDataTable("select * from QSLMetodaBaleniVedlejsi");
            
            return true;
        }

        protected override void BindData()
        {
            //events/////
            this.textBoxPocetKsDOKrabice.LostFocus += this.pocetKSdoKrabicLostFocus;
            this.textBoxVyskaSetu.LostFocus += vyskaSetuLostFocus;
            this.textBoxSirkaSetu.LostFocus += sirkaSetuLostFocus;
            this.textBoxDelkaSetu.LostFocus += delkaSetuLostFocus;
            this.dataGridViewPrilohy.CellContentClick += prilohyLinkClicked;

            //datagrids/////
            this.dataGridViewPrikazyKVyskladneni.AutoGenerateColumns = false;
            this.dataGridViewPrikazyKVyskladneni.DataSource = prikazyKVyskladneniDTAB;
            this.dataGridViewHistorieZmen.AutoGenerateColumns = false;
            this.dataGridViewHistorieZmen.DataSource = historieZmenDTAB;

            this.dataGridViewPrilohy.AutoGenerateColumns = false;
            this.dataGridViewPrilohy.DataSource = this.tAttachment;
            

            //textBoxes/////
            //ID - PK, always set
            this.textBoxID.Text = Convert.ToString(this.parentDTAB.Rows[0]["IDSampleList"]);
            //CisloSetu
            string tmp = Convert.ToString(parentDTAB.Rows[0]["CisloSetu"]);
            if ( tmp != null )
            {
                textBoxCisloSetu.Text = tmp;
            }
            //pocet ks dop krabice
            tmp = Convert.ToString(parentDTAB.Rows[0]["NumberInBox"]);
            if (tmp != null)
            {
                textBoxPocetKsDOKrabice.Text = tmp;
            }
            //sirka
            tmp = Convert.ToString(parentDTAB.Rows[0]["WidthSet"]);
            if (tmp != null)
            {
                textBoxSirkaSetu.Text = tmp;
            }
            //delka
            tmp = Convert.ToString(parentDTAB.Rows[0]["LengthSet"]);
            if (tmp != null)
            {
                textBoxDelkaSetu.Text = tmp;
            }
            //Vyska
            tmp = Convert.ToString(parentDTAB.Rows[0]["HeightSet"]);
            if (tmp != null)
            {
                textBoxVyskaSetu.Text = tmp;
            }
            //Vaha
            tmp = Convert.ToString(parentDTAB.Rows[0]["WeightSet2"]);
            if (tmp != null)
            {
                textBoxVahaPoslPKV.Text = tmp;
                textBoxTotalWeigth.Text = Convert.ToString(prikazyKVyskladneniDTAB.Rows[0]["SumTotalWeight"]);
            }
            //datum zprac
            tmp = Convert.ToString(parentDTAB.Rows[0]["DateOfProcessing"]);
            if (tmp != null)
            {
                dateTimePickerDatumZpracovani.Text = tmp;
            }
            else
            {
                dateTimePickerDatumZpracovani.Checked = false;
            }
            //datum zprac
            tmp = Convert.ToString(parentDTAB.Rows[0]["DateOfApproval"]);
            if (tmp != null)
            {
                dateTimePickerDatumSchvaleni.Text = tmp;
            }
            else
            {
                dateTimePickerDatumSchvaleni.Checked = false;
            }
            //dulezite info k setu
            tmp = Convert.ToString(parentDTAB.Rows[0]["NoteForApproval"]);
            if (tmp != null)
            {
                textBoxDuleziteInformaceKsetu.Text = tmp;
            }

            checkBoxPoslanoWI.Checked = Convert.ToBoolean(parentDTAB.Rows[0]["PostedWi"]);


            //comboBoxes/////
            //zeme
            this.comboBoxZeme.DataSource = zemeComboData;
            this.comboBoxZeme.DisplayMember = "Zeme";
            string attr = Convert.ToString(this.parentDTAB.Rows[0]["ZemeStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < zemeComboData.Count; i++)
                    if (zemeComboData[i].Zeme == attr)
                    {
                        this.comboBoxZeme.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxZeme.SelectedIndex = -1;
            }
            this.comboBoxStatusSetu.DataSource = statusSetuComboData;
            this.comboBoxStatusSetu.DisplayMember = "Name";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["StatusSetStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < statusSetuComboData.Count; i++)
                    if (statusSetuComboData[i].Name == attr)
                    {
                        this.comboBoxStatusSetu.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxStatusSetu.SelectedIndex = -1;
            }
            //breather bag 
            this.comboBoxBreatherBag.DataSource = breatherBagComboData;
            this.comboBoxBreatherBag.DisplayMember = "Name";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["BreatherBagStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < breatherBagComboData.Count; i++)
                    if (breatherBagComboData[i].Name == attr)
                    {
                        this.comboBoxBreatherBag.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxBreatherBag.SelectedIndex = -1;
            }
            //metoda hlavni
            this.comboBoxMetodaBaleniHlavni.DataSource = metodaBalenHlavniiDTAB;
            this.comboBoxMetodaBaleniHlavni.DisplayMember = "MethodOfPackagingMain";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["MethodOfPackagingMain"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < metodaBalenHlavniiDTAB.Rows.Count; i++)
                    if (Convert.ToString(metodaBalenHlavniiDTAB.Rows[i]["MethodOfPackagingMain"]) == attr)
                    {
                        this.comboBoxMetodaBaleniHlavni.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxMetodaBaleniHlavni.SelectedIndex = -1;
            }
            //metoda vedlejsi
            this.comboBoxMetodaBaleniVedlejsi.DataSource = metodaBaleniVedlejsiDTAB;
            this.comboBoxMetodaBaleniVedlejsi.DisplayMember = "MethodOfPackagingSecondary";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["MethodOfPackagingSecondary"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < metodaBaleniVedlejsiDTAB.Rows.Count; i++)
                    if (Convert.ToString(metodaBaleniVedlejsiDTAB.Rows[i]["MethodOfPackagingSecondary"]) == attr)
                    {
                        this.comboBoxMetodaBaleniVedlejsi.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxMetodaBaleniVedlejsi.SelectedIndex = -1;
            }
            //druh baleni
            this.comboBoxDruhBaleni.DataSource = druhBaleniComboData;
            this.comboBoxDruhBaleni.DisplayMember = "Name";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["TypeOfPackagingStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < druhBaleniComboData.Count; i++)
                    if (druhBaleniComboData[i].Name == attr)
                    {
                        this.comboBoxDruhBaleni.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxDruhBaleni.SelectedIndex = -1;
            }
            //velikost krabice 
            this.comboBoxVelikostKrabice.DataSource = velikostKrabicComboData;
            this.comboBoxVelikostKrabice.DisplayMember = "Name";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["SizeOfBoxStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < velikostKrabicComboData.Count; i++)
                    if (velikostKrabicComboData[i].Name == attr)
                    {
                        this.comboBoxVelikostKrabice.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxVelikostKrabice.SelectedIndex = -1;
            }
            
            //kdo zpracoval
            this.comboBoxZpracovalWI.DataSource = zpracovalWIComboData;
            this.comboBoxZpracovalWI.DisplayMember = "ResponsiblePhotoCode";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["WhoWorkedStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < zpracovalWIComboData.Count; i++)
                    if (zpracovalWIComboData[i].ResponsiblePhotoCode == attr)
                    {
                        this.comboBoxZpracovalWI.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxZpracovalWI.SelectedIndex = -1;
            }

            //kdo schvalil
            this.comboBoxKdoSchvalilWI.DataSource = kdoSchvalilWIComboData;
            this.comboBoxKdoSchvalilWI.DisplayMember = "ResponsiblePhotoCode";
            attr = Convert.ToString(this.parentDTAB.Rows[0]["WhoApprovedStr"]);
            if (!String.IsNullOrEmpty(attr))
            {
                for (int i = 0; i < kdoSchvalilWIComboData.Count; i++)
                    if (kdoSchvalilWIComboData[i].ResponsiblePhotoCode == attr)
                    {
                        this.comboBoxKdoSchvalilWI.SelectedIndex = i;
                        break;
                    }
            }
            else
            {
                this.comboBoxKdoSchvalilWI.SelectedIndex = -1;
            }
            this.comboBoxPoznamkaKUlozeniSetu.Items.AddRange(poznamkaKUlozeniSetu);

            cisloSetuC = zemeC = statusSetuC = pocetKsDoKrabC = vyskaC = sirkaC = delkaC = poznamkaKulozC = zpracovalC = kdoSchvalilC = duleziteinfoC = breatherBagC = metodBalHlavniC = metodaBalVedlejsiC = druhBaleniC = velikostKrabC = datumZpracC = datumSchvaleniC = poslanoC = gridC = false;
        }

        protected override bool DeleteRecordCore()
        {
            string idDampleList = Convert.ToString(parentDTAB.Rows[0]["IDSampleList"]);

            SmartISLib.Data.Execute("update TPrikazVyskladneni set SampleList = null where SampleList = " + idDampleList);

            SmartISLib.Data.Execute("Delete from TSampleList where IDSampleList = " + idDampleList);
            return true;
        }

        protected override bool UpdateRecordCore()
        {

            if (
                String.IsNullOrEmpty(textBoxCisloSetu.Text) ||
                String.IsNullOrEmpty(comboBoxZeme.Text) ||
                String.IsNullOrEmpty(comboBoxStatusSetu.Text) ||
                String.IsNullOrEmpty(textBoxVyskaSetu.Text) ||
                String.IsNullOrEmpty(textBoxSirkaSetu.Text) ||
                String.IsNullOrEmpty(textBoxDelkaSetu.Text) ||
                String.IsNullOrEmpty(comboBoxMetodaBaleniHlavni.Text)
            )
            {
                SmartISLib.Messages.Error("Cěrveně označená políčká nesmí být prázdná!");
                return false;
            }

            if (cisloSetuC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set CisloSetu = '{0}' where IDSampleList = {1}", textBoxCisloSetu.Text, (int)this.PrimaryKey));
                cisloSetuC = false;
            }
            if (zemeC)
            {
                string a = "null";
                foreach (Data.TZeme z in zemeComboData)
                {
                    if (z.Zeme == this.comboBoxZeme.Text)
                    {
                        a = z.IDZeme.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set Zeme = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                zemeC = false;
            }
            if (statusSetuC)
            {
                string a = "null";
                foreach (Data.TSampleListCis z in statusSetuComboData)
                {
                    if (z.Name == this.comboBoxStatusSetu.Text)
                    {
                        a = z.ID.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set StatusSet = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                statusSetuC = false;
            }
            if (pocetKsDoKrabC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set NumberInBox = {0} where IDSampleList = {1}", textBoxPocetKsDOKrabice.Text, (int)this.PrimaryKey));

                pocetKsDoKrabC = false;
            }

            if (breatherBagC)
            {
                string a = "null";
                foreach (Data.TSampleListCis z in breatherBagComboData)
                {
                    if (z.Name == this.comboBoxBreatherBag.Text)
                    {
                        a = z.ID.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set BreatherBag = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                breatherBagC = false;
            }

            if (metodBalHlavniC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set MethodOfPackagingMain = '{0}' where IDSampleList = {1}", comboBoxMetodaBaleniHlavni.Text, (int)this.PrimaryKey));
                metodBalHlavniC = false;
            }

            if (metodaBalVedlejsiC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set MethodOfPackagingSecondary = '{0}' where IDSampleList = {1}", comboBoxMetodaBaleniVedlejsi.Text, (int)this.PrimaryKey));

                metodaBalVedlejsiC = false;
            }

            if (druhBaleniC)
            {
                string a = "null";
                foreach (Data.TSampleListCis z in druhBaleniComboData)
                {
                    if (z.Name == this.comboBoxDruhBaleni.Text)
                    {
                        a = z.ID.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set TypeOfPackaging = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                druhBaleniC = false;
            }

            if (sirkaC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set WidthSet = {0} where IDSampleList = {1}", textBoxSirkaSetu.Text, (int)this.PrimaryKey));
                sirkaC = false;
            }
            if (delkaC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set LengthSet = {0} where IDSampleList = {1}", textBoxDelkaSetu.Text, (int)this.PrimaryKey));
                delkaC = false;
            }
            if (vyskaC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set HeightSet = {0} where IDSampleList = {1}", textBoxDelkaSetu.Text, (int)this.PrimaryKey));
                vyskaC = false;
            }
            if (velikostKrabC)
            {
                string a = "null";
                foreach (Data.TSampleListCis z in velikostKrabicComboData)
                {
                    if (z.Name == this.comboBoxVelikostKrabice.Text)
                    {
                        a = z.ID.ToString();
                        break;
                    }
                }

                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set SizeOfBox = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                velikostKrabC = false;
            }
            if (zpracovalC)
            {
                string a = "null";
                foreach (Data.TPersonResponsiblePhoto z in zpracovalWIComboData)
                {
                    if (z.ResponsiblePhotoCode == this.comboBoxZpracovalWI.Text)
                    {
                        a = z.IDResponsiblePhoto.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set WhoWorked = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                zpracovalC = false;
            }
            if (kdoSchvalilC)
            {
                string a = "null";
                foreach (Data.TPersonResponsiblePhoto z in kdoSchvalilWIComboData)
                {
                    if (z.ResponsiblePhotoCode == this.comboBoxKdoSchvalilWI.Text)
                    {
                        a = z.IDResponsiblePhoto.ToString();
                        break;
                    }
                }
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set WhoApproved = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                kdoSchvalilC = false;
            }
            if (duleziteinfoC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set NoteForApproval = '{0}' where IDSampleList = {1}", textBoxDuleziteInformaceKsetu.Text, (int)this.PrimaryKey));
                duleziteinfoC = false;
            }
            if (datumZpracC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set DateOfProcessing = '{0}' where IDSampleList = {1}", dateTimePickerDatumZpracovani.Value.ToString("yyyy-MM-dd"), (int)this.PrimaryKey));
                datumZpracC = false;
            }
            if (datumSchvaleniC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set DateOfApproval = '{0}' where IDSampleList = {1}", dateTimePickerDatumSchvaleni.Value.ToString("yyyy-MM-dd"), (int)this.PrimaryKey));
                datumSchvaleniC = false;
            }
            if (poslanoC)
            {
                string a = "0";
                if (checkBoxPoslanoWI.Checked)
                    a = "1";
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set PostedWi = {0} where IDSampleList = {1}", a, (int)this.PrimaryKey));
                poslanoC = false;
            }
            if (poznamkaKulozC)
            {
                SmartISLib.Data.Execute(string.Format("UPDATE TSampleList set NoteForApproval = '{0}' where IDSampleList = {1}", comboBoxPoznamkaKUlozeniSetu.Text, (int)this.PrimaryKey));
                poznamkaKulozC = false;
            }
            if (gridC)
            {
                //if (isPrilohyInserted)
                //{
                //    // nejdrive ulozim soubory, aby se vygeneroval PK
                //    this.tAttachment.Save();
                //    gridC = false;
                //    SmartISLib.ORM.DbTable<Data.TAttachmentSL> tmpDB;
                //    for (int i = 0; i < tAttachment.Count; i++)
                //    {
                //        tmpDB = Data.TAttachmentSL.LoadBy("Attachment =@param0 and SampleList =@param1", tAttachment[i].IDAttachment, (int)this.PrimaryKey);
                //        Console.WriteLine("__Count: " + tmpDB.Count + " , PK: " + (int)this.PrimaryKey + ", ID " + tAttachment[i].IDAttachment);
                //        if (tmpDB.Count == 0)
                //        {
                //            SmartISLib.Data.Execute(string.Format("insert into TAttachmentSL(SampleList, Attachment) values ({0}, {1})", (int)this.PrimaryKey, tAttachment[i].IDAttachment));
                //            Console.WriteLine(string.Format("insert into TAttachmentSL(SampleList, Attachment) values ({0}, {1})", (int)this.PrimaryKey, tAttachment[i].IDAttachment));
                //        }
                //    }
                //    isPrilohyInserted = false;
                //}
                ////odstranim na zaklade pk
                //foreach (int i in deletedFromGrid)
                //{
                //    SmartISLib.Data.Execute(string.Format("DELETE FROM TAttachmentSL where SampleList = {0} AND Attachment = {1}", (int)this.PrimaryKey, i));
                //    Console.WriteLine(string.Format("DELETE FROM TAttachmentSL where SampleList = {0} AND Attachment = {1}", (int)this.PrimaryKey, i));
                //}
                this.tAttachment.Save();
                gridC = false;
                SmartISLib.Data.Execute("DELETE FROM TAttachmentSL WHERE SampleList = " + (int)this.PrimaryKey);
                for (int i = 0; i < tAttachment.Count; i++)
                {
                    SmartISLib.Data.Execute(string.Format("insert into TAttachmentSL(SampleList, Attachment) values ({0}, {1})", (int)this.PrimaryKey, tAttachment[i].IDAttachment));
                }

            }
            return true;
        }

        #endregion

        #region events
        private void buttonPrilohyVlozit(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                Data.TAttachments newAttatchment = Data.TAttachments.Create();
                newAttatchment.AttPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                // +1 -> posledni lomitko
                int len = Convert.ToString(newAttatchment.AttPath).Length + 1;
                // cele jmeno souboru - cesta k souboru
                newAttatchment.AttName = openFileDialog1.FileName.Substring(len, openFileDialog1.FileName.Length - len);
                this.tAttachment.Add(newAttatchment);
                dataGridViewPrilohy.Refresh();
            }
            this.NotifyChanged();
            this.gridC = true;

        }

        private void buttonPrilohySmazat(object sender, EventArgs e)
        {
            if (tAttachment.Count == 0) return;
            int rowindex = dataGridViewPrilohy.CurrentCell.RowIndex;
            tAttachment.RemoveAt(rowindex);
            dataGridViewPrilohy.Refresh();
            this.gridC = true;
            this.NotifyChanged();
        }
       

        private void textBoxCisloSetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.cisloSetuC = true;
        }

        private void comboBoxZeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.zemeC = true;
        }

        private void comboBoxStatusSetu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.statusSetuC = true;
        }

        private void textBoxPocetKsDOKrabice_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.pocetKsDoKrabC = true;
        }

        private void textBoxVyskaSetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.vyskaC = true;
        }

        private void textBoxSirkaSetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.sirkaC = true;
        }

        private void textBoxDelkaSetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.delkaC = true;
        }

        private void comboBoxPoznamkaKUlozeniSetu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.poznamkaKulozC = true;
        }

        private void comboBoxZpracovalWI_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.zpracovalC = true;
        }

        private void comboBoxKdoSchvalilWI_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.kdoSchvalilC = true;
        }

        private void textBoxDuleziteInformaceKsetu_TextChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.duleziteinfoC = true;
        }

        private void comboBoxBreatherBag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.breatherBagC = true;
        }

        private void comboBoxMetodaBaleniHlavni_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.metodBalHlavniC = true;
        }

        private void comboBoxMetodaBaleniVedlejsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.metodaBalVedlejsiC = true;
        }

        private void comboBoxDruhBaleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.druhBaleniC = true;
        }

        private void comboBoxVelikostKrabice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.velikostKrabC = true;
        }

        private void dateTimePickerDatumZpracovani_ValueChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.datumZpracC = true;
        }

        private void dateTimePickerDatumSchvaleni_ValueChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.datumSchvaleniC = true;
        }

        private void checkBoxPoslanoWI_CheckedChanged(object sender, EventArgs e)
        {
            this.NotifyChanged();
            this.poslanoC = true;
        }

        private void pocetKSdoKrabicLostFocus(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBoxPocetKsDOKrabice.Text);
                if (a < 1 || a > 99)
                {
                    SmartISLib.Messages.Error("Zadejte číslo v intervalu 1-99!");
                    this.textBoxPocetKsDOKrabice.Text = null;
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Zadejte celé číslo!");
                this.textBoxPocetKsDOKrabice.Text = null;
            }
        }

        private void sirkaSetuLostFocus(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBoxSirkaSetu.Text);
                if (a < 1 || a > 99)
                {
                    SmartISLib.Messages.Error("Zadejte číslo v intervalu 1-99!");
                    this.textBoxSirkaSetu.Text = null;
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Zadejte celé číslo!");
                this.textBoxSirkaSetu.Text = null;
            }
        }

        private void delkaSetuLostFocus(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBoxDelkaSetu.Text);
                if (a < 10 || a > 99)
                {
                    SmartISLib.Messages.Error("Zadejte číslo v intervalu 10-99!");
                    this.textBoxDelkaSetu.Text = null;
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Zadejte celé číslo!");
                this.textBoxDelkaSetu.Text = null;
            }
        }

        private void vyskaSetuLostFocus(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBoxVyskaSetu.Text);
                if (a < 10 || a > 99)
                {
                    SmartISLib.Messages.Error("Zadejte číslo v intervalu 10-99!");
                    this.textBoxVyskaSetu.Text = null;
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Zadejte celé číslo!");
                this.textBoxVyskaSetu.Text = null;
            }
        }

        private void prilohyLinkClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string path = (string)this.tAttachment[e.RowIndex].AttPath;
                if (!String.IsNullOrEmpty(path))
                    System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex) 
            {
                SmartISLib.Messages.Error("Soubor nelze otevřít");
            }
        }
        #endregion
    }
}

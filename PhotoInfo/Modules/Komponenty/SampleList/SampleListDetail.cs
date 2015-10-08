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

        #region overriden methods

        protected override bool LoadRecordCore()
        {
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
            //datagrids
            this.dataGridViewPrikazyKVyskladneni.AutoGenerateColumns = false;
            this.dataGridViewPrikazyKVyskladneni.DataSource = prikazyKVyskladneniDTAB;
            this.dataGridViewHistorieZmen.AutoGenerateColumns = false;
            this.dataGridViewHistorieZmen.DataSource = historieZmenDTAB;

            //textBoxes

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


            //comboBoxes
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
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                DataGridViewRow row = (DataGridViewRow)dataGridViewPrilohy.RowTemplate.Clone();
                row.CreateCells(dataGridViewPrilohy, file);
                dataGridViewPrilohy.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewPrilohy.CurrentCell.RowIndex;
            dataGridViewPrilohy.Rows.RemoveAt(rowindex);
        }

    }
}

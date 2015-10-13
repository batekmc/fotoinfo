using SmartISLib.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo.Modules.Komponenty.RevizeCasu
{
    public partial class RevizeCasuDetail : SmartISLib.Modules.GridDetail.DetailControl
    {
        //grid view data set
        private DataTable revisionsTable;
        // item detail
        private Data.QFTimesRevisionDialog ormTimeRev;
        //workaround
        private int fkTypeRevision = 0;
        
        public RevizeCasuDetail()
        {
            InitializeComponent();
        }


        #region overrided methods


        protected override bool PrepareNew()
        {
            // has to be set, because if TypeRevision has not been changed, then it takes default value 0
            if (this.ormTimeRev.TypeRevision == 0)
                this.ormTimeRev.TypeRevision = this.fkTypeRevision;
            try
            {
                bool res = this.InsertProcedure();
                return res;
            }
            catch (Exception ex) {
                SmartISLib.Messages.Error(ex.Message);
                SmartISLib.Messages.Error(ex.StackTrace);
                return false;
            }
            
        }


        protected override bool UpdateRecordCore()
        {
            try
            {
                // has to be set, because if TypeRevision has not been changed, then it takes default value 0
                if (this.ormTimeRev.TypeRevision == 0)
                    this.ormTimeRev.TypeRevision = this.fkTypeRevision;
                this.ormTimeRev.Update();
                UpdateProcedure();
                return true;
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
                return false;
            }
        }

        protected override bool DeleteRecordCore()
        {
            DataTable mDt = SmartISLib.Data.GetDataTable("Select MaxRevision from QTimesRevisionMax where Component = " + this.ormTimeRev.Component);
            int maxRev = Convert.ToInt32(  ( (DataRow)mDt.Rows[0] )["MaxRevision"]  );
            //maze se jen pokud se jedna o posledni revizi
            if (maxRev == ormTimeRev.Revision)
            {
                this.ormTimeRev.Delete();
                SmartISLib.Messages.Information("Revize smazána.");
            }
            else
                SmartISLib.Messages.Information("Odstranil lze pouze poslední revizi.");
            return true;
        }

        protected override bool LoadRecordCore()
        {
            try
            {
                //Load data for fields - ORM 
                this.ormTimeRev = Data.QFTimesRevisionDialog.Load((int)this.PrimaryKey);
                //load data for grid - View not in ORM
                SqlDataAdapter adapter = SmartISLib.Data.GetDataAdapter("SELECT image, VS, VV, vm, vp, vx, pp, pm, px,k,RoutingVyp, timeSAPvyp,SourceImage, ExportDate,CounterNo, CancelImage FROM QFTimeRevisionDetail2 where TimesRevisionDetailID = " + this.PrimaryKey);
                revisionsTable = new DataTable();
                adapter.Fill(revisionsTable);
            }
            catch (Exception e)
            {
                SmartISLib.Messages.Error("Nepodařilo se načíst data z QFTimesRevisionDialog");   
                SmartISLib.Messages.Error(e.Message);
                return false;
            }

            return true;
        }

        protected override void BindData()
        {
            // bind grid data to grid
            this.dataGridView1.DataSource = this.revisionsTable;
            //set PK
            if ( this.PrimaryKey != null)
                this.ormTimeRev.TimesRevisionID = (int)this.PrimaryKey; 

            BindTextBox(this.textBox2, ormTimeRev, "CompStatus");
            BindTextBox(this.textBox1, ormTimeRev, "CompCode");
            BindTextBox(this.textBox3, ormTimeRev, "CompCategory");
            BindTextBox(this.textBox4, ormTimeRev, "CompPhotoDate");
            BindTextBox(this.textBox5, ormTimeRev, "CompComent");
            BindTextBox(this.textBox6, ormTimeRev, "Revision");

            BindComboBox(this.comboBox1, "select * from TPickType order by PickTypeName", "PickTypeID", "PickTypeName", ormTimeRev, "PickType");
            BindComboBox(this.comboBox2, "select * from TCorrection order by CorrectionName", "CorrectionID", "CorrectionName", ormTimeRev, "Correction");
            BindComboBox(this.comboBox4, "SELECT * FROM TIFU", "ifuID", "IFUtype", ormTimeRev, "IFU_type");

            BindTextBox(this.textBoxPoznamkaKOprave, ormTimeRev, "CorrectionNote");
            BindTextBox(this.textBox8, ormTimeRev, "Note");
            BindTextBox(this.textBox9, ormTimeRev, "FileLink");

            BindTextBox(this.textBox10, ormTimeRev, "CompCode");
            BindTextBox(this.textBox11, ormTimeRev, "TimeKoef");

            BindCheckBox(this.checkBox1, ormTimeRev, "Actual");
            BindCheckBox(this.checkBox2, ormTimeRev, "IFU");
            BindCheckBox(this.checkBoxPrekontrolovatBaleni, ormTimeRev, "CheckPackage");
            BindCheckBox(this.checkBoxRevizeZkontrolovana, ormTimeRev, "RevisionDone");

            this.fkTypeRevision = ormTimeRev.TypeRevision;
            if (ormTimeRev.TypeRevision == 1)
                this.radioButton1.Checked = true;
            else if (ormTimeRev.TypeRevision == 2)
                this.radioButton2.Checked = true;
            else if (ormTimeRev.TypeRevision == 3)
                this.radioButton3.Checked = true;

            BindComboBox(this.comboBox3, string.Format("SELECT Revision FROM QMainComponentRevision where TimesRevisionID={0}", ormTimeRev.MainCompRevision), "Revision", "TimesRevisionID", ormTimeRev, "TypeRevision");
            //Display text to user
            this.comboBox3.SelectedIndex = 0;

            this.radioButton1.Name = "1";
            this.radioButton2.Name = "2";
            this.radioButton3.Name = "3";

            this.radioButton1.Click += this.AllCheckBoxes_CheckedChanged;
            this.radioButton2.Click += this.AllCheckBoxes_CheckedChanged;
            this.radioButton3.Click += this.AllCheckBoxes_CheckedChanged;
            
        }

        #endregion 

        #region methods
        private bool UpdateProcedure()
        {
            DbTable<Data.TTimesRevisionDetail> detail = Data.TTimesRevisionDetail.LoadBy("TimesRevision =@param0 AND SourceImage is null", ormTimeRev.TimesRevisionID);
            DbTable<Data.TTimesRevisionDetail> detail2;


            foreach (Data.TTimesRevisionDetail dTTime in detail)
            {
                detail2 = Data.TTimesRevisionDetail.LoadBySourceImage(dTTime.TimesRevisionDetailID);

                foreach (Data.TTimesRevisionDetail dTTime2 in detail2)
                {
                    Data.Procedures.SPTimesRevisionDetailUpd(dTTime2.TimesRevisionDetailID);
                }

            }
            return true;
        }

        private bool InsertProcedure()
        {
            DbTable<Data.TTimesRevision> actualRev = Data.TTimesRevision.LoadBy("Component =@param0 and Actual =@param1", (int)this.ormTimeRev.Component, 1);
            if (actualRev[0] == null )
            {
                SmartISLib.Messages.Error("Zatím neexistuje žádná aktuální revize, nelze vytvoøit další.");
                return false;
            }
            DataTable mDt = SmartISLib.Data.GetDataTable("Select MaxRevision from QTimesRevisionMax where Component = " + this.ormTimeRev.Component);
            if (mDt.Rows.Count < 1)
            {
                SmartISLib.Messages.Error("Neexistuje  hledaný záznam v MaxRevision");
                return false;
            }
            int maxRev = Convert.ToInt32(  ( (DataRow)mDt.Rows[0] )["MaxRevision"]  );
            int aRev = actualRev[0].Revision;
            int aRevID = actualRev[0].TimesRevisionID;

            if (maxRev == ++aRev)
            {
                SmartISLib.Messages.Error("Již byla vytvořena jedna revize po aktuální.");
                return false;
            }
            else 
            {
                //Splneny podminky, vytvoreni nove revize
                //vytvori novou hlavicku
                Data.Procedures.SPTimesRevisionNew(this.ormTimeRev.TimesRevisionID, this.ormTimeRev.Component);

                //zjisti nove ID
                SqlDataReader sqlR = Data.Procedures.SPIdentityNew("");
                sqlR.Read();
                DbNullable<int> newID= Convert.ToInt32( sqlR["Identity"] );
                if (newID == null)
                {
                    SmartISLib.Messages.Error("Novárevize nebyla vytvořena.");
                    return false;
                }
                sqlR.Close();
                //pokud jsou stejne comp i main-comp pak udela update odkazu v MainRevision
                if (ormTimeRev.Component == ormTimeRev.MainComponent)
                {
                    Data.Procedures.SPTimesRevisionUpdateMainRevision(newID);
                }

                //novy detail
                Data.Procedures.SPTimesRevisionDetailNew(ormTimeRev.TimesRevisionID, newID);

                //pokud jsou v detailu odkazy - update odkazu na foto
                mDt = SmartISLib.Data.GetDataTable("SELECT * FROM QTimesRevisionSourceImage where TimesRevision =" + ormTimeRev.TimesRevisionID);
                foreach(DataRow row in mDt.Rows)
                {
                    int newDetailID = -1;
                    if(ormTimeRev.Component == ormTimeRev.MainComponent)
                    {
                        newDetailID = Data.TTimesRevisionDetail.LoadBy("TimesRevision =@param0 and Image =@param1", this.ormTimeRev.Component, row["SourceImageNo"])[0].TimesRevisionDetailID;
                    }
                    else 
                    { 
                        newDetailID  = Data.TTimesRevisionDetail.LoadBy("TimesRevision =@param0 and Image in (select SourceImageNo from QTimesRevisionSourceImage where Component =@param1 and Revision =@param2 )", ormTimeRev.TimesRevisionID, row["Image"], ormTimeRev.MainCompRevision)[0].TimesRevisionDetailID;
                    }

                    //zjisti datum exportu

                    DbNullable<DateTime> expDate = Data.TTimesRevisionDetail.LoadBy("TimesRevisionDetailID =@param0", row["TimesRevisionDetailID"])[0].ExportDate;
                    string str;
                    if (expDate != null)
                        str = string.Format("UPDATE TTimesRevisionDetail set SourceImage ={0}, ExportDate = {1} where TimesRevision = {2} and image = {3}", newDetailID, expDate, newID, Convert.ToInt32(row["Image"]));
                    else
                        str = string.Format("UPDATE TTimesRevisionDetail set SourceImage ={0}, ExportDate = {1} where TimesRevision = {2} and image = {3}", newDetailID, "NULL", newID, Convert.ToInt32(row["Image"]));

                    SmartISLib.Data.Execute(str);

                }
                mDt = SmartISLib.Data.GetDataTable("SELECT * FROM QTimesRevisionCheckMainComp where MainComponent =" + ormTimeRev.Component);

                //pokud je  comp nekde jinde jako main-comp pak update pole RevisionDone=0
                foreach (DataRow row in mDt.Rows) {
                    Data.Procedures.SPComponentTimesRevisionUpd(ormTimeRev.Component);            
                }
                SmartISLib.Messages.Information("Záznam uložen.");
                //if (Module.GridControl != null)
                //    Module.GridControl.RefreshData();
                return true;
    
            }
        }

        #endregion

        #region click events

        /// <summary>
        /// If is radiobutton checked, then the typeRevision value is set based on the RB name.
        /// RB names are 1,2,3 so it works fine. 
        /// </summary>
        /// <param name="sender">Radiobutton</param>
        /// <param name="e"></param>
        private void AllCheckBoxes_CheckedChanged(Object sender, EventArgs e)
        {
            // Check of the raiser of the event is a checked Checkbox.
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                if (String.IsNullOrEmpty(rb.Name))
                    return;
                //button name is 1|2|3
                this.ormTimeRev.TypeRevision = Int32.Parse(rb.Name);
                //Oznamim zmenu gui
                this.NotifyChanged();
            }
        }


        /// <summary>
        /// Button for file select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                this.textBox9.Text = file;
            }
        }

        #endregion
    }
}

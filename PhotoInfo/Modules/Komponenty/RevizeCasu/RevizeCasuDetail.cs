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
        
        public RevizeCasuDetail()
        {
            InitializeComponent();
        }


        protected override bool InsertRecordCore()
        {
            try
            {
                Console.WriteLine("insert__________Most: " + this.textBox9.Text);
                return true;
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
                return false;
            }
        }

        protected override bool UpdateRecordCore()
        {
            try
            {

                Console.WriteLine("____Checked:  " + this.ormTimeRev.TypeRevision);
                this.ormTimeRev.Update();
                //UpdateProcedure();
                return true;
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
                return false;
            }
        }


        protected override bool LoadRecordCore()
        {
            try
            {
                //Load data for fields - ORM 
                this.ormTimeRev = Data.QFTimesRevisionDialog.Load((int)this.PrimaryKey);
                //load data for grid
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

            BindTextBox(this.textBox2, ormTimeRev, "CompStatus");
            BindTextBox(this.textBox1, ormTimeRev, "CompCode");
            BindTextBox(this.textBox3, ormTimeRev, "CompCategory");
            BindTextBox(this.textBox4, ormTimeRev, "CompPhotoDate");
            BindTextBox(this.textBox5, ormTimeRev, "CompComent");
            BindTextBox(this.textBox6, ormTimeRev, "Revision");

            BindComboBox(this.comboBox1, "select * from TPickType order by PickTypeName", "PickTypeName", "PickTypeName", ormTimeRev, "PickType");
            BindComboBox(this.comboBox2, "select * from TCorrection order by CorrectionName", "CorrectionName", "CorrectionName", ormTimeRev, "CorrectionNote");
            BindComboBox(this.comboBox4, "SELECT * FROM TIFU", "IFUtype", "IFUtype", ormTimeRev, "IFU_type");

            BindTextBox(this.textBox7, ormTimeRev, "CorrectionNote");
            BindTextBox(this.textBox8, ormTimeRev, "Note");
            BindTextBox(this.textBox9, ormTimeRev, "FileLink");

            BindTextBox(this.textBox10, ormTimeRev, "CompCode");
            BindTextBox(this.textBox11, ormTimeRev, "TimeKoef");

            BindCheckBox(this.checkBox1, ormTimeRev, "Actual");
            BindCheckBox(this.checkBox1, ormTimeRev, "IFU");
            BindCheckBox(this.checkBox1, ormTimeRev, "CheckPackage");
            BindCheckBox(this.checkBox1, ormTimeRev, "RevisionDone");

            if (ormTimeRev.TypeRevision == 1)
                this.radioButton1.Checked = true;
            else if (ormTimeRev.TypeRevision == 2)
                this.radioButton2.Checked = true;
            else if (ormTimeRev.TypeRevision == 3)
                this.radioButton3.Checked = true;


            BindComboBox(this.comboBox3, string.Format("SELECT Revision FROM QMainComponentRevision where TimesRevisionID={0}", ormTimeRev.MainCompRevision), "Revision", "TimesRevisionID", ormTimeRev, "TypeRevision");
            //Display text to user
            this.comboBox3.SelectedIndex = 0;
            
        }

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

        #region click events
        private void AllCheckBoxes_CheckedChanged(Object sender, EventArgs e)
        {
            // Check of the raiser of the event is a checked Checkbox.
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                // TODO FUCKING HELL SHIT!!!!!
                Console.WriteLine("__________________RB NAME " + rb.Name);
                this.ormTimeRev.TypeRevision = Int32.Parse(rb.Name);
            }
        }

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

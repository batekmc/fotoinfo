using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo.Forms
{
    public partial class GlobalniNastaveni : Form
    {
        public GlobalniNastaveni()
        {
            InitializeComponent();
            loadFormDataFromDb();
        }

        private void loadFormDataFromDb()
        {

            DataTable data = SmartISLib.Data.GetDataTable("select * from TParameters");
            if (data.Rows.Count < 1)
            {
                SmartISLib.Messages.Error("Bohužel se v databázi nenachází požadovaný záznam.");
                return;

            }
            //Tabulka me jenom jeden radek. Pokud jich je vice tak se vezme prvni,
            //pokud mene tak se ukaze error uzivateli.
            DataRow row = data.Rows[0];
            //textBox1 - hmotnostni koeficient
            this.textBox1.Text = Convert.ToString(row["HmotnostKoef"]);
            // textBox2 - cesta pro most db
            this.textBox2.Text = Convert.ToString(row["PathMostForm"]);
            // textBox3 - prirazka
            this.textBox3.Text = Convert.ToString((Convert.ToDouble(row["TimeKoef"]) * 100 + "%"));

            //textBox1.on

            //IFu blbosti
            data = SmartISLib.Data.GetDataTable("select * from TIFU");

            foreach (DataRow dRow in data.Rows)
            {
                this.dataGridView1.Rows.Add( new string[]
                        {
                            Convert.ToString(dRow["IfuType"]),
                            Convert.ToString(dRow["IfuValue"])
                        }
                    );
            
            }

            //UPDATE listenery
            this.textBox1.TextChanged += this.Hmotnost_TextChanged;
            this.textBox2.TextChanged += this.Most_TextChanged;
            this.textBox3.TextChanged += this.Prirazka_TextChanged;
            this.dataGridView1.CellEndEdit += this.DataGrid_CellEdited;
            this.dataGridView1.RowsAdded += this.DataGrid_RowAdded;
        }

        private void DataGrid_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double ifuValue = 0;
            string ifuType;
            try
            {
                ifuType = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ifuValue = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            }
            catch (Exception ex) {
                SmartISLib.Messages.Error("Špatný formát záznamu. Používejte desetinné čárky místo teček.");
                return;
            }
            string sql = String.Format("insert into TIFU(ifuType, ifuValue) values('{0}', {1})", ifuType, ifuValue.ToString(CultureInfo.InvariantCulture));
            // TODO - nefunguje nejlepe: otestovat poradne.
            SmartISLib.Data.Execute(sql);
        }

        private void DataGrid_CellEdited(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex+1;
            string strVal = "";
            double doubleVal = 0;
            bool isDouble = false;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    strVal = Convert.ToString((string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                else
                {
                    doubleVal = Convert.ToDouble((string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    isDouble = true;
                }
                
            }
            catch (Exception ex) {
                SmartISLib.Messages.Error("Špatný formát záznamu. Používejte desetinné čárky místo teček.");
                return;
            }
            string sql;
            if (!isDouble)
                sql = String.Format("UPDATE TIFU SET IFUTYPE = '{0}' where ifuID = {1}", strVal, id);
            else
            {
                sql = String.Format("UPDATE TIFU SET IFUValue = {0} where ifuID = {1}", doubleVal, id);
                sql = sql.Replace(',', '.');
            }
            SmartISLib.Data.Execute(sql);


        }

        private void Hmotnost_TextChanged(object sender, EventArgs e) {
            //Otestuju, jestli ma update smysl
            try
            {
                Convert.ToDouble(this.textBox1.Text);
            }
            catch (Exception ex) {
                SmartISLib.Messages.Error("Špatný formát záznamu. Používejte desetinné čárky místo teček.");
                return;
            }
            string sql = String.Format("UPDATE Tparameters SET HmotnostKoef = {0} where ID = 1", this.textBox1.Text);
            //debilni zpusob nahrazeni desetinne carky teckou...
            sql= sql.Replace(',', '.');
            SmartISLib.Data.Execute(sql);
        }

        private void Most_TextChanged(object sender, EventArgs e)
        {
            //Otestuju, jestli ma update smysl
            try
            {
                String str = Convert.ToString(this.textBox2.Text);
                //if (!System.IO.Directory.Exists(str)) {
                //    throw new Exception("Neexistujici slozka");
                
                //}
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Špatný formát záznamu. Používejte desetinné čárky místo teček.");
                return;
            }
            string sql = String.Format("UPDATE Tparameters SET PathMostForm = '{0}' where ID = 1", this.textBox2.Text);
            SmartISLib.Data.Execute(sql);
        }

        private void Prirazka_TextChanged(object sender, EventArgs e)
        {
            double prirazka = 0;
            //Otestuju, jestli ma update smysl
            try
            {
                prirazka = Convert.ToDouble(this.textBox3.Text.Remove(this.textBox3.Text.Length - 1));
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error("Špatný formát záznamu. Používejte desetinné čárky místo teček.");
                return;
            }
            string sql = String.Format("UPDATE Tparameters SET TimeKoef = {0} where ID = 1", prirazka/100);
            //debilni zpusob nahrazeni desetinne carky teckou...
            sql = sql.Replace(',', '.');
            SmartISLib.Data.Execute(sql);
        }
    }
}

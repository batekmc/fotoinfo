using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo.Forms
{
    public partial class ImportZMasterlistu : Form
    {

        private Dictionary<string, string> mapping;
        private SmartISLib.ORM.DbTable<Data.TMasterListTmp> tMaster;

        public ImportZMasterlistu()
        {
            // mapovani sloupcu na hodnoty v databazi
            mapping = new Dictionary<string, string>();
            mapping.Add("Material Number", "KarvinaCode");
            mapping.Add("Preferred Item Status", "Category");
            mapping.Add("Document Status Description", "pdmStatus");
            mapping.Add("Vendor Name", "VendorName");
            mapping.Add("Vendor Mat No", "VendorMatNo");
            mapping.Add("Manufacturer Part Number", "VendorCode");
            mapping.Add("Long English Description", "Description");
            mapping.Add("Converted Price Euro", "ConvertedPriceEuro");
            mapping.Add("ADDPAK", "ADDPAK");
            //    mapping.Add CreateMapping("S607 External Drainage", "S607ExternalDrainage");
            mapping.Add("Family Group", "FamilyGroup");
            mapping.Add("Replaced By Item", "ReplacedByItem");
            mapping.Add("Long Local Description CS", "LongLocalDescriptionCS");
            mapping.Add("Long Local Description DA", "LongLocalDescriptionDA");
            mapping.Add("Long Local Description DE", "LongLocalDescriptionDE");
            mapping.Add("Long Local Description EN", "LongLocalDescriptionEN");
            mapping.Add("Long Local Description ES", "LongLocalDescriptionES");
            mapping.Add("Long Local Description FI", "LongLocalDescriptionFI");
            mapping.Add("Long Local Description FR", "LongLocalDescriptionFR");
            mapping.Add("Long Local Description HU", "LongLocalDescriptionHU");
            mapping.Add("Long Local Description IT", "LongLocalDescriptionIT");
            mapping.Add("Long Local Description NL", "LongLocalDescriptionNL");
            mapping.Add("Long Local Description NO", "LongLocalDescriptionNO");
            mapping.Add("Long Local Description PT", "LongLocalDescriptionPT");
            mapping.Add("Long Local Description SV", "LongLocalDescriptionSV");
            mapping.Add("Temporarily Removed", "TemporarilyRemoved");
            mapping.Add("Sterility", "Sterility");
            mapping.Add("Natural Rubber LATEX", "NaturalRubberLATEX");
            mapping.Add("PVC", "PVC");
            mapping.Add("Phthalates", "Phthalates");
            mapping.Add("Pyrogens", "Pyrogens");
            mapping.Add("Sales Restriction", "SalesRestriction");
            mapping.Add("Component Classification MDD", "ComponentClassificationMDD");
            mapping.Add("MDD Classification Rule", "MDDClassificationRule");
            mapping.Add("Intended Use", "IntendedUse");
            mapping.Add("Non Invasive liquids", "NonInvasiveliquids");
            mapping.Add("Sterilisation Cycle", "SterilisationCycle");
            mapping.Add("Family Group1", "FamilyGroup1");
            mapping.Add("Phase Out Date", "PhaseOutDate");
            mapping.Add("Reason For Replacement", "ReasonForReplacement");
            mapping.Add("VAT", "VAT");
            mapping.Add("Country Of Origin Of The Material", "CountryOfOriginOfTheMaterial");
            mapping.Add("Component Description For Label CS", "ComponentDescriptionForLabelCS");
            mapping.Add("Component Description For Label DA", "ComponentDescriptionForLabelDA");
            mapping.Add("Component Description For Label DE", "ComponentDescriptionForLabelDE");
            mapping.Add("Component Description For Label EN", "ComponentDescriptionForLabelEN");
            mapping.Add("Component Description For Label ES", "ComponentDescriptionForLabelES");
            mapping.Add("Component Description For Label FI", "ComponentDescriptionForLabelFI");
            mapping.Add("Component Description For Label FR", "ComponentDescriptionForLabelFR");
            mapping.Add("Component Description For Label HU", "ComponentDescriptionForLabelHU");
            mapping.Add("Component Description For Label IT", "ComponentDescriptionForLabelIT");
            mapping.Add("Component Description For Label NL", "ComponentDescriptionForLabelNL");
            mapping.Add("Component Description For Label NO", "ComponentDescriptionForLabelNO");
            mapping.Add("Component Description For Label PT", "ComponentDescriptionForLabelPT");
            mapping.Add("Component Description For Label SV", "ComponentDescriptionForLabelSV");
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.textBoxSelectedFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            importExcel(this.textBoxSelectedFile.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool importExcel(string file)
        {
            //SmartISLib.Session.BeginTransaction();
            string connectionExcel = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;'", file);
            using (OleDbConnection connection = new OleDbConnection(connectionExcel))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Masterlist$]", connection);

                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    tMaster = new SmartISLib.ORM.DbTable<Data.TMasterListTmp>();
                    while (dr.Read())
                    {
                        Data.TMasterListTmp tmp = Data.TMasterListTmp.Create();
                        foreach (string key in mapping.Keys)
                        {
                            tmp[mapping[key]] = dr[key];
                        }
                        tMaster.Add(tmp);
                    }
                }
            }
            tMaster.Save();


            return true;
        
        }
    }
}

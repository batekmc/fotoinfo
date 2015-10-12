using SmartISLib;
using SmartISLib.Modules;
using SmartISLib.Modules.EditableGrid;
using SmartISLib.Modules.GridDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo
{
    public partial class MainForm : SmartISLib.Forms.FormMain
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region override methods from SmartISLib.Forms.FormMain

        protected override bool Authenticate()
        {
            bool authentificated = Security.Autentificate.autentificate();
            if (authentificated)
            {
                this.toolStripStatusLabel1.Text = "Přihlášený uživatel: " + Security.Autentificate.User;
            }

            return authentificated;
        }

        protected override void OnBeforeInitialized()
        {
            SmartISLib.Shared.AppName = "Photo Info";
        }

        protected override string GetConnectionString()
        {
            return Other.AppConfigParser.getInstance.ConnectionString;
        }

        protected override SmartISLib.Interfaces.IExceptionHandler CreateExceptionHandler()
        {
            return new Other.ExceptionHandler();
        }

        protected override SmartISLib.Interfaces.IUserSettingsManager CreateUserSettingsManager()
        {
            return new Other.UserSettingsManager();
        }

        protected override void OnLoadModules()
        {
            Assembly a = Assembly.GetExecutingAssembly();
            SmartISLib.Modules.AppModuleManager.LoadAssembly(a);
        }


        #endregion


        #region click events
        private void pDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("PDM_Status").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void kategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("KategorieKomponentu").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void komponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("KomponentKategorie").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void statusSetuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("StatusySetu").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void druhBaleníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("DruhBaleni").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void typyBreatherBagůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("TypyBreatherBagu").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
            
        }

        private void typyKrabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("TypyKrabic").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void opravyKomponentůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("SeznamOpravKomponentu").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void způsobyVyskladněníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("ZpusobyVyskladneni").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void typyFotekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("SeznamTypuFotek").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        
        }

        private void kdoFotíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("KdoFoti").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void dostupnostFotekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("DostupnostFotek").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        private void zeměPoznámkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("ZemePoznamky").Start(
SmartISLib.Modules.EditableGrid.EditableGridStartingOptions.Empty);
        }

        /// <summary>
        /// Allows user to exprt viewed data into Excel file format. 
        /// Functionalitzy is provided bySmartISLib:)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Instances.CurrentModule is GridDetailModuleInstance)
                {
                    GridDetailModuleInstance module =
                        Instances.CurrentModule as GridDetailModuleInstance;
                    module.GridControl.Export();
                    SmartISLib.Messages.Information("Soubor uložen.");
                }
                else if (Instances.CurrentModule is EditableGridModuleInstance)
                {
                    EditableGridModuleInstance module =
                        Instances.CurrentModule as EditableGridModuleInstance;
                    module.GridControl.Export();
                    SmartISLib.Messages.Information("Soubor uložen.");
                }
                else
                {
                    SmartISLib.Messages.Error("Žádná vstupní data.\nToto tlačítko je určeno k exportu dat zobrazených v tabulce, do souboru ve formátu XLSX (Microsoft Excel)");
                }
            }
            catch (Exception ex)
            {
                SmartISLib.Messages.Error(ex.Message);
            }
        }

        private void globálníNastaveníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.GlobalniNastaveni().Show();
        }

        private void historieZměnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("HistorieZmen").Start(
SmartISLib.Modules.GridDetail.GridStartingOptions.Empty);

        }

        private void seznamKomponentůToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("SeznamKomponent").Start(
SmartISLib.Modules.GridDetail.GridStartingOptions.Empty);
        }

        private void příkazyKVyskladněníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("PrikazyKVyskladneni").Start(
SmartISLib.Modules.GridDetail.GridStartingOptions.Empty);
        }

        private void revizeČasůToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("RevizeCasu").Start(
SmartISLib.Modules.GridDetail.GridStartingOptions.Empty);

        }
        private void sampleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppModuleManager.GetModuleByName("SampleList").Start(
SmartISLib.Modules.GridDetail.GridStartingOptions.Empty);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.ImportZMasterlistu().Show();
        }


        #endregion click events

    }
}

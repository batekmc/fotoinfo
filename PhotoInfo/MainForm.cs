﻿using SmartISLib.Modules;
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

    }
}

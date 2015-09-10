using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.SeznamOpravKomponentu
{

    class SeznamOpravKomponentu : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static SeznamOpravKomponentu instance = new SeznamOpravKomponentu();

        public static SeznamOpravKomponentu Instance { get { return instance; } }

        private SeznamOpravKomponentu()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik SeznamOpravKomponentu";
            this.Name = "SeznamOpravKomponentu";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new SeznamOpravKomponentuInstance(this);
        }
    }

    class SeznamOpravKomponentuInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public SeznamOpravKomponentuInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TCorrection ORDER BY CorrectionName", "CorrectionName", "Zp;sob opravy");
        }


    }
}

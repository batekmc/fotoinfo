using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.SeznamTypuFotek
{
    class SeznamTypuFotek : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static SeznamTypuFotek instance = new SeznamTypuFotek();

        public static SeznamTypuFotek Instance { get { return instance; } }

        private SeznamTypuFotek()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik SeznamTypuFotek";
            this.Name = "SeznamTypuFotek";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new SeznamTypuFotekInstance(this);
        }
    }

    class SeznamTypuFotekInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public SeznamTypuFotekInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TImageType ORDER BY ImageName", "ImageName", "Typ Fotky");
        }


    }
}

using PhotoInfo.Modules.Ciselniky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.DostupnostFotek
{

    class DostupnostFotek : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static DostupnostFotek instance = new DostupnostFotek();

        public static DostupnostFotek Instance { get { return instance; } }

        private DostupnostFotek()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik DostupnostFotek";
            this.Name = "DostupnostFotek";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new DostupnostFotekInstance(this);
        }
    }

    class DostupnostFotekInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public DostupnostFotekInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TAvailability", "AvailabilityName", "Dostupnost");
        }
    }
}

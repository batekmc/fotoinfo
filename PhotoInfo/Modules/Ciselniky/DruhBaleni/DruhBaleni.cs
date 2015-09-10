using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.DruhBaleni
{

    class DruhBaleni : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static DruhBaleni instance = new DruhBaleni();

        public static DruhBaleni Instance { get { return instance; } }

        private DruhBaleni()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik DruhBaleni";
            this.Name = "DruhBaleni";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new DruhBaleniInstance(this);
        }
    }

    class DruhBaleniInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public DruhBaleniInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TSampleListCis where SCategory='DruhBaleni' Order by Name", "Name", "Druh balení");
        }


    }
}

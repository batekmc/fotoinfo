using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.StatusySetu
{

    class StatusySetu : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static StatusySetu instance = new StatusySetu();

        public static StatusySetu Instance { get { return instance; } }

        private StatusySetu()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik KdoFoti";
            this.Name = "StatusySetu";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new StatusySetuInstance(this);
        }
    }

    class StatusySetuInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public StatusySetuInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TSampleListCis where SCategory='Status' order by Name", "Name");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.TypyBreatherBagu
{

    class TypyBreatherBagu : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static TypyBreatherBagu instance = new TypyBreatherBagu();

        public static TypyBreatherBagu Instance { get { return instance; } }

        private TypyBreatherBagu()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik TypyBreatherBagu";
            this.Name = "TypyBreatherBagu";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new TypyBreatherBaguInstance(this);
        }
    }

    class TypyBreatherBaguInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public TypyBreatherBaguInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TSampleListCis where SCategory='BreatherBag' order by Name", "Name", "Breather bag");
        }


    }
}

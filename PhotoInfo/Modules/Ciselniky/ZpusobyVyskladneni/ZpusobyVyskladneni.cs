using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.ZpusobyVyskladneni
{

    class ZpusobyVyskladneni : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static ZpusobyVyskladneni instance = new ZpusobyVyskladneni();

        public static ZpusobyVyskladneni Instance { get { return instance; } }

        private ZpusobyVyskladneni()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik ZpusobyVyskladneni";
            this.Name = "ZpusobyVyskladneni";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new ZpusobyVyskladneniInstance(this);
        }
    }

    class ZpusobyVyskladneniInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public ZpusobyVyskladneniInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TPickType ORDER BY PickTypeName", "PickTypeName", "Způsoby vyskladnění", 500);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.ZemePoznamky
{

    class ZemePoznamky : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static ZemePoznamky instance = new ZemePoznamky();

        public static ZemePoznamky Instance { get { return instance; } }

        private ZemePoznamky()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik ZemePoznamky";
            this.Name = "ZemePoznamky";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new ZemePoznamkyInstance(this);
        }
    }

    class ZemePoznamkyInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public ZemePoznamkyInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod) : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new ZemeGrid();
        }

        protected override SmartISLib.Filters.FilterControl CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions) 
        {
            return new ZemeFilter();
        }

    }
}

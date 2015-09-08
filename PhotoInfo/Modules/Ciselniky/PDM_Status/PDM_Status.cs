using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.PDM_Status
{
    class PDM_StatusModule : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static PDM_StatusModule instance = new PDM_StatusModule();

        public static PDM_StatusModule Instance { get { return instance; } }

        private PDM_StatusModule() {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik PDM_Status";
            this.Name = "PDM_Status";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new PDM_StatusModuleInstance(this);
        }
    }

    class PDM_StatusModuleInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public PDM_StatusModuleInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {
            
        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new PDM_StatusGrid();
        }


    }


}

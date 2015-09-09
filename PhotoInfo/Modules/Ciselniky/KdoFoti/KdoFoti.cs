using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.KdoFoti
{

    class KdoFoti : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static KdoFoti instance = new KdoFoti();

        public static KdoFoti Instance { get { return instance; } }

        private KdoFoti()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik KdoFoti";
            this.Name = "KdoFoti";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new KdoFotiInstance(this);
        }
    }

    class KdoFotiInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public KdoFotiInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TODO", "TODO");
        }


    }


}

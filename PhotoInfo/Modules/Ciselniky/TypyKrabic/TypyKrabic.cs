using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.TypyKrabic
{

    class TypyKrabic : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static TypyKrabic instance = new TypyKrabic();

        public static TypyKrabic Instance { get { return instance; } }

        private TypyKrabic()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik TypyKrabic";
            this.Name = "TypyKrabic";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new TypyKrabicInstance(this);
        }
    }

    class TypyKrabicInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public TypyKrabicInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new CiselnikyDesign("TSampleListCis where SCategory='VelikostKrabice' order by Name", "Name", "Velikost Krabice");
        }


    }
}

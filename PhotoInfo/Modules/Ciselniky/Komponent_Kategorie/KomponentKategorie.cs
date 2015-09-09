using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.Komponent_Kategorie
{
    class KomponentKategorie : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static KomponentKategorie instance = new KomponentKategorie();

        public static KomponentKategorie Instance { get { return instance; } }

        private KomponentKategorie()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik KomponentKategorie";
            this.Name = "KomponentKategorie";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {

            return new KomponentKategorieInstance(this);
        }
    }

    class KomponentKategorieInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public KomponentKategorieInstance(SmartISLib.Modules.EditableGrid.EditableGridModule mod)
            : base(mod)
        {

        }

        protected override SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
        {
            return new KomponentKategorieGrid();
        }



    }
}

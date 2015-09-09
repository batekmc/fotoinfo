using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Ciselniky.Kategorie_komponentu
{
    class KategorieKomponentu : SmartISLib.Modules.EditableGrid.EditableGridModule
    {
        private static KategorieKomponentu instance = new KategorieKomponentu();

        public static KategorieKomponentu Instance { get { return instance; } }

        private KategorieKomponentu()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Ciselnik KategorieKomponentu";
            this.Name = "KategorieKomponentu";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL; 
        }

        protected override SmartISLib.Modules.AppModuleInstance CreateInstance(){

            return new KategorieKomponentuInstance(this);
        }
    }

    class KategorieKomponentuInstance : SmartISLib.Modules.EditableGrid.EditableGridModuleInstance
    {
        public KategorieKomponentuInstance (SmartISLib.Modules.EditableGrid.EditableGridModule mod) : base(mod)
        {

        }

        protected override  SmartISLib.Modules.EditableGrid.EditableGridControl CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions){
            return new KategorieKomponentuGrid();
        }
        
    
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Komponenty.SeznamKomponent
{

    public class SeznamKomponent : SmartISLib.Modules.GridDetail.GridDetailModule
    {
        private static SeznamKomponent instance = new SeznamKomponent();

        public static SeznamKomponent Instance
        {
            get { return instance; }
        }
        public SeznamKomponent()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Seznam Komponentu";
            this.Name = "SeznamKomponent";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }
        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new SeznamKomponentInstance(this);
        }

        public class SeznamKomponentInstance : SmartISLib.Modules.GridDetail.GridDetailModuleInstance
        {

            public SeznamKomponentInstance(SeznamKomponent module)
                : base(module)
            {

            }

            protected override SmartISLib.Modules.GridDetail.DetailControl
                CreateDetail(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SeznamKomponentDetail();
            }

            protected override SmartISLib.Modules.GridDetail.GridControl
                CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SeznamKomponentGrid();
            }

            protected override SmartISLib.Filters.FilterControl
                CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SeznamKomponentFilter();
            }
        }

    }
}

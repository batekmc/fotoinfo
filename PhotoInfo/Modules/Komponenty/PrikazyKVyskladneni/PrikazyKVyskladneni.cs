using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Komponenty.PrikazyKVyskladneni
{

    public class PrikazyKVyskladneni : SmartISLib.Modules.GridDetail.GridDetailModule
    {
        private static PrikazyKVyskladneni instance = new PrikazyKVyskladneni();

        public static PrikazyKVyskladneni Instance
        {
            get { return instance; }
        }
        public PrikazyKVyskladneni()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Prikazy K Vyskladneni";
            this.Name = "PrikazyKVyskladneni";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }
        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new PrikazyKVyskladneniInst5ance(this);
        }

        public class PrikazyKVyskladneniInst5ance : SmartISLib.Modules.GridDetail.GridDetailModuleInstance
        {

            public PrikazyKVyskladneniInst5ance(PrikazyKVyskladneni module)
                : base(module)
            {

            }

            protected override SmartISLib.Modules.GridDetail.DetailControl
                CreateDetail(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new PrikazyKVyskladneniDetail();
            }

            protected override SmartISLib.Modules.GridDetail.GridControl
                CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new PrikazyKVyskladneniGrid();
            }

            protected override SmartISLib.Filters.FilterControl
                CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new PrikazyKVyskladneniFilter();
            }
        }

    }
}

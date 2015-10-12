using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Komponenty.RevizeCasu
{
    public class RevizeCasu : SmartISLib.Modules.GridDetail.GridDetailModule
    {
        private static RevizeCasu instance = new RevizeCasu();

        public static RevizeCasu Instance
        {
            get { return instance; }
        }
        public RevizeCasu()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Revize Casu";
            this.Name = "RevizeCasu";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }
        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new RevizeCasuInstance(this);
        }

        public class RevizeCasuInstance : SmartISLib.Modules.GridDetail.GridDetailModuleInstance
        {

            public RevizeCasuInstance(RevizeCasu module)
                : base(module)
            {

            }

            protected override SmartISLib.Modules.GridDetail.DetailControl
                CreateDetail(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new RevizeCasuDetail();
            }

            protected override SmartISLib.Modules.GridDetail.GridControl
                CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new RevizeCasuGrid();
            }

            protected override SmartISLib.Filters.FilterControl
                CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new RevizeCasuFilter();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Komponenty.HistorieZmen
{
    public class HistorieZmen : SmartISLib.Modules.GridDetail.GridDetailModule
    {
        private static HistorieZmen instance = new HistorieZmen();

        public static HistorieZmen Instance
        {
            get { return instance; }
        }
        public HistorieZmen()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Historie Zmen";
            this.Name = "HistorieZmen";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }
        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new HistorieZmenInstance(this);
        }

        public class HistorieZmenInstance : SmartISLib.Modules.GridDetail.GridDetailModuleInstance
        {

            public HistorieZmenInstance(HistorieZmen module)
                : base(module)
            {

            }

            //protected override SmartISLib.Modules.GridDetail.DetailControl
            //    CreateDetail(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            //{
            //    return new HistorieZmenDetail();
            //}

            protected override SmartISLib.Modules.GridDetail.GridControl
                CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new HistorieZmenGrid();
            }

            protected override SmartISLib.Filters.FilterControl
                CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new HistorieZmenFilter();
            }
        }

    }
}

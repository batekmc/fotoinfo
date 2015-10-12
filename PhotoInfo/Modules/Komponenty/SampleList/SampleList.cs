using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Modules.Komponenty.SampleList
{
    public class SampleList : SmartISLib.Modules.GridDetail.GridDetailModule
    {
        private static SampleList instance = new SampleList();

        public static SampleList Instance
        {
            get { return instance; }
        }
        public SampleList()
        {
            this.Author = "Tarek Batiha";
            this.Description = "Sample List";
            this.Name = "SampleList";

            this.Rights = SmartISLib.Modules.AppModuleRight.ALL;
        }
        protected override SmartISLib.Modules.AppModuleInstance CreateInstance()
        {
            return new SampleListInstance(this);
        }

        public class SampleListInstance : SmartISLib.Modules.GridDetail.GridDetailModuleInstance
        {

            public SampleListInstance(SampleList module)
                : base(module)
            {

            }

            protected override SmartISLib.Modules.GridDetail.DetailControl
                CreateDetail(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SampleListDetail();
            }

            protected override SmartISLib.Modules.GridDetail.GridControl
                CreateGrid(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SampleListGrid();
            }

            protected override SmartISLib.Filters.FilterControl
                CreateFilter(SmartISLib.Modules.AppModuleStartingOptions startingOptions)
            {
                return new SampleListFilter();
            }
        }

    }
}


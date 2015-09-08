using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Other
{
    class ExceptionHandler : SmartISLib.Interfaces.IExceptionHandler
    {
        void SmartISLib.Interfaces.IExceptionHandler.Handle(Exception ex, bool quiet)
        {
            SmartISLib.Messages.Error(ex.StackTrace);//TOD devel only
        }
    }
}

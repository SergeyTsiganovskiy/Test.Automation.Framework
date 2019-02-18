using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NLog;

namespace Framework
{
    class DriverContex
    {
        private static readonly Logger Logger = LogManager.GetLogger("DRIVER");
        private readonly Collection<ErrorDetail> verifyMessages = new Collection<ErrorDetail>();
    }
}

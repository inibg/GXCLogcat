using System;
using System.Collections.Generic;
using System.Text;
using Artech.Common.Framework.Commands;

namespace GXCLogcat
{
    class CommandKeys
    {


        private static CommandKey AttrSelectDevice = new CommandKey(Package.guid, "SelectDevice");
        public static CommandKey SelectDevice
        {
            get { return AttrSelectDevice; }
        }
    }
}

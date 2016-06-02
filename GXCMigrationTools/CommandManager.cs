using Artech.Architecture.UI.Framework.Helper;
using Artech.Common.Framework.Commands;
using System.Windows.Forms;
using Artech.Architecture.UI.Framework.Services;

namespace GXCLogcat
{
    class CommandManager : CommandDelegator
    {
        public CommandManager()
        {
            AddCommand(CommandKeys.SelectDevice, new ExecHandler(ExecSelectDevice), new QueryHandler(QuerySelectDevice)); 
        }

        public bool ExecSelectDevice(CommandData data)
        {
            SelectDevice sd = new SelectDevice();
            sd.ShowDialog();
            return true;
        }

        private bool QuerySelectDevice(CommandData data, ref CommandStatus status)
        {
            status.State = CommandState.Disabled;
            if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            {
                status.State = CommandState.Enabled;
            }
            return true;
        }
    }
}

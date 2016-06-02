using Artech.Architecture.Common.Services;
using Artech.Architecture.UI.Framework.Controls;
using Artech.Architecture.UI.Framework.Packages;
using Artech.Packages.Definition;
using System;
using System.Runtime.InteropServices;


namespace GXCLogcatWindow
{
    [Guid("BDF56C1F-EED8-468D-BB72-F4AD63ACA71C")]
    public class GXCLogcatWindowPackage : AbstractPackageUI
    {
        private GXCLogcatWindow toolWindow;

        public override string Name
        {
            get { return "GXCLogcat"; }
        }

        public override void Initialize(IGxServiceProvider services)
        {
            base.Initialize(services);
        }

        public override IToolWindow CreateToolWindow(System.Guid toolWindowId)
        {
            if (toolWindowId.Equals(GXCLogcatWindow.guid))
            {
                if (toolWindow == null)
                    toolWindow = new GXCLogcatWindow();
                return toolWindow;
            }

            return base.CreateToolWindow(toolWindowId);
        }
    }
}

using System;
using System.Text;
using Artech.FrameworkDE;
using Artech.Architecture.UI.Framework.Packages;
using Artech.Common.Framework.Selection;
using Artech.Architecture.UI.Framework.Services;
using System.Runtime.InteropServices;

namespace GXCLogcatWindow
{
    [Guid("31864E82-E81F-4407-A295-3523458A3271")]
    public partial class GXCLogcatWindow : AbstractToolWindow
    {

        public static Guid guid = typeof(GXCLogcatWindow).GUID;

        public GXCLogcatWindow()
        {
            InitializeComponent();
            cmbDevices.Items.Add("Hola");
            cmbDevices.Items.Add("Chau");
        }


        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

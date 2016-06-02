using Artech.Architecture.Common.Packages;
using Artech.Architecture.Common.Services;
using System.Runtime.InteropServices;
using Artech.Architecture.UI.Framework.Packages;
using System;

namespace GXCLogcat
{
    [Guid("71156678-6E7A-4F17-9FFD-B9D1CB3EE712")]
	public class Package : AbstractPackageUI	{

        public static Guid guid = typeof(Package).GUID; 

		public override string Name
		{
			get { return "GXCLogcat"; }
		}

		public override void Initialize(IGxServiceProvider services)
		{
			base.Initialize(services);
            AddCommandTarget(new CommandManager());
		}
	}
}

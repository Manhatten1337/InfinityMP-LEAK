using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Infinity.Properties
{
	// Token: 0x02000018 RID: 24
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002234 File Offset: 0x00000434
		internal Resources()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000058A8 File Offset: 0x00003AA8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Infinity.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000058F0 File Offset: 0x00003AF0
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000223E File Offset: 0x0000043E
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000A2 RID: 162
		private static ResourceManager resourceMan;

		// Token: 0x040000A3 RID: 163
		private static CultureInfo resourceCulture;
	}
}

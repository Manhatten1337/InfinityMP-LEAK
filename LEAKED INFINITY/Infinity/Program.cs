using System;
using System.Windows.Forms;

namespace Infinity
{
	// Token: 0x02000014 RID: 20
	internal static class Program
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000021BE File Offset: 0x000003BE
		[STAThread]
		private static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}

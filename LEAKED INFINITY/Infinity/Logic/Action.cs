using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Infinity.Logic
{
	// Token: 0x02000019 RID: 25
	[NullableContext(1)]
	[Nullable(0)]
	internal class Action
	{
		// Token: 0x06000059 RID: 89
		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();

		// Token: 0x0600005A RID: 90
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();

		// Token: 0x0600005B RID: 91 RVA: 0x00002247 File Offset: 0x00000447
		public static void Log(string message)
		{
			Console.WriteLine(message);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002251 File Offset: 0x00000451
		public static void AttachConsole(Process processToAttach)
		{
			Action.AllocConsole();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005908 File Offset: 0x00003B08
		public static void LaunchFortnite()
		{
			Action.<>c__DisplayClass9_0 CS$<>8__locals1 = new Action.<>c__DisplayClass9_0();
			Process process = ProcessHelper.StartProcess(Global.FNPath + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
			Process process2 = ProcessHelper.StartProcess(Global.FNPath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
			Process process3 = ProcessHelper.StartProcess(Global.FNPath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
			Process process4 = new Process();
			process4.StartInfo.FileName = Global.FNPath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe";
			process4.StartInfo.Arguments = string.Concat(new string[]
			{
				"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=2725i0h34666525d51b022h3 -AUTH_TYPE=epic -AUTH_LOGIN=\"",
				Global.Email,
				"\" -AUTH_PASSWORD=\"",
				Global.Password,
				"\" -SKIPPATCHCHECK"
			});
			process4.StartInfo.UseShellExecute = false;
			process4.StartInfo.RedirectStandardOutput = true;
			process4.StartInfo.RedirectStandardError = true;
			process4.StartInfo.CreateNoWindow = true;
			process4.Start();
			Action.AttachConsole(process4);
			CS$<>8__locals1.outputBuilder = new StringBuilder();
			CS$<>8__locals1.errorBuilder = new StringBuilder();
			ProcessHelper.InjectDll(process4.Id, Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "InfinityRedirect.dll"));
			process4.OutputDataReceived += delegate(object sender, DataReceivedEventArgs args)
			{
				Action.<>c__DisplayClass9_0.<<LaunchFortnite>b__0>d <<LaunchFortnite>b__0>d = new Action.<>c__DisplayClass9_0.<<LaunchFortnite>b__0>d();
				<<LaunchFortnite>b__0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
				<<LaunchFortnite>b__0>d.<>4__this = CS$<>8__locals1;
				<<LaunchFortnite>b__0>d.sender = sender;
				<<LaunchFortnite>b__0>d.args = args;
				<<LaunchFortnite>b__0>d.<>1__state = -1;
				<<LaunchFortnite>b__0>d.<>t__builder.Start<Action.<>c__DisplayClass9_0.<<LaunchFortnite>b__0>d>(ref <<LaunchFortnite>b__0>d);
			};
			process4.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs args)
			{
				CS$<>8__locals1.errorBuilder.Append(args.Data);
			};
			process4.BeginOutputReadLine();
			process4.BeginErrorReadLine();
			process4.WaitForExit();
			process.Close();
			process2.Close();
			process4.Close();
			process3.Close();
			Action.FreeConsole();
		}

		// Token: 0x040000A4 RID: 164
		private const int PROCESS_VM_READ = 16;

		// Token: 0x040000A5 RID: 165
		private const int MEM_COMMIT = 4096;

		// Token: 0x040000A6 RID: 166
		private const int PAGE_READWRITE = 4;

		// Token: 0x040000A7 RID: 167
		private const string TARGET_PROCESS_NAME = "FortniteClient-Win64-Shipping.exe";

		// Token: 0x040000A8 RID: 168
		private const string INJECTED_DLL_NAME = "injected.dll";
	}
}

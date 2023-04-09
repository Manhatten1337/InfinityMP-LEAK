using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Infinity.Logic
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProcessHelper
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00005CAC File Offset: 0x00003EAC
		public static Process StartProcess(string path, bool shouldFreeze, string extraArgs = "")
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = path,
					Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=2725i0h34666525d51b022h3 " + extraArgs
				}
			};
			process.Start();
			if (shouldFreeze)
			{
				foreach (object obj in process.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					ProcessHelper.SuspendThread(ProcessHelper.OpenThread(2, false, processThread.Id));
				}
			}
			return process;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005D60 File Offset: 0x00003F60
		public static void InjectDll(int processId, string path)
		{
			IntPtr hProcess = ProcessHelper.OpenProcess(1082, false, processId);
			IntPtr procAddress = ProcessHelper.GetProcAddress(ProcessHelper.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			uint num = (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char)));
			IntPtr intPtr = ProcessHelper.VirtualAllocEx(hProcess, IntPtr.Zero, num, 12288U, 4U);
			UIntPtr uintPtr;
			ProcessHelper.WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(path), num, out uintPtr);
			ProcessHelper.CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
		}

		// Token: 0x0600006F RID: 111
		[DllImport("kernel32.dll")]
		public static extern int SuspendThread(IntPtr hThread);

		// Token: 0x06000070 RID: 112
		[DllImport("kernel32.dll")]
		public static extern int ResumeThread(IntPtr hThread);

		// Token: 0x06000071 RID: 113
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);

		// Token: 0x06000072 RID: 114
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x06000073 RID: 115
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x06000074 RID: 116
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x06000075 RID: 117
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000076 RID: 118
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000077 RID: 119
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x06000078 RID: 120
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
	}
}

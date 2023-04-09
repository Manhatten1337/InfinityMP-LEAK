using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infinity.Logic;

namespace Infinity
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(0)]
	public class InfinityFriends : UserControl
	{
		// Token: 0x06000026 RID: 38
		[DllImport("user32.dll")]
		private static extern bool GetScrollInfo(IntPtr hWnd, int n, ref InfinityFriends.SCROLLINFO lpScrollInfo);

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll")]
		private static extern int SetScrollInfo(IntPtr hWnd, int n, [In] ref InfinityFriends.SCROLLINFO lpScrollInfo, bool bRedraw);

		// Token: 0x06000028 RID: 40 RVA: 0x000045B0 File Offset: 0x000027B0
		public InfinityFriends()
		{
			this.InitializeComponent();
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.WrapContents = false;
			this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			this.flowLayoutPanel1.Scroll += this.FlowLayoutPanel1_Scroll;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002137 File Offset: 0x00000337
		private void FlowLayoutPanel1_Scroll([Nullable(2)] object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004634 File Offset: 0x00002834
		[DebuggerStepThrough]
		private Task<List<string>> FetchNamesAsync()
		{
			InfinityFriends.<FetchNamesAsync>d__11 <FetchNamesAsync>d__ = new InfinityFriends.<FetchNamesAsync>d__11();
			<FetchNamesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<string>>.Create();
			<FetchNamesAsync>d__.<>4__this = this;
			<FetchNamesAsync>d__.<>1__state = -1;
			<FetchNamesAsync>d__.<>t__builder.Start<InfinityFriends.<FetchNamesAsync>d__11>(ref <FetchNamesAsync>d__);
			return <FetchNamesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004678 File Offset: 0x00002878
		[DebuggerStepThrough]
		private void InfinityFriends_Load(object sender, EventArgs e)
		{
			InfinityFriends.<InfinityFriends_Load>d__12 <InfinityFriends_Load>d__ = new InfinityFriends.<InfinityFriends_Load>d__12();
			<InfinityFriends_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InfinityFriends_Load>d__.<>4__this = this;
			<InfinityFriends_Load>d__.sender = sender;
			<InfinityFriends_Load>d__.e = e;
			<InfinityFriends_Load>d__.<>1__state = -1;
			<InfinityFriends_Load>d__.<>t__builder.Start<InfinityFriends.<InfinityFriends_Load>d__12>(ref <InfinityFriends_Load>d__);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002137 File Offset: 0x00000337
		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000046C0 File Offset: 0x000028C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000046F8 File Offset: 0x000028F8
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new FlowLayoutPanel();
			base.SuspendLayout();
			this.flowLayoutPanel1.Location = new Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new Size(295, 380);
			this.flowLayoutPanel1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.flowLayoutPanel1);
			base.Name = "InfinityFriends";
			base.Size = new Size(295, 380);
			base.Load += this.InfinityFriends_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x04000051 RID: 81
		private const int SB_HORZ = 0;

		// Token: 0x04000052 RID: 82
		private const int SB_VERT = 1;

		// Token: 0x04000053 RID: 83
		private const int SIF_ALL = 23;

		// Token: 0x04000054 RID: 84
		private const int SIF_DISABLENOSCROLL = 8;

		// Token: 0x04000055 RID: 85
		private readonly string apiUrl = "http://infinityapi.nekuzi.cf:43614/infinity/launcher/api/get/friends/" + Global.DisplayName;

		// Token: 0x04000056 RID: 86
		private readonly HttpClient httpClient = new HttpClient();

		// Token: 0x04000057 RID: 87
		[Nullable(0)]
		private IContainer components = null;

		// Token: 0x04000058 RID: 88
		[Nullable(0)]
		private FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x0200000C RID: 12
		[NullableContext(0)]
		private struct SCROLLINFO
		{
			// Token: 0x04000059 RID: 89
			public int cbSize;

			// Token: 0x0400005A RID: 90
			public int fMask;

			// Token: 0x0400005B RID: 91
			public int nMin;

			// Token: 0x0400005C RID: 92
			public int nMax;

			// Token: 0x0400005D RID: 93
			public int nPage;

			// Token: 0x0400005E RID: 94
			public int nPos;

			// Token: 0x0400005F RID: 95
			public int nTrackPos;
		}
	}
}

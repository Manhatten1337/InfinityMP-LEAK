using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Infinity
{
	// Token: 0x0200000F RID: 15
	public class InfinityNews : UserControl
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000214C File Offset: 0x0000034C
		public InfinityNews()
		{
			this.InitializeComponent();
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.WrapContents = false;
			this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004CB4 File Offset: 0x00002EB4
		[DebuggerStepThrough]
		private void LoadData()
		{
			InfinityNews.<LoadData>d__2 <LoadData>d__ = new InfinityNews.<LoadData>d__2();
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<InfinityNews.<LoadData>d__2>(ref <LoadData>d__);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004CF0 File Offset: 0x00002EF0
		[NullableContext(1)]
		[DebuggerStepThrough]
		private void InfinityNews_Load(object sender, EventArgs e)
		{
			InfinityNews.<InfinityNews_Load>d__4 <InfinityNews_Load>d__ = new InfinityNews.<InfinityNews_Load>d__4();
			<InfinityNews_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InfinityNews_Load>d__.<>4__this = this;
			<InfinityNews_Load>d__.sender = sender;
			<InfinityNews_Load>d__.e = e;
			<InfinityNews_Load>d__.<>1__state = -1;
			<InfinityNews_Load>d__.<>t__builder.Start<InfinityNews.<InfinityNews_Load>d__4>(ref <InfinityNews_Load>d__);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004D38 File Offset: 0x00002F38
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004D70 File Offset: 0x00002F70
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new FlowLayoutPanel();
			base.SuspendLayout();
			this.flowLayoutPanel1.Location = new Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new Size(598, 491);
			this.flowLayoutPanel1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.flowLayoutPanel1);
			base.Name = "InfinityNews";
			base.Size = new Size(598, 491);
			base.Load += this.InfinityNews_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x04000078 RID: 120
		[Nullable(1)]
		private const string url = "http://infinityapi.nekuzi.cf:43614/launcher/v1/news";

		// Token: 0x04000079 RID: 121
		private IContainer components = null;

		// Token: 0x0400007A RID: 122
		private FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x02000010 RID: 16
		[NullableContext(1)]
		[Nullable(0)]
		private class Item
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600003A RID: 58 RVA: 0x0000218B File Offset: 0x0000038B
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002193 File Offset: 0x00000393
			public string Title { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003C RID: 60 RVA: 0x0000219C File Offset: 0x0000039C
			// (set) Token: 0x0600003D RID: 61 RVA: 0x000021A4 File Offset: 0x000003A4
			public string ImageUrl { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000021AD File Offset: 0x000003AD
			// (set) Token: 0x0600003F RID: 63 RVA: 0x000021B5 File Offset: 0x000003B5
			public string Description { get; set; }
		}
	}
}

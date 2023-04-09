using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infinity.Logic;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Infinity
{
	// Token: 0x02000007 RID: 7
	public partial class Form1 : Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020FC File Offset: 0x000002FC
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000245C File Offset: 0x0000065C
		[NullableContext(1)]
		[DebuggerStepThrough]
		private void button3_Click(object sender, EventArgs e)
		{
			Form1.<button3_Click>d__1 <button3_Click>d__ = new Form1.<button3_Click>d__1();
			<button3_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button3_Click>d__.<>4__this = this;
			<button3_Click>d__.sender = sender;
			<button3_Click>d__.e = e;
			<button3_Click>d__.<>1__state = -1;
			<button3_Click>d__.<>t__builder.Start<Form1.<button3_Click>d__1>(ref <button3_Click>d__);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024A4 File Offset: 0x000006A4
		[NullableContext(1)]
		private void Form1_Load(object sender, EventArgs e)
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string path = Path.Combine(baseDirectory, "config.json");
			bool flag = !File.Exists(path);
			if (!flag)
			{
				string value = File.ReadAllText(path);
				object arg = JsonConvert.DeserializeObject<object>(value);
				Control emailBox = this.EmailBox;
				if (Form1.<>o__2.<>p__1 == null)
				{
					Form1.<>o__2.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form1)));
				}
				Func<CallSite, object, string> target = Form1.<>o__2.<>p__1.Target;
				CallSite <>p__ = Form1.<>o__2.<>p__1;
				if (Form1.<>o__2.<>p__0 == null)
				{
					Form1.<>o__2.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Email", typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				emailBox.Text = target(<>p__, Form1.<>o__2.<>p__0.Target(Form1.<>o__2.<>p__0, arg));
				Control passwordBox = this.PasswordBox;
				if (Form1.<>o__2.<>p__3 == null)
				{
					Form1.<>o__2.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form1)));
				}
				Func<CallSite, object, string> target2 = Form1.<>o__2.<>p__3.Target;
				CallSite <>p__2 = Form1.<>o__2.<>p__3;
				if (Form1.<>o__2.<>p__2 == null)
				{
					Form1.<>o__2.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Password", typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				passwordBox.Text = target2(<>p__2, Form1.<>o__2.<>p__2.Target(Form1.<>o__2.<>p__2, arg));
				if (Form1.<>o__2.<>p__5 == null)
				{
					Form1.<>o__2.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Form1)));
				}
				Func<CallSite, object, string> target3 = Form1.<>o__2.<>p__5.Target;
				CallSite <>p__3 = Form1.<>o__2.<>p__5;
				if (Form1.<>o__2.<>p__4 == null)
				{
					Form1.<>o__2.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "FNPath", typeof(Form1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Global.FNPath = target3(<>p__3, Form1.<>o__2.<>p__4.Target(Form1.<>o__2.<>p__4, arg));
				bool flag2 = this.EmailBox.Text != "";
				if (flag2)
				{
					Global.IsPrevSaved = true;
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026D8 File Offset: 0x000008D8
		[NullableContext(1)]
		private void DiscordBtn_Click(object sender, EventArgs e)
		{
			string fileName = "https://discord.gg/infinitymp";
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000270C File Offset: 0x0000090C
		[NullableContext(1)]
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string fileName = "http://infinityapi.nekuzi.cf:43614/forgotpassword";
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002740 File Offset: 0x00000940
		[NullableContext(1)]
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string fileName = "http://infinityapi.nekuzi.cf:43614/register";
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}
	}
}

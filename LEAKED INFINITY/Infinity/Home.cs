using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infinity.Logic;
using Newtonsoft.Json.Linq;

namespace Infinity
{
	// Token: 0x0200000A RID: 10
	public partial class Home : Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000211F File Offset: 0x0000031F
		public Home()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002137 File Offset: 0x00000337
		[NullableContext(1)]
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000213A File Offset: 0x0000033A
		[NullableContext(1)]
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Infinity.Logic.Action.LaunchFortnite();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002137 File Offset: 0x00000337
		[NullableContext(1)]
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002137 File Offset: 0x00000337
		[NullableContext(1)]
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003B60 File Offset: 0x00001D60
		[NullableContext(1)]
		private void Home_Load(object sender, EventArgs e)
		{
			base.FormClosed += this.Home_FormClosing;
			this.ProfileBtn.Text = Global.DisplayName;
			string address = "http://infinityapi.nekuzi.cf:43614/infinity/launcher/api/get/friends/" + Global.DisplayName;
			int num = 0;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string json = webClient.DownloadString(address);
					JArray jarray = JArray.Parse(json);
					num = jarray.Count;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Count Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this.FriendCount.Text = num.ToString();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002143 File Offset: 0x00000343
		[NullableContext(1)]
		private void Home_FormClosing([Nullable(2)] object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C2C File Offset: 0x00001E2C
		[NullableContext(1)]
		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Token: 0x0400004D RID: 77
		private InfinityNews infinityNews1;
	}
}

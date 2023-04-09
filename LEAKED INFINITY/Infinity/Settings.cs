using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infinity.Logic;
using Newtonsoft.Json;

namespace Infinity
{
	// Token: 0x02000015 RID: 21
	public partial class Settings : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000021D2 File Offset: 0x000003D2
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000054F4 File Offset: 0x000036F4
		[NullableContext(1)]
		private void FindFolderBtn_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.RootFolder = Environment.SpecialFolder.Personal;
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				bool flag = dialogResult == DialogResult.OK;
				if (flag)
				{
					Global.FNPath = folderBrowserDialog.SelectedPath;
					this.FolderPathText.Text = Global.FNPath;
					string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
					string path = Path.Combine(baseDirectory, "config.json");
					var value = new
					{
						FNPath = folderBrowserDialog.SelectedPath
					};
					bool flag2 = File.Exists(path);
					if (flag2)
					{
						string value2 = File.ReadAllText(path);
						Settings.Config config = JsonConvert.DeserializeObject<Settings.Config>(value2);
						config.FNPath = folderBrowserDialog.SelectedPath;
						string contents = JsonConvert.SerializeObject(config);
						File.WriteAllText(path, contents);
					}
					else
					{
						string contents2 = JsonConvert.SerializeObject(value);
						File.WriteAllText(path, contents2);
					}
					MessageBox.Show("successfully saved!");
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000055E8 File Offset: 0x000037E8
		[NullableContext(1)]
		private void Settings_Load(object sender, EventArgs e)
		{
			bool flag = Global.FNPath != "";
			if (flag)
			{
				this.FolderPathText.Text = Global.FNPath;
			}
		}

		// Token: 0x02000016 RID: 22
		[NullableContext(1)]
		[Nullable(0)]
		public class Config
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600004D RID: 77 RVA: 0x000021EA File Offset: 0x000003EA
			// (set) Token: 0x0600004E RID: 78 RVA: 0x000021F2 File Offset: 0x000003F2
			public string Email { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600004F RID: 79 RVA: 0x000021FB File Offset: 0x000003FB
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00002203 File Offset: 0x00000403
			public string Password { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000051 RID: 81 RVA: 0x0000220C File Offset: 0x0000040C
			// (set) Token: 0x06000052 RID: 82 RVA: 0x00002214 File Offset: 0x00000414
			public string FNPath { get; set; }
		}
	}
}

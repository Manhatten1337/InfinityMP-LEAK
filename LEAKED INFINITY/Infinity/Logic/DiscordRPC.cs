using System;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;

namespace Infinity.Logic
{
	// Token: 0x0200001C RID: 28
	internal class DiscordRPC
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00005B80 File Offset: 0x00003D80
		public static void Init()
		{
			DiscordRpcClient discordRpcClient = new DiscordRpcClient("1089790762675351612");
			discordRpcClient.Logger = new ConsoleLogger
			{
				Level = LogLevel.Warning
			};
			discordRpcClient.OnReady += delegate(object sender, ReadyMessage e)
			{
			};
			discordRpcClient.OnPresenceUpdate += delegate(object sender, PresenceMessage e)
			{
			};
			discordRpcClient.Initialize();
			discordRpcClient.SetPresence(new RichPresence
			{
				Details = "Infinity",
				State = "In Launcher",
				Assets = new Assets
				{
					LargeImageKey = "bigimg",
					LargeImageText = "Infinity the skid by ctrlkohl"
				}
			});
		}
	}
}

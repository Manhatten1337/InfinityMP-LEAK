namespace Infinity
{
	// Token: 0x0200000A RID: 10
	public partial class Home : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003C48 File Offset: 0x00001E48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003C80 File Offset: 0x00001E80
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Infinity.Home));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.SettingsBtn = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LaunchBtn = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.FriendCount = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.infinityNews2 = new global::Infinity.InfinityNews();
			this.ProfileBtn = new global::System.Windows.Forms.Button();
			this.infinityFriends1 = new global::Infinity.InfinityFriends();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LaunchBtn).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(15, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(177, 57);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.button1.Location = new global::System.Drawing.Point(60, 123);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(74, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Home";
			this.button1.UseVisualStyleBackColor = false;
			this.SettingsBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.SettingsBtn.FlatAppearance.BorderSize = 0;
			this.SettingsBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SettingsBtn.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.SettingsBtn.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.SettingsBtn.Location = new global::System.Drawing.Point(60, 169);
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new global::System.Drawing.Size(74, 40);
			this.SettingsBtn.TabIndex = 2;
			this.SettingsBtn.Text = "Settings";
			this.SettingsBtn.UseVisualStyleBackColor = false;
			this.SettingsBtn.Click += new global::System.EventHandler(this.SettingsBtn_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.label1.Location = new global::System.Drawing.Point(824, 38);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(81, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Free to play";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.LaunchBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LaunchBtn.Image");
			this.LaunchBtn.Location = new global::System.Drawing.Point(824, 60);
			this.LaunchBtn.Name = "LaunchBtn";
			this.LaunchBtn.Size = new global::System.Drawing.Size(270, 101);
			this.LaunchBtn.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LaunchBtn.TabIndex = 4;
			this.LaunchBtn.TabStop = false;
			this.LaunchBtn.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.label2.Location = new global::System.Drawing.Point(813, 229);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(53, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Friends";
			this.FriendCount.AutoSize = true;
			this.FriendCount.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.FriendCount.ForeColor = global::System.Drawing.Color.White;
			this.FriendCount.Location = new global::System.Drawing.Point(872, 229);
			this.FriendCount.Name = "FriendCount";
			this.FriendCount.Size = new global::System.Drawing.Size(33, 19);
			this.FriendCount.TabIndex = 6;
			this.FriendCount.Text = "000";
			this.FriendCount.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.FriendCount.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.label4.Location = new global::System.Drawing.Point(216, 38);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(42, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "News";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.infinityNews2.Location = new global::System.Drawing.Point(209, 60);
			this.infinityNews2.Name = "infinityNews2";
			this.infinityNews2.Size = new global::System.Drawing.Size(598, 491);
			this.infinityNews2.TabIndex = 8;
			this.ProfileBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.ProfileBtn.FlatAppearance.BorderSize = 0;
			this.ProfileBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ProfileBtn.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.ProfileBtn.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.ProfileBtn.Location = new global::System.Drawing.Point(33, 602);
			this.ProfileBtn.Name = "ProfileBtn";
			this.ProfileBtn.Size = new global::System.Drawing.Size(177, 40);
			this.ProfileBtn.TabIndex = 9;
			this.ProfileBtn.Text = "{Player Name}";
			this.ProfileBtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ProfileBtn.UseVisualStyleBackColor = false;
			this.infinityFriends1.Location = new global::System.Drawing.Point(816, 251);
			this.infinityFriends1.Name = "infinityFriends1";
			this.infinityFriends1.Size = new global::System.Drawing.Size(295, 380);
			this.infinityFriends1.TabIndex = 10;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			base.ClientSize = new global::System.Drawing.Size(1108, 654);
			base.Controls.Add(this.infinityFriends1);
			base.Controls.Add(this.ProfileBtn);
			base.Controls.Add(this.infinityNews2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.FriendCount);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.LaunchBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.SettingsBtn);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Name = "Home";
			this.Text = "Home";
			base.Load += new global::System.EventHandler(this.Home_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LaunchBtn).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000044 RID: 68
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button SettingsBtn;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.PictureBox LaunchBtn;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label FriendCount;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400004E RID: 78
		private global::Infinity.InfinityNews infinityNews2;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Button ProfileBtn;

		// Token: 0x04000050 RID: 80
		private global::Infinity.InfinityFriends infinityFriends1;
	}
}

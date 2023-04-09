namespace Infinity
{
	// Token: 0x02000007 RID: 7
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002774 File Offset: 0x00000974
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027AC File Offset: 0x000009AC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Infinity.Form1));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.EmailBox = new global::System.Windows.Forms.TextBox();
			this.PasswordBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.RememberMe = new global::System.Windows.Forms.CheckBox();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.DiscordBtn = new global::System.Windows.Forms.Button();
			this.LoginBtn = new global::System.Windows.Forms.Button();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.linkLabel3 = new global::System.Windows.Forms.LinkLabel();
			this.label5 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(165, 54);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(61, 57, 54);
			this.panel1.Location = new global::System.Drawing.Point(334, 234);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(200, 3);
			this.panel1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(152, 149, 145);
			this.label1.Location = new global::System.Drawing.Point(540, 228);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(23, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "OR";
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(61, 57, 54);
			this.panel2.Location = new global::System.Drawing.Point(569, 234);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(200, 3);
			this.panel2.TabIndex = 2;
			this.EmailBox.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.EmailBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.EmailBox.Font = new global::System.Drawing.Font("Segoe UI", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.EmailBox.ForeColor = global::System.Drawing.Color.White;
			this.EmailBox.Location = new global::System.Drawing.Point(334, 267);
			this.EmailBox.Name = "EmailBox";
			this.EmailBox.Size = new global::System.Drawing.Size(435, 25);
			this.EmailBox.TabIndex = 3;
			this.PasswordBox.BackColor = global::System.Drawing.Color.FromArgb(8, 8, 8);
			this.PasswordBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.PasswordBox.Font = new global::System.Drawing.Font("Segoe UI", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.PasswordBox.ForeColor = global::System.Drawing.Color.White;
			this.PasswordBox.Location = new global::System.Drawing.Point(334, 332);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new global::System.Drawing.Size(435, 25);
			this.PasswordBox.TabIndex = 4;
			this.PasswordBox.UseSystemPasswordChar = true;
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(102, 96, 95);
			this.label2.Location = new global::System.Drawing.Point(334, 249);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(39, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email:";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(102, 96, 95);
			this.label3.Location = new global::System.Drawing.Point(334, 314);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password:";
			this.RememberMe.AutoSize = true;
			this.RememberMe.ForeColor = global::System.Drawing.Color.FromArgb(208, 191, 185);
			this.RememberMe.Location = new global::System.Drawing.Point(334, 386);
			this.RememberMe.Name = "RememberMe";
			this.RememberMe.Size = new global::System.Drawing.Size(109, 19);
			this.RememberMe.TabIndex = 7;
			this.RememberMe.Text = "Remember Me?";
			this.RememberMe.UseVisualStyleBackColor = true;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.FromArgb(31, 110, 41);
			this.linkLabel1.Location = new global::System.Drawing.Point(642, 390);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(127, 15);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Forgot your password?";
			this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.FromArgb(102, 192, 167);
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.DiscordBtn.BackColor = global::System.Drawing.Color.FromArgb(88, 101, 242);
			this.DiscordBtn.FlatAppearance.BorderSize = 0;
			this.DiscordBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DiscordBtn.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.DiscordBtn.ForeColor = global::System.Drawing.Color.White;
			this.DiscordBtn.Location = new global::System.Drawing.Point(497, 157);
			this.DiscordBtn.Name = "DiscordBtn";
			this.DiscordBtn.Size = new global::System.Drawing.Size(111, 58);
			this.DiscordBtn.TabIndex = 9;
			this.DiscordBtn.Text = "Discord";
			this.DiscordBtn.UseVisualStyleBackColor = false;
			this.DiscordBtn.Click += new global::System.EventHandler(this.DiscordBtn_Click);
			this.LoginBtn.BackColor = global::System.Drawing.Color.FromArgb(102, 192, 167);
			this.LoginBtn.FlatAppearance.BorderSize = 0;
			this.LoginBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoginBtn.Location = new global::System.Drawing.Point(415, 424);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new global::System.Drawing.Size(266, 47);
			this.LoginBtn.TabIndex = 11;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new global::System.EventHandler(this.button3_Click);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = global::System.Drawing.Color.FromArgb(31, 110, 41);
			this.linkLabel2.Location = new global::System.Drawing.Point(508, 474);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(80, 15);
			this.linkLabel2.TabIndex = 12;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Privacy Policy";
			this.linkLabel2.VisitedLinkColor = global::System.Drawing.Color.FromArgb(102, 192, 167);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(208, 191, 185);
			this.label4.Location = new global::System.Drawing.Point(428, 508);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(191, 19);
			this.label4.TabIndex = 13;
			this.label4.Text = "Don't have a Infinity account?";
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.LinkColor = global::System.Drawing.Color.FromArgb(31, 110, 41);
			this.linkLabel3.Location = new global::System.Drawing.Point(625, 510);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new global::System.Drawing.Size(47, 15);
			this.linkLabel3.TabIndex = 14;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Sign up";
			this.linkLabel3.VisitedLinkColor = global::System.Drawing.Color.FromArgb(102, 192, 167);
			this.linkLabel3.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.FromArgb(102, 96, 95);
			this.label5.Location = new global::System.Drawing.Point(269, 630);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(542, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "Infinity is not affiliated, endorsed, or administered by Epic Games or their respective copyright holders";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			base.ClientSize = new global::System.Drawing.Size(1108, 654);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.linkLabel3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.DiscordBtn);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.RememberMe);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.PasswordBox);
			base.Controls.Add(this.EmailBox);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			base.Name = "Form1";
			this.Text = "Infinity";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox EmailBox;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox PasswordBox;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.CheckBox RememberMe;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button DiscordBtn;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button LoginBtn;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.LinkLabel linkLabel3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label5;
	}
}

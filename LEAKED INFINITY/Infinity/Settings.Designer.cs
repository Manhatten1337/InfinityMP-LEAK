namespace Infinity
{
	// Token: 0x02000015 RID: 21
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000561C File Offset: 0x0000381C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005654 File Offset: 0x00003854
		private void InitializeComponent()
		{
			this.FolderPathText = new global::System.Windows.Forms.TextBox();
			this.FindFolderBtn = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.FolderPathText.Location = new global::System.Drawing.Point(24, 31);
			this.FolderPathText.Name = "FolderPathText";
			this.FolderPathText.Size = new global::System.Drawing.Size(978, 23);
			this.FolderPathText.TabIndex = 0;
			this.FindFolderBtn.Location = new global::System.Drawing.Point(1008, 31);
			this.FindFolderBtn.Name = "FindFolderBtn";
			this.FindFolderBtn.Size = new global::System.Drawing.Size(24, 23);
			this.FindFolderBtn.TabIndex = 1;
			this.FindFolderBtn.Text = "...";
			this.FindFolderBtn.UseVisualStyleBackColor = true;
			this.FindFolderBtn.Click += new global::System.EventHandler(this.FindFolderBtn_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.label4.Location = new global::System.Drawing.Point(24, 9);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(92, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Fortnite Path:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			base.ClientSize = new global::System.Drawing.Size(1108, 654);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.FindFolderBtn);
			base.Controls.Add(this.FolderPathText);
			base.Name = "Settings";
			this.Text = "Infinity";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009B RID: 155
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TextBox FolderPathText;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button FindFolderBtn;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label4;
	}
}

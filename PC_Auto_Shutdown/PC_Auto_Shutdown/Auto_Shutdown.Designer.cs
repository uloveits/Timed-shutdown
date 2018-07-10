namespace PC_Auto_Shutdown
{
	partial class Auto_Shutdown
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auto_Shutdown));
			this.label1 = new System.Windows.Forms.Label();
			this.dateTime = new System.Windows.Forms.DateTimePicker();
			this.doIt = new System.Windows.Forms.Button();
			this.hoursCombo = new System.Windows.Forms.ComboBox();
			this.minutesCombo = new System.Windows.Forms.ComboBox();
			this.CancelIt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// dateTime
			// 
			resources.ApplyResources(this.dateTime, "dateTime");
			this.dateTime.Name = "dateTime";
			// 
			// doIt
			// 
			this.doIt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			resources.ApplyResources(this.doIt, "doIt");
			this.doIt.Name = "doIt";
			this.doIt.UseVisualStyleBackColor = true;
			this.doIt.Click += new System.EventHandler(this.doIt_Click);
			// 
			// hoursCombo
			// 
			this.hoursCombo.FormattingEnabled = true;
			resources.ApplyResources(this.hoursCombo, "hoursCombo");
			this.hoursCombo.Name = "hoursCombo";
			// 
			// minutesCombo
			// 
			this.minutesCombo.FormattingEnabled = true;
			resources.ApplyResources(this.minutesCombo, "minutesCombo");
			this.minutesCombo.Name = "minutesCombo";
			// 
			// CancelIt
			// 
			resources.ApplyResources(this.CancelIt, "CancelIt");
			this.CancelIt.Name = "CancelIt";
			this.CancelIt.UseVisualStyleBackColor = true;
			this.CancelIt.Click += new System.EventHandler(this.CancelIt_Click);
			// 
			// Auto_Shutdown
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CancelIt);
			this.Controls.Add(this.minutesCombo);
			this.Controls.Add(this.hoursCombo);
			this.Controls.Add(this.doIt);
			this.Controls.Add(this.dateTime);
			this.Controls.Add(this.label1);
			this.Name = "Auto_Shutdown";
			this.Load += new System.EventHandler(this.Auto_Shutdown_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTime;
		private System.Windows.Forms.Button doIt;
		private System.Windows.Forms.ComboBox hoursCombo;
		private System.Windows.Forms.ComboBox minutesCombo;
		private System.Windows.Forms.Button CancelIt;
	}
}


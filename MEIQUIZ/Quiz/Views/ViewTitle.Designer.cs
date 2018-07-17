namespace Quiz.Views
{
	partial class ViewTitle
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TimerAnimation = new System.Windows.Forms.Timer(this.components);
			this.pictBoxTitle = new System.Windows.Forms.PictureBox();
			this.pictBoxRyoma = new System.Windows.Forms.PictureBox();
			this.pictBoxCompany = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxRyoma)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxCompany)).BeginInit();
			this.SuspendLayout();
			// 
			// TimerAnimation
			// 
			this.TimerAnimation.Enabled = true;
			this.TimerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
			// 
			// pictBoxTitle
			// 
			this.pictBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictBoxTitle.Image = global::Quiz.Properties.Resources.title;
			this.pictBoxTitle.Location = new System.Drawing.Point(0, 0);
			this.pictBoxTitle.Name = "pictBoxTitle";
			this.pictBoxTitle.Size = new System.Drawing.Size(900, 750);
			this.pictBoxTitle.TabIndex = 2;
			this.pictBoxTitle.TabStop = false;
			this.pictBoxTitle.Visible = false;
			this.pictBoxTitle.Click += new System.EventHandler(this.pictBoxTitle_Click);
			// 
			// pictBoxRyoma
			// 
			this.pictBoxRyoma.Image = global::Quiz.Properties.Resources.ryoma;
			this.pictBoxRyoma.Location = new System.Drawing.Point(372, 230);
			this.pictBoxRyoma.Name = "pictBoxRyoma";
			this.pictBoxRyoma.Size = new System.Drawing.Size(224, 202);
			this.pictBoxRyoma.TabIndex = 1;
			this.pictBoxRyoma.TabStop = false;
			this.pictBoxRyoma.Visible = false;
			// 
			// pictBoxCompany
			// 
			this.pictBoxCompany.Image = global::Quiz.Properties.Resources.maenomeri;
			this.pictBoxCompany.Location = new System.Drawing.Point(175, 449);
			this.pictBoxCompany.Margin = new System.Windows.Forms.Padding(2);
			this.pictBoxCompany.Name = "pictBoxCompany";
			this.pictBoxCompany.Size = new System.Drawing.Size(582, 41);
			this.pictBoxCompany.TabIndex = 0;
			this.pictBoxCompany.TabStop = false;
			this.pictBoxCompany.Visible = false;
			// 
			// ViewTitle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pictBoxTitle);
			this.Controls.Add(this.pictBoxRyoma);
			this.Controls.Add(this.pictBoxCompany);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ViewTitle";
			this.Size = new System.Drawing.Size(900, 750);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewTitle_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictBoxTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxRyoma)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxCompany)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictBoxCompany;
		private System.Windows.Forms.PictureBox pictBoxRyoma;
		private System.Windows.Forms.Timer TimerAnimation;
		private System.Windows.Forms.PictureBox pictBoxTitle;
	}
}

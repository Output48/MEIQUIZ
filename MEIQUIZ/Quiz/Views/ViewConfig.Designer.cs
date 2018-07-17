namespace Quiz.Views
{
	partial class ViewConfig
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewConfig));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(884, 711);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 644);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(884, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "CONFIG";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxName
			// 
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxName.Location = new System.Drawing.Point(35, 83);
			this.textBoxName.MaxLength = 200;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(388, 21);
			this.textBoxName.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSeaGreen;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.Color.White;
			this.buttonSave.Location = new System.Drawing.Point(35, 129);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(187, 53);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "SAVE";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.White;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.ForeColor = System.Drawing.Color.MidnightBlue;
			this.buttonBack.Location = new System.Drawing.Point(15, 655);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(151, 43);
			this.buttonBack.TabIndex = 9;
			this.buttonBack.Text = "BACK";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.SteelBlue;
			this.label2.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(26, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(405, 68);
			this.label2.TabIndex = 10;
			this.label2.Text = "Name";
			// 
			// ViewConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewConfig";
			this.Size = new System.Drawing.Size(884, 711);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label label2;
	}
}

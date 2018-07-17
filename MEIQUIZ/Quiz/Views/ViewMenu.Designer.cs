namespace Quiz.Views
{
	partial class ViewMenu
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
			this.labelTypeMessage = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTypeMessage
			// 
			this.labelTypeMessage.AutoSize = true;
			this.labelTypeMessage.Font = new System.Drawing.Font("TBシネマ丸ゴシック Std M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTypeMessage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTypeMessage.Location = new System.Drawing.Point(19, 526);
			this.labelTypeMessage.Name = "labelTypeMessage";
			this.labelTypeMessage.Size = new System.Drawing.Size(0, 40);
			this.labelTypeMessage.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::Quiz.Properties.Resources.menu_back;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(900, 750);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(58, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(304, 60);
			this.button1.TabIndex = 2;
			this.button1.Text = "SINGLE PLAY";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.ButtonClick);
			this.button1.Leave += new System.EventHandler(this.ButtonLeave);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SteelBlue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(58, 146);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(304, 60);
			this.button2.TabIndex = 3;
			this.button2.Text = "VS MODE";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.ButtonClick);
			this.button2.Leave += new System.EventHandler(this.ButtonLeave);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.SteelBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(58, 230);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(304, 60);
			this.button3.TabIndex = 4;
			this.button3.Text = "MAKE QUIZ";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.ButtonClick);
			this.button3.Leave += new System.EventHandler(this.ButtonLeave);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.SteelBlue;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(58, 314);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(304, 60);
			this.button4.TabIndex = 5;
			this.button4.Text = "CONFIG";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.ButtonClick);
			this.button4.Leave += new System.EventHandler(this.ButtonLeave);
			// 
			// ViewMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.labelTypeMessage);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewMenu";
			this.Size = new System.Drawing.Size(900, 750);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTypeMessage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

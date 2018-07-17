namespace Quiz.Views
{
	partial class ViewQuiz
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQuiz));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.TimerSpan = new System.Windows.Forms.Timer(this.components);
			this.TimerProgress = new System.Windows.Forms.Timer(this.components);
			this.pictBoxWindow = new System.Windows.Forms.PictureBox();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelUser = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxWindow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 511);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(442, 100);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button2.ForeColor = System.Drawing.Color.SteelBlue;
			this.button2.Location = new System.Drawing.Point(442, 511);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(442, 100);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button3.ForeColor = System.Drawing.Color.SteelBlue;
			this.button3.Location = new System.Drawing.Point(0, 611);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(442, 100);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackColor = System.Drawing.Color.SteelBlue;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(442, 611);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(442, 100);
			this.button4.TabIndex = 5;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(136, 461);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(700, 30);
			this.progressBar1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(42, 456);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(800, 40);
			this.label1.TabIndex = 7;
			this.label1.Text = "TIME";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TimerSpan
			// 
			this.TimerSpan.Tick += new System.EventHandler(this.TimerSpan_Tick);
			// 
			// TimerProgress
			// 
			this.TimerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
			// 
			// pictBoxWindow
			// 
			this.pictBoxWindow.BackgroundImage = global::Quiz.Properties.Resources.correct_window;
			this.pictBoxWindow.Location = new System.Drawing.Point(258, 138);
			this.pictBoxWindow.Name = "pictBoxWindow";
			this.pictBoxWindow.Size = new System.Drawing.Size(375, 211);
			this.pictBoxWindow.TabIndex = 8;
			this.pictBoxWindow.TabStop = false;
			this.pictBoxWindow.Visible = false;
			// 
			// labelQuestion
			// 
			this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelQuestion.BackColor = System.Drawing.Color.White;
			this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelQuestion.Image = global::Quiz.Properties.Resources.question_back;
			this.labelQuestion.Location = new System.Drawing.Point(42, 40);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(800, 400);
			this.labelQuestion.TabIndex = 1;
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
			// labelUser
			// 
			this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelUser.AutoSize = true;
			this.labelUser.BackColor = System.Drawing.Color.SandyBrown;
			this.labelUser.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUser.ForeColor = System.Drawing.Color.White;
			this.labelUser.Location = new System.Drawing.Point(725, 0);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(159, 26);
			this.labelUser.TabIndex = 9;
			this.labelUser.Text = "MULTI PLAY";
			this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelUser.Visible = false;
			// 
			// ViewQuiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.pictBoxWindow);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelQuestion);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewQuiz";
			this.Size = new System.Drawing.Size(884, 711);
			((System.ComponentModel.ISupportInitialize)(this.pictBoxWindow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer TimerSpan;
		private System.Windows.Forms.Timer TimerProgress;
		private System.Windows.Forms.PictureBox pictBoxWindow;
		private System.Windows.Forms.Label labelUser;
	}
}

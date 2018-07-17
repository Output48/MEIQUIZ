namespace Quiz.Views
{
	partial class ViewMake
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMake));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvQuestionList = new System.Windows.Forms.DataGridView();
			this.textBoxQuestion = new System.Windows.Forms.TextBox();
			this.textBoxAnswer = new System.Windows.Forms.TextBox();
			this.textBoxChoice1 = new System.Windows.Forms.TextBox();
			this.textBoxChoice2 = new System.Windows.Forms.TextBox();
			this.textBoxChoice3 = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).BeginInit();
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
			this.label1.Text = "MAKE QUIZ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvQuestionList
			// 
			this.dgvQuestionList.AllowUserToAddRows = false;
			this.dgvQuestionList.AllowUserToDeleteRows = false;
			this.dgvQuestionList.AllowUserToResizeColumns = false;
			this.dgvQuestionList.AllowUserToResizeRows = false;
			this.dgvQuestionList.BackgroundColor = System.Drawing.Color.White;
			this.dgvQuestionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuestionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuestionList.ColumnHeadersVisible = false;
			this.dgvQuestionList.GridColor = System.Drawing.Color.SteelBlue;
			this.dgvQuestionList.Location = new System.Drawing.Point(24, 13);
			this.dgvQuestionList.MultiSelect = false;
			this.dgvQuestionList.Name = "dgvQuestionList";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuestionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvQuestionList.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
			this.dgvQuestionList.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvQuestionList.RowTemplate.Height = 60;
			this.dgvQuestionList.RowTemplate.ReadOnly = true;
			this.dgvQuestionList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvQuestionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvQuestionList.ShowCellToolTips = false;
			this.dgvQuestionList.Size = new System.Drawing.Size(398, 538);
			this.dgvQuestionList.TabIndex = 2;
			this.dgvQuestionList.SelectionChanged += new System.EventHandler(this.dgvQuestionList_SelectionChanged);
			// 
			// textBoxQuestion
			// 
			this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxQuestion.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxQuestion.Location = new System.Drawing.Point(454, 55);
			this.textBoxQuestion.MaxLength = 200;
			this.textBoxQuestion.Multiline = true;
			this.textBoxQuestion.Name = "textBoxQuestion";
			this.textBoxQuestion.Size = new System.Drawing.Size(388, 170);
			this.textBoxQuestion.TabIndex = 3;
			// 
			// textBoxAnswer
			// 
			this.textBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAnswer.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxAnswer.Location = new System.Drawing.Point(454, 283);
			this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(10);
			this.textBoxAnswer.MaxLength = 60;
			this.textBoxAnswer.Name = "textBoxAnswer";
			this.textBoxAnswer.Size = new System.Drawing.Size(388, 21);
			this.textBoxAnswer.TabIndex = 4;
			// 
			// textBoxChoice1
			// 
			this.textBoxChoice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxChoice1.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxChoice1.Location = new System.Drawing.Point(454, 362);
			this.textBoxChoice1.Margin = new System.Windows.Forms.Padding(10);
			this.textBoxChoice1.MaxLength = 60;
			this.textBoxChoice1.Name = "textBoxChoice1";
			this.textBoxChoice1.Size = new System.Drawing.Size(388, 21);
			this.textBoxChoice1.TabIndex = 5;
			// 
			// textBoxChoice2
			// 
			this.textBoxChoice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxChoice2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxChoice2.Location = new System.Drawing.Point(454, 441);
			this.textBoxChoice2.Margin = new System.Windows.Forms.Padding(10);
			this.textBoxChoice2.MaxLength = 60;
			this.textBoxChoice2.Name = "textBoxChoice2";
			this.textBoxChoice2.Size = new System.Drawing.Size(388, 21);
			this.textBoxChoice2.TabIndex = 6;
			// 
			// textBoxChoice3
			// 
			this.textBoxChoice3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxChoice3.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxChoice3.Location = new System.Drawing.Point(454, 520);
			this.textBoxChoice3.Margin = new System.Windows.Forms.Padding(10);
			this.textBoxChoice3.MaxLength = 60;
			this.textBoxChoice3.Name = "textBoxChoice3";
			this.textBoxChoice3.Size = new System.Drawing.Size(388, 21);
			this.textBoxChoice3.TabIndex = 7;
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSeaGreen;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.Color.White;
			this.buttonSave.Location = new System.Drawing.Point(445, 566);
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
			this.label2.Location = new System.Drawing.Point(445, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(405, 217);
			this.label2.TabIndex = 10;
			this.label2.Text = "Question";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SandyBrown;
			this.label3.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(445, 244);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(405, 70);
			this.label3.TabIndex = 11;
			this.label3.Text = "Answer";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.SteelBlue;
			this.label4.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(445, 323);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(405, 70);
			this.label4.TabIndex = 12;
			this.label4.Text = "Choice1";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.SteelBlue;
			this.label5.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(445, 402);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(405, 70);
			this.label5.TabIndex = 13;
			this.label5.Text = "Choice2";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(445, 481);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(405, 70);
			this.label6.TabIndex = 14;
			this.label6.Text = "Choice3";
			// 
			// buttonNew
			// 
			this.buttonNew.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNew.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNew.ForeColor = System.Drawing.Color.White;
			this.buttonNew.Location = new System.Drawing.Point(24, 566);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(398, 53);
			this.buttonNew.TabIndex = 15;
			this.buttonNew.Text = "NEW";
			this.buttonNew.UseVisualStyleBackColor = false;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.PaleVioletRed;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.Color.White;
			this.buttonDelete.Location = new System.Drawing.Point(663, 566);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(187, 53);
			this.buttonDelete.TabIndex = 16;
			this.buttonDelete.Text = "DELETE";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// ViewMake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxChoice3);
			this.Controls.Add(this.textBoxChoice2);
			this.Controls.Add(this.textBoxChoice1);
			this.Controls.Add(this.textBoxAnswer);
			this.Controls.Add(this.textBoxQuestion);
			this.Controls.Add(this.dgvQuestionList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewMake";
			this.Size = new System.Drawing.Size(884, 711);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvQuestionList;
		private System.Windows.Forms.TextBox textBoxQuestion;
		private System.Windows.Forms.TextBox textBoxAnswer;
		private System.Windows.Forms.TextBox textBoxChoice1;
		private System.Windows.Forms.TextBox textBoxChoice2;
		private System.Windows.Forms.TextBox textBoxChoice3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonDelete;
	}
}

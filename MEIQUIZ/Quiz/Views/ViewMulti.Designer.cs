namespace Quiz.Views
{
	partial class ViewMulti
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelTypeMessage = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonBack = new System.Windows.Forms.Button();
			this.dgvUserList = new System.Windows.Forms.DataGridView();
			this.buttonBattle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
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
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.ForeColor = System.Drawing.Color.White;
			this.buttonBack.Location = new System.Drawing.Point(58, 430);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(304, 60);
			this.buttonBack.TabIndex = 5;
			this.buttonBack.Text = "BACK";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// dgvUserList
			// 
			this.dgvUserList.AllowUserToAddRows = false;
			this.dgvUserList.AllowUserToDeleteRows = false;
			this.dgvUserList.AllowUserToResizeColumns = false;
			this.dgvUserList.AllowUserToResizeRows = false;
			this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
			this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserList.ColumnHeadersVisible = false;
			this.dgvUserList.GridColor = System.Drawing.Color.SteelBlue;
			this.dgvUserList.Location = new System.Drawing.Point(58, 23);
			this.dgvUserList.MultiSelect = false;
			this.dgvUserList.Name = "dgvUserList";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvUserList.RowHeadersVisible = false;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
			this.dgvUserList.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvUserList.RowTemplate.Height = 60;
			this.dgvUserList.RowTemplate.ReadOnly = true;
			this.dgvUserList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvUserList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUserList.ShowCellToolTips = false;
			this.dgvUserList.Size = new System.Drawing.Size(304, 334);
			this.dgvUserList.TabIndex = 6;
			this.dgvUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellClick);
			// 
			// buttonBattle
			// 
			this.buttonBattle.BackColor = System.Drawing.Color.Crimson;
			this.buttonBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBattle.Font = new System.Drawing.Font("Eurostile ExtendedTwo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBattle.ForeColor = System.Drawing.Color.White;
			this.buttonBattle.Location = new System.Drawing.Point(58, 363);
			this.buttonBattle.Name = "buttonBattle";
			this.buttonBattle.Size = new System.Drawing.Size(304, 60);
			this.buttonBattle.TabIndex = 7;
			this.buttonBattle.Text = "BATTLE";
			this.buttonBattle.UseVisualStyleBackColor = false;
			this.buttonBattle.Click += new System.EventHandler(this.buttonBallte_Click);
			// 
			// ViewMulti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonBattle);
			this.Controls.Add(this.dgvUserList);
			this.Controls.Add(this.labelTypeMessage);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewMulti";
			this.Size = new System.Drawing.Size(900, 750);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewMulti_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTypeMessage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.DataGridView dgvUserList;
		private System.Windows.Forms.Button buttonBattle;
	}
}

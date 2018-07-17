using System;
using System.IO;
using System.Threading;
using Ukity;

namespace Quiz
{
	/// <summary>
	/// メインフォーム
	/// </summary>
	public partial class MainForm : UkityForm
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shownイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Shown(object sender, EventArgs e)
		{
			Thread.Sleep(2000);

			this.ViewPanel.BackgroundImage = null;

			ViewPanel.Controls.Add(new Views.ViewTitle());
			ViewPanel.Controls[0].Focus();
		}

		/// <summary>
		/// ページ変更
		/// </summary>
		/// <param name="page">変更先ページ名</param>
		/// <param name="args">汎用引数</param>
		public override void ChangePage(string page, object args = null)
		{
			switch (page)
			{
				case "ViewMenu":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewMenu());
					break;

				case "ViewQuiz":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewQuiz());
					break;

				case "ViewMulti":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewMulti());
					break;

				case "ViewResult":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewResult(args));
					break;

				case "ViewMake":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewMake());
					break;

				case "ViewConfig":
					ViewPanel.Controls.RemoveAt(0);
					ViewPanel.Controls.Add(new Views.ViewConfig());
					break;
			}
		}

		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			if (File.Exists("Multi.csv"))
			{
				File.Delete("Multi.csv");
			}
		}
	}
}

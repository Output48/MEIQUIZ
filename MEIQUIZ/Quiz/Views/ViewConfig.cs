using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ukity;

namespace Quiz.Views
{
	/// <summary>
	/// コンフィグビュー
	/// </summary>
	public partial class ViewConfig : ViewController
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ViewConfig()
		{
			InitializeComponent();

			GetConfig();

			music = new SoundController(Properties.Resources.menu_sound);
			music.Play();
		}

		/// <summary>
		/// 設定取得
		/// </summary>
		private void GetConfig()
		{
			try
			{
				Encoding enc = Encoding.GetEncoding("Shift_JIS");
				StreamReader sr = new StreamReader("Config.txt", enc);

				while(sr.Peek() > -1)
				{
					textBoxName.Text = sr.ReadLine();
				}

				sr.Close();
			}
			catch (Exception)
			{
				textBoxName.Text = "USER";
				buttonSave_Click(null, null);
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			ChangePage("ViewMenu");
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				Encoding enc = Encoding.GetEncoding("Shift_JIS");
				StreamWriter sw = new StreamWriter("Config.txt", false, enc);

				if (textBoxName.Text != "")
				{
					sw.WriteLine(textBoxName.Text);
				}

				sw.Close();

				if (sender != null)
				{
					MessageBox.Show("保存しました");
				}
			}
			catch(Exception)
			{
				if (sender != null)
				{
					MessageBox.Show("保存に失敗しました");
				}
			}
		}
	}
}

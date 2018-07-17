using System;
using Ukity;

namespace Quiz.Views
{
	/// <summary>
	/// クイズビュー
	/// </summary>
	public partial class ViewResult : ViewController
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ViewResult(object args)
		{
			InitializeComponent();

			music = new SoundController(Properties.Resources.quiz_sound);
			music.Play();

			Datas.Result result = (Datas.Result)args;

			TypeMessage.Write(labelQuestion,
				"RESULT\n\n" +
				"CORRECT ...... " + result.Correct.ToString() + " / " + result.Question.ToString() + "\n" +
				"CORR RATE .... " + ((double)(result.Correct / (double)result.Question) * 100).ToString("0.00") + " %\n" +
				"TOTAL TIME ... " + (result.TotalTime / 10).ToString() + "\n" +
				"AVERAGE ...... " + ((((double)result.TotalTime / 10) / (double)result.Question)).ToString("0.00") + " sec/Q" +
				"\n\n\n\nCLICK RETURN TO MENU >>>");
		}

		private void labelQuestion_Click(object sender, EventArgs e)
		{
			ChangePage("ViewMenu");
		}
	}
}

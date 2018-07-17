using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Ukity;

namespace Quiz.Views
{
	/// <summary>
	/// クイズビュー
	/// </summary>
	public partial class ViewQuiz : ViewController
	{
		/// <summary>
		/// クイズデータ
		/// </summary>
		private DataTable quiz = null;

		/// <summary>
		/// 出題
		/// </summary>
		private DataRow nowQ = null;

		/// <summary>
		/// 回答結果
		/// </summary>
		private Datas.Result result = new Datas.Result();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ViewQuiz()
		{
			InitializeComponent();

			if (File.Exists("Multi.csv"))
			{
				quiz = Datas.Question.GetData("Multi.csv");
				labelUser.Visible = true;
			}
			else
			{
				quiz = Datas.Question.GetData();
			}

			music = new SoundController(Properties.Resources.quiz_sound);
			music.Play();

			TimerSpan.Enabled = true;
		}

		/// <summary>
		/// 問題更新
		/// </summary>
		private void UpdateQuestion()
		{
			pictBoxWindow.Visible = false;

			if (quiz != null && quiz.Rows.Count > 0)
			{
				if (nowQ != null)
				{
					quiz.Rows.Remove(nowQ);
				}

				Random random = new Random();
				int index = random.Next(quiz.Rows.Count);

				nowQ = quiz.Rows[index];

				var choices = new List<string>(){ "Answer", "Choice1", "Choice2", "Choice3" };
				index = random.Next(choices.Count);
				button1.Text = nowQ[choices[index]].ToString();
				button1.Click += new EventHandler(this.button_Click);
				choices.RemoveAt(index);
				index = random.Next(choices.Count);
				button2.Text = nowQ[choices[index]].ToString();
				button2.Click += new EventHandler(this.button_Click);
				choices.RemoveAt(index);
				index = random.Next(choices.Count);
				button3.Text = nowQ[choices[index]].ToString();
				button3.Click += new EventHandler(this.button_Click);
				choices.RemoveAt(index);
				index = random.Next(choices.Count);
				button4.Text = nowQ[choices[index]].ToString();
				button4.Click += new EventHandler(this.button_Click);

				TypeMessage.Write(labelQuestion, "第" + result.Question + "問\n" + nowQ["Question"].ToString());
			}
		}

		/// <summary>
		/// 回答ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Click(object sender, EventArgs e)
		{
			button1.Click -= new EventHandler(this.button_Click);
			button2.Click -= new EventHandler(this.button_Click);
			button3.Click -= new EventHandler(this.button_Click);
			button4.Click -= new EventHandler(this.button_Click);

			Button btn = (Button)sender;

			if (btn.Text == nowQ["Answer"].ToString())
			{
				result.Correct++;
				pictBoxWindow.Image = Properties.Resources.correct_window;
				pictBoxWindow.Visible = true;
				effect = new System.Media.SoundPlayer(Properties.Resources.correct);
				effect.Play();
			}
			else
			{
				pictBoxWindow.Image = Properties.Resources.incorrect_window;
				pictBoxWindow.Visible = true;
				effect = new System.Media.SoundPlayer(Properties.Resources.incorrect);
				effect.Play();
			}

			Refresh();
			Thread.Sleep(1000);

			result.TotalTime += progressBar1.Maximum - progressBar1.Value;
			TimerProgress.Enabled = false;
			TimerSpan.Interval = 100;
			TimerSpan.Enabled = true;
		}

		/// <summary>
		/// タイマー処理（出題間隔）
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerSpan_Tick(object sender, EventArgs e)
		{
			TimerSpan.Enabled = false;
			progressBar1.Value = 100;
			TimerProgress.Enabled = true;

			if (result.Question >= 10)
			{
				Thread.Sleep(2000);
				ChangePage("ViewResult", result);
				return;
			}

			result.Question++;

			UpdateQuestion();
		}

		/// <summary>
		/// タイマー処理（プログレスバー）
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerProgress_Tick(object sender, EventArgs e)
		{
			progressBar1.Value -= 1;
			if (progressBar1.Value == 0)
			{
				effect = new System.Media.SoundPlayer(Properties.Resources.incorrect);
				effect.Play();

				result.TotalTime += progressBar1.Maximum;
				TimerProgress.Enabled = false;
				TimerSpan.Interval = 100;
				TimerSpan.Enabled = true;
			}
		}
	}
}

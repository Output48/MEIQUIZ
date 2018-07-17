using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Ukity;

namespace Quiz.Views
{
	public partial class ViewMenu : ViewController
	{
		public ViewMenu()
		{
			InitializeComponent();

			music = new SoundController(Properties.Resources.menu_sound);
			music.Play();

			if (File.Exists("Multi.csv"))
			{
				File.Delete("Multi.csv");
			}

			TypeMessage.Write(labelTypeMessage, "メインメニューです。\nお好きなモードを選択してください。");
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			switch(btn.Name)
			{
				case "button1":
					if (btn.BackColor == Color.Goldenrod)
					{
						ChangePage("ViewQuiz");
					}
					else
					{
						btn.BackColor = Color.Goldenrod;
						TypeMessage.Write(labelTypeMessage, "ひとりで遊ぶモードです。");
					}
					break;
				case "button2":
					if (btn.BackColor == Color.Goldenrod)
					{
						ChangePage("ViewMulti");
					}
					else
					{
						btn.BackColor = Color.Goldenrod;
						TypeMessage.Write(labelTypeMessage, "離れた人とクイズでバトル！\nオンラインマルチプレイモードです。");
					}
					break;
				case "button3":
					if (btn.BackColor == Color.Goldenrod)
					{
						ChangePage("ViewMake");
					}
					else
					{
						btn.BackColor = Color.Goldenrod;
						TypeMessage.Write(labelTypeMessage, "クイズを自分で作れるモードです。");
					}
					break;
				case "button4":
					if (btn.BackColor == Color.Goldenrod)
					{
						ChangePage("ViewConfig");
					}
					else
					{
						btn.BackColor = Color.Goldenrod;
						TypeMessage.Write(labelTypeMessage, "各種設定が行えます。");
					}
					break;
			}
		}

		private void ButtonLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = Color.SteelBlue;
		}
	}
}

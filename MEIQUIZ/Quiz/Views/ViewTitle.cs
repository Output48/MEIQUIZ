using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukity;

namespace Quiz.Views
{
	/// <summary>
	/// タイトルビュー
	/// </summary>
	public partial class ViewTitle : ViewController
	{
		/// <summary>
		/// 透明度
		/// </summary>
		private float opacity = 0;

		/// <summary>
		/// 終了フラグ
		/// </summary>
		private bool EndFlag = false;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ViewTitle()
		{
			InitializeComponent();
		}

		/// <summary>
		/// タイマー処理（アニメーション）
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerAnimation_Tick(object sender, EventArgs e)
		{
			if (opacity <= 1)
			{
				Bitmap canvas = new Bitmap(pictBoxCompany.Width, pictBoxCompany.Height);
				Graphics g = Graphics.FromImage(canvas);

				System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix();
				cm.Matrix00 = 1;
				cm.Matrix11 = 1;
				cm.Matrix22 = 1;
				cm.Matrix33 = opacity;
				cm.Matrix44 = 1;

				System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
				ia.SetColorMatrix(cm);

				g.DrawImage(
					Properties.Resources.maenomeri,
					new Rectangle(0, 0, pictBoxCompany.Image.Width, pictBoxCompany.Image.Height),
					0,
					0,
					pictBoxCompany.Image.Width,
					pictBoxCompany.Image.Height,
					GraphicsUnit.Pixel,
					ia);

				g.Dispose();

				pictBoxCompany.Image = canvas;

				opacity += 0.1F;

				pictBoxCompany.Visible = true;
				Refresh();
			}
			else
			{
				if (pictBoxRyoma.Visible == false)
				{
					pictBoxRyoma.Visible = true;

					effect = new System.Media.SoundPlayer(Properties.Resources.ryoma_load);
					Refresh();
					effect.PlaySync();

					TimerAnimation.Interval = 2000;
				}
				else
				{
					pictBoxCompany.Visible = false;
					pictBoxRyoma.Visible = false;

					music = new SoundController(Properties.Resources.title_sound);
					music.Play();

					pictBoxTitle.Visible = true;
					Refresh();
					TimerAnimation.Enabled = false;
					EndFlag = true;
				}
			}
		}

		/// <summary>
		/// KeyDownイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ViewTitle_KeyDown(object sender, KeyEventArgs e)
		{
			if (EndFlag)
			{
				ChangePage("ViewMenu");

				this.Dispose();
			}
		}

		/// <summary>
		/// Clickイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictBoxTitle_Click(object sender, EventArgs e)
		{
			if (EndFlag)
			{
				ChangePage("ViewMenu");

				this.Dispose();
			}
		}
	}
}

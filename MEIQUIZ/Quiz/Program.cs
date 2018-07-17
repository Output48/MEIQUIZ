using System;
using System.Windows.Forms;

/******************************************************************
 * 
 * ■　　　■　■■■■　■　　■■■　　■　　■　■　■■■■
 * ■■　■■　■　　　　■　■　　　■　■　　■　■　　　　■
 * ■　■　■　■■■■　■　■　　　■　■　　■　■　　　■
 * ■　　　■　■　　　　■　■　　■■　■　　■　■　　■
 * ■　　　■　■■■■　■　　■■■■　　■■　　■　■■■■
 * 
 * Company: MAENOMERI Co., Ltd.
 * Author : Yukio Yoshimura
 * Date   : 2018.06.15
 * Update : 2018.06.20
 * Note   : 
 ******************************************************************/
namespace Quiz
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}

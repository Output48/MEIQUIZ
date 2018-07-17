using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using System.Net;
using System.IO;
using Ukity;

namespace Quiz.Views
{
	public partial class ViewMulti : ViewController
	{
		public ViewMulti()
		{
			InitializeComponent();

			SendQuizData();

			GetUsers();

			music = new SoundController(Properties.Resources.menu_sound);
			music.Play();

			TypeMessage.Write(labelTypeMessage, "ロビーです。\n対戦相手を選んでください。");
		}

		private void buttonBallte_Click(object sender, EventArgs e)
		{
			DelUser();

			ChangePage("ViewQuiz");
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			DelUser();

			ChangePage("ViewMenu");
		}

		private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string user = dgvUserList.SelectedRows[0].Cells[0].Value.ToString();

			GetUsers(user);
		}

		private void GetUsers(string name = "")
		{
			try
			{
				string url = "http://[データ取得用URL]";

				Encoding enc = Encoding.GetEncoding("Shift_JIS");

				WebClient wc = new WebClient();
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] resData;
				if (name == "")
				{
					resData = wc.DownloadData(url);

					string temp = enc.GetString(resData);
					string[] users = temp.Split(new string[] { "\r\n" }, StringSplitOptions.None);

					StreamReader srC = new StreamReader(".\\Config.txt", enc);

					string user = srC.ReadLine();
					srC.Close();

					dgvUserList.Columns.Add("User", "User");
					dgvUserList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

					for (int i = 0; i < users.Length; i++)
					{
						if (users[i] != "" && users[i] != user)
						{
							dgvUserList.Rows.Add();
							dgvUserList[0, i].Value = users[i];
						}
					}
				}
				else
				{
					string postData = "user=" + name;
					byte[] postDataBytes = enc.GetBytes(postData);

					resData = wc.UploadData(url, postDataBytes);

					string temp = enc.GetString(resData);

					StreamWriter sw = new StreamWriter("Multi.csv", false, enc);
					sw.Write(temp);
					sw.Close();
				}
				wc.Dispose();
			}
			catch(Exception)
			{

			}
		}

		private bool SendQuizData()
		{
			try
			{
				string url = "http://[データ送信用URL]";

				Encoding enc = Encoding.GetEncoding("Shift_JIS");

				StreamReader srQ = new StreamReader(".\\Quiz.csv", enc);
				StreamReader srC = new StreamReader(".\\Config.txt", enc);

				string user = srC.ReadLine();
				srC.Close();

				string postData = "user=" + user + "&quiz=" + WebUtility.UrlEncode(srQ.ReadToEnd());
				byte[] postDataBytes = enc.GetBytes(postData);
				srQ.Close();

				WebClient wc = new WebClient();
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] resData = wc.UploadData(url, postDataBytes);
				wc.Dispose();

				return true;
			}
			catch(Exception)
			{
				return false;
			}
		}

		private void DelUser()
		{
			try
			{
				string url = "http://[データ削除用URL]";

				Encoding enc = Encoding.GetEncoding("Shift_JIS");

				WebClient wc = new WebClient();
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				byte[] resData;

				StreamReader srC = new StreamReader(".\\Config.txt", enc);

				string user = srC.ReadLine();
				srC.Close();

				string postData = "user=" + user;
				byte[] postDataBytes = enc.GetBytes(postData);

				resData = wc.UploadData(url, postDataBytes);

				wc.Dispose();
			}
			catch (Exception)
			{

			}
		}

		private void ViewMulti_Paint(object sender, PaintEventArgs e)
		{
			dgvUserList.CurrentCell = null;
		}
	}
}

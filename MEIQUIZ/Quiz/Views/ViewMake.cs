using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ukity;

namespace Quiz.Views
{
	/// <summary>
	/// クイズ作成ビュー
	/// </summary>
	public partial class ViewMake : ViewController
	{
		/// <summary>
		/// クイズデータ
		/// </summary>
		private DataTable quiz = null;

		/// <summary>
		/// 新規追加フラグ
		/// </summary>
		private bool newFlag = false;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ViewMake()
		{
			InitializeComponent();

			quiz = Datas.Question.GetData();

			dgvQuestionList.DataSource = quiz;
			dgvQuestionList.Columns[0].Visible = false;
			dgvQuestionList.Columns[2].Visible = false;
			dgvQuestionList.Columns[3].Visible = false;
			dgvQuestionList.Columns[4].Visible = false;
			dgvQuestionList.Columns[5].Visible = false;
			dgvQuestionList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			music = new SoundController(Properties.Resources.menu_sound);
			music.Play();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			ChangePage("ViewMenu");
		}

		private void dgvQuestionList_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvQuestionList.SelectedRows.Count > 0)
			{
				newFlag = false;
				textBoxQuestion.Text = dgvQuestionList[1, dgvQuestionList.SelectedRows[0].Index].Value.ToString();
				textBoxAnswer.Text = dgvQuestionList[2, dgvQuestionList.SelectedRows[0].Index].Value.ToString();
				textBoxChoice1.Text = dgvQuestionList[3, dgvQuestionList.SelectedRows[0].Index].Value.ToString();
				textBoxChoice2.Text = dgvQuestionList[4, dgvQuestionList.SelectedRows[0].Index].Value.ToString();
				textBoxChoice3.Text = dgvQuestionList[5, dgvQuestionList.SelectedRows[0].Index].Value.ToString();
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				Encoding enc = Encoding.GetEncoding("Shift_JIS");
				StreamWriter sr = new StreamWriter("Quiz.csv", false, enc);

				int colCount = quiz.Columns.Count;
				int lastColIndex = colCount - 1;

				for (int i = 0; i < colCount; i++)
				{
					string field = quiz.Columns[i].Caption;
					field = "\"" + field + "\"";
					sr.Write(field);

					if (lastColIndex > i)
					{
						sr.Write(',');
					}
				}
				sr.Write("\r\n");

				int no = 0;
				for (int i = 0; i < quiz.Rows.Count; i++)
				{
					DataRow row = quiz.Rows[i];
					if (!newFlag && dgvQuestionList.SelectedRows[0].Index == i)
					{
						row[1] = textBoxQuestion.Text;
						row[2] = textBoxAnswer.Text;
						row[3] = textBoxChoice1.Text;
						row[4] = textBoxChoice2.Text;
						row[5] = textBoxChoice3.Text;
					}

					for (int j = 0; j < colCount; j++)
					{
						string field = row[j].ToString();
						field = "\"" + field + "\"";
						sr.Write(field);

						if (lastColIndex > j)
						{
							sr.Write(',');
						}
					}
					sr.Write("\r\n");

					if (int.Parse(row[0].ToString()) > no)
					{
						no = int.Parse(row[0].ToString());
					}
				}

				if (newFlag)
				{
					DataRow row = quiz.Rows[0];
					row[0] = no++.ToString();
					row[1] = textBoxQuestion.Text;
					row[2] = textBoxAnswer.Text;
					row[3] = textBoxChoice1.Text;
					row[4] = textBoxChoice2.Text;
					row[5] = textBoxChoice3.Text;

					for (int j = 0; j < colCount; j++)
					{
						string field = row[j].ToString();
						field = "\"" + field + "\"";
						sr.Write(field);

						if (lastColIndex > j)
						{
							sr.Write(',');
						}
					}
					sr.Write("\r\n");
				}

				sr.Close();

				quiz = Datas.Question.GetData();

				dgvQuestionList.DataSource = quiz;

				MessageBox.Show("保存しました");
			}
			catch(Exception)
			{
				MessageBox.Show("保存に失敗しました");
			}
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			newFlag = true;
			textBoxQuestion.Text = "";
			textBoxAnswer.Text = "";
			textBoxChoice1.Text = "";
			textBoxChoice2.Text = "";
			textBoxChoice3.Text = "";
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				Encoding enc = Encoding.GetEncoding("Shift_JIS");
				StreamWriter sw = new StreamWriter("Quiz.csv", false, enc);

				int colCount = quiz.Columns.Count;
				int lastColIndex = colCount - 1;

				for (int i = 0; i < colCount; i++)
				{
					string field = quiz.Columns[i].Caption;
					field = "\"" + field + "\"";
					sw.Write(field);

					if (lastColIndex > i)
					{
						sw.Write(',');
					}
				}
				sw.Write("\r\n");

				int no = 0;
				for (int i = 0; i < quiz.Rows.Count; i++)
				{
					DataRow row = quiz.Rows[i];
					if (!newFlag && dgvQuestionList.SelectedRows[0].Index == i)
					{
						continue;
					}

					for (int j = 0; j < colCount; j++)
					{
						string field = row[j].ToString();
						field = "\"" + field + "\"";
						sw.Write(field);

						if (lastColIndex > j)
						{
							sw.Write(',');
						}
					}
					sw.Write("\r\n");

					if (int.Parse(row[0].ToString()) > no)
					{
						no = int.Parse(row[0].ToString());
					}
				}

				if (newFlag)
				{
					DataRow row = quiz.Rows[0];
					row[0] = no++.ToString();
					row[1] = textBoxQuestion.Text;
					row[2] = textBoxAnswer.Text;
					row[3] = textBoxChoice1.Text;
					row[4] = textBoxChoice2.Text;
					row[5] = textBoxChoice3.Text;

					for (int j = 0; j < colCount; j++)
					{
						string field = row[j].ToString();
						field = "\"" + field + "\"";
						sw.Write(field);

						if (lastColIndex > j)
						{
							sw.Write(',');
						}
					}
					sw.Write("\r\n");
				}

				sw.Close();

				quiz = Datas.Question.GetData();

				dgvQuestionList.DataSource = quiz;

				MessageBox.Show("削除しました");
			}
			catch (Exception)
			{
				MessageBox.Show("削除に失敗しました");
			}
		}
	}
}

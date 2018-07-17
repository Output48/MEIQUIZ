using System;
using System.Data;
using System.Data.OleDb;

namespace Quiz.Datas
{
	public class Question
	{
		/// <summary>
		/// クイズデータ取得
		/// </summary>
		/// <param name="file">ファイル名</param>
		/// <returns>クイズデータ</returns>
		public static DataTable GetData(string file = "")
		{
			try
			{
				DataTable ret = new DataTable();

				OleDbConnection con = new OleDbConnection(
					"Provider=Microsoft.Jet.OLEDB.4.0;"
					+ "Data Source=.\\; "
					+ "Extended Properties=\"Text;HDR=YES;FMT=Delimited\"");

				if (file == "")
				{
					file = "Quiz.csv";
				}

				OleDbCommand command = new OleDbCommand(
					"SELECT * FROM [" + file + "]",
					con);

				OleDbDataAdapter adapter = new OleDbDataAdapter(command);

				adapter.Fill(ret);

				return ret;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}

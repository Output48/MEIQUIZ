using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Datas
{
	public class Result
	{
		private int _correct = 0;
		/// <summary>
		/// 正解数
		/// </summary>
		public int Correct
		{
			get
			{
				return _correct;
			}
			set
			{
				_correct = value;
			}
		}

		private int _question = 0;
		/// <summary>
		/// 質問数
		/// </summary>
		public int Question
		{
			get
			{
				return _question;
			}
			set
			{
				_question = value;
			}
		}

		private int _totalTime = 0;
		/// <summary>
		/// 総回答時間
		/// </summary>
		public int TotalTime
		{
			get
			{
				return _totalTime;
			}
			set
			{
				_totalTime = value;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zmeyika
{
	public class Score
	{
		private int score;
		private int level;
		public int speed;
		public Score(int score, int level)
		{
			this.score = score;
			this.level = level;
		}
		public bool ScoreUp() //метод, который увеличивает баллы
		{
			score += 1;
			if (score % 10 == 0)
			{
				level += 1;
				return true;
			}
			else { return false; }
		}
		public bool ScoreDown() //метод, который уменьшает баллы
		{
			score -= 1;
			if (score % 10 == 0)
			{
				level -= 1;
				return true;
			}
			else { return false; }
		}
		public void ScoreWrite()
		{
			Console.SetCursorPosition(90, 10);
			Console.WriteLine("Score:" + score.ToString());
			Console.SetCursorPosition(90, 11);
			Console.WriteLine("Level1:" + level.ToString());
		}
	}
}

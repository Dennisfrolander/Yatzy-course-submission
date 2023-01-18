namespace Yatzy.Tests
{
	public class YatzyCalculatingPointMethods
	{
		private List<int> ettSexList = new();
		public int ettTillSex(int v1, int v2, int v3, int v4, int v5)
		{
			int[] array = { v1, v2, v3, v4, v5 };


			for (int i = 0; i < 5; i++)
			{
				if (!ettSexList.Contains(array[i]))
				{
					ettSexList.Add(array[i]);
				}
			}
			for (int i = 0; i < ettSexList.Count; i++)
			{
				int counter = 0;
				for (int j = 0; j < 5; j++)
				{
					if (ettSexList[i] == array[j])
					{
						counter++;
					}
				}
				if (counter > 0)
				{
					ettSexList[i] *= counter;
				}
			}
			return ettSexList[0];
		}

		private List<int> pairChecker = new();
		public int Par(int v1, int v2, int v3, int v4, int v5)
		{
			int[] array = { v1, v2, v3, v4, v5 };
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (array[i] == array[j])
					{
						diceCount++;
					}
					if (diceCount == 2)
					{
						pairChecker.Add(array[i]);
					}
				}
			}
			if (pairChecker.Count > 0)
			{
				return pairChecker.Max() * 2;
			}
			else
			{
				return 0;
			}
		}
	}
}

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

		public int Triss(int v1, int v2, int v3, int v4, int v5)
		{
			int[] array = { v1, v2, v3, v4, v5 };
			int test = 0;
			for (int j = 0; j < 5; j++)
			{
				int diceCount = 0;
				for (int k = 0; k < 5; k++)
				{
					if (array[j] == array[k])
					{
						diceCount++;

					}
					if (diceCount == 3)
					{
						test = array[j] * 3;
						break;
					}
				}

			}
			return test;
		}
		public int fyrtal(int v1, int v2, int v3, int v4, int v5)
		{
			int resultat = 0;
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
					if (diceCount == 4)
					{
						resultat = array[j] * 4;
						break;
					}
				}
			}
			return resultat;
		}
		public int kåk(int v1, int v2, int v3, int v4, int v5)
		{
			int[] array = { v1, v2, v3, v4, v5 };
			bool fullHouse = false;
			int fullHouseValue = 0;
			int points = 0;
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (array[i] == array[j])
					{
						diceCount++;
					}
					if (diceCount == 3)
					{
						fullHouseValue = array[i];
						fullHouse = true;
						break;
					}
				}
			}
			if (fullHouse)
			{
				for (int i = 0; i < 5; i++)
				{
					int diceCount = 0;
					for (int j = 0; j < 5; j++)
					{
						if (array[i] == array[j] && array[i] != fullHouseValue)
						{
							diceCount++;
						}
					}
					if (diceCount == 2)
					{
						fullHouseValue *= 3;
						fullHouseValue += (array[i] * 2);
						points = fullHouseValue;
						break;
					}
				}
			}
			return points;
		}
		public int tvåpar(int v1, int v2, int v3, int v4, int v5)
		{
			int[] array = { v1, v2, v3, v4, v5 };
			int firstPairValue = 0;
			int secondPairValue = 0;
			int totSum = 0;
			bool pairCheck = false;
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (array[i] == array[j])
					{
						diceCount++;

					}
				}
				if (diceCount == 2)
				{
					firstPairValue = array[i];
					pairCheck = true;
				}
				else if (diceCount == 3)
				{
					firstPairValue = array[i];
					pairCheck = true;
				}
				else if (diceCount >= 4)
				{
					totSum = array[i] * 4;
					break;
				}
			}
			if (pairCheck)
			{
				for (int i = 0; i < 5; i++)
				{
					int diceCount = 0;
					for (int j = 0; j < 5; j++)
					{
						if (array[i] == array[j] && array[i] != firstPairValue)
						{
							diceCount++;
						}
					}
					if (diceCount == 2)
					{
						secondPairValue = array[i];
						totSum = firstPairValue + secondPairValue;
						totSum *= 2;
					}
					else if (diceCount == 3)
					{
						secondPairValue = array[i];
						totSum = firstPairValue + secondPairValue;
						totSum *= 2;
					}
				}
			}
			return totSum;
		}
		public int litenStege(int v1, int v2, int v3, int v4, int v5)
		{
			int point = 0;
			int[] array = { v1, v2, v3, v4, v5 };
			for (int i = 0; i < 5; i++)
			{

				if (!pairChecker.Contains(array[i]))
				{
					pairChecker.Add(array[i]);
					point += array[i];
				}
			}
			if (point == 15 && pairChecker.Count == 5)
			{
				return point;
			}
			else
			{
				return 0;
			}
		}
		public int storStege(int v1, int v2, int v3, int v4, int v5)
		{
			int point = 0;
			int[] array = { v1, v2, v3, v4, v5 };
			for (int i = 0; i < 5; i++)
			{

				if (!pairChecker.Contains(array[i]))
				{
					pairChecker.Add(array[i]);
					point += array[i];
				}
			}
			if (point == 20 && pairChecker.Count == 5)
			{
				return point;
			}
			else
			{
				return 0;
			}
		}
		public int yatzy(int v1, int v2, int v3, int v4, int v5)
		{
			int point = 0;
			int[] array = { v1, v2, v3, v4, v5 };
			for (int i = 0; i < 5; i++)
			{
				int counter = 0;
				for (int k = 0; k < 5; k++)
				{

					if (array[i] == array[k])
					{
						counter++;
					}
				}
				if (counter == 5)
				{
					point = 50;
				}
			}
			return point;
		}
	}
}

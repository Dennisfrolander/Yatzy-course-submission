using Yatzy.Models;
namespace Yatzy.YatziMethods 
{ 
	public class CalculatingPoints
	{

		public void EttTillSex(List<int> savedDiceList, List<string> scoreboardPointName, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll, List<int> listOfNumber)
		{
			for (int i = 0; i < 5; i++)
			{

				if (!listOfNumber.Contains(savedDiceList[i]))
				{
					listOfNumber.Add(savedDiceList[i]);
				}
			}

			for (int i = 0; i < listOfNumber.Count; i++)
			{
				int counter = 0;
				for (int j = 0; j < 5; j++)
				{
					if (listOfNumber[i] == savedDiceList[j])
					{
						counter++;
					}
				}
				int index = listOfNumber[i];
				if (counter > 0 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[index - 1].Item1 == 0)
				{
					listOfNumber[i] *= counter;
					index = listOfNumber[i] / counter;

				}
				protokoll.Add(new Protokoll(listOfNumber[i], scoreboardPointName[index - 1], true, false));
			}
			listOfNumber.Clear();
		}
		public void Par(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll, List<int> listOfNumber)
		{
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (savedDiceList[i] == savedDiceList[j])
					{
						diceCount++;
					}
					if (diceCount == 2)
					{
						listOfNumber.Add(savedDiceList[i]);
					}
				}
			}
			if (listOfNumber.Count > 0 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[8].Item1 == 0)
			{
				protokoll.Add(new Protokoll(listOfNumber.Max() * 2, "1 par", true, false));
			}
			listOfNumber.Clear();
		}

		public void TvåPar(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{
			int firstPairValue = 0;
			bool pairCheck = false;
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (savedDiceList[i] == savedDiceList[j])
					{
						diceCount++;
					}
				}
				if (diceCount == 2)
				{
					firstPairValue = savedDiceList[i];
					pairCheck = true;
				}
				else if (diceCount == 3)
				{
					firstPairValue = savedDiceList[i];
					pairCheck = true;
				}
				else if (diceCount >= 4 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[9].Item1 == 0)
				{
					protokoll.Add(new Protokoll(savedDiceList[i] * 4, "2 par", true, false));
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
						if (savedDiceList[i] == savedDiceList[j] && savedDiceList[i] != firstPairValue)
						{
							diceCount++;
						}
					}
					int secondPairValue;
					if (diceCount == 2 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[9].Item1 == 0)
					{
						secondPairValue = savedDiceList[i];
						firstPairValue += secondPairValue;
						protokoll.Add(new Protokoll(firstPairValue * 2, "2 par", true, false));
						break;
					}
					else if (diceCount == 3 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[9].Item1 == 0)
					{
						secondPairValue = savedDiceList[i];
						firstPairValue += secondPairValue;
						protokoll.Add(new Protokoll(firstPairValue * 2, "2 par", true, false));
						break;
					}
				}
			}
		}

		public void Triss(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (savedDiceList[i] == savedDiceList[j])
					{
						diceCount++;
					}
				}
				if (diceCount >= 3 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[10].Item1 == 0)
				{
					protokoll.Add(new Protokoll(savedDiceList[i] * 3, "Triss", true, false));
					break;
				}
			}
		}

		public void Fyrtal(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (savedDiceList[i] == savedDiceList[j])
					{
						diceCount++;
					}
				}
				if (diceCount >= 4 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[11].Item1 == 0)
				{
					protokoll.Add(new Protokoll(savedDiceList[i] * 4, "Fyrtal", true, false));
					break;
				}
			}
		}

		public void LitenStege(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll, List<int> listOfNumber)
		{
			int points = 0;
			for (int i = 0; i < 5; i++)
			{
				if (!listOfNumber.Contains(savedDiceList[i]))
				{
					listOfNumber.Add(savedDiceList[i]);
					points += savedDiceList[i];
				}
			}
			if (points == 15 && listOfNumber.Count == 5 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[12].Item1 == 0)
			{
				protokoll.Add(new Protokoll(points, "Liten stege", true, false));
			}
			listOfNumber.Clear();
		}


		public void StorStege(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll, List<int> listOfNumber)
		{
			int points = 0;
			for (int i = 0; i < 5; i++)
			{
				if (!listOfNumber.Contains(savedDiceList[i]))
				{
					listOfNumber.Add(savedDiceList[i]);
					points += savedDiceList[i];
				}
			}
			if (points == 20 && listOfNumber.Count == 5 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[13].Item1 == 0)
			{
				protokoll.Add(new Protokoll(points, "Stor stege", true, false));
			}
			listOfNumber.Clear();
		}







		public void Kåk(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{
			bool fullHouse = false;
			int fullHouseValue = 0;
			for (int i = 0; i < 5; i++)
			{
				int diceCount = 0;
				for (int j = 0; j < 5; j++)
				{
					if (savedDiceList[i] == savedDiceList[j])
					{
						diceCount++;
					}
					if (diceCount == 3)
					{
						fullHouseValue = savedDiceList[i];
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
						if (savedDiceList[i] == savedDiceList[j] && savedDiceList[i] != fullHouseValue)
						{
							diceCount++;
						}
					}
					if (diceCount == 2 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[14].Item1 == 0)
					{
						fullHouseValue *= 3;
						fullHouseValue += (savedDiceList[i] * 2);
						protokoll.Add(new Protokoll(fullHouseValue, "Kåk", true, false));
						break;
					}
				}
			}
		}
	}
}
using Yatzy.Models;
namespace Yatzy.YatziMethods 
{ 
	public class CalculatingPoints
	{
		/*Tar fram alla enskilda nummer sedan jämför antalet av varje enskilt nummer och multiplicerar numret med antal och
		om den aktiva spelarens poäng är 0. Läggs poängen in i protokoll*/
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
				if (counter > 0)
				{
					listOfNumber[i] *= counter;
					index = listOfNumber[i] / counter;

				}
				if(listOfAddedPlayers[indexOfCurrentPlayer].playerScore[index - 1].Item1 == 0)
				{
					protokoll.Add(new Protokoll(listOfNumber[i], scoreboardPointName[index - 1], true, false));
				}
				
			}
			listOfNumber.Clear();
		}
		/* Kontrollerar ifall det finns två av samma tal, om det är fallet läggs talet in i en ny lista. 
		 Om den aktiva spelarens Par poäng är 0 så läggs den största siffran multiplicerat med 2 från den nya listan in i protokollet*/
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
		/* Likt par funktionen kontrollrar den ifall det finns fler av samma tal, om det finns 4 eller fler av samma tal
		 * så multiplceras det talet med 4 och läggs in i protokollet, ifall det finns 2 eller 3 av samma tal
		 blir paircheck true och då letar funktionen efter ännu ett par som inte är av samma värde som det första. */ 
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
		/* Kontrollerar ifall det finns 3 eller fler av samma tal, 
		 * ifall det finns så multipliceras talet med 3 och läggs in i protokollet om den aktiva spelarens poäng är 0*/ 
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
		/* Kontrollerar ifall det finns 4 eller fler av samma tal, 
		 * ifall det finns så multipliceras talet med 4 och läggs in i protokollet om den aktiva spelarens poäng är 0*/
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
		/* Kontrollerar att alla tal är av olika värden, ifall alla tal är olika och total summan blir 15 så läggs det 
		 in i protokollet om den aktiva spelares poäng är 0*/ 
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

		/* Kontrollerar att alla tal är av olika värden, ifall alla tal är olika och total summan blir 20 så läggs det 
		 in i protokollet om den aktiva spelares poäng är 0*/
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
		/* Kontrollerar ifall det finns 3 tal med samma värde, om det finns så sparas den siffran och blir fullHouse true och då letar den efter 
		 ett par som inte är av samma värde som den sparade siffran. Om det hittas ett par så multiplicerars siffran 
		 från trissen med 3, och sedan adderas med paret.
		 Då läggs det in i protokollet om den aktiva spelarens poäng är 0. */
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
		/* Adderar alla tal med varandra och om den aktiva spelarens poäng är 0, så läggs totalsumman in i protokollet*/
		public void Chans(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{
			int points = 0;
			for (int i = 0; i < 5; i++)
			{
				points += savedDiceList[i];
			}
			if (listOfAddedPlayers[indexOfCurrentPlayer].playerScore[15].Item1 == 0)
			{
				protokoll.Add(new Protokoll(points, "Chans", true, false));
			}
		}
		/* Kontrollerar ifall alla nummer är av samma värde, om den aktiva spelarens poäng är 0 så läggs 50 poäng in i protokollet*/ 
		public void Yatzy(List<int> savedDiceList, List<Player> listOfAddedPlayers, int indexOfCurrentPlayer, List<Protokoll> protokoll)
		{

			for (int i = 0; i < 5; i++)
			{
				int counter = 0;
				for (int j = 0; j < 5; j++)
				{

					if (savedDiceList[i] == savedDiceList[j])
					{
						counter++;
					}
				}
				if (counter == 5 && listOfAddedPlayers[indexOfCurrentPlayer].playerScore[16].Item1 == 0)
				{
					protokoll.Add(new Protokoll(50, "YATZY", true, false));
					break;
				}
			}
		}
	}
}
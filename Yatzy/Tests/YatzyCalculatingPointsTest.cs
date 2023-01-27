using Xunit;
using Yatzy.Models;
using Yatzy.YatziMethods;

namespace Yatzy.Tests

{
	public class YatzyCalculatingPointsTest

	{
		[Fact]
		public void EttTillSex_Test()
		{
			// Arrange
			var savedDiceList = new List<int> { 2, 3, 2, 5, 2 };
			var scoreboardPointName = new List<string> { "Ettor", "Tvåor", "Treor", "Fyror", "Femmor", "Sexor" };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var listOfNumber = new List<int>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.EttTillSex(savedDiceList, scoreboardPointName, listOfAddedPlayers, indexOfCurrentPlayer, protokoll, listOfNumber);

			// Assert
			Assert.Equal(6, protokoll[0].Points);
			Assert.Equal(3, protokoll[1].Points);
			Assert.Equal(5, protokoll[2].Points);
			Assert.Equal("Tvåor", protokoll[0].Choice);
			Assert.Equal("Treor", protokoll[1].Choice);
			Assert.Equal("Femmor", protokoll[2].Choice);
		}

		[Theory]
		[InlineData(5, 5, 5, 5, 5, 10)]
		[InlineData(1, 2, 1, 2, 1, 4)]
		[InlineData(4, 6, 6, 4, 5, 12)]
		public void Par_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var listOfNumber = new List<int>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Par(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll, listOfNumber);

			// Assert
			Assert.Equal(expected, protokoll[0].Points);
		}


		[Theory]
		[InlineData(1, 1, 1, 2, 2, 6)]
		[InlineData(6, 2, 2, 2, 6, 16)]
		[InlineData(2, 2, 2, 2, 2, 8)]
		[InlineData(2, 1, 6, 3, 6, 0)]
		[InlineData(4, 3, 3, 4, 4, 14)]
		[InlineData(4, 4, 4, 5, 4, 16)]
		public void TvåPar_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.TvåPar(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}

		[Theory]
		[InlineData(3, 3, 4, 4, 4, 12)]
		[InlineData(5, 3, 5, 4, 5, 15)]
		[InlineData(3, 3, 3, 4, 4, 9)]
		[InlineData(5, 2, 2, 2, 5, 6)]
		[InlineData(1, 1, 1, 6, 6, 3)]
		[InlineData(6, 6, 2, 2, 5, 0)]
		public void Triss_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Triss(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}


		[Theory]
		[InlineData(1, 1, 1, 1, 1, 4)]
		[InlineData(2, 2, 2, 2, 2, 8)]
		[InlineData(3, 3, 3, 3, 3, 12)]
		[InlineData(4, 4, 4, 4, 4, 16)]
		[InlineData(5, 5, 5, 5, 5, 20)]
		[InlineData(3, 2, 3, 3, 6, 0)]
		[InlineData(6, 6, 6, 6, 3, 24)]
		public void Fyrtal_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Fyrtal(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}


		[Theory]
		[InlineData(1, 3, 5, 2, 4, 15)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(1, 2, 3, 5, 4, 15)]
		[InlineData(1, 2, 3, 6, 4, 0)]
		[InlineData(6, 5, 4, 3, 2, 0)]
		public void LitenStege_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();
			var listOfNumber = new List<int>();

			// Act
			YatzyCalculator.LitenStege(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll, listOfNumber);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}

		[Theory]
		[InlineData(6, 3, 5, 2, 4, 20)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(6, 2, 3, 5, 4, 20)]
		[InlineData(1, 2, 3, 6, 4, 0)]
		[InlineData(6, 5, 4, 3, 2, 20)]
		[InlineData(1, 5, 4, 3, 2, 0)]
		public void StorStege_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();
			var listOfNumber = new List<int>();

			// Act
			YatzyCalculator.StorStege(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll, listOfNumber);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}


		[Theory]
		[InlineData(1, 1, 1, 1, 1, 0)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(1, 1, 1, 2, 2, 7)]
		[InlineData(6, 6, 6, 5, 5, 28)]
		[InlineData(3, 3, 3, 4, 4, 17)]
		public void Kåk_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Kåk(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}


		[Theory]
		[InlineData(1, 1, 1, 1, 1, 5)]
		[InlineData(2, 6, 3, 3, 6, 20)]
		[InlineData(1, 1, 1, 2, 2, 7)]
		[InlineData(6, 6, 6, 5, 5, 28)]
		[InlineData(1, 2, 3, 4, 5, 15)]
		[InlineData(2, 3, 4, 5, 6, 20)]
		public void Chans_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Chans(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			Assert.Equal(expected, protokoll[0].Points);
		}

		[Theory]
		[InlineData(1, 1, 1, 1, 1, 50)]
		[InlineData(2, 2, 2, 2, 2, 50)]
		[InlineData(3, 3, 3, 3, 3, 50)]
		[InlineData(4, 4, 4, 4, 4, 50)]
		[InlineData(5, 5, 5, 5, 5, 50)]
		[InlineData(6, 6, 6, 6, 6, 50)]
		[InlineData(1, 1, 1, 2, 2, 0)]
		[InlineData(6, 6, 6, 5, 5, 0)]
		public void Yatzy_Test(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			// Arrange
			var savedDiceList = new List<int> { valueA, valueB, valueC, valueD, valueF };
			var listOfAddedPlayers = new List<Player> { new Player("Player 1 firstname", "Player 1 lastname") };
			int indexOfCurrentPlayer = 0;
			var protokoll = new List<Protokoll>();
			var YatzyCalculator = new CalculatingPoints();

			// Act
			YatzyCalculator.Yatzy(savedDiceList, listOfAddedPlayers, indexOfCurrentPlayer, protokoll);

			// Assert
			if (protokoll.Count > 0)
			{
				Assert.Equal(expected, protokoll[0].Points);
			}
			else
			{
				Assert.Equal(expected, protokoll.Count);
			}
		}
	}
}

using Xunit;
using Yatzy.Models;

namespace Yatzy.Tests
{
	public class PlayerMethodsTest
	{
		public List<Player> PlayersListAdd = new();
		[Fact]
		public void AddPlayerTest()
		{
			var newPlayer = new PlayerMethods();
			string firstName = "Dennis";
			string lastName = "Frölander";
			bool expectedValue = false;

			newPlayer.AddPlayer("Dennis", "Frölander", PlayersListAdd);

			foreach (Player player in PlayersListAdd)
			{
				if (player.FirstName == firstName && player.LastName == lastName)
				{
					expectedValue = true;
				}
				else
				{
					expectedValue = false;
				}
			}

			Assert.True(expectedValue);
		}

		public List<Player> PlayersListRemove = new()
		{
			new Player("Dennis", "Frölander"),
			new Player("Niklas", "Andersson"),
			new Player("Hannes", "Nilsson"),
		};

		[Theory]
		[InlineData("Dennis", "Frölander", true)]
		[InlineData("Hannes", "Nilsson", true)]
		[InlineData("Niklas", "Andersson", true)]

		public void RemovePlayerTest(string firstName, string lastName, bool expectedValue)
		{
			var removePlayer = new PlayerMethods();
			foreach (Player player in PlayersListRemove)
			{
				if (player.FirstName == firstName && player.LastName == lastName)
				{
					removePlayer.RemovePlayer(firstName, lastName, PlayersListRemove);
					expectedValue = true;
					break;
				}
				else
				{
					expectedValue = false;
				}
			}


			Assert.True(expectedValue);
		}
	}
}

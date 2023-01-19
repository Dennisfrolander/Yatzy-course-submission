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
	}
}

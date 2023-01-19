using Yatzy.Models;

namespace Yatzy.Tests
{
	public class PlayerMethods
	{
		public void AddPlayer(string firstName, string lastName, List<Player> PlayersList)
		{
			if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
			{
				PlayersList.Add(new Player(firstName, lastName));
			}
		}
	}
}

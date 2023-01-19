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

		public void RemovePlayer(string firstName, string lastName, List<Player> PlayersList)
		{
			var playersCopy = PlayersList.ToList();
			string errorMessageIfWrongPlayer = "";
			foreach (var player in playersCopy)
			{

				if (player.FirstName == firstName && player.LastName == lastName)
				{
					PlayersList.Remove(player);
				}
				else
				{
					errorMessageIfWrongPlayer = $"Player does not exist";
				}
			}
		}
	}
}

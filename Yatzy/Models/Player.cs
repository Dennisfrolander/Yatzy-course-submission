namespace Yatzy.Models
{
	public class Player
	{
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";

		public static int NumberOfPlayers = 0;
		public string NewPlayer { get; }


		public int AntalKast { get; set; }

		public List<dynamic> playerScore { get; set; }


		public Player(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
			NewPlayer = NumberOfPlayers.ToString();
			NumberOfPlayers++;
			AntalKast = 3;
			playerScore = new List<dynamic>()
			{
			(0,"Ettor"),
			(0,"Tvåor"),
			(0,"Treor"),
			(0,"Fyror"),
			(0, "Femmor"),
			(0, "Sexor"),
			(0, "Bonus(63)"),
			(0, "Summa"),
			(0, "1 par"),
			(0, "2 par"),
			(0, "Triss"),
			(0, "Fyrtal"),
			(0, "Liten stege"),
			(0, "Stor stege"),
			(0, "Kåk"),
			(0, "Chans"),
			(0, "YATZY"),
			(0, "Total summa")
			};

		}
	}
}
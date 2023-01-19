namespace Yatzy.Models
{
	public class Player
	{
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int AntalKast { get; set; }
		public List<dynamic> playerScore { get; set; }

		private static readonly List<string> list = new()
		{
			"Ettor",
			"Tvåor",
			"Treor",
			"Fyror",
			"Femmor",
			"Sexor",
			"Bonus(63)",
			"Summa",
			"1 par",
			"2 par",
			"Triss",
			"Fyrtal",
			"Liten stege",
			"Stor stege",
			"Kåk",
			"Chans",
			"YATZY",
			"Total summa",
		};

		public static List<string> ScoreBoardPoints = list;
		public Player(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
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
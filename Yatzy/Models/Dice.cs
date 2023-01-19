namespace Yatzy.Models
{
	public class Dice
	{
		private Random rand = new Random();
		public int currentRoll { get; set; }
		public string SaveRoll { get; set; } = "";
		public bool currentRollBool { get; set; }

		public int RollDice()
		{
			currentRoll = rand.Next(1, 7);
			return currentRoll;
		}

	}
}

namespace Yatzy.Models
{
	public class Protokoll
	{
		public int Points { get; set; }
		public string Choice { get; set; }
		public bool Check { get; set; }
		public bool Submit { get; set; }

		public Protokoll(int point, string val, bool check, bool submit)
		{
			this.Points = point;
			this.Choice = val;
			this.Check = check;
			this.Submit = submit;
		}
	}
}

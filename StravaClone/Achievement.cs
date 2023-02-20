namespace StravaClone
{
	public class Achievement
	{
		public enum Rank
		{
			Gold,
			Silver,
			Bronze
		}

		public string Sport { get; set; }
		public double Distance { get; set; }
		public double Elevation { get; set; }
		public Rank Grade { get; set; }

		public void AnalyzeEffort()
		{

		}

		public void YourResults()
		{

		}
	}
}

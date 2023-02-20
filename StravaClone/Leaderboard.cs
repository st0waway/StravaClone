namespace StravaClone
{
	public class Leaderboard
	{
		public static void GetLeaderboard()
		{
			var leaders = new Dictionary<string, string>()
			{
				{ "First", "Tom" },
				{ "Second", "Bob" },
				{ "Third", "Scott" }
			};

			foreach (var leader in leaders)
			{
				Console.WriteLine($"{leader.Key} + {leader.Value}");
			}
		}
	}
}

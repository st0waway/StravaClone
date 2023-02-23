namespace StravaClone
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Leaderboard.GetLeaderboard();

			var user = new User()
			{
				FirstName = "John",
				LastName = "Doe,",
				Email = "johndoe@gmail.com",
				Password = "hgf123",
				Age = 20
			};
			
			var activity = new Activity()
			{	
				User = user,
				DateTime = DateTime.Today,
				Location = "Chisinau",
				ActivityName = "Evening cycling run",
			};

			var achievement = new Achievement()
			{
				Sport = "Cycling",
				Distance = 100,
				Elevation = 10,
				Grade = Achievement.Rank.Gold
			};

			activity.Achievements = new List<Achievement>(){achievement};
		}
	}
}
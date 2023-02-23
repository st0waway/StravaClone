using System.Security.Cryptography.X509Certificates;

namespace StravaClone
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Leaderboard.GetLeaderboard();

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

			activity.Achievements = new List<Achievement>() { achievement };


			var users = new List<User>
			{
				new User()
				{
					FirstName = "John",
					LastName = "Doe,",
					Email = "johndoe@gmail.com",
					Password = "hgf123",
					Age = 16
				},
				new User()
				{
					FirstName = "Dmitriy",
					LastName = "Rosca,",
					Email = "drosca@gmail.com",
					Password = "asd123zxc",
					Age = 70
				},
				new User()
				{
					FirstName = "Steven",
					LastName = "Hawk,",
					Email = "sh@gmail.com",
					Password = "zxcgfd34r",
					Age = 30
				}
			};

			OrderByAgeDelegate byAgeDelegate = new(OrderByAge);
			var sortedUsers = byAgeDelegate(users);
			Console.WriteLine("sort by age");
			foreach (var sortedUser in sortedUsers)
			{
				Console.WriteLine($"{sortedUser.FirstName} - {sortedUser.Age}");
			}

			GetTeensDelegate teensDelegate = new(GetTeens);
			var teens = teensDelegate(users);
			Console.WriteLine("teens");
			foreach (var teen in teens)
			{
				Console.WriteLine($"{teen.FirstName} - {teen.Age}");
			}

			GetAdultsDelegate adultsDelegate = new(GetAdults);
			var adults = adultsDelegate(users);
			Console.WriteLine("adults");
			foreach (var adult in adults)
			{
				Console.WriteLine($"{adult.FirstName} - {adult.Age}");
			}

			GetSeniorsDelegate seniorsDelegate = new(GetSeniors);
			var seniors = seniorsDelegate(users);
			Console.WriteLine("seniors");
			foreach (var senior in seniors)
			{
				Console.WriteLine($"{senior.FirstName} - {senior.Age}");
			}

			
			var emails = users.Select(e => e.Email).ToList();
			Console.WriteLine("emails:");
			foreach (var email in emails)
			{
				Console.WriteLine(email);
			}

		}

		public delegate List<User> OrderByAgeDelegate(List<User> users);

		public delegate List<User> GetTeensDelegate(List<User> users);

		public delegate List<User> GetAdultsDelegate(List<User> users);

		public delegate List<User> GetSeniorsDelegate(List<User> users);

		public static List<User> OrderByAge(List<User> users)
		{
			return users.OrderBy(e => e.Age).ToList();
		}

		public static List<User> GetTeens(List<User> users)
		{
			return users.Where(e => e.Age < 18).ToList();
		}

		public static List<User> GetAdults(List<User> users)
		{
			return users.Where(e => e.Age >= 18).ToList();
		}
		public static List<User> GetSeniors(List<User> users)
		{
			return users.Where(e => e.Age >= 65).ToList();
		}
	}
}
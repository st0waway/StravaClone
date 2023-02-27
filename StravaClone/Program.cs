using StravaClone.Topics;

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


			//Create a collection
			var users = new List<User>
			{
				new User()
				{
					FirstName = "John",
					LastName = "Doe",
					Email = "johndoe@gmail.com",
					Password = "hgf123",
					Age = 16
				},
				new User()
				{
					FirstName = "Elena",
					LastName = "Rosca",
					Email = "drosca@gmail.com",
					Password = "asd123zxc",
					Age = 70
				},
				new User()
				{
					FirstName = "Steven",
					LastName = "Hawk",
					Email = "sh@gmail.com",
					Password = "zxcgfd34r",
					Age = 30
				}
			};

			//Manipulate collection via delegates
			var byAgeDelegate = new OrderByAgeDelegate(Delegates.OrderByAge);
			var sortedUsers = byAgeDelegate(users);
			Console.WriteLine("sort by age");
			foreach (var sortedUser in sortedUsers)
			{
				Console.WriteLine($"{sortedUser.FirstName} - {sortedUser.Age}");
			}

			var teensDelegate = new GetTeensDelegate(Delegates.GetTeens);
			var teens = teensDelegate(users);
			Console.WriteLine("teens");
			foreach (var teen in teens)
			{
				Console.WriteLine($"{teen.FirstName} - {teen.Age}");
			}

			var adultsDelegate = new GetAdultsDelegate(Delegates.GetAdults);
			var adults = adultsDelegate(users);
			Console.WriteLine("adults");
			foreach (var adult in adults)
			{
				Console.WriteLine($"{adult.FirstName} - {adult.Age}");
			}

			var seniorsDelegate = new GetSeniorsDelegate(Delegates.GetSeniors);
			var seniors = seniorsDelegate(users);
			Console.WriteLine("seniors");
			foreach (var senior in seniors)
			{
				Console.WriteLine($"{senior.FirstName} - {senior.Age}");
			}

			//Rewrite using anonymous functions
			GetArrayOfLastNamesDelegate getAndPrintLastNames = delegate(List<User> userList)
			{
				var lastNames = userList.Select(e => e.LastName).ToArray();
				Console.WriteLine("last names:");
				foreach (var lastName in lastNames)
				{
					Console.WriteLine(lastName);
				}
				
				return lastNames;
			};
			
			getAndPrintLastNames(users);

			//lambda expressions
			PrintPasswordsDelegate printPasswordsDelegate = (users) =>
			{
				Console.WriteLine("passwords:");
				foreach (var user in users)
				{
					Console.WriteLine(user.Password);
				}
			};

			printPasswordsDelegate(users);



			//Using extension methods on the collection
			var fistNames = users.GetFirstNames();
			Console.WriteLine("first names:");
			foreach (var fistName in fistNames)
			{
				Console.WriteLine(fistName);
			}

			//Using Select/where operators on the collection
			var emails = users.Select(e => e.Email).ToList();
			Console.WriteLine("emails:");
			foreach (var email in emails)
			{
				Console.WriteLine(email);
			}

		}
	}
}
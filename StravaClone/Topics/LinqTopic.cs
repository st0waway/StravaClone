namespace StravaClone.Topics
{
	public class LinqTopic
	{
		public static void DoOperations()
		{
			var users = new List<User>
			{
				new User()
				{
					ID = 1,
					FirstName = "John",
					LastName = "Doe",
					Email = "johndoe@gmail.com",
					Password = "hgf123",
					Age = 16
				},
				new User()
				{
					ID = 2,
					FirstName = "Elena",
					LastName = "Rosca",
					Email = "drosca@gmail.com",
					Password = "asd123zxc",
					Age = 70
				},
				new User()
				{
					ID = 3,
					FirstName = "Steven",
					LastName = "Hawk",
					Email = "sh@gmail.com",
					Password = "zxcgfd34r",
					Age = 30
				},
				new User()
				{
					ID = 4,
					FirstName = "Ana",
					LastName = "Ramura",
					Email = "aram@gmail.com",
					Password = "qwerasd",
					Age = 25
				},
				new User()
				{
					ID = 5,
					FirstName = "Ana",
					LastName = "Nejenari",
					Email = "nana@gmail.com",
					Password = "qwesdasf",
					Age = 30
				},

			};

			var numbers1 = new int[]
			{
				1, 1, 2, 1, 3, 4, 5, 4, 5, 1, 6
			};

			var numbers2 = new int[]
			{
				7, 5, 9, 8, 31, 12
			};

			var numbersText = new string[]
			{
				"one", "one", "two", "one", "three", "four", "five", "four", "five", "one", "six"
			};

			var seniors = users.Where(e => e.Age > 65);
			var firstTwo = users.Take(2);
			var lastFour = users.Skip(1);
			var firstTwoNumbers = numbers1.TakeWhile(e => e == 1);
			var noFives = numbers1.SkipWhile(e => e == 1);
			var distinctNumbers = numbers1.Distinct();
			var passwords = users.Select(e => e.Password);
			var joined = numbers1.Join(numbers2, 
																num1 => num1,
																num2 => num2,
																(num1, num2) => num1);
			var groupJoin = numbers1.Join(numbers2, 
																num1 => num1,
																num2 => num2,
																(num1, num2) => num1);
			var zip = numbers1.Zip(numbersText);
			var ordered = users.OrderBy(e => e.Age).ThenBy(e => e.ID);
			var desc = users.OrderByDescending(e => e.ID).ThenBy(e => e.Age);
			var reversedNumbers = numbers1.Reverse();
			var concat = numbers1.Concat(numbers2);
			var union = numbers1.Union(numbers2);
			var intersect = numbers1.Intersect(numbers2);
			var except = numbers1.Except(numbers2);
			var first = users.First(e => e.Age > 16);
			var firstOrDefault = users.FirstOrDefault(e => e.Age > 16);
			var last = users.Last(e => e.ID < 3);
			var lastOrDefault = users.LastOrDefault(e => e.ID > 3);




			Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
			foreach (var user in zip)
			{
				Console.WriteLine(lastOrDefault.FirstName);
			}

			Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

		}
	}
}

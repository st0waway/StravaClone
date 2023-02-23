namespace StravaClone
{
	public static class MyExtensions
	{
		public static string[] GetFirstNames(this List<User> users)
		{
			return users.Select(e => e.FirstName).ToArray();
		}
	}
}

namespace StravaClone
{
	public static class MyExtensions
	{
		public static string[] GetFirstNames(List<User> users)
		{
			return users.Select(e => e.FirstName).ToArray();
		}
	}
}

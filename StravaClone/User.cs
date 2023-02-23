namespace StravaClone
{
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int  Age { get; set; }
		public int ID { get; set; }
		public List<Activity>? Activity { get; set; }
		public User() { }

		public void CreateActivity()
		{

		}
	}
}

﻿namespace StravaClone
{
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public List<Activity>? Activity { get; set; }
		public User() { }

		public void CreateActivity()
		{

		}
	}
}

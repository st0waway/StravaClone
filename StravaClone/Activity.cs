namespace StravaClone
{
	public class Activity
	{
		public User User { get; set; }
		public DateTime DateTime { get; set; }
		public string Location { get; set; }
		public string ActivityName { get; set; }
		public List<Photos>? Photos { get; set; }
		public List<Achievement>? Achievements { get; set; }

		public Activity()
		{

		}

		public void Start()
		{

		}

		public void Stop()
		{

		}

		public void Like()
		{

		}

		public void Comment(string text)
		{

		}

		public void Share()
		{

		}
	}
}

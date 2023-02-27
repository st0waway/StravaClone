namespace StravaClone.Topics
{
    public delegate List<User> OrderByAgeDelegate(List<User> users);

    public delegate List<User> GetTeensDelegate(List<User> users);

    public delegate List<User> GetAdultsDelegate(List<User> users);

    public delegate List<User> GetSeniorsDelegate(List<User> users);

    public delegate string[] GetArrayOfLastNamesDelegate(List<User> users);

    public delegate void PrintPasswordsDelegate(List<User> users);
    internal class Delegates
    {
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

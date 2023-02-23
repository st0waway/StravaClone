namespace StravaClone.Repository
{
    internal interface IRepository<T> where T : User
    {
	    IEnumerable<T> GetAll(); 
		T GetUser(int id); 
		void Create(T item);
		void Update(T item);
		void Delete(int id);
		void Save();
	}
}

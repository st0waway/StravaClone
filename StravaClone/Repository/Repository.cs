namespace StravaClone.Repository
{
	public class Repository<T> : IRepository<T> where T : User
	{
		protected readonly List<T> Context;

		public Repository(List<T> context)
		{
			Context = context;
		}
		public IEnumerable<T> GetAll()
		{
			return Context.ToList();
		}

		public T GetUser(int id)
		{
			return Context.First(e => e.ID == id);
		}

		public void Create(T entity)
		{
			Context.Add(entity);
		}


		public void Update(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			T entity = Context.First(e => e.ID == id);
			if (entity != null)
				Context.Remove(entity);
		}

		public void Save()
		{
			throw new NotImplementedException();
		}



	}
}

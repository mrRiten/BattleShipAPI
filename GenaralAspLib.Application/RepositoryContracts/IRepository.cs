namespace GeneralAspLib.Application.RepositoryContracts
{
    public interface IRepository<T> where T : class
    {
        public Task<T?> GetAsync(int id);
        public Task<ICollection<T>?> GetAllAsync();

        public Task AddAsync(T entity);
        public Task<T?> UpdateAsync(T entity);
        public Task DeleteAsync(int id);
    }
}

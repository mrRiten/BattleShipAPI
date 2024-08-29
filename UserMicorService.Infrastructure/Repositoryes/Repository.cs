using GeneralAspLib.Application.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using UserMicroService.Core;

namespace UserMicorService.Infrastructure.Repositoryes
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly BattleShipContex _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(BattleShipContex context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null) { return; }

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<T>?> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T?> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}

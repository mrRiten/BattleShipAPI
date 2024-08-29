using GeneralAspLib.Application.RepositoryContracts;
using UserMicroService.Core.Models;

namespace UserMicroService.Application.RepositoryContracts
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<User?> GetAsync(string login);
        public Task<User?> GetByName(string name);

        public Task<User?> GetByRoleAsync(int roleId);
        public Task<User?> GetByRaitingAsync(int raitingId);
    }
}

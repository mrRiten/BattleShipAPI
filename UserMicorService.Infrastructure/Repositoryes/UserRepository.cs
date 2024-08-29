using Microsoft.EntityFrameworkCore;
using UserMicroService.Application.RepositoryContracts;
using UserMicroService.Core;
using UserMicroService.Core.Models;

namespace UserMicorService.Infrastructure.Repositoryes
{
    public class UserRepository(BattleShipContex contex) : Repository<User>(contex), IUserRepository
    {
        public async Task<User?> GetAsync(string login)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Login == login);
        }

        public async Task<User?> GetByName(string name)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == name);
        }

        public async Task<User?> GetByRaitingAsync(int raitingId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.RaitingId == raitingId);
        }

        public async Task<User?> GetByRoleAsync(int roleId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.RoleId == roleId);
        }
    }
}

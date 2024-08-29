using UserMicroService.Core;
using UserMicroService.Core.Models;

namespace UserMicorService.Infrastructure.Repositoryes
{
    public class RoleRepository(BattleShipContex context) : Repository<Role>(context)
    {
    }
}

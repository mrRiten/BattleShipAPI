using UserMicroService.Core;
using UserMicroService.Core.Models;

namespace UserMicorService.Infrastructure.Repositoryes
{
    public class RaitingRepository(BattleShipContex contex) : Repository<Raitimg>(contex)
    {

    }
}

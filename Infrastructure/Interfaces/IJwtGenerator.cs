using Data.Models;

namespace Infrastructure.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(User user);
    }
}

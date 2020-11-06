using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

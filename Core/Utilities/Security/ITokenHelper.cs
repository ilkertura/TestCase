using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

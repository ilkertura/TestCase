using Business.Models;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IEnumerable<User> GetAll(UserFilterModel filter);
        User Get(UserFilterModel filter);
        User GetByEmail(string email);
        List<OperationClaim> GetClaims(User user);
        User Add(User entity);
        User Update(User entity);
        bool Delete(int id);

    }
}

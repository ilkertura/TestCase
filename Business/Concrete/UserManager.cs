using Business.Abstract;
using Business.DependecyResolvers.Ninject;
using Business.Models;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDAL _userDAL;
        public UserManager()
        {
            _userDAL = NinjectDependencyResolver.Resolve<IUserDAL>();
        }
        public User Add(User entity)
        {
            return _userDAL.Add(entity);
        }

        public bool Delete(int id)
        {
            var entity = _userDAL.Get(u => u.Id == id);
            if (entity != null)
            {

                return _userDAL.Delete(entity);
            }
            return false;
        }

        public User Get(UserFilterModel filter)
        {
            return _userDAL.Get(u => u.FirstName.Contains(filter.UserName) || u.LastName.Contains(filter.UserName) || u.Email.Contains(filter.UserName));
        }

        public IEnumerable<User> GetAll(UserFilterModel filter)
        {
            return _userDAL.GetAll(u => u.FirstName.Contains(filter.UserName) || u.LastName.Contains(filter.UserName) || u.Email.Contains(filter.UserName)).Take(filter.Count);
        }

        public User GetByEmail(string email)
        {
            return _userDAL.Get(u => u.Email == email.Trim());
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDAL.GetClaims(user);
        }

        public User Update(User entity)
        {
            return _userDAL.Update(entity);
        }
    }
}

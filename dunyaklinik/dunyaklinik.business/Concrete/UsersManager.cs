using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class UsersManager : IUsersService
    {
        private IUsersDal _userDal;

        public UsersManager(IUsersDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Users user)
        {
            _userDal.Add(user);
        }

        public void Delete(Users user)
        {
            _userDal.Delete(user);
        }

        public List<Users> GetList()
        {
            return _userDal.GetList();
        }

        public void Update(Users user)
        {
            _userDal.Update(user);
        }
    }
}

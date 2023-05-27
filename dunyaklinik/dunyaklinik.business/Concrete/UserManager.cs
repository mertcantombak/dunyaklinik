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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetList()
        {
            return _userDal.GetList();
        }

        public User GetUser(string MailAddress, string Password)
        {
            User user = new User();
            user = _userDal.Get(s => s.MailAddress == MailAddress && s.Password == Password);
            return user;
        }
        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}

using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dunyaklinik.entities.Concrete;

namespace dunyaklinik.business.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}

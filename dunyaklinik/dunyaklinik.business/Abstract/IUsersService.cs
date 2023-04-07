using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dunyaklinik.entities.Concrete;

namespace dunyaklinik.business.Abstract
{
    public interface IUsersService
    {
        List<Users> GetList();
        void Add(Users user);
        void Update(Users user);
        void Delete(Users user);
    }
}

using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IClientUsersService
    {
        List<ClientUsers> GetList();
        void Add(ClientUsers clientUser);
        void Update(ClientUsers clientUser);
        void Delete(ClientUsers clientUser);
    }
}

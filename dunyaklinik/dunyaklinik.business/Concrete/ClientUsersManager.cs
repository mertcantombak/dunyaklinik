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
    public class ClientUsersManager : IClientUsersService
    {
        private IClientUsersDal _clientUserDal;
        public ClientUsersManager(IClientUsersDal clientUserDal)
        {
            _clientUserDal = clientUserDal;
        }

        public void Add(ClientUsers clientUser)
        {
            _clientUserDal.Add(clientUser);
        }

        public void Delete(ClientUsers clientUser)
        {
            _clientUserDal?.Delete(clientUser);
        }

        public List<ClientUsers> GetList()
        {
            return _clientUserDal.GetList();
        }

        public void Update(ClientUsers clientUser)
        {
            _clientUserDal.Update(clientUser);
        }
    }
}

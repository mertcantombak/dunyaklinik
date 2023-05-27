using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dunyaklinik.core.DataAccess.EntityFramework;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;

namespace dunyaklinik.dataaccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DunyaKlinikContext>, IUserDal
    {
    }
}

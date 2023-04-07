using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dunyaklinik.core.DataAccess;
using dunyaklinik.entities.Concrete;

namespace dunyaklinik.dataaccess.Abstract
{
    public interface IUsersDal : IEntityRepository<Users>
    {

    }
}

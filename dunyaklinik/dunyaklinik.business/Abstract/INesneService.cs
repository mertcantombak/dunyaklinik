using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface INesneService
    {
        List<nesne> GetList();
        void Add(nesne nesne);
        void Update(nesne nesne);
        void Delete(nesne nesne);
    }
}

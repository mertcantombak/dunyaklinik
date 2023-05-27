using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IDenemeService
    {
        List<Deneme> GetList();
        void Add(Deneme nesne);
        void Update(Deneme nesne);
        void Delete(Deneme nesne);
    }
}

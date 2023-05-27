using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class DenemeManager : IDenemeService
    {
        private IDenemeDal _nesneDal;

        public DenemeManager(IDenemeDal nesneDal)
        {
            _nesneDal = nesneDal;
        }

        public void Add(Deneme nesne)
        {
            _nesneDal.Add(nesne);
        }

        public void Delete(Deneme nesne)
        {
            _nesneDal.Delete(nesne);
        }

        public List<Deneme> GetList()
        {
            return _nesneDal.GetList();
        }

        public void Update(Deneme nesne)
        {
            _nesneDal.Update(nesne);
        }
    }
}

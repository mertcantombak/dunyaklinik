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
    public class NesneManager : INesneService
    {
        private INesneDal _nesneDal;
        public void Add(nesne nesne)
        {
            _nesneDal.Add(nesne);
        }

        public void Delete(nesne nesne)
        {
            _nesneDal.Delete(nesne);
        }

        public List<nesne> GetList()
        {
            return _nesneDal.GetList();
        }

        public void Update(nesne nesne)
        {
            _nesneDal.Update(nesne);
        }
    }
}

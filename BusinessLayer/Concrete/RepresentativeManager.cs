using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RepresentativeManager : IRepresentativeService
    {
        IRepresentativeDal _RepresentativeDal;

        public RepresentativeManager(IRepresentativeDal RepresentativeDal)
        {
            _RepresentativeDal = RepresentativeDal;
        }

        public void AboutAdd(Representative Representative)
        {
            _RepresentativeDal.Insert(Representative);
        }

        public void AboutDelete(Representative Representative)
        {
            _RepresentativeDal.Delete(Representative);
        }

        public void AboutUpdate(Representative Representative)
        {
            _RepresentativeDal.Update(Representative);
        }

        public List<Representative> GetAboutList()
        {
            return _RepresentativeDal.List();
        }

        public Representative GetByID(int id)
        {
            return _RepresentativeDal.Get(x => x.Id == id);
        }
    }
}
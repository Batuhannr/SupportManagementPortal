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
    public class CompaniesManager : ICompaniesService
    {
        ICompaniesDal _companiesDal;

        public CompaniesManager(ICompaniesDal companiesDal)
        {
            _companiesDal = companiesDal;
        }

        public void AboutAdd(Companies companies)
        {
            _companiesDal.Insert(companies);
        }

        public void AboutDelete(Companies companies)
        {
            _companiesDal.Delete(companies);
        }

        public void AboutUpdate(Companies companies)
        {
            _companiesDal.Update(companies);
        }

        public List<Companies> GetAboutList()
        {
            return _companiesDal.List();
        }

        public Companies GetByID(int id)
        {
            return _companiesDal.Get(x => x.Id == id);
        }
    }
}
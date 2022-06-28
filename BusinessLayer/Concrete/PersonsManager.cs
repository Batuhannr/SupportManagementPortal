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
    public class PersonsManager : IPersonsService
    {
        IPersonsDal _personsDal;

        public PersonsManager(IPersonsDal PersonsDal)
        {
            _personsDal = PersonsDal;
        }

        public void AboutAdd(Persons Persons)
        {
            _personsDal.Insert(Persons);
        }

        public void AboutDelete(Persons Persons)
        {
            _personsDal.Delete(Persons);
        }

        public void AboutUpdate(Persons Persons)
        {
            _personsDal.Update(Persons);
        }

        public List<Persons> GetAboutList()
        {
            return _personsDal.List();
        }

        public Persons GetByID(int id)
        {
            return _personsDal.Get(x => x.Id == id);
        }
    }
}
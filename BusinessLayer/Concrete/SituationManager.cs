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
    public class SituationManager : ISituationService
    {
        ISituationDal _SituationDal;

        public SituationManager(ISituationDal SituationDal)
        {
            _SituationDal = SituationDal;
        }

        public void AboutAdd(Situation Situation)
        {
            _SituationDal.Insert(Situation);
        }

        public void AboutDelete(Situation Situation)
        {
            _SituationDal.Delete(Situation);
        }

        public void AboutUpdate(Situation Situation)
        {
            _SituationDal.Update(Situation);
        }

        public List<Situation> GetAboutList()
        {
            return _SituationDal.List();
        }

        public Situation GetByID(int id)
        {
            return _SituationDal.Get(x => x.Id == id);
        }
    }
}
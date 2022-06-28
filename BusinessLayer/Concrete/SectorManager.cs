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
    public class SectorManager : ISectorService
    {
        ISectorDal _SectorDal;

        public SectorManager(ISectorDal SectorDal)
        {
            _SectorDal = SectorDal;
        }

        public void AboutAdd(Sector Sector)
        {
            _SectorDal.Insert(Sector);
        }

        public void AboutDelete(Sector Sector)
        {
            _SectorDal.Delete(Sector);
        }

        public void AboutUpdate(Sector Sector)
        {
            _SectorDal.Update(Sector);
        }

        public List<Sector> GetAboutList()
        {
            return _SectorDal.List();
        }

        public Sector GetByID(int id)
        {
            return _SectorDal.Get(x => x.Id == id);
        }
    }
}
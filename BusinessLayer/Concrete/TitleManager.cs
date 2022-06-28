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
    public class TitleManager : ITitleService
    {
        ITitleDal _TitleDal;

        public TitleManager(ITitleDal TitleDal)
        {
            _TitleDal = TitleDal;
        }

        public void AboutAdd(Title Title)
        {
            _TitleDal.Insert(Title);
        }

        public void AboutDelete(Title Title)
        {
            _TitleDal.Delete(Title);
        }

        public void AboutUpdate(Title Title)
        {
            _TitleDal.Update(Title);
        }

        public List<Title> GetAboutList()
        {
            return _TitleDal.List();
        }

        public Title GetByID(int id)
        {
            return _TitleDal.Get(x => x.Id == id);
        }
    }
}
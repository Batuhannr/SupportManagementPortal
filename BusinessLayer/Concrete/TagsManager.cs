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
    public class TagsManager : ITagsService
    {
        ITagsDal _TagsDal;

        public TagsManager(ITagsDal TagsDal)
        {
            _TagsDal = TagsDal;
        }

        public void AboutAdd(Tags Tags)
        {
            _TagsDal.Insert(Tags);
        }

        public void AboutDelete(Tags Tags)
        {
            _TagsDal.Delete(Tags);
        }

        public void AboutUpdate(Tags Tags)
        {
            _TagsDal.Update(Tags);
        }

        public List<Tags> GetAboutList()
        {
            return _TagsDal.List();
        }

        public Tags GetByID(int id)
        {
            return _TagsDal.Get(x => x.Id == id);
        }
    }
}